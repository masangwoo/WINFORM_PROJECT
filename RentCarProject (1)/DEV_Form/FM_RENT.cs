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
    public partial class FM_RENT : BaseMDIChildForm
    {
        public FM_RENT()
        {
            InitializeComponent();
        }
        #region
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FM_RENT2_Load(object sender, EventArgs e)
        {
            
        }
        #endregion

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FM_RENT_ADD Login = new FM_RENT_ADD();
            Login.ShowDialog();
        }
    }
}
