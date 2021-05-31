
namespace DEV_Form
{
    partial class FM_Car
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRefresh1 = new System.Windows.Forms.Button();
            this.txtCarName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoGas = new System.Windows.Forms.RadioButton();
            this.rdoHybrid = new System.Windows.Forms.RadioButton();
            this.rdoOil = new System.Windows.Forms.RadioButton();
            this.rdoTot = new System.Windows.Forms.RadioButton();
            this.rdoLpg = new System.Windows.Forms.RadioButton();
            this.rdoElec = new System.Windows.Forms.RadioButton();
            this.txtCarCode = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkWait = new System.Windows.Forms.CheckBox();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.cboRentCost = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvGridCar = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.GroupBox();
            this.btnPicDelete = new System.Windows.Forms.Button();
            this.btnPicSave = new System.Windows.Forms.Button();
            this.btnLoadPic = new System.Windows.Forms.Button();
            this.picCarImg = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGridCar)).BeginInit();
            this.btnRefresh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCarImg)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRefresh1);
            this.groupBox1.Controls.Add(this.txtCarName);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtCarCode);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.chkWait);
            this.groupBox1.Controls.Add(this.dtpStart);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtpEnd);
            this.groupBox1.Controls.Add(this.cboRentCost);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1519, 127);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "차량 조회";
            // 
            // btnRefresh1
            // 
            this.btnRefresh1.Location = new System.Drawing.Point(772, 73);
            this.btnRefresh1.Name = "btnRefresh1";
            this.btnRefresh1.Size = new System.Drawing.Size(108, 29);
            this.btnRefresh1.TabIndex = 16;
            this.btnRefresh1.Text = "입력값 초기화";
            this.btnRefresh1.UseVisualStyleBackColor = true;
            this.btnRefresh1.Click += new System.EventHandler(this.btnRefresh1_Click);
            // 
            // txtCarName
            // 
            this.txtCarName.Location = new System.Drawing.Point(367, 27);
            this.txtCarName.Name = "txtCarName";
            this.txtCarName.Size = new System.Drawing.Size(156, 23);
            this.txtCarName.TabIndex = 15;
            this.txtCarName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCarName_KeyDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoGas);
            this.groupBox2.Controls.Add(this.rdoHybrid);
            this.groupBox2.Controls.Add(this.rdoOil);
            this.groupBox2.Controls.Add(this.rdoTot);
            this.groupBox2.Controls.Add(this.rdoLpg);
            this.groupBox2.Controls.Add(this.rdoElec);
            this.groupBox2.Location = new System.Drawing.Point(441, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(285, 70);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "연료 분류";
            // 
            // rdoGas
            // 
            this.rdoGas.AutoSize = true;
            this.rdoGas.Location = new System.Drawing.Point(89, 18);
            this.rdoGas.Name = "rdoGas";
            this.rdoGas.Size = new System.Drawing.Size(61, 19);
            this.rdoGas.TabIndex = 16;
            this.rdoGas.Text = "휘발유";
            this.rdoGas.UseVisualStyleBackColor = true;
            // 
            // rdoHybrid
            // 
            this.rdoHybrid.AutoSize = true;
            this.rdoHybrid.Location = new System.Drawing.Point(6, 43);
            this.rdoHybrid.Name = "rdoHybrid";
            this.rdoHybrid.Size = new System.Drawing.Size(61, 19);
            this.rdoHybrid.TabIndex = 12;
            this.rdoHybrid.Text = "Hybrid";
            this.rdoHybrid.UseVisualStyleBackColor = true;
            // 
            // rdoOil
            // 
            this.rdoOil.AutoSize = true;
            this.rdoOil.Location = new System.Drawing.Point(89, 45);
            this.rdoOil.Name = "rdoOil";
            this.rdoOil.Size = new System.Drawing.Size(49, 19);
            this.rdoOil.TabIndex = 15;
            this.rdoOil.Text = "경유";
            this.rdoOil.UseVisualStyleBackColor = true;
            // 
            // rdoTot
            // 
            this.rdoTot.AutoSize = true;
            this.rdoTot.Checked = true;
            this.rdoTot.Location = new System.Drawing.Point(165, 45);
            this.rdoTot.Name = "rdoTot";
            this.rdoTot.Size = new System.Drawing.Size(77, 19);
            this.rdoTot.TabIndex = 14;
            this.rdoTot.TabStop = true;
            this.rdoTot.Text = "전체 조회";
            this.rdoTot.UseVisualStyleBackColor = true;
            // 
            // rdoLpg
            // 
            this.rdoLpg.AutoSize = true;
            this.rdoLpg.Location = new System.Drawing.Point(165, 18);
            this.rdoLpg.Name = "rdoLpg";
            this.rdoLpg.Size = new System.Drawing.Size(46, 19);
            this.rdoLpg.TabIndex = 13;
            this.rdoLpg.Text = "LPG";
            this.rdoLpg.UseVisualStyleBackColor = true;
            // 
            // rdoElec
            // 
            this.rdoElec.AutoSize = true;
            this.rdoElec.Location = new System.Drawing.Point(6, 18);
            this.rdoElec.Name = "rdoElec";
            this.rdoElec.Size = new System.Drawing.Size(61, 19);
            this.rdoElec.TabIndex = 11;
            this.rdoElec.Text = "전기차";
            this.rdoElec.UseVisualStyleBackColor = true;
            // 
            // txtCarCode
            // 
            this.txtCarCode.Location = new System.Drawing.Point(110, 27);
            this.txtCarCode.Name = "txtCarCode";
            this.txtCarCode.Size = new System.Drawing.Size(156, 23);
            this.txtCarCode.TabIndex = 1;
            this.txtCarCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCarCode_KeyDown);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(886, 73);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 29);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "차량 코드";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "차량 명";
            // 
            // chkWait
            // 
            this.chkWait.AutoSize = true;
            this.chkWait.Location = new System.Drawing.Point(321, 78);
            this.chkWait.Name = "chkWait";
            this.chkWait.Size = new System.Drawing.Size(90, 19);
            this.chkWait.TabIndex = 10;
            this.chkWait.Text = "대기중 검색";
            this.chkWait.UseVisualStyleBackColor = true;
            // 
            // dtpStart
            // 
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(732, 29);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(101, 23);
            this.dtpStart.TabIndex = 4;
            this.dtpStart.Value = new System.DateTime(1991, 1, 1, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "가격별 검색";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(857, 29);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(104, 23);
            this.dtpEnd.TabIndex = 5;
            this.dtpEnd.Value = new System.DateTime(2021, 5, 25, 10, 25, 4, 0);
            // 
            // cboRentCost
            // 
            this.cboRentCost.FormattingEnabled = true;
            this.cboRentCost.Location = new System.Drawing.Point(110, 76);
            this.cboRentCost.Name = "cboRentCost";
            this.cboRentCost.Size = new System.Drawing.Size(156, 23);
            this.cboRentCost.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(667, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "등록 일자";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(839, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "~";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvGridCar);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 127);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1519, 620);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "차량 정보";
            // 
            // dgvGridCar
            // 
            this.dgvGridCar.AllowUserToAddRows = false;
            this.dgvGridCar.AllowUserToDeleteRows = false;
            this.dgvGridCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGridCar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGridCar.Location = new System.Drawing.Point(3, 19);
            this.dgvGridCar.Name = "dgvGridCar";
            this.dgvGridCar.RowHeadersWidth = 51;
            this.dgvGridCar.RowTemplate.Height = 25;
            this.dgvGridCar.Size = new System.Drawing.Size(1513, 598);
            this.dgvGridCar.TabIndex = 3;
            this.dgvGridCar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrid_CellClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Controls.Add(this.btnPicDelete);
            this.btnRefresh.Controls.Add(this.btnPicSave);
            this.btnRefresh.Controls.Add(this.btnLoadPic);
            this.btnRefresh.Controls.Add(this.picCarImg);
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnRefresh.Location = new System.Drawing.Point(0, 370);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(1519, 377);
            this.btnRefresh.TabIndex = 17;
            this.btnRefresh.TabStop = false;
            this.btnRefresh.Text = "이미지 조회";
            // 
            // btnPicDelete
            // 
            this.btnPicDelete.Location = new System.Drawing.Point(628, 38);
            this.btnPicDelete.Name = "btnPicDelete";
            this.btnPicDelete.Size = new System.Drawing.Size(75, 23);
            this.btnPicDelete.TabIndex = 3;
            this.btnPicDelete.Text = "삭제";
            this.btnPicDelete.UseVisualStyleBackColor = true;
            this.btnPicDelete.Click += new System.EventHandler(this.btnPicDelete_Click);
            // 
            // btnPicSave
            // 
            this.btnPicSave.Location = new System.Drawing.Point(534, 37);
            this.btnPicSave.Name = "btnPicSave";
            this.btnPicSave.Size = new System.Drawing.Size(88, 23);
            this.btnPicSave.TabIndex = 2;
            this.btnPicSave.Text = "저장";
            this.btnPicSave.UseVisualStyleBackColor = true;
            this.btnPicSave.Click += new System.EventHandler(this.btnPicSave_Click);
            // 
            // btnLoadPic
            // 
            this.btnLoadPic.Location = new System.Drawing.Point(407, 37);
            this.btnLoadPic.Name = "btnLoadPic";
            this.btnLoadPic.Size = new System.Drawing.Size(121, 23);
            this.btnLoadPic.TabIndex = 1;
            this.btnLoadPic.Text = "이미지 불러오기";
            this.btnLoadPic.UseVisualStyleBackColor = true;
            this.btnLoadPic.Click += new System.EventHandler(this.btnLoadPic_Click);
            // 
            // picCarImg
            // 
            this.picCarImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCarImg.Location = new System.Drawing.Point(3, 22);
            this.picCarImg.Name = "picCarImg";
            this.picCarImg.Size = new System.Drawing.Size(383, 392);
            this.picCarImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCarImg.TabIndex = 0;
            this.picCarImg.TabStop = false;
            this.picCarImg.Click += new System.EventHandler(this.picCarImg_Click);
            // 
            // FM_Car
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1519, 747);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FM_Car";
            this.Text = "FM_Car";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FM_ITEM_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGridCar)).EndInit();
            this.btnRefresh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCarImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoElec;
        private System.Windows.Forms.RadioButton rdoHybrid;
        private System.Windows.Forms.TextBox txtCarCode;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkWait;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.ComboBox cboRentCost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvGridCar;
        private System.Windows.Forms.GroupBox btnRefresh;
        private System.Windows.Forms.Button btnPicDelete;
        private System.Windows.Forms.Button btnPicSave;
        private System.Windows.Forms.Button btnLoadPic;
        private System.Windows.Forms.PictureBox picCarImg;
        private System.Windows.Forms.TextBox txtCarName;
        private System.Windows.Forms.RadioButton rdoGas;
        private System.Windows.Forms.RadioButton rdoOil;
        private System.Windows.Forms.RadioButton rdoTot;
        private System.Windows.Forms.RadioButton rdoLpg;
        private System.Windows.Forms.Button btnRefresh1;
    }
}