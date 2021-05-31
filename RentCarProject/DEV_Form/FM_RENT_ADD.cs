using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEV_Form
{
    public partial class FM_RENT_ADD : BaseMDIChildForm
    {
        public FM_RENT_ADD()
        {
            InitializeComponent();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            FM_SearchClient Login = new FM_SearchClient();
            Login.ShowDialog();
            if (Login.Tag.ToString() != "") txtClientID.Text = Login.Tag.ToString();
        }

        private void btnCar_Click(object sender, EventArgs e)
        {
           /* FM_SearchClient Login = new FM_SearchClient();
            Login.ShowDialog();
            if (Login.Tag.ToString() != "") txtClientID.Text = Login.Tag.ToString();*/
        }
    }
}
