
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
            this.hdb_Create = new System.Windows.Forms.ToolStripMenuItem();
            this.hdb_View = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHDM = new System.Windows.Forms.ToolStripMenuItem();
            this.đơnĐặtHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDM = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDM_NV = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDM_KH = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDM_NCU = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDT = new System.Windows.Forms.ToolStripMenuItem();
            this.ptClose = new System.Windows.Forms.PictureBox();
            this.lbTenDN = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lvddh = new System.Windows.Forms.ListView();
            this.menuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptClose)).BeginInit();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.AutoSize = false;
            this.menuMain.BackColor = System.Drawing.Color.PeachPuff;
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
            this.menuMain.Size = new System.Drawing.Size(810, 63);
            this.menuMain.TabIndex = 2;
            this.menuMain.Text = "menuStrip1";
            // 
            // mnuSasa
            // 
            this.mnuSasa.AutoSize = false;
            this.mnuSasa.Image = ((System.Drawing.Image)(resources.GetObject("mnuSasa.Image")));
            this.mnuSasa.Name = "mnuSasa";
            this.mnuSasa.Size = new System.Drawing.Size(68, 51);
            this.mnuSasa.Text = "SASA";
            // 
            // mnuKho
            // 
            this.mnuKho.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuKho_QLHH,
            this.mnuKho_QLMH,
            this.mnuKho_BCTK});
            this.mnuKho.Name = "mnuKho";
            this.mnuKho.Size = new System.Drawing.Size(44, 51);
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
            this.mnuSX.Size = new System.Drawing.Size(73, 51);
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
            this.mnuHDM,
            this.đơnĐặtHàngToolStripMenuItem});
            this.mnuHoadon.Name = "mnuHoadon";
            this.mnuHoadon.Size = new System.Drawing.Size(73, 51);
            this.mnuHoadon.Text = "Hoá đơn";
            // 
            // mnuHDB
            // 
            this.mnuHDB.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hdb_Create,
            this.hdb_View});
            this.mnuHDB.Name = "mnuHDB";
            this.mnuHDB.Size = new System.Drawing.Size(160, 22);
            this.mnuHDB.Text = "Hoá đơn bán";
            
            // 
            // hdb_Create
            // 
            this.hdb_Create.Name = "hdb_Create";
            this.hdb_Create.Size = new System.Drawing.Size(158, 22);
            this.hdb_Create.Text = "Tạo hoá đơn";
            this.hdb_Create.Click += new System.EventHandler(this.hdb_Create_Click);
            // 
            // hdb_View
            // 
            this.hdb_View.Name = "hdb_View";
            this.hdb_View.Size = new System.Drawing.Size(158, 22);
            this.hdb_View.Text = "Xem hoá đơn";
            this.hdb_View.Click += new System.EventHandler(this.hdb_View_Click);
            // 
            // mnuHDM
            // 
            this.mnuHDM.Name = "mnuHDM";
            this.mnuHDM.Size = new System.Drawing.Size(160, 22);
            this.mnuHDM.Text = "Hoá đơn mua";
            this.mnuHDM.Click += new System.EventHandler(this.mnuHDM_Click);
            // 
            // đơnĐặtHàngToolStripMenuItem
            // 
            this.đơnĐặtHàngToolStripMenuItem.Name = "đơnĐặtHàngToolStripMenuItem";
            this.đơnĐặtHàngToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.đơnĐặtHàngToolStripMenuItem.Text = "Đơn đặt hàng";
            // 
            // mnuDM
            // 
            this.mnuDM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDM_NV,
            this.mnuDM_KH,
            this.mnuDM_NCU});
            this.mnuDM.Name = "mnuDM";
            this.mnuDM.Size = new System.Drawing.Size(82, 51);
            this.mnuDM.Text = "Danh mục";
            // 
            // mnuDM_NV
            // 
            this.mnuDM_NV.Name = "mnuDM_NV";
            this.mnuDM_NV.Size = new System.Drawing.Size(163, 22);
            this.mnuDM_NV.Text = "Nhân viên";
            this.mnuDM_NV.Click += new System.EventHandler(this.mnuDM_NV_Click);
            // 
            // mnuDM_KH
            // 
            this.mnuDM_KH.Name = "mnuDM_KH";
            this.mnuDM_KH.Size = new System.Drawing.Size(163, 22);
            this.mnuDM_KH.Text = "Khách hàng";
            this.mnuDM_KH.Click += new System.EventHandler(this.mnuDM_KH_Click);
            // 
            // mnuDM_NCU
            // 
            this.mnuDM_NCU.Name = "mnuDM_NCU";
            this.mnuDM_NCU.Size = new System.Drawing.Size(163, 22);
            this.mnuDM_NCU.Text = "Nhà cung ứng";
            this.mnuDM_NCU.Click += new System.EventHandler(this.mnuDM_NCU_Click);
            // 
            // mnuDT
            // 
            this.mnuDT.Name = "mnuDT";
            this.mnuDT.Size = new System.Drawing.Size(87, 51);
            this.mnuDT.Text = "Doanh Thu";
            this.mnuDT.Click += new System.EventHandler(this.mnuDT_Click);
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
            // lbTenDN
            // 
            this.lbTenDN.AutoSize = true;
            this.lbTenDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenDN.ForeColor = System.Drawing.Color.Coral;
            this.lbTenDN.Location = new System.Drawing.Point(21, 322);
            this.lbTenDN.Name = "lbTenDN";
            this.lbTenDN.Size = new System.Drawing.Size(70, 16);
            this.lbTenDN.TabIndex = 4;
            this.lbTenDN.Text = "lbTenDN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bạn đang đăng nhập dưới tên";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Salmon;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Blue;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(15, 358);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(129, 50);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "ĐĂNG XUẤT";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "ĐƠN ĐẶT HÀNG";
            // 
            // lvddh
            // 
            this.lvddh.HideSelection = false;
            this.lvddh.Location = new System.Drawing.Point(231, 107);
            this.lvddh.Name = "lvddh";
            this.lvddh.Size = new System.Drawing.Size(121, 97);
            this.lvddh.TabIndex = 8;
            this.lvddh.UseCompatibleStateImageBehavior = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(810, 420);
            this.Controls.Add(this.lvddh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTenDN);
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
        private System.Windows.Forms.ToolStripMenuItem hdb_Create;
        private System.Windows.Forms.ToolStripMenuItem mnuDM_NCU;
        private System.Windows.Forms.Label lbTenDN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.ToolStripMenuItem hdb_View;
        private System.Windows.Forms.ToolStripMenuItem đơnĐặtHàngToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvddh;
    }
}

