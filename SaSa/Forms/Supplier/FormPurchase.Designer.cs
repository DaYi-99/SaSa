
namespace SaSa.Forms.Supplier
{
    partial class FormPurchase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPurchase));
            this.panelTitle = new System.Windows.Forms.Panel();
            this.ptMin = new System.Windows.Forms.PictureBox();
            this.label18 = new System.Windows.Forms.Label();
            this.ptClose = new System.Windows.Forms.PictureBox();
            this.dtsPurchase = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.panelThongTin = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMasp = new SaSa.RJ_Controls.RJ_Textbox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnThem = new SaSa.RJ_Controls.RJ_Button();
            this.cboSP = new System.Windows.Forms.ComboBox();
            this.cboLH = new System.Windows.Forms.ComboBox();
            this.txtThanhtien = new SaSa.RJ_Controls.RJ_Textbox();
            this.txtSoluong = new SaSa.RJ_Controls.RJ_Textbox();
            this.txtDongia = new SaSa.RJ_Controls.RJ_Textbox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboTenncu = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMancu = new SaSa.RJ_Controls.RJ_Textbox();
            this.txtMahdm = new SaSa.RJ_Controls.RJ_Textbox();
            this.txtChuatt = new SaSa.RJ_Controls.RJ_Textbox();
            this.txtDatt = new SaSa.RJ_Controls.RJ_Textbox();
            this.txtTongtien = new SaSa.RJ_Controls.RJ_Textbox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.btnHuy = new SaSa.RJ_Controls.RJ_Button();
            this.btnLuu = new SaSa.RJ_Controls.RJ_Button();
            this.btnInHD = new SaSa.RJ_Controls.RJ_Button();
            this.btnHuyHD = new SaSa.RJ_Controls.RJ_Button();
            this.panelPurchase = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.drvPurchase = new System.Windows.Forms.DataGridView();
            this.sTTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mASPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dONGIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tHANHTIENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsPurchase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            this.panelThongTin.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.panelPurchase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drvPurchase)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelTitle.Controls.Add(this.ptMin);
            this.panelTitle.Controls.Add(this.label18);
            this.panelTitle.Controls.Add(this.ptClose);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(800, 40);
            this.panelTitle.TabIndex = 0;
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            this.panelTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseMove);
            this.panelTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseUp);
            // 
            // ptMin
            // 
            this.ptMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptMin.Image = ((System.Drawing.Image)(resources.GetObject("ptMin.Image")));
            this.ptMin.Location = new System.Drawing.Point(721, 4);
            this.ptMin.Name = "ptMin";
            this.ptMin.Size = new System.Drawing.Size(35, 33);
            this.ptMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptMin.TabIndex = 4;
            this.ptMin.TabStop = false;
            this.ptMin.Click += new System.EventHandler(this.ptMin_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Yellow;
            this.label18.Location = new System.Drawing.Point(345, 12);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(113, 16);
            this.label18.TabIndex = 3;
            this.label18.Text = "HOÁ ĐƠN MUA";
            // 
            // ptClose
            // 
            this.ptClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptClose.Image = ((System.Drawing.Image)(resources.GetObject("ptClose.Image")));
            this.ptClose.Location = new System.Drawing.Point(762, 3);
            this.ptClose.Name = "ptClose";
            this.ptClose.Size = new System.Drawing.Size(35, 33);
            this.ptClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptClose.TabIndex = 1;
            this.ptClose.TabStop = false;
            this.ptClose.Click += new System.EventHandler(this.ptClose_Click);
            // 
            // dtsPurchase
            // 
            this.dtsPurchase.DataSetName = "NewDataSet";
            this.dtsPurchase.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1});
            // 
            // dataTable1
            // 
            this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn4,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn5,
            this.dataColumn6});
            this.dataTable1.TableName = "PURCHASE";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "STT";
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "MASP";
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "TENSP";
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "SL";
            this.dataColumn3.DataType = typeof(int);
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "DONGIA";
            this.dataColumn5.DataType = typeof(decimal);
            // 
            // dataColumn6
            // 
            this.dataColumn6.ColumnName = "THANHTIEN";
            this.dataColumn6.DataType = typeof(decimal);
            // 
            // panelThongTin
            // 
            this.panelThongTin.Controls.Add(this.groupBox2);
            this.panelThongTin.Controls.Add(this.groupBox1);
            this.panelThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelThongTin.Location = new System.Drawing.Point(0, 40);
            this.panelThongTin.Name = "panelThongTin";
            this.panelThongTin.Size = new System.Drawing.Size(800, 223);
            this.panelThongTin.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMasp);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.cboSP);
            this.groupBox2.Controls.Add(this.cboLH);
            this.groupBox2.Controls.Add(this.txtThanhtien);
            this.groupBox2.Controls.Add(this.txtSoluong);
            this.groupBox2.Controls.Add(this.txtDongia);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBox2.Location = new System.Drawing.Point(12, 123);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 90);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin sản phẩm";
            // 
            // txtMasp
            // 
            this.txtMasp.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtMasp.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtMasp.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMasp.BorderRadius = 0;
            this.txtMasp.BorderSize = 2;
            this.txtMasp.Enabled = false;
            this.txtMasp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMasp.ForeColor = System.Drawing.Color.DimGray;
            this.txtMasp.Location = new System.Drawing.Point(340, 24);
            this.txtMasp.Margin = new System.Windows.Forms.Padding(2);
            this.txtMasp.Multiline = false;
            this.txtMasp.Name = "txtMasp";
            this.txtMasp.Padding = new System.Windows.Forms.Padding(2);
            this.txtMasp.PasswordChar = false;
            this.txtMasp.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMasp.PlaceholderText = "";
            this.txtMasp.Size = new System.Drawing.Size(100, 21);
            this.txtMasp.TabIndex = 18;
            this.txtMasp.Texts = "";
            this.txtMasp.UnderlinedStyle = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(278, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "Mã SP";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Gold;
            this.btnThem.BackgroundColor = System.Drawing.Color.Gold;
            this.btnThem.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnThem.BorderRadius = 20;
            this.btnThem.BorderSize = 0;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Blue;
            this.btnThem.Location = new System.Drawing.Point(686, 19);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(72, 60);
            this.btnThem.TabIndex = 16;
            this.btnThem.Text = "THÊM";
            this.btnThem.TextColor = System.Drawing.Color.Blue;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cboSP
            // 
            this.cboSP.FormattingEnabled = true;
            this.cboSP.Location = new System.Drawing.Point(102, 54);
            this.cboSP.Name = "cboSP";
            this.cboSP.Size = new System.Drawing.Size(151, 21);
            this.cboSP.TabIndex = 15;
            this.cboSP.TextChanged += new System.EventHandler(this.cboSP_TextChanged);
            // 
            // cboLH
            // 
            this.cboLH.FormattingEnabled = true;
            this.cboLH.Location = new System.Drawing.Point(102, 25);
            this.cboLH.Name = "cboLH";
            this.cboLH.Size = new System.Drawing.Size(151, 21);
            this.cboLH.TabIndex = 15;
            // 
            // txtThanhtien
            // 
            this.txtThanhtien.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtThanhtien.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtThanhtien.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtThanhtien.BorderRadius = 0;
            this.txtThanhtien.BorderSize = 2;
            this.txtThanhtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThanhtien.ForeColor = System.Drawing.Color.DimGray;
            this.txtThanhtien.Location = new System.Drawing.Point(543, 53);
            this.txtThanhtien.Margin = new System.Windows.Forms.Padding(2);
            this.txtThanhtien.Multiline = false;
            this.txtThanhtien.Name = "txtThanhtien";
            this.txtThanhtien.Padding = new System.Windows.Forms.Padding(2);
            this.txtThanhtien.PasswordChar = false;
            this.txtThanhtien.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtThanhtien.PlaceholderText = "";
            this.txtThanhtien.Size = new System.Drawing.Size(100, 21);
            this.txtThanhtien.TabIndex = 14;
            this.txtThanhtien.Texts = "";
            this.txtThanhtien.UnderlinedStyle = true;
            // 
            // txtSoluong
            // 
            this.txtSoluong.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtSoluong.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtSoluong.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSoluong.BorderRadius = 0;
            this.txtSoluong.BorderSize = 2;
            this.txtSoluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoluong.ForeColor = System.Drawing.Color.DimGray;
            this.txtSoluong.Location = new System.Drawing.Point(340, 53);
            this.txtSoluong.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoluong.Multiline = false;
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Padding = new System.Windows.Forms.Padding(2);
            this.txtSoluong.PasswordChar = false;
            this.txtSoluong.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSoluong.PlaceholderText = "";
            this.txtSoluong.Size = new System.Drawing.Size(100, 21);
            this.txtSoluong.TabIndex = 14;
            this.txtSoluong.Texts = "";
            this.txtSoluong.UnderlinedStyle = true;
            this.txtSoluong.MouseLeave += new System.EventHandler(this.txtSoluong_MouseLeave);
            // 
            // txtDongia
            // 
            this.txtDongia.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtDongia.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtDongia.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtDongia.BorderRadius = 0;
            this.txtDongia.BorderSize = 2;
            this.txtDongia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDongia.ForeColor = System.Drawing.Color.DimGray;
            this.txtDongia.Location = new System.Drawing.Point(543, 25);
            this.txtDongia.Margin = new System.Windows.Forms.Padding(2);
            this.txtDongia.Multiline = false;
            this.txtDongia.Name = "txtDongia";
            this.txtDongia.Padding = new System.Windows.Forms.Padding(2);
            this.txtDongia.PasswordChar = false;
            this.txtDongia.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDongia.PlaceholderText = "";
            this.txtDongia.Size = new System.Drawing.Size(100, 21);
            this.txtDongia.TabIndex = 14;
            this.txtDongia.Texts = "";
            this.txtDongia.UnderlinedStyle = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(457, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Thành Tiền";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(457, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Đơn giá";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(278, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Số lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Loại hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Sản phẩm";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboTenncu);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtMancu);
            this.groupBox1.Controls.Add(this.txtMahdm);
            this.groupBox1.Controls.Add(this.txtChuatt);
            this.groupBox1.Controls.Add(this.txtDatt);
            this.groupBox1.Controls.Add(this.txtTongtien);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 111);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // cboTenncu
            // 
            this.cboTenncu.FormattingEnabled = true;
            this.cboTenncu.Location = new System.Drawing.Point(102, 75);
            this.cboTenncu.Name = "cboTenncu";
            this.cboTenncu.Size = new System.Drawing.Size(151, 21);
            this.cboTenncu.TabIndex = 15;
            this.cboTenncu.SelectedIndexChanged += new System.EventHandler(this.cboTenncu_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label9.Location = new System.Drawing.Point(341, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Còn lại";
            // 
            // txtMancu
            // 
            this.txtMancu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtMancu.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtMancu.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMancu.BorderRadius = 0;
            this.txtMancu.BorderSize = 2;
            this.txtMancu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMancu.ForeColor = System.Drawing.Color.DimGray;
            this.txtMancu.Location = new System.Drawing.Point(102, 49);
            this.txtMancu.Margin = new System.Windows.Forms.Padding(2);
            this.txtMancu.Multiline = false;
            this.txtMancu.Name = "txtMancu";
            this.txtMancu.Padding = new System.Windows.Forms.Padding(2);
            this.txtMancu.PasswordChar = false;
            this.txtMancu.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMancu.PlaceholderText = "";
            this.txtMancu.Size = new System.Drawing.Size(100, 21);
            this.txtMancu.TabIndex = 9;
            this.txtMancu.Texts = "";
            this.txtMancu.UnderlinedStyle = true;
            // 
            // txtMahdm
            // 
            this.txtMahdm.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtMahdm.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtMahdm.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMahdm.BorderRadius = 0;
            this.txtMahdm.BorderSize = 2;
            this.txtMahdm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMahdm.ForeColor = System.Drawing.Color.DimGray;
            this.txtMahdm.Location = new System.Drawing.Point(102, 21);
            this.txtMahdm.Margin = new System.Windows.Forms.Padding(2);
            this.txtMahdm.Multiline = false;
            this.txtMahdm.Name = "txtMahdm";
            this.txtMahdm.Padding = new System.Windows.Forms.Padding(2);
            this.txtMahdm.PasswordChar = false;
            this.txtMahdm.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMahdm.PlaceholderText = "";
            this.txtMahdm.Size = new System.Drawing.Size(100, 21);
            this.txtMahdm.TabIndex = 9;
            this.txtMahdm.Texts = "";
            this.txtMahdm.UnderlinedStyle = true;
            // 
            // txtChuatt
            // 
            this.txtChuatt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtChuatt.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtChuatt.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtChuatt.BorderRadius = 0;
            this.txtChuatt.BorderSize = 2;
            this.txtChuatt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChuatt.ForeColor = System.Drawing.Color.DimGray;
            this.txtChuatt.Location = new System.Drawing.Point(429, 75);
            this.txtChuatt.Margin = new System.Windows.Forms.Padding(2);
            this.txtChuatt.Multiline = false;
            this.txtChuatt.Name = "txtChuatt";
            this.txtChuatt.Padding = new System.Windows.Forms.Padding(2);
            this.txtChuatt.PasswordChar = false;
            this.txtChuatt.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtChuatt.PlaceholderText = "";
            this.txtChuatt.Size = new System.Drawing.Size(100, 21);
            this.txtChuatt.TabIndex = 9;
            this.txtChuatt.Texts = "0";
            this.txtChuatt.UnderlinedStyle = true;
            // 
            // txtDatt
            // 
            this.txtDatt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtDatt.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtDatt.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtDatt.BorderRadius = 0;
            this.txtDatt.BorderSize = 2;
            this.txtDatt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatt.ForeColor = System.Drawing.Color.DimGray;
            this.txtDatt.Location = new System.Drawing.Point(429, 49);
            this.txtDatt.Margin = new System.Windows.Forms.Padding(2);
            this.txtDatt.Multiline = false;
            this.txtDatt.Name = "txtDatt";
            this.txtDatt.Padding = new System.Windows.Forms.Padding(2);
            this.txtDatt.PasswordChar = false;
            this.txtDatt.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDatt.PlaceholderText = "";
            this.txtDatt.Size = new System.Drawing.Size(100, 21);
            this.txtDatt.TabIndex = 9;
            this.txtDatt.Texts = "0";
            this.txtDatt.UnderlinedStyle = true;
            // 
            // txtTongtien
            // 
            this.txtTongtien.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtTongtien.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtTongtien.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTongtien.BorderRadius = 0;
            this.txtTongtien.BorderSize = 2;
            this.txtTongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongtien.ForeColor = System.Drawing.Color.DimGray;
            this.txtTongtien.Location = new System.Drawing.Point(429, 21);
            this.txtTongtien.Margin = new System.Windows.Forms.Padding(2);
            this.txtTongtien.Multiline = false;
            this.txtTongtien.Name = "txtTongtien";
            this.txtTongtien.Padding = new System.Windows.Forms.Padding(2);
            this.txtTongtien.PasswordChar = false;
            this.txtTongtien.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTongtien.PlaceholderText = "";
            this.txtTongtien.Size = new System.Drawing.Size(100, 21);
            this.txtTongtien.TabIndex = 9;
            this.txtTongtien.Texts = "0";
            this.txtTongtien.UnderlinedStyle = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label10.Location = new System.Drawing.Point(341, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Thanh toán";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label11.Location = new System.Drawing.Point(341, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Tồng tiền";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(22, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tên NCU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(22, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mã NCU";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mã HĐM";
            // 
            // panelFooter
            // 
            this.panelFooter.Controls.Add(this.btnHuy);
            this.panelFooter.Controls.Add(this.btnLuu);
            this.panelFooter.Controls.Add(this.btnInHD);
            this.panelFooter.Controls.Add(this.btnHuyHD);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 495);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(800, 55);
            this.panelFooter.TabIndex = 3;
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnHuy.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.btnHuy.BorderColor = System.Drawing.Color.Black;
            this.btnHuy.BorderRadius = 20;
            this.btnHuy.BorderSize = 1;
            this.btnHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.Black;
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(114, 6);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnHuy.Size = new System.Drawing.Size(77, 40);
            this.btnHuy.TabIndex = 11;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuy.TextColor = System.Drawing.Color.Black;
            this.btnHuy.UseVisualStyleBackColor = false;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnLuu.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.btnLuu.BorderColor = System.Drawing.Color.Black;
            this.btnLuu.BorderRadius = 20;
            this.btnLuu.BorderSize = 1;
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.Black;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(30, 6);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnLuu.Size = new System.Drawing.Size(77, 40);
            this.btnLuu.TabIndex = 12;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.TextColor = System.Drawing.Color.Black;
            this.btnLuu.UseVisualStyleBackColor = false;
            // 
            // btnInHD
            // 
            this.btnInHD.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnInHD.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.btnInHD.BorderColor = System.Drawing.Color.Black;
            this.btnInHD.BorderRadius = 20;
            this.btnInHD.BorderSize = 1;
            this.btnInHD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInHD.FlatAppearance.BorderSize = 0;
            this.btnInHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInHD.ForeColor = System.Drawing.Color.Black;
            this.btnInHD.Image = ((System.Drawing.Image)(resources.GetObject("btnInHD.Image")));
            this.btnInHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInHD.Location = new System.Drawing.Point(594, 6);
            this.btnInHD.Name = "btnInHD";
            this.btnInHD.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnInHD.Size = new System.Drawing.Size(176, 40);
            this.btnInHD.TabIndex = 1;
            this.btnInHD.Text = "In hoá đơn";
            this.btnInHD.TextColor = System.Drawing.Color.Black;
            this.btnInHD.UseVisualStyleBackColor = false;
            // 
            // btnHuyHD
            // 
            this.btnHuyHD.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnHuyHD.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.btnHuyHD.BorderColor = System.Drawing.Color.Black;
            this.btnHuyHD.BorderRadius = 20;
            this.btnHuyHD.BorderSize = 1;
            this.btnHuyHD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuyHD.FlatAppearance.BorderSize = 0;
            this.btnHuyHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyHD.ForeColor = System.Drawing.Color.Black;
            this.btnHuyHD.Image = ((System.Drawing.Image)(resources.GetObject("btnHuyHD.Image")));
            this.btnHuyHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuyHD.Location = new System.Drawing.Point(400, 6);
            this.btnHuyHD.Name = "btnHuyHD";
            this.btnHuyHD.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnHuyHD.Size = new System.Drawing.Size(188, 40);
            this.btnHuyHD.TabIndex = 2;
            this.btnHuyHD.Text = "Huỷ hoá đơn";
            this.btnHuyHD.TextColor = System.Drawing.Color.Black;
            this.btnHuyHD.UseVisualStyleBackColor = false;
            this.btnHuyHD.Click += new System.EventHandler(this.btnHuyHD_Click);
            // 
            // panelPurchase
            // 
            this.panelPurchase.Controls.Add(this.label12);
            this.panelPurchase.Controls.Add(this.drvPurchase);
            this.panelPurchase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPurchase.Location = new System.Drawing.Point(0, 263);
            this.panelPurchase.Name = "panelPurchase";
            this.panelPurchase.Padding = new System.Windows.Forms.Padding(30);
            this.panelPurchase.Size = new System.Drawing.Size(800, 232);
            this.panelPurchase.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(32, 210);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(196, 15);
            this.label12.TabIndex = 1;
            this.label12.Text = "* Nháy đúp dòng để xoá sản phẩm";
            // 
            // drvPurchase
            // 
            this.drvPurchase.AutoGenerateColumns = false;
            this.drvPurchase.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.drvPurchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drvPurchase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sTTDataGridViewTextBoxColumn,
            this.mASPDataGridViewTextBoxColumn,
            this.tENSPDataGridViewTextBoxColumn,
            this.sLDataGridViewTextBoxColumn,
            this.dONGIADataGridViewTextBoxColumn,
            this.tHANHTIENDataGridViewTextBoxColumn});
            this.drvPurchase.DataMember = "PURCHASE";
            this.drvPurchase.DataSource = this.dtsPurchase;
            this.drvPurchase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drvPurchase.Location = new System.Drawing.Point(30, 30);
            this.drvPurchase.Name = "drvPurchase";
            this.drvPurchase.Size = new System.Drawing.Size(740, 172);
            this.drvPurchase.TabIndex = 0;
            this.drvPurchase.DoubleClick += new System.EventHandler(this.drvPurchase_DoubleClick);
            // 
            // sTTDataGridViewTextBoxColumn
            // 
            this.sTTDataGridViewTextBoxColumn.DataPropertyName = "STT";
            this.sTTDataGridViewTextBoxColumn.HeaderText = "STT";
            this.sTTDataGridViewTextBoxColumn.Name = "sTTDataGridViewTextBoxColumn";
            // 
            // mASPDataGridViewTextBoxColumn
            // 
            this.mASPDataGridViewTextBoxColumn.DataPropertyName = "MASP";
            this.mASPDataGridViewTextBoxColumn.HeaderText = "MASP";
            this.mASPDataGridViewTextBoxColumn.Name = "mASPDataGridViewTextBoxColumn";
            // 
            // tENSPDataGridViewTextBoxColumn
            // 
            this.tENSPDataGridViewTextBoxColumn.DataPropertyName = "TENSP";
            this.tENSPDataGridViewTextBoxColumn.HeaderText = "Tên sản phẩm";
            this.tENSPDataGridViewTextBoxColumn.Name = "tENSPDataGridViewTextBoxColumn";
            // 
            // sLDataGridViewTextBoxColumn
            // 
            this.sLDataGridViewTextBoxColumn.DataPropertyName = "SL";
            this.sLDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            this.sLDataGridViewTextBoxColumn.Name = "sLDataGridViewTextBoxColumn";
            // 
            // dONGIADataGridViewTextBoxColumn
            // 
            this.dONGIADataGridViewTextBoxColumn.DataPropertyName = "DONGIA";
            this.dONGIADataGridViewTextBoxColumn.HeaderText = "Đơn giá";
            this.dONGIADataGridViewTextBoxColumn.Name = "dONGIADataGridViewTextBoxColumn";
            // 
            // tHANHTIENDataGridViewTextBoxColumn
            // 
            this.tHANHTIENDataGridViewTextBoxColumn.DataPropertyName = "THANHTIEN";
            this.tHANHTIENDataGridViewTextBoxColumn.HeaderText = "Thành tiền";
            this.tHANHTIENDataGridViewTextBoxColumn.Name = "tHANHTIENDataGridViewTextBoxColumn";
            // 
            // FormPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.panelPurchase);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelThongTin);
            this.Controls.Add(this.panelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPurchase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPurchase";
            this.Load += new System.EventHandler(this.FormPurchase_Load);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsPurchase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            this.panelThongTin.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelFooter.ResumeLayout(false);
            this.panelPurchase.ResumeLayout(false);
            this.panelPurchase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drvPurchase)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.PictureBox ptClose;
        private System.Data.DataSet dtsPurchase;
        private System.Data.DataTable dataTable1;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn4;
        private System.Windows.Forms.Panel panelThongTin;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Panel panelPurchase;
        private System.Windows.Forms.DataGridView drvPurchase;
        private RJ_Controls.RJ_Button btnInHD;
        private RJ_Controls.RJ_Button btnHuyHD;
        private RJ_Controls.RJ_Button btnHuy;
        private RJ_Controls.RJ_Button btnLuu;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn5;
        private RJ_Controls.RJ_Textbox txtTongtien;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private RJ_Controls.RJ_Textbox txtThanhtien;
        private RJ_Controls.RJ_Textbox txtDongia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private RJ_Controls.RJ_Textbox txtMancu;
        private RJ_Controls.RJ_Textbox txtMahdm;
        private RJ_Controls.RJ_Textbox txtChuatt;
        private RJ_Controls.RJ_Textbox txtDatt;
        private System.Windows.Forms.ComboBox cboLH;
        private RJ_Controls.RJ_Textbox txtSoluong;
        private System.Windows.Forms.Label label12;
        private RJ_Controls.RJ_Button btnThem;
        private System.Windows.Forms.ComboBox cboTenncu;
        private RJ_Controls.RJ_Textbox txtMasp;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cboSP;
        private System.Data.DataColumn dataColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mASPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dONGIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tHANHTIENDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox ptMin;
    }
}