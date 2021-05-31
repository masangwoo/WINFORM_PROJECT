
namespace ApplicationDev_Do
{
    partial class FM_Main
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
            this.components = new System.ComponentModel.Container();
            this.MenuStip = new System.Windows.Forms.MenuStrip();
            this.M_SYSTEM = new System.Windows.Forms.ToolStripMenuItem();
            this.FM_RentClient = new System.Windows.Forms.ToolStripMenuItem();
            this.FM_RENT = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.stbSearch = new System.Windows.Forms.ToolStripButton();
            this.stbInsert = new System.Windows.Forms.ToolStripButton();
            this.stbDelete = new System.Windows.Forms.ToolStripButton();
            this.stbSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.stbclose = new System.Windows.Forms.ToolStripButton();
            this.stbExit = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tssSpace = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssUserName = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssNowDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.myTabControl1 = new ApplicationDev_Do.MyTabControl();
            this.FM_Car = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStip
            // 
            this.MenuStip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.M_SYSTEM});
            this.MenuStip.Location = new System.Drawing.Point(0, 0);
            this.MenuStip.Name = "MenuStip";
            this.MenuStip.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.MenuStip.Size = new System.Drawing.Size(1029, 30);
            this.MenuStip.TabIndex = 0;
            // 
            // M_SYSTEM
            // 
            this.M_SYSTEM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FM_RentClient,
            this.FM_Car,
            this.FM_RENT});
            this.M_SYSTEM.Name = "M_SYSTEM";
            this.M_SYSTEM.Size = new System.Drawing.Size(103, 24);
            this.M_SYSTEM.Text = "시스템 관리";
            // 
            // FM_RentClient
            // 
            this.FM_RentClient.Name = "FM_RentClient";
            this.FM_RentClient.Size = new System.Drawing.Size(224, 26);
            this.FM_RentClient.Text = "고객 조회";
            // 
            // FM_RENT
            // 
            this.FM_RENT.Name = "FM_RENT";
            this.FM_RENT.Size = new System.Drawing.Size(224, 26);
            this.FM_RENT.Text = "렌트 관리";
            this.FM_RENT.Click += new System.EventHandler(this.FM_RENT_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.AutoSize = false;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stbSearch,
            this.stbInsert,
            this.stbDelete,
            this.stbSave,
            this.toolStripSeparator1,
            this.stbclose,
            this.stbExit});
            this.toolStrip.Location = new System.Drawing.Point(0, 30);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1029, 111);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
            // 
            // stbSearch
            // 
            this.stbSearch.Image = global::ApplicationDev_Do.Properties.Resources.BtnSearch;
            this.stbSearch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.stbSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stbSearch.Name = "stbSearch";
            this.stbSearch.Size = new System.Drawing.Size(54, 108);
            this.stbSearch.Text = "조회";
            this.stbSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.stbSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.stbSearch.Click += new System.EventHandler(this.stbSearch_Click);
            // 
            // stbInsert
            // 
            this.stbInsert.Image = global::ApplicationDev_Do.Properties.Resources.BtnAdd;
            this.stbInsert.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.stbInsert.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stbInsert.Name = "stbInsert";
            this.stbInsert.Size = new System.Drawing.Size(54, 108);
            this.stbInsert.Text = "추가";
            this.stbInsert.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.stbInsert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.stbInsert.Click += new System.EventHandler(this.stbInsert_Click);
            // 
            // stbDelete
            // 
            this.stbDelete.Image = global::ApplicationDev_Do.Properties.Resources.BtnDelete;
            this.stbDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.stbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stbDelete.Name = "stbDelete";
            this.stbDelete.Size = new System.Drawing.Size(54, 108);
            this.stbDelete.Text = "삭제";
            this.stbDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.stbDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.stbDelete.Click += new System.EventHandler(this.stbDelete_Click);
            // 
            // stbSave
            // 
            this.stbSave.Image = global::ApplicationDev_Do.Properties.Resources.BtnSaveB;
            this.stbSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.stbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stbSave.Name = "stbSave";
            this.stbSave.Size = new System.Drawing.Size(54, 108);
            this.stbSave.Text = "저장";
            this.stbSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.stbSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.stbSave.Click += new System.EventHandler(this.stbSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 111);
            // 
            // stbclose
            // 
            this.stbclose.Image = global::ApplicationDev_Do.Properties.Resources.BtnClose;
            this.stbclose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.stbclose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stbclose.Name = "stbclose";
            this.stbclose.Size = new System.Drawing.Size(54, 108);
            this.stbclose.Text = "닫기";
            this.stbclose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.stbclose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.stbclose.Click += new System.EventHandler(this.stbclose_Click);
            // 
            // stbExit
            // 
            this.stbExit.Image = global::ApplicationDev_Do.Properties.Resources.BtcExit;
            this.stbExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.stbExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stbExit.Name = "stbExit";
            this.stbExit.Size = new System.Drawing.Size(54, 108);
            this.stbExit.Text = "종료";
            this.stbExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.stbExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssSpace,
            this.tssUserName,
            this.tssNowDate});
            this.statusStrip.Location = new System.Drawing.Point(0, 576);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 18, 0);
            this.statusStrip.Size = new System.Drawing.Size(1029, 24);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // tssSpace
            // 
            this.tssSpace.AutoSize = false;
            this.tssSpace.Name = "tssSpace";
            this.tssSpace.Size = new System.Drawing.Size(410, 18);
            this.tssSpace.Spring = true;
            // 
            // tssUserName
            // 
            this.tssUserName.AutoSize = false;
            this.tssUserName.Name = "tssUserName";
            this.tssUserName.Size = new System.Drawing.Size(300, 18);
            this.tssUserName.Text = "toolStripStatusLabel2";
            // 
            // tssNowDate
            // 
            this.tssNowDate.AutoSize = false;
            this.tssNowDate.Name = "tssNowDate";
            this.tssNowDate.Size = new System.Drawing.Size(300, 18);
            this.tssNowDate.Text = "toolStripStatusLabel3";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // myTabControl1
            // 
            this.myTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myTabControl1.Location = new System.Drawing.Point(0, 141);
            this.myTabControl1.Name = "myTabControl1";
            this.myTabControl1.SelectedIndex = 0;
            this.myTabControl1.Size = new System.Drawing.Size(1029, 435);
            this.myTabControl1.TabIndex = 4;
            // 
            // FM_Car
            // 
            this.FM_Car.Name = "FM_Car";
            this.FM_Car.Size = new System.Drawing.Size(224, 26);
            this.FM_Car.Text = "차량관리";
            // 
            // FM_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 600);
            this.Controls.Add(this.myTabControl1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.MenuStip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuStip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FM_Main";
            this.Text = "Application DEV V 1.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MenuStip.ResumeLayout(false);
            this.MenuStip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStip;
        private System.Windows.Forms.ToolStripMenuItem M_SYSTEM;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripButton stbSearch;
        private System.Windows.Forms.ToolStripButton stbInsert;
        private System.Windows.Forms.ToolStripButton stbDelete;
        private System.Windows.Forms.ToolStripButton stbSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton stbclose;
        private System.Windows.Forms.ToolStripButton stbExit;
        private System.Windows.Forms.ToolStripStatusLabel tssSpace;
        private System.Windows.Forms.ToolStripStatusLabel tssUserName;
        private System.Windows.Forms.ToolStripStatusLabel tssNowDate;
        private System.Windows.Forms.Timer timer1;
        private MyTabControl myTabControl1;
        private System.Windows.Forms.ToolStripMenuItem FM_RentClient;
        private System.Windows.Forms.ToolStripMenuItem FM_RENT;
        private System.Windows.Forms.ToolStripMenuItem FM_Car;
    }
}