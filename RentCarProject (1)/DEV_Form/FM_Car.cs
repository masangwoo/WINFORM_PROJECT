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

    public partial class FM_Car : Form, ChildInterface
    {
        private SqlConnection Connect = null; // 접속 정보 객체 명명
        // 접속 주소 
        private string strConn = "Data Source=222.235.141.8; Initial Catalog=AppDev;User ID=kfqs1;Password=1234";

        public FM_Car()
        {
            InitializeComponent();
        }
        /*        #region ComboBox And GridView Search,Add,Insert,UpdateDelete,Save*/
        private void FM_ITEM_Load(object sender, EventArgs e)
        {
            try
            {
                #region ComboBox Connect
                // 콤보박스 품목 상세 데이터 조회 및 추가
                // 접속 정보 커넥선 에 등록 및 객체 선언
                Connect = new SqlConnection(strConn);
                Connect.Open();
                #endregion

                if (Connect.State != System.Data.ConnectionState.Open)
                {
                    MessageBox.Show("데이터 베이스 연결에 실패 하였습니다.");
                    return;
                }

                #region ComboBox Search
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT DISTINCT CARSIZE FROM TB_4_CAR ", Connect);
                DataTable dtTemp = new DataTable();
                adapter.Fill(dtTemp);

                cboRentCost.DataSource = dtTemp;
                cboRentCost.DisplayMember = "CARSIZE";
                cboRentCost.ValueMember = "CARSIZE";
                cboRentCost.Text = "";

                #endregion

                #region Fix Date
                // 원하는 날짜 픽스
                dtpEnd.Text = string.Format("{0:yyyy-MM-dd}", DateTime.Now);
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                Connect.Close();
            }

        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            try
            {
                dgvGridCar.DataSource = null; // 그리드의 데이터 소스를 초기화 한다.
                Connect = new SqlConnection(strConn);
                Connect.Open();

                if (Connect.State != System.Data.ConnectionState.Open)
                {
                    MessageBox.Show("데이터 베이스 연결에 실패 하였습니다.");
                    return;
                }

                #region Parameter Prod
                // 조회를 위한 파라매터 설정
                string sCarCode = txtCarCode.Text;
                string sCarType = "";
                string sCarName = txtCarName.Text;
                string sStartDate = dtpStart.Text;
                string sEndDate = dtpEnd.Text;
                string sCarsize = cboRentCost.Text;
                string sUseFlag = "";

                if (rdoElec.Checked == true) sCarType = "Elec";
                else if (rdoGas.Checked == true) sCarType = "Gas";
                else if (rdoLpg.Checked == true) sCarType = "LPG";
                else if (rdoHybrid.Checked == true) sCarType = "Hyb";
                else if (rdoOil.Checked == true) sCarType = "Oil";
                else sCarType = "";

                if (chkWait.Checked == true) sUseFlag = "W";
                #endregion

                #region Search SQL

                SqlDataAdapter Adapter = new SqlDataAdapter
                    (" SELECT CARCODE,                         " +
                     "        CARTYPE,                         " +
                     "        CARNAME,                         " +
                     "        CARSIZE,                         " +
                     "        CARNUM,                         " +
                     "        CASE                             " +
                     "        WHEN USEFLAG = 'U' THEN '렌트중' " +
                     "        WHEN USEFLAG = 'F' THEN '정비중' " +
                     "        WHEN USEFLAG = 'W' THEN '대기중' " +
                     "        END AS  USEFLAG,                 " +
                     "        CARREGIST,                       " +
                     "        CARMAKER,                        " +
                     "        RENTPRICE,                       " +
                     "        MAKER,                           " +
                     "        MAKEDATE,                        " +
                     /*"        EDITOR                           " +*/
                     "        EDITDATE                         " +
                     "   FROM TB_4_CAR WITH(NOLOCK)        " +
                    $"  WHERE CARCODE LIKE '%{sCarCode}%'      " + // CODE 조회
                    $"    AND CARTYPE LIKE '%{sCarType}%'      " + // 라디오 박스 조회
                    $"    AND CARNAME LIKE '%{sCarName}%'      " + // NAME 조회
                    $"    AND CARSIZE LIKE '%{sCarsize}%'      " + // 콤보 박스 조회
                    $"    AND USEFLAG LIKE '%{sUseFlag}%'      " + // 체크박스 조회
                    $"    AND CARREGIST BETWEEN '{sStartDate}' " + // 날짜 조회
                    $"    AND '{sEndDate}'", Connect);


                #endregion

                #region Bring DataTB

                DataTable dtTemp = new DataTable();
                Adapter.Fill(dtTemp);
                #endregion

                if (dtTemp.Rows.Count == 0)
                {
                    dgvGridCar.DataSource = null;
                    return;
                }
                dgvGridCar.DataSource = dtTemp; // 데이터 그리드 뷰에 데이터 테이블 등록

                #region Change GridHeader Name
                // 그리드뷰의 헤더 명칭 선언
                dgvGridCar.Columns["CARCODE"].HeaderText = "차량 ID";
                dgvGridCar.Columns["CARTYPE"].HeaderText = "차량 분류";
                dgvGridCar.Columns["CARNAME"].HeaderText = "차량 종류";
                dgvGridCar.Columns["CARSIZE"].HeaderText = "사이즈 분류";
                dgvGridCar.Columns["CARNUM"].HeaderText = "차량 번호";
                dgvGridCar.Columns["USEFLAG"].HeaderText = "상태";
                dgvGridCar.Columns["CARREGIST"].HeaderText = "등록 일시";
                dgvGridCar.Columns["CARMAKER"].HeaderText = "제조사";
                dgvGridCar.Columns["RENTPRICE"].HeaderText = "렌트가격";
                dgvGridCar.Columns["MAKER"].HeaderText = "등록자";
                dgvGridCar.Columns["MAKEDATE"].HeaderText = "등록 일시";
                /*                dgvGridCar.Columns["EDITOR"].HeaderText = "수정자";
                */
                dgvGridCar.Columns["EDITDATE"].HeaderText = "수정 일시";
                #endregion

                #region Columns Width
                // 그리드 뷰의 폭 지정
                dgvGridCar.Columns[0].Width = 100;
                dgvGridCar.Columns[1].Width = 100;
                dgvGridCar.Columns[2].Width = 100;
                dgvGridCar.Columns[3].Width = 100;
                dgvGridCar.Columns[4].Width = 200;
                dgvGridCar.Columns[5].Width = 100;
                dgvGridCar.Columns[6].Width = 200;
                dgvGridCar.Columns[7].Width = 100;
                dgvGridCar.Columns[8].Width = 200;
                dgvGridCar.Columns[9].Width = 200;
                dgvGridCar.Columns[10].Width = 200;
                dgvGridCar.Columns[11].Width = 200;
                #endregion

                #region ReadOnly Parameters
                // 컬럼의 수정 여부를 지정 한다
                dgvGridCar.Columns["CARCODE"].ReadOnly = true;
                dgvGridCar.Columns["MAKER"].ReadOnly = true;
                dgvGridCar.Columns["MAKEDATE"].ReadOnly = true;
                dgvGridCar.Columns["RENTPRICE"].ReadOnly = true;
                dgvGridCar.Columns["EDITDATE"].ReadOnly = true;
                #endregion

            }
            catch (Exception ex)
            {
                MessageBox.Show("조회 실패", ToString());

            }
            finally
            {
                Connect.Close();
            }
        }

        private void btnRefresh1_Click(object sender, EventArgs e)
        {
            /*if (this.cboRentCost.SelectedIndex == 0) return;
            if (MessageBox.Show("검색 조건을 초기화하시겠습니까?", "Delete", MessageBoxButtons.YesNo) == DialogResult.No) return;
            
            if(this.cboRentCost.SelectedIndex >= 0)
            {
            }*/
        }

        #region KeyDown Enter for Search
        private void txtCarName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click_1(null, null);
            }
        }
        private void txtCarCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click_1(null, null);
            }
        }
        #endregion

        #region Interface
        public void Inquire()
        {
        }

        public void DoNew()
        {
        }

        public void Delete()
        {
        }

        public void Save()
        {
        }
        #endregion

        #region why...?
        /*public override void Inquire()
      {
          base.Inquire();

          //DB helper 선언
          DBHelper helper = new DBHelper(false);
          try
          {
              string sUserId = t.Text;
              string sUserName = txtUserName.Text;

              DataTable Dttemp = new DataTable();
              Dttemp = helper.FillTable("SP_USER_JJG_S1", CommandType.StoredProcedure
                  , helper.CreateParameter("USERID", sUserId)
                  , helper.CreateParameter("USERNAME", sUserName));

              if (Dttemp.Rows.Count == 0)
              {
                  dgvGridCar.DataSource = null;
                  MessageBox.Show("조회할 데이터가 없습니다.");
              }
              else
              {
                  //그리드 뷰에 데이터 삽입
                  dgvGridCar.DataSource = Dttemp;
              }

          }
          catch (Exception ex)
          {

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
      }*/
        #endregion

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

            }
        }

    }
}
