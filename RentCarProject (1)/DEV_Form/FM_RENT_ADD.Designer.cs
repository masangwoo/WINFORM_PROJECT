
namespace DEV_Form
{
    partial class FM_RENT_ADD
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
            this.btnImgSave = new System.Windows.Forms.Button();
            this.btnImgDelete = new System.Windows.Forms.Button();
            this.btnContract = new System.Windows.Forms.Button();
            this.dgvContract = new System.Windows.Forms.DataGridView();
            this.dtpRentEnd = new System.Windows.Forms.DateTimePicker();
            this.txtExpCost = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbInsurance = new System.Windows.Forms.ComboBox();
            this.dtpRentStart = new System.Windows.Forms.DateTimePicker();
            this.txtCarID = new System.Windows.Forms.TextBox();
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.btnCar = new System.Windows.Forms.Button();
            this.btnClient = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContract)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpRentEnd);
            this.groupBox1.Controls.Add(this.txtExpCost);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbInsurance);
            this.groupBox1.Controls.Add(this.dtpRentStart);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.None;
            this.groupBox1.Location = new System.Drawing.Point(29, 102);
            this.groupBox1.Size = new System.Drawing.Size(561, 207);
            this.groupBox1.Text = "내역 등록";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnImgSave);
            this.groupBox2.Controls.Add(this.btnImgDelete);
            this.groupBox2.Controls.Add(this.btnContract);
            this.groupBox2.Controls.Add(this.dgvContract);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.None;
            this.groupBox2.Location = new System.Drawing.Point(29, 327);
            this.groupBox2.Size = new System.Drawing.Size(561, 314);
            this.groupBox2.Text = "계약서이미지등록";
            // 
            // btnImgSave
            // 
            this.btnImgSave.Location = new System.Drawing.Point(363, 246);
            this.btnImgSave.Name = "btnImgSave";
            this.btnImgSave.Size = new System.Drawing.Size(89, 29);
            this.btnImgSave.TabIndex = 8;
            this.btnImgSave.Text = "저장";
            this.btnImgSave.UseVisualStyleBackColor = true;
            // 
            // btnImgDelete
            // 
            this.btnImgDelete.Location = new System.Drawing.Point(458, 246);
            this.btnImgDelete.Name = "btnImgDelete";
            this.btnImgDelete.Size = new System.Drawing.Size(90, 29);
            this.btnImgDelete.TabIndex = 7;
            this.btnImgDelete.Text = "삭제";
            this.btnImgDelete.UseVisualStyleBackColor = true;
            // 
            // btnContract
            // 
            this.btnContract.Location = new System.Drawing.Point(372, 211);
            this.btnContract.Name = "btnContract";
            this.btnContract.Size = new System.Drawing.Size(176, 29);
            this.btnContract.TabIndex = 6;
            this.btnContract.Text = "파일불러오기";
            this.btnContract.UseVisualStyleBackColor = true;
            // 
            // dgvContract
            // 
            this.dgvContract.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContract.Location = new System.Drawing.Point(22, 39);
            this.dgvContract.Name = "dgvContract";
            this.dgvContract.RowHeadersWidth = 51;
            this.dgvContract.RowTemplate.Height = 29;
            this.dgvContract.Size = new System.Drawing.Size(328, 236);
            this.dgvContract.TabIndex = 5;
            // 
            // dtpRentEnd
            // 
            this.dtpRentEnd.Location = new System.Drawing.Point(273, 63);
            this.dtpRentEnd.Name = "dtpRentEnd";
            this.dtpRentEnd.Size = new System.Drawing.Size(211, 27);
            this.dtpRentEnd.TabIndex = 16;
            // 
            // txtExpCost
            // 
            this.txtExpCost.Location = new System.Drawing.Point(273, 141);
            this.txtExpCost.Name = "txtExpCost";
            this.txtExpCost.Size = new System.Drawing.Size(162, 27);
            this.txtExpCost.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "보험선택";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(273, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "예상비용";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "반납예정일";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "렌트시작일";
            // 
            // cmbInsurance
            // 
            this.cmbInsurance.FormattingEnabled = true;
            this.cmbInsurance.Location = new System.Drawing.Point(29, 140);
            this.cmbInsurance.Name = "cmbInsurance";
            this.cmbInsurance.Size = new System.Drawing.Size(151, 28);
            this.cmbInsurance.TabIndex = 10;
            // 
            // dtpRentStart
            // 
            this.dtpRentStart.Location = new System.Drawing.Point(27, 63);
            this.dtpRentStart.Name = "dtpRentStart";
            this.dtpRentStart.Size = new System.Drawing.Size(211, 27);
            this.dtpRentStart.TabIndex = 9;
            // 
            // txtCarID
            // 
            this.txtCarID.Location = new System.Drawing.Point(417, 42);
            this.txtCarID.Name = "txtCarID";
            this.txtCarID.Size = new System.Drawing.Size(125, 27);
            this.txtCarID.TabIndex = 7;
            this.txtCarID.Text = "차량아이디";
            // 
            // txtClientID
            // 
            this.txtClientID.Location = new System.Drawing.Point(158, 41);
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.Size = new System.Drawing.Size(125, 27);
            this.txtClientID.TabIndex = 6;
            this.txtClientID.Text = "고객아이디";
            // 
            // btnCar
            // 
            this.btnCar.Location = new System.Drawing.Point(317, 41);
            this.btnCar.Name = "btnCar";
            this.btnCar.Size = new System.Drawing.Size(94, 29);
            this.btnCar.TabIndex = 5;
            this.btnCar.Text = "차량조회";
            this.btnCar.UseVisualStyleBackColor = true;
            // 
            // btnClient
            // 
            this.btnClient.Location = new System.Drawing.Point(58, 39);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(94, 29);
            this.btnClient.TabIndex = 4;
            this.btnClient.Text = "고객조회";
            this.btnClient.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(392, 660);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 29);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(500, 660);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 29);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "닫기";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // FM_RENT_ADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 718);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtCarID);
            this.Controls.Add(this.txtClientID);
            this.Controls.Add(this.btnCar);
            this.Controls.Add(this.btnClient);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "FM_RENT_ADD";
            this.Text = "FM_RENT_ADD2";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.btnClient, 0);
            this.Controls.SetChildIndex(this.btnCar, 0);
            this.Controls.SetChildIndex(this.txtClientID, 0);
            this.Controls.SetChildIndex(this.txtCarID, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContract)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImgSave;
        private System.Windows.Forms.Button btnImgDelete;
        private System.Windows.Forms.Button btnContract;
        private System.Windows.Forms.DataGridView dgvContract;
        private System.Windows.Forms.DateTimePicker dtpRentEnd;
        private System.Windows.Forms.TextBox txtExpCost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbInsurance;
        private System.Windows.Forms.DateTimePicker dtpRentStart;
        private System.Windows.Forms.TextBox txtCarID;
        private System.Windows.Forms.TextBox txtClientID;
        private System.Windows.Forms.Button btnCar;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}