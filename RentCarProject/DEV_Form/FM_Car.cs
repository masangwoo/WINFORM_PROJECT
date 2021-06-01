using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Drawing.Imaging;
using Microsoft.VisualBasic;
using System.Transactions;
using System.ComponentModel.Design.Serialization;
using System.Drawing;
using System.IO;

namespace DEV_Form
{

    public partial class FM_Car : BaseMDIChildForm
    {
        

        public FM_Car()
        {
            InitializeComponent();
        }
        private void FM_ITEM_Load(object sender, EventArgs e)
        {
            DBHelper helper = new DBHelper(false);
            try
            {
                string sCarsize = cboRentCost.Text;

                DataTable DataTemp = new DataTable();
                DataTemp = helper.FillTable("SP_4_CAR_S3", CommandType.StoredProcedure ,helper.CreateParameter("CARSIZE",sCarsize) );

                cboRentCost.DataSource = DataTemp;
                cboRentCost.DisplayMember = "CARSIZE";
                cboRentCost.ValueMember = "CARSIZE";
                cboRentCost.Text = "";
                dtpEnd.Text = string.Format("{0:yyyy-MM-dd}", DateTime.Now);
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString());}
            finally { helper.Close();}
        }

        private void btnRefresh1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("검색 조건을 초기화하시겠습니까?", "Delete", MessageBoxButtons.YesNo) == DialogResult.No) return;
            else
            {
                txtCarName.Text = string.Empty;
                txtCarCode.Text = string.Empty;
                cboRentCost.SelectedIndex = 0;
                dgvGridCar.Columns.Clear();
                dgvGridCar.Refresh();
            }
        }

        public override void Inquire()
        {
            base.Inquire();
            DBHelper helper = new DBHelper(false);
            try
            {
                string sCarCode = txtCarCode.Text;
                string sCarType = "";
                string sCarName = txtCarName.Text;
                string sStartDate = dtpStart.Text;
                string sEndDate = dtpEnd.Text;
                string sCarsize = cboRentCost.Text;
                string sUseFlag = "";
                string sCarNum = "";
                string sCarRegist = "";
                string sCarMaker = "";
                string sRentPrice = "";
                string sEditor = "";


                if (rdoElec.Checked == true) sCarType = "Elec";
                else if (rdoGas.Checked == true) sCarType = "Gas";
                else if (rdoLpg.Checked == true) sCarType = "LPG";
                else if (rdoHybrid.Checked == true) sCarType = "Hyb";
                else if (rdoOil.Checked == true) sCarType = "Oil";
                else sCarType = "";

                if (chkWait.Checked == true) sUseFlag = "W";

                DataTable DataTemp = new DataTable();
                DataTemp = helper.FillTable("SP_4_CAR_S1", CommandType.StoredProcedure
                    , helper.CreateParameter("CARCODE", sCarCode)
                    , helper.CreateParameter("CARTYPE", sCarType)
                    , helper.CreateParameter("CARNAME", sCarName)
                    , helper.CreateParameter("CARSIZE", sCarsize)
                    , helper.CreateParameter("CARNUM", sCarNum)
                    , helper.CreateParameter("USEFLAG", sUseFlag)
                    , helper.CreateParameter("CARREGIST", sCarRegist)
                    , helper.CreateParameter("CARMAKER", sCarMaker)
                    , helper.CreateParameter("RENTPRICE", sRentPrice)
                    , helper.CreateParameter("STARTDATE", sStartDate)
                    , helper.CreateParameter("EDITOR", sEditor)
                    , helper.CreateParameter("ENDDATE", sEndDate));

                if (DataTemp.Rows.Count == 0)
                {
                    dgvGridCar.DataSource = null;
                    MessageBox.Show("조회할 데이터가 없습니다.");
                    return;
                }
                else
                {
                    //그리드 뷰에 데이터 삽입 
                    dgvGridCar.DataSource = DataTemp;
                }
                dgvGridCar.Columns["CARCODE"].HeaderText = "차량 ID";     dgvGridCar.Columns[0].Width = 100;
                dgvGridCar.Columns["CARTYPE"].HeaderText = "연료";        dgvGridCar.Columns[1].Width = 100;
                dgvGridCar.Columns["CARNAME"].HeaderText = "차종";        dgvGridCar.Columns[2].Width = 100;
                dgvGridCar.Columns["CARSIZE"].HeaderText = "사이즈";      dgvGridCar.Columns[3].Width = 100;
                dgvGridCar.Columns["CARNUM"].HeaderText = "차량 번호";    dgvGridCar.Columns[4].Width = 100;
                dgvGridCar.Columns["USEFLAG"].HeaderText = "상태";        dgvGridCar.Columns[5].Width = 100;
                dgvGridCar.Columns["CARREGIST"].HeaderText = "구매 일시"; dgvGridCar.Columns[6].Width = 200;
                dgvGridCar.Columns["CARMAKER"].HeaderText = "제조사";     dgvGridCar.Columns[7].Width = 200;
                dgvGridCar.Columns["RENTPRICE"].HeaderText = "렌트가격";  dgvGridCar.Columns[8].Width = 200;
                dgvGridCar.Columns["MAKER"].HeaderText = "등록자";        dgvGridCar.Columns[9].Width = 100;
                dgvGridCar.Columns["MAKEDATE"].HeaderText = "등록 일시";  dgvGridCar.Columns[10].Width = 200;
                dgvGridCar.Columns["EDITOR"].HeaderText = "수정자";       dgvGridCar.Columns[11].Width = 100;
                dgvGridCar.Columns["EDITDATE"].HeaderText = "수정 일시";  dgvGridCar.Columns[12].Width = 100;

                dgvGridCar.Columns["CARCODE"].ReadOnly = true;
                dgvGridCar.Columns["MAKER"].ReadOnly = true;
                dgvGridCar.Columns["MAKEDATE"].ReadOnly = true;
                dgvGridCar.Columns["EDITDATE"].ReadOnly = true;
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
            DataRow dr = ((DataTable)dgvGridCar.DataSource).NewRow();
            ((DataTable)dgvGridCar.DataSource).Rows.Add(dr);   // 그리드 뷰에 테이블을 추가하는 것이 아닌
                                                               // 데이터 소스를 추가하고 그것을 가져오는 방식
        }

        public override void Delete()
        {
            base.Delete();
            if (dgvGridCar.Rows.Count == 0) return;
            int iSelectIndex = dgvGridCar.CurrentCell.RowIndex;
            DataTable dtTemp = (DataTable)dgvGridCar.DataSource; // 데이터 소스의 데이터를 임시 테이블에 넣고
            dtTemp.Rows[iSelectIndex].Delete();                     // 그 테이블을 삭제하는 형식
        }

        public override void Save()
        {
            base.Save();
            string sCarCode = string.Empty;
            string sCarType = string.Empty;
            string sCarName = string.Empty;
            string sCarsize = string.Empty;
            string sCarNum = string.Empty;
            string sFirstDate = string.Empty;
            string sCarMaker = string.Empty;
            string sUseflag = string.Empty;
            string sRentPrice = string.Empty;
            string sMakedate = string.Empty;



            DataTable dataTemp1 = ((DataTable)dgvGridCar.DataSource).GetChanges();// 기존에 데이터 소스에 저장된 내용과 바뀐 부분을 체크하는 함수
            if (dataTemp1 == null) return; // 바뀐 내용들만 dtTemp에 추가

            if (MessageBox.Show("데이터를 등록 하시겠습니까?", "데이터 저장", MessageBoxButtons.YesNo) == DialogResult.No) return;
            DBHelper helper = new DBHelper(true);
            try
            {
                //트랜잭션 설정, 데이터 테이블의 상태 체크
                foreach (DataRow drRow in dataTemp1.Rows)
                {
                    switch (drRow.RowState)
                    {
                        case DataRowState.Deleted:
                            drRow.RejectChanges();
                            sCarCode = drRow["CARCODE"].ToString();
                            helper.ExecuteNoneQuery("SP_4_CAR_D1", CommandType.StoredProcedure, helper.CreateParameter("CARCODE", sCarCode));
                            break;

                        case DataRowState.Added:
                            sCarName = drRow["CARNAME"].ToString();
                            sCarType = drRow["CARTYPE"].ToString();
                            sUseflag = drRow["USEFLAG"].ToString();
                            sCarNum = drRow["CARNUM"].ToString();
                            sCarsize = drRow["CARSIZE"].ToString();
                            sRentPrice = drRow["RENTPRICE"].ToString();
                            sFirstDate = drRow["CARREGIST"].ToString();
                            sFirstDate = sFirstDate.Substring(0, 10);
                            sCarMaker = drRow["CARMAKER"].ToString();
                            sMakedate = drRow["MAKEDATE"].ToString();

                            helper.ExecuteNoneQuery("SP_4_CAR_I1", CommandType.StoredProcedure,
                                                    helper.CreateParameter("CARNAME", sCarName),
                                                    helper.CreateParameter("CARTYPE", sCarType),
                                                    helper.CreateParameter("USEFLAG", sUseflag),
                                                    helper.CreateParameter("CARNUM", sCarNum),
                                                    helper.CreateParameter("CARSIZE", sCarsize),
                                                    helper.CreateParameter("CARREGIST", sFirstDate),
                                                    helper.CreateParameter("CARMAKER", sCarMaker),
                                                    helper.CreateParameter("RENTPRICE", sRentPrice),
                                                    helper.CreateParameter("MAKEDATE", sMakedate),
                                                    helper.CreateParameter("MAKER", Common.LogInID));
                            if (sCarType == "" || sCarName == "" || sCarNum == "" || sCarsize == "" || sUseflag == "" || sRentPrice == "")
                            {
                                MessageBox.Show("'연료', '차종', '차량 번호','사이즈','상태'" + " 는 빈칸으로 남겨둘 수 없습니다.");
                                return;
                            }
                            break;

                        case DataRowState.Modified:
                            sCarCode = drRow["CARCODE"].ToString();
                            sCarName = drRow["CARNAME"].ToString();
                            sCarType = drRow["CARTYPE"].ToString();
                            sUseflag = drRow["USEFLAG"].ToString();
                            sCarNum = drRow["CARNUM"].ToString();
                            sCarsize = drRow["CARSIZE"].ToString();
                            sRentPrice = drRow["RENTPRICE"].ToString();
                            sFirstDate = drRow["CARREGIST"].ToString();
                            sFirstDate=  sFirstDate.Substring(0,10);
                            sCarMaker = drRow["CARMAKER"].ToString();
                            helper.ExecuteNoneQuery("SP_4_CAR_U1", CommandType.StoredProcedure,
                                                    helper.CreateParameter("CARCODE", sCarCode),
                                                    helper.CreateParameter("CARNAME", sCarName),
                                                    helper.CreateParameter("CARTYPE", sCarType),
                                                    helper.CreateParameter("USEFLAG", sUseflag),
                                                    helper.CreateParameter("CARNUM", sCarNum),
                                                    helper.CreateParameter("CARSIZE", sCarsize),
                                                    helper.CreateParameter("RENTPRICE", sRentPrice),
                                                    helper.CreateParameter("CARREGIST", sFirstDate),
                                                    helper.CreateParameter("CARMAKER", sCarMaker),
                                                    helper.CreateParameter("EDITOR", Common.LogInID));
                            break;

                            
                    }
                }
                //성공 시 DB COMMIT
                helper.Commit();
                //메세지
                MessageBox.Show("정상적으로 등록 하였습니다.");

                //재조회
                Inquire();
            }
            catch (Exception ex)
            {
                //트랜잭션 롤백
                helper.Rollback();
                // 메세지
                MessageBox.Show(ex.ToString());
                MessageBox.Show("데이터 등록에 실패하였습니다.");
            }
            finally
            {
                //DB Close
                helper.Close();
            }


        }

        #region IMG
        private SqlConnection Connect = null; // 접속 정보 객체 명명
        // 접속 주소 
        private string strConn = "Data Source=222.235.141.8; Initial Catalog=AppDev;User ID=kfqs1;Password=1234";
        private void btnLoadPic_Click(object sender, EventArgs e)
        {
            string sImagefile = string.Empty;
            //이미지 불러오기 및 저장, 파일 탐색기 호출

            OpenFileDialog Dialog = new OpenFileDialog();//클래스 객체 선언
            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                sImagefile = Dialog.FileName;
                picCarImg.Tag = Dialog.FileName;
                //지정된 파일에서 이미지를 만들어 픽쳐박스에 넣는다.
                picCarImg.Image = Bitmap.FromFile(sImagefile);
            }
        }

        private void picCarImg_Click(object sender, EventArgs e)
        {
            //픽쳐박스를 클릭하면 그룹박스 전체에 채워지게 만드는 코드
            if (this.picCarImg.Dock == DockStyle.Fill)
            {
                //이미지가 가득 채워져있는 상태면 원상태로 바꿔라
                this.picCarImg.Dock = DockStyle.None;
            }
            else
            {
                //이미지가 가득 채워져 있지 않으면 가득 채워라
                picCarImg.Dock = DockStyle.Fill;
                //이미지를 가장 앞으로 가지고 온다.
                picCarImg.BringToFront();
            }
        }

        private void btnPicSave_Click(object sender, EventArgs e)
        {
            //픽쳐박스 이미지 저장
            if (dgvGridCar.Rows.Count == 0) return; // 입력할 CARCODE 줄이 없으면 리턴
            if (picCarImg.Image == null) return;  // Picturebox에 이미지가 없을 경우 리턴
            if (picCarImg.Tag.ToString() == "") return; //  picItemImage.Tag = Dialog.FileName; 에서 tag로 저장한 내용이 없으면 리턴
            if (MessageBox.Show("선택한 이미지로 등록하시겠습니까?", "이미지 등록", MessageBoxButtons.YesNo) == DialogResult.No) return;

            #region Connect
            Byte[] bImage = null;
            Connect = new SqlConnection(strConn);
            #endregion

            try
            {
                #region Save Image
                FileStream stream = new FileStream(picCarImg.Tag.ToString(), FileMode.Open, FileAccess.Read);  // 파일에서 그림파일을 가져올 수 있도록 경로와 방법을 지정(읽기전용)
                BinaryReader reader = new BinaryReader(stream);  // 그림을 바이너리 형식으로 변환해준다.
                bImage = reader.ReadBytes(Convert.ToInt32(stream.Length)); // Byte로 변환해준다.
                reader.Close();
                stream.Close();
                //바이너리 코드는 컴퓨터가 인식할 수 있는 0/1로 된 2진법 코드
                //byte를 컴퓨터는 알수 있다.
                #endregion

                #region Connect Open
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Connect;
                Connect.Open();
                #endregion

                #region Parameter Cmd
                string sCarCode = dgvGridCar.CurrentRow.Cells["CARCODE"].Value.ToString();  // 현재 선택된 행에 CARCODE라는 칸에 값을 string 형식으로 받아와라 /왜 CARCODE? -- 기본 KEY값이기 때문에 반드시 존재
                cmd.CommandText = "UPDATE TB_4_CAR SET CARIMG = @IMAGE WHERE CARCODE = @CARCODE";
                cmd.Parameters.AddWithValue("@IMAGE", bImage); // byte 형식의 이미지 파일  -- @IMAGE로 업데이트 
                cmd.Parameters.AddWithValue("@CARCODE", sCarCode);
                cmd.ExecuteNonQuery();
                Connect.Close();
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류입니다. 관리자에게 문의하세요", ToString());
            }
            MessageBox.Show("정상적으로 저장되었습니다.");
        }

        private void btnPicDelete_Click(object sender, EventArgs e)
        {
            //품목에 저장된 이미지 삭제
            if (dgvGridCar.Rows.Count == 0) return;
            if (MessageBox.Show("선택한 이미지를 삭제하시겠습니까?", "이미지 삭제", MessageBoxButtons.YesNo) == DialogResult.No) return;

            #region Connect
            SqlCommand cmd = new SqlCommand();
            Connect = new SqlConnection(strConn);
            Connect.Open();
            #endregion

            try
            {
                string sCarCode = dgvGridCar.CurrentRow.Cells["CARCODE"].Value.ToString();
                cmd.CommandText = "UPDATE TB_4_CAR SET CARIMG = null WHERE CARCODE = '" + sCarCode + "'";
                cmd.Connection = Connect;

                cmd.ExecuteNonQuery();
                picCarImg.Image = null;
                MessageBox.Show("정상적으로 삭제 하였습니다.");
            }
            catch (Exception)
            {
                MessageBox.Show("삭제에 실패했습니다.", ToString());
            }
        }

        private void dgvGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //그리드 셀 선택 시 해당품목 이미지 가져오기
            string sCarCode = dgvGridCar.CurrentRow.Cells["CARCODE"].Value.ToString();
            Connect = new SqlConnection(strConn);
            Connect.Open();

            try
            {
                picCarImg.Image = null; // 초기화 하고 시작 이전에 있던 이미지가 남아있는 것을 방지
                string sSql = "SELECT CARIMG FROM TB_4_CAR WHERE CARCODE ='" + sCarCode + "'AND CARIMG IS NOT NULL";// itemimage를 sql에서 조회

                SqlDataAdapter adapter = new SqlDataAdapter(sSql, Connect);
                DataTable dtTemp = new DataTable();
                adapter.Fill(dtTemp); // 데이터를 담는다.

                if (dtTemp.Rows.Count == 0) return;

                byte[] bImage = null;
                bImage = (byte[])dtTemp.Rows[0]["CARIMG"]; // byte 형식으로 형변환을 해라
                if (bImage != null)
                {
                    picCarImg.Image = new Bitmap(new MemoryStream(bImage));//메모리 스트림을 이용하여 파일을 비트형으로 만들어라
                    picCarImg.BringToFront();//가장 앞으로
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류입니다. 관리자에게 문의하세요", ToString());
            }
            finally
            {
                Connect.Close();
            }
        }
        #endregion

    }
}
