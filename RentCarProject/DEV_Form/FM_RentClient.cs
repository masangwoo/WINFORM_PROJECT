using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DEV_Form
{
    public partial class FM_RentClient : BaseMDIChildForm
    {

        private SqlConnection Connect = null;
        private string strConn = "Data Source=222.235.141.8; Initial Catalog=AppDev;User ID=kfqs1;Password=1234";

        public FM_RentClient()
        {
            InitializeComponent();
        }
 

        public override void Inquire()
        {
                DBHelper helper = new DBHelper(false);
                try
                {
                    String sClientId = txtClientID.Text;//고객ID
                    String sClientName = txtClientName.Text; //고객이름
                    String sStartDate = dtpStart.Text; //가입일자Start
                    String sEndDate = dtpEnd.Text; //끝나는일자
                    String sClientClass = ""; //고객등급

                    if (rdoBlacklist.Checked == true) sClientClass = "BLACK";
                    else if (rdoGeneral.Checked == true) sClientClass = "NORMAL";
                    else if (rdoVip.Checked == true) sClientClass = "VIP";
                    else sClientClass = "";

                    DataTable dtTemp = new DataTable();
                    dtTemp = helper.FillTable("SP_4_Client_S1", CommandType.StoredProcedure
                                                , helper.CreateParameter("CLIENTID", sClientId)
                                                , helper.CreateParameter("CLIENTNAME", sClientName)
                                                , helper.CreateParameter("STARTDATE", sStartDate)
                                                , helper.CreateParameter("ENDDATE", sEndDate)
                                                , helper.CreateParameter("USERCLASS", sClientClass));

                    if (dtTemp.Rows.Count == 0)
                    {
                        dgvGrid.DataSource = null;
                        MessageBox.Show("조회할 데이터가 없습니다");
                    }
                    else
                    {
                        //그리드 뷰에 데이터 삽입
                        dgvGrid.DataSource = dtTemp;
                    }
                    /*
                     *    @CLIENTID INTEGER,
                          @CLIENTNAME VARCHAR(50) ,
                          @STARTDATE DATETIME ,
                          @ENDDATE DATETIME,
                          @USERCLASS VARCHAR(10)
                     * */
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    helper.Close();
                }
        }
        public override void DoNew()
        {
            base.DoNew();
            DataRow dr = ((DataTable)dgvGrid.DataSource).NewRow();
            ((DataTable)dgvGrid.DataSource).Rows.Add(dr);

            // 마지막에 추가된 행 선택
            int MaxRow = dgvGrid.Rows.Count - 1;
            dgvGrid.Rows[MaxRow].Selected = true;
            dgvGrid.CurrentCell = dgvGrid.Rows[MaxRow].Cells[0];

        }
        public override void Delete()
        {
            base.Delete();
            if (dgvGrid.Rows.Count == 0) return;

            String sClientId = dgvGrid.CurrentRow.Cells["CLIENTId"].Value.ToString();
            DataTable dtTemp = (DataTable)dgvGrid.DataSource;
            for (int i = 0; i < dtTemp.Rows.Count; i++)
            {
                if (dtTemp.Rows[i].RowState == DataRowState.Deleted) continue;
                if (dtTemp.Rows[i][0].ToString() == sClientId)
                {
                    dtTemp.Rows[i].Delete();
                    break;
                }

            }
        }

        public override void Save()
        {
            base.Save();
            String ClientId = String.Empty;
            String sClientName = String.Empty;
            //int iAge = 0;
            String sAge = String.Empty;
            String sGender = String.Empty;
            String sAddress = String.Empty;
            String sPhoneNumber = String.Empty;
            String sUserClass = String.Empty;

            //추가된 row들만 dtTemp로 들어가게된다.
            DataTable dtTemp = ((DataTable)dgvGrid.DataSource).GetChanges();
            if (dtTemp == null) return;

            if (MessageBox.Show("데이터를 등록하시겠습니까?", "데이터 저장",
                MessageBoxButtons.YesNo) == DialogResult.No) return;
            DBHelper helper = new DBHelper(true);
            try
            {
                //트랜잭션 설정
                //데이터 테이블의 상태 체크
                foreach (DataRow drRow in dtTemp.Rows)
                {
                    switch (drRow.RowState)
                    {
                        case DataRowState.Deleted:
                            drRow.RejectChanges();
                            ClientId = drRow["CLIENTID"].ToString();
                            helper.ExecuteNoneQuery("SP_4_Client_D1"
                                                    , CommandType.StoredProcedure
                                                    , helper.CreateParameter("CLIENTID", ClientId));
                            break;
                        case DataRowState.Added:
                            sClientName = drRow["CLIENTNAME"].ToString();
                            //iAge = int.Parse(drRow["AGE"].ToString());
                            sAge = drRow["AGE"].ToString();

                            sGender = drRow["GENDER"].ToString();
                            if (sGender == "여자") sGender = "W";
                            else sGender = "M";

                            sAddress = drRow["ADDRESS"].ToString();
                            sPhoneNumber = drRow["PHONENUMBER"].ToString();

                            sUserClass = drRow["USERCLASS"].ToString();
                            if (sUserClass == "VIP") sUserClass = "VIP";
                            else if (sUserClass == "사용불가") sUserClass = "BLACK";
                            else sUserClass = "NORMAL";

                            helper.ExecuteNoneQuery("SP_4_Client_I1"
                                                    , CommandType.StoredProcedure
                                                    , helper.CreateParameter("CLIENTNAME", sClientName)
                                                    , helper.CreateParameter("AGE", sAge)
                                                    , helper.CreateParameter("GENDER", sGender)
                                                    , helper.CreateParameter("ADDRESS", sAddress)
                                                    , helper.CreateParameter("PHONENUMBER", sPhoneNumber)
                                                    , helper.CreateParameter("USERCLASS", sUserClass)
                                                    , helper.CreateParameter("MAKER", Common.LogInID));
                            break;
                        case DataRowState.Modified:
                            ClientId = drRow["CLIENTID"].ToString();
                            sClientName = drRow["CLIENTNAME"].ToString();
                            sGender = drRow["GENDER"].ToString();
                            sAge = drRow["AGE"].ToString();
                            if (sGender == "여자") sGender = "W";
                            else sGender = "M";

                            sAddress = drRow["ADDRESS"].ToString();
                            sPhoneNumber = drRow["PHONENUMBER"].ToString();

                            sUserClass = drRow["USERCLASS"].ToString();
                            if (sUserClass == "VIP") sUserClass = "VIP";
                            else if (sUserClass == "사용불가") sUserClass = "BLACK";
                            else sUserClass = "NORMAL";

                            helper.ExecuteNoneQuery("SP_4_Client_U1"
                                                    , CommandType.StoredProcedure
                                                    , helper.CreateParameter("CLIENTID", ClientId)
                                                    , helper.CreateParameter("CLIENTNAME", sClientName)
                                                    , helper.CreateParameter("AGE", sAge)
                                                    , helper.CreateParameter("GENDER", sGender)
                                                    , helper.CreateParameter("ADDRESS", sAddress)
                                                    , helper.CreateParameter("PHONENUMBER", sPhoneNumber)
                                                    , helper.CreateParameter("USERCLASS", sUserClass));
                            break;
                    }
                }
                //성공시 DB COMMIT
                helper.Commit();

                //메시지
                MessageBox.Show("정상적으로 등록하였씁니다.");

                //재조회
                Inquire();

            }
            catch (Exception ex)
            {
                //트랜잭션 롤백
                helper.Rollback();
                //메세지
                MessageBox.Show(ex.ToString());
                MessageBox.Show("데이터 등록에 실패하였습니다.");
            }
            finally
            {
                //DB Close
                helper.Close();
            }

        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            Inquire();
        }

        private void picLicenseImg_Click(object sender, EventArgs e)
        {
            if (this.picLicenseImg.Dock == System.Windows.Forms.DockStyle.Fill)
            {
                // 이미지가 가득 채워져있는 상태이면 원상태로 바꿔라
                this.picLicenseImg.Dock = System.Windows.Forms.DockStyle.None;
            }
            else
            {
                // 이미지가 가득 채워져 있지 않으면 가득 채워라
                picLicenseImg.Dock = System.Windows.Forms.DockStyle.Fill;
                // 이미지를 가장 앞으로 가져온다
                picLicenseImg.BringToFront();
            }
        }

        private void btnPicUpload_Click(object sender, EventArgs e)
        {
            string sImageFile = string.Empty;
            // 이미지 불러오기 및 저장, 파일 탐색기 호출

            OpenFileDialog Dialog = new OpenFileDialog();
            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                sImageFile = Dialog.FileName;
                picLicenseImg.Tag = Dialog.FileName;
                // 지정된 파일에서 이미지를 만들어 픽쳐박스에 넣는다.
                picLicenseImg.Image = Bitmap.FromFile(sImageFile);
            }
        }

        private void btnPicSave_Click(object sender, EventArgs e)
        {
            // 픽쳐박스 이미지 저장
            if (dgvGrid.Rows.Count == 0) return;
            if (picLicenseImg.Image == null) return;
            if (picLicenseImg.Tag.ToString() == "") return;

            if (MessageBox.Show("선택된 이미지로 등록 하시겠습니까?", "이미지 등록", MessageBoxButtons.YesNo) == DialogResult.No) return;

            Byte[] bImage = null;
            Connect = new SqlConnection(strConn);
            try
            {
                // 파일을 불러오기 위한 파일 경로 방법 지정
                FileStream stream = new FileStream(picLicenseImg.Tag.ToString(), FileMode.Open, FileAccess.Read);

                // 읽어들인 파일을 바이너리 코드로 변환
                BinaryReader reader = new BinaryReader(stream);

                // 만들어진 바이너리 코드 이미지를 Byte화하여 저장
                bImage = reader.ReadBytes(Convert.ToInt32(stream.Length));

                reader.Close();
                stream.Close();
                // 바이너리 코드는 컴퓨터가 인식할 수 있는 0과 1로 구성된 이진코드
                // 바이트 코드는 CPU가 아닌 가상머신에서 이해할 수 있는 코드

                // SQL SERVER에 연결
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Connect;
                Connect.Open();

                string sClientCode = dgvGrid.CurrentRow.Cells["CLIENTID"].Value.ToString();
                cmd.CommandText = "UPDATE TB_4_RENTUSER SET LICENSE = @LICENSE WHERE CLIENTID = @CLIENTID";
                cmd.Parameters.AddWithValue("@LICENSE", bImage);
                cmd.Parameters.AddWithValue("@CLIENTID", sClientCode);
                cmd.ExecuteNonQuery();
                Connect.Close();
                MessageBox.Show("이미지가 등록되었습니다.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {

            }
        }

        private void dgvGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 선택 시 해당품목 이미지 가져오기
            string sClientCode = dgvGrid.CurrentRow.Cells["CLIENTID"].Value.ToString();

            Connect = new SqlConnection(strConn);
            Connect.Open();

            try
            {
                // 이미지 초기화
                picLicenseImg.Image = null;
                string sSql = $"SELECT LICENSE FROM TB_4_RENTUSER WHERE CLIENTID = '{sClientCode}' AND CLIENTID IS NOT NULL";
                SqlDataAdapter Adapter = new SqlDataAdapter(sSql, Connect);
                DataTable dtTemp = new DataTable();
                Adapter.Fill(dtTemp);

                if (dtTemp.Rows.Count == 0) return;
                if (dtTemp.Rows[0]["LICENSE"].ToString() == "") return;

                // 이미지 담을 byte 변수
                byte[] bImage = null;

                // 이미지를 byte화 한다
                bImage = (byte[])dtTemp.Rows[0]["LICENSE"];
                if (bImage != null)
                {
                    picLicenseImg.Image = new Bitmap(new MemoryStream(bImage)); // 메모리 스트림을 이용하여 파일을
                    picLicenseImg.BringToFront();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Connect.Close();
            }
        }

        private void btnPictDelete_Click(object sender, EventArgs e)
        {
            // 품목에 저장된 이미지 삭제
            if (dgvGrid.Rows.Count == 0) return;
            if (MessageBox.Show("선택한 이미지를 삭제하시겠습니까?", "이미지 삭제", MessageBoxButtons.YesNo) == DialogResult.No) return;
            SqlCommand cmd = new SqlCommand();
            Connect = new SqlConnection(strConn);
            Connect.Open();

            try
            {
                string sClientCode = dgvGrid.CurrentRow.Cells["CLIENTID"].Value.ToString();
                cmd.CommandText = $"UPDATE TB_4_RENTUSER SET LICENSE = null WHERE CLIENTID = '{sClientCode}'";
                cmd.Connection = Connect;
                cmd.ExecuteNonQuery();
                picLicenseImg.Image = null;
                MessageBox.Show("정상적으로 삭제하였습니다.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

            }
        }

        private void FM_RentClient_Load(object sender, EventArgs e)
        {
            dtpStart.Text = string.Format("{0:yyyy-}{1:MM-dd}", DateTime.Today.AddYears(-1), DateTime.Now);
        }

    }

}

