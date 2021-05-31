
namespace DEV_Form
{
    partial class FM_RENT
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCarID = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdoTotal = new System.Windows.Forms.RadioButton();
            this.rdoInsur1 = new System.Windows.Forms.RadioButton();
            this.rdoInsur2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkNreturn = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.txtRentCode = new System.Windows.Forms.TextBox();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.btnPicDelete = new System.Windows.Forms.Button();
            this.btnPicSave = new System.Windows.Forms.Button();
            this.btnLoadPic = new System.Windows.Forms.Button();
            this.picCtrImg = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCtrImg)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnReturn);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtCarID);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.chkNreturn);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpEnd);
            this.groupBox1.Controls.Add(this.txtRentCode);
            this.groupBox1.Controls.Add(this.dtpStart);
            this.groupBox1.Controls.Add(this.txtClientName);
            this.groupBox1.Size = new System.Drawing.Size(1451, 165);
            this.groupBox1.Text = "조회";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPicDelete);
            this.groupBox2.Controls.Add(this.btnPicSave);
            this.groupBox2.Controls.Add(this.btnLoadPic);
            this.groupBox2.Controls.Add(this.picCtrImg);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 484);
            this.groupBox2.Size = new System.Drawing.Size(1451, 291);
            this.groupBox2.Text = "계약서 이미지 관리";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(912, 101);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 29);
            this.btnAdd.TabIndex = 28;
            this.btnAdd.Text = "추가";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(1028, 101);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(90, 29);
            this.btnReturn.TabIndex = 27;
            this.btnReturn.Text = "반납";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(611, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "차량 ID";
            // 
            // txtCarID
            // 
            this.txtCarID.Location = new System.Drawing.Point(671, 30);
            this.txtCarID.Name = "txtCarID";
            this.txtCarID.Size = new System.Drawing.Size(177, 27);
            this.txtCarID.TabIndex = 26;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdoTotal);
            this.groupBox3.Controls.Add(this.rdoInsur1);
            this.groupBox3.Controls.Add(this.rdoInsur2);
            this.groupBox3.Location = new System.Drawing.Point(148, 77);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(257, 67);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "보험종류";
            // 
            // rdoTotal
            // 
            this.rdoTotal.AutoSize = true;
            this.rdoTotal.Location = new System.Drawing.Point(21, 27);
            this.rdoTotal.Name = "rdoTotal";
            this.rdoTotal.Size = new System.Drawing.Size(60, 24);
            this.rdoTotal.TabIndex = 6;
            this.rdoTotal.Text = "전체";
            this.rdoTotal.UseVisualStyleBackColor = true;
            // 
            // rdoInsur1
            // 
            this.rdoInsur1.AutoSize = true;
            this.rdoInsur1.Checked = true;
            this.rdoInsur1.Location = new System.Drawing.Point(87, 27);
            this.rdoInsur1.Name = "rdoInsur1";
            this.rdoInsur1.Size = new System.Drawing.Size(60, 24);
            this.rdoInsur1.TabIndex = 5;
            this.rdoInsur1.TabStop = true;
            this.rdoInsur1.Text = "일반";
            this.rdoInsur1.UseVisualStyleBackColor = true;
            // 
            // rdoInsur2
            // 
            this.rdoInsur2.AutoSize = true;
            this.rdoInsur2.Location = new System.Drawing.Point(153, 26);
            this.rdoInsur2.Name = "rdoInsur2";
            this.rdoInsur2.Size = new System.Drawing.Size(60, 24);
            this.rdoInsur2.TabIndex = 5;
            this.rdoInsur2.Text = "완전";
            this.rdoInsur2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "렌트코드";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1143, 101);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 29);
            this.btnSearch.TabIndex = 23;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "고객 ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1086, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "~";
            // 
            // chkNreturn
            // 
            this.chkNreturn.AutoSize = true;
            this.chkNreturn.Location = new System.Drawing.Point(528, 106);
            this.chkNreturn.Name = "chkNreturn";
            this.chkNreturn.Size = new System.Drawing.Size(141, 24);
            this.chkNreturn.TabIndex = 22;
            this.chkNreturn.Text = "미반납 차량조회";
            this.chkNreturn.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(879, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "동록일자";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(1112, 32);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(121, 27);
            this.dtpEnd.TabIndex = 21;
            this.dtpEnd.Value = new System.DateTime(2021, 5, 25, 0, 0, 0, 0);
            // 
            // txtRentCode
            // 
            this.txtRentCode.Location = new System.Drawing.Point(116, 29);
            this.txtRentCode.Name = "txtRentCode";
            this.txtRentCode.Size = new System.Drawing.Size(177, 27);
            this.txtRentCode.TabIndex = 18;
            // 
            // dtpStart
            // 
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(959, 31);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(121, 27);
            this.dtpStart.TabIndex = 20;
            this.dtpStart.Value = new System.DateTime(2020, 5, 1, 0, 0, 0, 0);
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(406, 28);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(177, 27);
            this.txtClientName.TabIndex = 19;
            // 
            // btnPicDelete
            // 
            this.btnPicDelete.Location = new System.Drawing.Point(518, 231);
            this.btnPicDelete.Name = "btnPicDelete";
            this.btnPicDelete.Size = new System.Drawing.Size(94, 29);
            this.btnPicDelete.TabIndex = 3;
            this.btnPicDelete.Text = "삭제";
            this.btnPicDelete.UseVisualStyleBackColor = true;
            // 
            // btnPicSave
            // 
            this.btnPicSave.Location = new System.Drawing.Point(418, 231);
            this.btnPicSave.Name = "btnPicSave";
            this.btnPicSave.Size = new System.Drawing.Size(94, 29);
            this.btnPicSave.TabIndex = 4;
            this.btnPicSave.Text = "저장";
            this.btnPicSave.UseVisualStyleBackColor = true;
            // 
            // btnLoadPic
            // 
            this.btnLoadPic.Location = new System.Drawing.Point(58, 231);
            this.btnLoadPic.Name = "btnLoadPic";
            this.btnLoadPic.Size = new System.Drawing.Size(221, 29);
            this.btnLoadPic.TabIndex = 5;
            this.btnLoadPic.Text = "이미지 불러오기";
            this.btnLoadPic.UseVisualStyleBackColor = true;
            // 
            // picCtrImg
            // 
            this.picCtrImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCtrImg.Location = new System.Drawing.Point(58, 26);
            this.picCtrImg.Name = "picCtrImg";
            this.picCtrImg.Size = new System.Drawing.Size(554, 199);
            this.picCtrImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCtrImg.TabIndex = 2;
            this.picCtrImg.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 165);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1451, 319);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "렌트카 정보";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1445, 293);
            this.dataGridView1.TabIndex = 0;
            // 
            // FM_RENT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1451, 775);
            this.Controls.Add(this.groupBox4);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "FM_RENT";
            this.Text = "FM_RENT";
            this.Load += new System.EventHandler(this.FM_RENT2_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox4, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCtrImg)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCarID;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdoTotal;
        private System.Windows.Forms.RadioButton rdoInsur1;
        private System.Windows.Forms.RadioButton rdoInsur2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkNreturn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.TextBox txtRentCode;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.Button btnPicDelete;
        private System.Windows.Forms.Button btnPicSave;
        private System.Windows.Forms.Button btnLoadPic;
        private System.Windows.Forms.PictureBox picCtrImg;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}