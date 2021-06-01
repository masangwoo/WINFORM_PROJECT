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
using System.IO;

namespace DEV_Form
{
    public partial class FM_RENT : BaseMDIChildForm
    {
        private SqlConnection Connect = null; // 접속 정보 객체 명명
                                              // 접속 주소 
        private string strConn = "Data Source=222.235.141.8; Initial Catalog=AppDev;User ID=kfqs1;Password=1234";


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

        private void btnLoadPic_Click(object sender, EventArgs e)
        {
            string sImagefile = string.Empty;

            OpenFileDialog Dialog = new OpenFileDialog();
            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                sImagefile = Dialog.FileName;
                picCtrImg.Tag = Dialog.FileName;
                //지정된 파일에서 이미지를 만들어 픽쳐박스에 넣는다.
                picCtrImg.Image = Bitmap.FromFile(sImagefile);
            }
        }

        private void picCtrImg_Click(object sender, EventArgs e)
        {
            if (this.picCtrImg.Dock == DockStyle.Fill)
            {
                //이미지가 가득 채워져있는 상태면 원상태로 바꿔라
                this.picCtrImg.Dock = DockStyle.None;
            }
            else
            {
                //이미지가 가득 채워져 있지 않으면 가득 채워라
                picCtrImg.Dock = DockStyle.Fill;
                //이미지를 가장 앞으로 가지고 온다.
                picCtrImg.BringToFront();
            }
        }

        private void btnPicSave_Click(object sender, EventArgs e)
        {
            //픽쳐박스 이미지 저장

            if (picCtrImg.Image == null) return;  // Picturebox에 이미지가 없을 경우 리턴
            if (picCtrImg.Tag.ToString() == "") return; //  picItemImage.Tag = Dialog.FileName; 에서 tag로 저장한 내용이 없으면 리턴
            if (MessageBox.Show("선택한 이미지로 등록하시겠습니까?", "이미지 등록", MessageBoxButtons.YesNo) == DialogResult.No) return;

            string sImagefile = string.Empty;
            //이미지 불러오기 및 저장, 파일 탐색기 호출

            Byte[] bImage = null;
            Connect = new SqlConnection(strConn);


            try
            {
                #region Save Image
                FileStream stream = new FileStream(picCtrImg.Tag.ToString(), FileMode.Open, FileAccess.Read);  // 파일에서 그림파일을 가져올 수 있도록 경로와 방법을 지정(읽기전용)
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
                string sRentID =  // 현재 선택된 행에 CARCODE라는 칸에 값을 string 형식으로 받아와라 /왜 CARCODE? -- 기본 KEY값이기 때문에 반드시 존재
                cmd.CommandText = "UPDATE TB_4_RENT SET IMGCONTRACT = @IMAGE WHERE RENTID = @RENTID";
                cmd.Parameters.AddWithValue("@IMAGE", bImage); // byte 형식의 이미지 파일  -- @IMAGE로 업데이트 
                cmd.Parameters.AddWithValue("@RENTID", sRentID);
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
    }
}
