
namespace SaSa
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.mnuSasa = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKho = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKho_QLHH = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKho_QLMH = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKho_BCTK = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSX = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýGiaCôngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNguyênLiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýHàngLỗiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoadon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHDB = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHDM = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDM = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDM_NV = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDM_KH = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDT = new System.Windows.Forms.ToolStripMenuItem();
            this.ptClose = new System.Windows.Forms.PictureBox();
            this.tạoHoáĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptClose)).BeginInit();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.BackColor = System.Drawing.Color.Transparent;
            this.menuMain.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSasa,
            this.mnuKho,
            this.mnuSX,
            this.mnuHoadon,
            this.mnuDM,
            this.mnuDT});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Padding = new System.Windows.Forms.Padding(6, 10, 0, 2);
            this.menuMain.Size = new System.Drawing.Size(810, 33);
            this.menuMain.TabIndex = 2;
            this.menuMain.Text = "menuStrip1";
            // 
            // mnuSasa
            // 
            this.mnuSasa.Name = "mnuSasa";
            this.mnuSasa.Size = new System.Drawing.Size(52, 21);
            this.mnuSasa.Text = "SASA";
            // 
            // mnuKho
            // 
            this.mnuKho.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuKho_QLHH,
            this.mnuKho_QLMH,
            this.mnuKho_BCTK});
            this.mnuKho.Name = "mnuKho";
            this.mnuKho.Size = new System.Drawing.Size(44, 21);
            this.mnuKho.Text = "Kho";
            // 
            // mnuKho_QLHH
            // 
            this.mnuKho_QLHH.Name = "mnuKho_QLHH";
            this.mnuKho_QLHH.Size = new System.Drawing.Size(186, 22);
            this.mnuKho_QLHH.Text = "Quản lý hàng hoá";
            this.mnuKho_QLHH.Click += new System.EventHandler(this.mnuKho_QLHH_Click);
            // 
            // mnuKho_QLMH
            // 
            this.mnuKho_QLMH.Name = "mnuKho_QLMH";
            this.mnuKho_QLMH.Size = new System.Drawing.Size(186, 22);
            this.mnuKho_QLMH.Text = "Quản lý mặt hàng";
            this.mnuKho_QLMH.Click += new System.EventHandler(this.mnuKho_QLMH_Click);
            // 
            // mnuKho_BCTK
            // 
            this.mnuKho_BCTK.Name = "mnuKho_BCTK";
            this.mnuKho_BCTK.Size = new System.Drawing.Size(186, 22);
            this.mnuKho_BCTK.Text = "Báo cáo tồn kho";
            // 
            // mnuSX
            // 
            this.mnuSX.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýGiaCôngToolStripMenuItem,
            this.quảnLýNguyênLiệuToolStripMenuItem,
            this.quảnLýHàngLỗiToolStripMenuItem});
            this.mnuSX.Name = "mnuSX";
            this.mnuSX.Size = new System.Drawing.Size(73, 21);
            this.mnuSX.Text = "Sản xuất";
            // 
            // quảnLýGiaCôngToolStripMenuItem
            // 
            this.quảnLýGiaCôngToolStripMenuItem.Name = "quảnLýGiaCôngToolStripMenuItem";
            this.quảnLýGiaCôngToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.quảnLýGiaCôngToolStripMenuItem.Text = "Quản lý gia công";
            // 
            // quảnLýNguyênLiệuToolStripMenuItem
            // 
            this.quảnLýNguyênLiệuToolStripMenuItem.Name = "quảnLýNguyênLiệuToolStripMenuItem";
            this.quảnLýNguyênLiệuToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.quảnLýNguyênLiệuToolStripMenuItem.Text = "Quản lý nguyên liệu";
            // 
            // quảnLýHàngLỗiToolStripMenuItem
            // 
            this.quảnLýHàngLỗiToolStripMenuItem.Name = "quảnLýHàngLỗiToolStripMenuItem";
            this.quảnLýHàngLỗiToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.quảnLýHàngLỗiToolStripMenuItem.Text = "Quản lý hàng lỗi";
            // 
            // mnuHoadon
            // 
            this.mnuHoadon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHDB,
            this.mnuHDM});
            this.mnuHoadon.Name = "mnuHoadon";
            this.mnuHoadon.Size = new System.Drawing.Size(73, 21);
            this.mnuHoadon.Text = "Hoá đơn";
            // 
            // mnuHDB
            // 
            this.mnuHDB.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tạoHoáĐơnToolStripMenuItem});
            this.mnuHDB.Name = "mnuHDB";
            this.mnuHDB.Size = new System.Drawing.Size(180, 22);
            this.mnuHDB.Text = "Hoá đơn bán";
            this.mnuHDB.Click += new System.EventHandler(this.mnuHDB_Click);
            // 
            // mnuHDM
            // 
            this.mnuHDM.Name = "mnuHDM";
            this.mnuHDM.Size = new System.Drawing.Size(180, 22);
            this.mnuHDM.Text = "Hoá đơn mua";
            // 
            // mnuDM
            // 
            this.mnuDM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDM_NV,
            this.mnuDM_KH});
            this.mnuDM.Name = "mnuDM";
            this.mnuDM.Size = new System.Drawing.Size(82, 21);
            this.mnuDM.Text = "Danh mục";
            // 
            // mnuDM_NV
            // 
            this.mnuDM_NV.Name = "mnuDM_NV";
            this.mnuDM_NV.Size = new System.Drawing.Size(148, 22);
            this.mnuDM_NV.Text = "Nhân viên";
            this.mnuDM_NV.Click += new System.EventHandler(this.mnuDM_NV_Click);
            // 
            // mnuDM_KH
            // 
            this.mnuDM_KH.Name = "mnuDM_KH";
            this.mnuDM_KH.Size = new System.Drawing.Size(148, 22);
            this.mnuDM_KH.Text = "Khách hàng";
            this.mnuDM_KH.Click += new System.EventHandler(this.mnuDM_KH_Click);
            // 
            // mnuDT
            // 
            this.mnuDT.Name = "mnuDT";
            this.mnuDT.Size = new System.Drawing.Size(87, 21);
            this.mnuDT.Text = "Doanh Thu";
            // 
            // ptClose
            // 
            this.ptClose.BackColor = System.Drawing.Color.Transparent;
            this.ptClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptClose.Image = ((System.Drawing.Image)(resources.GetObject("ptClose.Image")));
            this.ptClose.Location = new System.Drawing.Point(785, 2);
            this.ptClose.Name = "ptClose";
            this.ptClose.Size = new System.Drawing.Size(23, 24);
            this.ptClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptClose.TabIndex = 3;
            this.ptClose.TabStop = false;
            this.ptClose.Click += new System.EventHandler(this.ptClose_Click);
            // 
            // tạoHoáĐơnToolStripMenuItem
            // 
            this.tạoHoáĐơnToolStripMenuItem.Name = "tạoHoáĐơnToolStripMenuItem";
            this.tạoHoáĐơnToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tạoHoáĐơnToolStripMenuItem.Text = "Tạo hoá đơn";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(810, 420);
            this.Controls.Add(this.ptClose);
            this.Controls.Add(this.menuMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuMain;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuSasa;
        private System.Windows.Forms.ToolStripMenuItem mnuKho;
        private System.Windows.Forms.ToolStripMenuItem mnuKho_QLHH;
        private System.Windows.Forms.ToolStripMenuItem mnuKho_QLMH;
        private System.Windows.Forms.ToolStripMenuItem mnuKho_BCTK;
        private System.Windows.Forms.ToolStripMenuItem mnuSX;
        private System.Windows.Forms.ToolStripMenuItem quảnLýGiaCôngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNguyênLiệuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýHàngLỗiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuHoadon;
        private System.Windows.Forms.ToolStripMenuItem mnuHDB;
        private System.Windows.Forms.ToolStripMenuItem mnuHDM;
        private System.Windows.Forms.ToolStripMenuItem mnuDM;
        private System.Windows.Forms.ToolStripMenuItem mnuDT;
        private System.Windows.Forms.PictureBox ptClose;
        private System.Windows.Forms.ToolStripMenuItem mnuDM_NV;
        private System.Windows.Forms.ToolStripMenuItem mnuDM_KH;
        private System.Windows.Forms.ToolStripMenuItem tạoHoáĐơnToolStripMenuItem;
    }
}

