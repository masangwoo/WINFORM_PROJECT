using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DEV_Form
{
    public partial class FM_RentClient : BaseMDIChildForm
    {

        private SqlConnection Connect = null;
        public FM_RentClient()
        {
            InitializeComponent();
        }
 

        public override void Inquire()
        {
            {
                DBHelper helper = new DBHelper(false);
                try
                {
                    //조회를 위한 파라매터 설정

                    String inputClientId = txtClientID.Text;
                    int iClinetId = 0;
                    if (inputClientId == "") iClinetId = 0;
                    else { iClinetId = Int32.Parse(txtClientID.Text); } //고객ID

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
                                                , helper.CreateParameter("CLIENTID", iClinetId)
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
        }
        public override void DoNew()
        {
            DataRow dr = ((DataTable)dgvGrid.DataSource).NewRow();
            ((DataTable)dgvGrid.DataSource).Rows.Add(dr);
        }
        public override void Delete()
        {
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
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Inquire();
        }

    }

}

