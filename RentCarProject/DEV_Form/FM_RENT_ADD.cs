using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace DEV_Form
{
    public partial class FM_RENT_ADD : BaseMDIChildForm
    {

        private SqlConnection Connect = null; // 접속 정보 객체 명명
        // 접속 주소 
        private string strConn = "Data Source=222.235.141.8; Initial Catalog=AppDev;User ID=kfqs1;Password=1234";


        public FM_RENT_ADD()
        {
            InitializeComponent();
        }

        private void btnCar_Click(object sender, EventArgs e)
        {
            FM_SearchCar formCar = new FM_SearchCar();
            formCar.ShowDialog();
            if (formCar.Tag.ToString() != "") txtCarID.Text = formCar.Tag.ToString();

        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            FM_SearchClient formClient = new FM_SearchClient();
            formClient.ShowDialog();
            if (formClient.Tag.ToString() != "") txtClientID.Text = formClient.Tag.ToString();
        }

      


        private void FM_RENT_ADD_Load(object sender, EventArgs e)
        {
                DBHelper helper = new DBHelper(false);
                try
                {
                    string sInsurance = cmbInsurance.Text;

                    DataTable DataTemp = new DataTable();
                    DataTemp = helper.FillTable("SP_4_Rent_S2", CommandType.StoredProcedure, helper.CreateParameter("INSURANCETYPE", sInsurance));

                    cmbInsurance.DataSource = DataTemp;
                    cmbInsurance.DisplayMember = "INSURANCETYPE";
                    cmbInsurance.ValueMember = "INSURANCETYPE";
                    cmbInsurance.Text = "";

                }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); }
                finally { helper.Close(); }
        }

     

        private void btnCostSearch_Click(object sender, EventArgs e)
        {
            if (dtpRentStart == null) return;
            if (dtpRentEnd == null) return;
            if (txtClientID == null) return;
            if (txtCarID == null) return;

            TimeSpan ts;

            string rStart = dtpRentStart.Value.ToShortDateString();
            string rEnd = dtpRentEnd.Value.ToShortDateString();

            DateTime startDay = Convert.ToDateTime(rStart);
            DateTime endDay = Convert.ToDateTime(rEnd);

            ts = endDay - startDay;

            int day = ts.Days;




            DBHelper helper = new DBHelper(false);
            try
            {

                string sCarcode = txtCarID.Text;
                DataTable DataTemp = new DataTable();
                DataTemp = helper.FillTable("SP_4_Rent_S3", CommandType.StoredProcedure, helper.CreateParameter("CARCODE", sCarcode));
                int Value = Convert.ToInt32(DataTemp.Rows[0][0]);



                if (cmbInsurance.Text == "일반 보험")
                { txtExpCost.Text = $"{day * Value + 10000}"; }
                else
                { txtExpCost.Text = $"{day * Value + 20000}"; }
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

        private void btnContract_Click(object sender, EventArgs e)
        {

        }

        private void imgCont_Click(object sender, EventArgs e)
        {

        }

        private void btnImgSave_Click(object sender, EventArgs e)
        {
           
        }
        private void btnLoadPic_Click(object sender, EventArgs e)
        {
           
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }

    }

