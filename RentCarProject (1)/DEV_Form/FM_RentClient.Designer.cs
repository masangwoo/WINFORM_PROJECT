﻿
namespace DEV_Form
{
    partial class FM_RentClient
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdoAll = new System.Windows.Forms.RadioButton();
            this.rdoBlacklist = new System.Windows.Forms.RadioButton();
            this.rdoGeneral = new System.Windows.Forms.RadioButton();
            this.rdoVip = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvGrid = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.picLicenseImg = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrid)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLicenseImg)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.dtpEnd);
            this.groupBox1.Controls.Add(this.dtpStart);
            this.groupBox1.Controls.Add(this.txtClientName);
            this.groupBox1.Controls.Add(this.txtClientID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Size = new System.Drawing.Size(800, 151);
            this.groupBox1.Text = "고객 조회";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvGrid);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 151);
            this.groupBox2.Size = new System.Drawing.Size(800, 231);
            this.groupBox2.Text = "고객 정보";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "고객 ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "가입일자";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "고객 이름";
            // 
            // txtClientID
            // 
            this.txtClientID.Location = new System.Drawing.Point(104, 35);
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.Size = new System.Drawing.Size(125, 27);
            this.txtClientID.TabIndex = 3;
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(329, 35);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(125, 27);
            this.txtClientName.TabIndex = 4;
            // 
            // dtpStart
            // 
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(104, 86);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(139, 27);
            this.dtpStart.TabIndex = 8;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(275, 86);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(135, 27);
            this.dtpEnd.TabIndex = 9;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdoAll);
            this.groupBox3.Controls.Add(this.rdoBlacklist);
            this.groupBox3.Controls.Add(this.rdoGeneral);
            this.groupBox3.Controls.Add(this.rdoVip);
            this.groupBox3.Location = new System.Drawing.Point(509, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(266, 96);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "고객등급";
            // 
            // rdoAll
            // 
            this.rdoAll.AutoSize = true;
            this.rdoAll.Location = new System.Drawing.Point(19, 61);
            this.rdoAll.Name = "rdoAll";
            this.rdoAll.Size = new System.Drawing.Size(95, 24);
            this.rdoAll.TabIndex = 3;
            this.rdoAll.TabStop = true;
            this.rdoAll.Text = "고객 전체";
            this.rdoAll.UseVisualStyleBackColor = true;
            // 
            // rdoBlacklist
            // 
            this.rdoBlacklist.AutoSize = true;
            this.rdoBlacklist.Location = new System.Drawing.Point(144, 31);
            this.rdoBlacklist.Name = "rdoBlacklist";
            this.rdoBlacklist.Size = new System.Drawing.Size(105, 24);
            this.rdoBlacklist.TabIndex = 2;
            this.rdoBlacklist.TabStop = true;
            this.rdoBlacklist.Text = "블랙리스트";
            this.rdoBlacklist.UseVisualStyleBackColor = true;
            // 
            // rdoGeneral
            // 
            this.rdoGeneral.AutoSize = true;
            this.rdoGeneral.Location = new System.Drawing.Point(78, 31);
            this.rdoGeneral.Name = "rdoGeneral";
            this.rdoGeneral.Size = new System.Drawing.Size(60, 24);
            this.rdoGeneral.TabIndex = 1;
            this.rdoGeneral.TabStop = true;
            this.rdoGeneral.Text = "일반";
            this.rdoGeneral.UseVisualStyleBackColor = true;
            // 
            // rdoVip
            // 
            this.rdoVip.AutoSize = true;
            this.rdoVip.Location = new System.Drawing.Point(19, 31);
            this.rdoVip.Name = "rdoVip";
            this.rdoVip.Size = new System.Drawing.Size(53, 24);
            this.rdoVip.TabIndex = 0;
            this.rdoVip.TabStop = true;
            this.rdoVip.Text = "VIP";
            this.rdoVip.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(249, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "~";
            // 
            // dgvGrid
            // 
            this.dgvGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGrid.Location = new System.Drawing.Point(3, 23);
            this.dgvGrid.Name = "dgvGrid";
            this.dgvGrid.RowHeadersWidth = 51;
            this.dgvGrid.RowTemplate.Height = 29;
            this.dgvGrid.Size = new System.Drawing.Size(794, 205);
            this.dgvGrid.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.picLicenseImg);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 382);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(800, 191);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "면허증 이미지 관리";
            // 
            // picLicenseImg
            // 
            this.picLicenseImg.Location = new System.Drawing.Point(27, 37);
            this.picLicenseImg.Name = "picLicenseImg";
            this.picLicenseImg.Size = new System.Drawing.Size(296, 132);
            this.picLicenseImg.TabIndex = 0;
            this.picLicenseImg.TabStop = false;
            // 
            // FM_RentClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 573);
            this.Controls.Add(this.groupBox4);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "FM_RentClient";
            this.Text = "FM_RentUser";
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox4, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrid)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLicenseImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.TextBox txtClientID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdoAll;
        private System.Windows.Forms.RadioButton rdoBlacklist;
        private System.Windows.Forms.RadioButton rdoGeneral;
        private System.Windows.Forms.RadioButton rdoVip;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvGrid;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox picLicenseImg;
    }
}