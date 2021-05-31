using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace DEV_Form
{
    public partial class FM_SearchClient : BaseSearchChildForm
    {

        private SqlConnection Connect = null; // 접속 정보 객체 명명
        // 접속 주소 
        private string strConn = "Data Source=222.235.141.8; Initial Catalog=AppDev;User ID=kfqs1;Password=1234";

        public FM_SearchClient()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Connect = new SqlConnection(strConn);
                Connect.Open();

                if (Connect.State != System.Data.ConnectionState.Open)
                {
                    MessageBox.Show("데이터 베이스 연결에 실패 하였습니다.");
                    return;
                }
               
                string sClientName = txtClient.Text; //고객이름

                #region Search SQL

                SqlDataAdapter Adapter = new SqlDataAdapter
                    (" SELECT CLIENTNAME,                         " +
                     "        CLIENTID,                         " +
                     "        PHONENUMBER                         " +
                     "   FROM TB_4_RENTUSER WITH(NOLOCK)        " +
                    $"  WHERE CLIENTNAME LIKE '%{sClientName}%'      " , Connect);

                DataTable dtTemp = new DataTable();
                Adapter.Fill(dtTemp);

                if (dtTemp.Rows.Count == 0)
                {
                    MessageBox.Show("검색 조건에 맞는 데이터가 없습니다.");
                    dgvGrid.DataSource = null;
                    return;
                }
                dgvGrid.DataSource = dtTemp;

                #endregion

                dgvGrid.Columns["CLIENTNAME"].HeaderText = "사용자";
                dgvGrid.Columns["CLIENTID"].HeaderText = "사용자 아이디";
                dgvGrid.Columns["PHONENUMBER"].HeaderText = "휴대폰 번호";

                dgvGrid.Columns[0].Width = 100;
                dgvGrid.Columns[1].Width = 100;
                dgvGrid.Columns[2].Width = 200;
                #region Bring DataTB

                /*                DataTable dtTemp = new DataTable();
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
                                dgvGridCar.Columns["EDITOR"].HeaderText = "수정자";

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
                                dgvGridCar.Columns["EDITDATE"].ReadOnly = true;*/
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

        private void txtClient_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(null, null);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (this.dgvGrid.Rows.Count == 0) return;

            this.Tag =  dgvGrid.CurrentRow.Cells["CLIENTID"].Value.ToString();
            #region Transaction Decl
            //SqlCommand Cmd = new SqlCommand();
            //SqlTransaction Txn;
            //#endregion

            //#region Connection Open
            //Connect = new SqlConnection(strConn);
            //Connect.Open();
            //#endregion

            //#region Transaction Init
            //Txn = Connect.BeginTransaction("Begin Transaction");
            //Cmd.Transaction = Txn;
            //Cmd.Connection = Connect;
            #endregion
            this.Close();
        }

       
    }
}
