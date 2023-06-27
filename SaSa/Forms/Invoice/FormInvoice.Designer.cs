
namespace SaSa.Forms.Invoice
{
    partial class FormInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInvoice));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ptClose = new System.Windows.Forms.PictureBox();
            this.groupBoxChung = new System.Windows.Forms.GroupBox();
            this.dtpNgayban = new System.Windows.Forms.DateTimePicker();
            this.cboManv = new System.Windows.Forms.ComboBox();
            this.cboMakh = new System.Windows.Forms.ComboBox();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txtTenkh = new System.Windows.Forms.TextBox();
            this.txtTennv = new System.Windows.Forms.TextBox();
            this.txtMahdb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxSP = new System.Windows.Forms.GroupBox();
            this.ptADD = new System.Windows.Forms.PictureBox();
            this.txtdathu = new System.Windows.Forms.TextBox();
            this.txtchuathu = new System.Windows.Forms.TextBox();
            this.txtTongtien = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.drvHDB = new System.Windows.Forms.DataGridView();
            this.sTTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mASPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOLUONGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dONGIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tHANHTIENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtsHDB = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.txtThanhtien = new System.Windows.Forms.TextBox();
            this.txtDongia = new System.Windows.Forms.TextBox();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.txtTensp = new System.Windows.Forms.TextBox();
            this.cboMasp = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.lbTongtien = new System.Windows.Forms.Label();
            this.rJ_Button5 = new SaSa.RJ_Controls.RJ_Button();
            this.rJ_Button4 = new SaSa.RJ_Controls.RJ_Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptClose)).BeginInit();
            this.groupBoxChung.SuspendLayout();
            this.groupBoxSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptADD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drvHDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsHDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.ptClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 40);
            this.panel1.TabIndex = 2;
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
            this.ptClose.Click += new System.EventHandler(this.ptClose_Click_1);
            // 
            // groupBoxChung
            // 
            this.groupBoxChung.Controls.Add(this.dtpNgayban);
            this.groupBoxChung.Controls.Add(this.cboManv);
            this.groupBoxChung.Controls.Add(this.cboMakh);
            this.groupBoxChung.Controls.Add(this.txtsdt);
            this.groupBoxChung.Controls.Add(this.txtdiachi);
            this.groupBoxChung.Controls.Add(this.txtTenkh);
            this.groupBoxChung.Controls.Add(this.txtTennv);
            this.groupBoxChung.Controls.Add(this.txtMahdb);
            this.groupBoxChung.Controls.Add(this.label8);
            this.groupBoxChung.Controls.Add(this.label7);
            this.groupBoxChung.Controls.Add(this.label6);
            this.groupBoxChung.Controls.Add(this.label5);
            this.groupBoxChung.Controls.Add(this.label4);
            this.groupBoxChung.Controls.Add(this.label3);
            this.groupBoxChung.Controls.Add(this.label2);
            this.groupBoxChung.Controls.Add(this.label1);
            this.groupBoxChung.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxChung.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBoxChung.Location = new System.Drawing.Point(12, 46);
            this.groupBoxChung.Name = "groupBoxChung";
            this.groupBoxChung.Size = new System.Drawing.Size(776, 155);
            this.groupBoxChung.TabIndex = 3;
            this.groupBoxChung.TabStop = false;
            this.groupBoxChung.Text = "Thông tin chung";
            // 
            // dtpNgayban
            // 
            this.dtpNgayban.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayban.Location = new System.Drawing.Point(132, 51);
            this.dtpNgayban.Name = "dtpNgayban";
            this.dtpNgayban.Size = new System.Drawing.Size(176, 22);
            this.dtpNgayban.TabIndex = 4;
            // 
            // cboManv
            // 
            this.cboManv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboManv.FormattingEnabled = true;
            this.cboManv.Location = new System.Drawing.Point(132, 80);
            this.cboManv.Name = "cboManv";
            this.cboManv.Size = new System.Drawing.Size(176, 24);
            this.cboManv.TabIndex = 2;
            this.cboManv.TextChanged += new System.EventHandler(this.cboManv_TextChanged);
            // 
            // cboMakh
            // 
            this.cboMakh.FormattingEnabled = true;
            this.cboMakh.Location = new System.Drawing.Point(563, 20);
            this.cboMakh.Name = "cboMakh";
            this.cboMakh.Size = new System.Drawing.Size(176, 24);
            this.cboMakh.TabIndex = 2;
            this.cboMakh.TextChanged += new System.EventHandler(this.cboMakh_TextChanged);
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(563, 111);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(176, 22);
            this.txtsdt.TabIndex = 1;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(563, 81);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(176, 22);
            this.txtdiachi.TabIndex = 1;
            // 
            // txtTenkh
            // 
            this.txtTenkh.Location = new System.Drawing.Point(563, 51);
            this.txtTenkh.Name = "txtTenkh";
            this.txtTenkh.Size = new System.Drawing.Size(176, 22);
            this.txtTenkh.TabIndex = 1;
            // 
            // txtTennv
            // 
            this.txtTennv.Location = new System.Drawing.Point(132, 111);
            this.txtTennv.Name = "txtTennv";
            this.txtTennv.Size = new System.Drawing.Size(176, 22);
            this.txtTennv.TabIndex = 1;
            // 
            // txtMahdb
            // 
            this.txtMahdb.Location = new System.Drawing.Point(132, 21);
            this.txtMahdb.Name = "txtMahdb";
            this.txtMahdb.Size = new System.Drawing.Size(176, 22);
            this.txtMahdb.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(437, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Điện thoại";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(437, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Địa chỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(437, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tên khách hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(437, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã khách hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(28, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(28, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(28, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày bán";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(28, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hoá đơn";
            // 
            // groupBoxSP
            // 
            this.groupBoxSP.Controls.Add(this.ptADD);
            this.groupBoxSP.Controls.Add(this.txtdathu);
            this.groupBoxSP.Controls.Add(this.txtchuathu);
            this.groupBoxSP.Controls.Add(this.txtTongtien);
            this.groupBoxSP.Controls.Add(this.label17);
            this.groupBoxSP.Controls.Add(this.label16);
            this.groupBoxSP.Controls.Add(this.lbTongtien);
            this.groupBoxSP.Controls.Add(this.label15);
            this.groupBoxSP.Controls.Add(this.label14);
            this.groupBoxSP.Controls.Add(this.drvHDB);
            this.groupBoxSP.Controls.Add(this.txtThanhtien);
            this.groupBoxSP.Controls.Add(this.txtDongia);
            this.groupBoxSP.Controls.Add(this.txtSoluong);
            this.groupBoxSP.Controls.Add(this.txtTensp);
            this.groupBoxSP.Controls.Add(this.cboMasp);
            this.groupBoxSP.Controls.Add(this.label12);
            this.groupBoxSP.Controls.Add(this.label13);
            this.groupBoxSP.Controls.Add(this.label11);
            this.groupBoxSP.Controls.Add(this.label10);
            this.groupBoxSP.Controls.Add(this.label9);
            this.groupBoxSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSP.Location = new System.Drawing.Point(12, 207);
            this.groupBoxSP.Name = "groupBoxSP";
            this.groupBoxSP.Size = new System.Drawing.Size(776, 428);
            this.groupBoxSP.TabIndex = 4;
            this.groupBoxSP.TabStop = false;
            this.groupBoxSP.Text = "Thông tin các mặt hàng";
            // 
            // ptADD
            // 
            this.ptADD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptADD.Image = ((System.Drawing.Image)(resources.GetObject("ptADD.Image")));
            this.ptADD.Location = new System.Drawing.Point(693, 67);
            this.ptADD.Name = "ptADD";
            this.ptADD.Size = new System.Drawing.Size(46, 40);
            this.ptADD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptADD.TabIndex = 6;
            this.ptADD.TabStop = false;
            this.ptADD.Click += new System.EventHandler(this.ptADD_Click);
            // 
            // txtdathu
            // 
            this.txtdathu.Location = new System.Drawing.Point(221, 380);
            this.txtdathu.Name = "txtdathu";
            this.txtdathu.Size = new System.Drawing.Size(72, 22);
            this.txtdathu.TabIndex = 5;
            // 
            // txtchuathu
            // 
            this.txtchuathu.Location = new System.Drawing.Point(318, 380);
            this.txtchuathu.Name = "txtchuathu";
            this.txtchuathu.Size = new System.Drawing.Size(126, 22);
            this.txtchuathu.TabIndex = 5;
            // 
            // txtTongtien
            // 
            this.txtTongtien.Location = new System.Drawing.Point(571, 377);
            this.txtTongtien.Name = "txtTongtien";
            this.txtTongtien.Size = new System.Drawing.Size(126, 22);
            this.txtTongtien.TabIndex = 5;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label17.Location = new System.Drawing.Point(703, 380);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(39, 16);
            this.label17.TabIndex = 4;
            this.label17.Text = "VNĐ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label16.Location = new System.Drawing.Point(473, 380);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 16);
            this.label16.TabIndex = 4;
            this.label16.Text = "Tổng hoá đơn";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label15.Location = new System.Drawing.Point(31, 401);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(110, 16);
            this.label15.TabIndex = 4;
            this.label15.Text = "Số tiền bằng chữ:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(31, 380);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(154, 16);
            this.label14.TabIndex = 4;
            this.label14.Text = "Nháy đúp 1 dòng để xoá";
            // 
            // drvHDB
            // 
            this.drvHDB.AutoGenerateColumns = false;
            this.drvHDB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.drvHDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drvHDB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sTTDataGridViewTextBoxColumn,
            this.mASPDataGridViewTextBoxColumn,
            this.tENSPDataGridViewTextBoxColumn,
            this.sOLUONGDataGridViewTextBoxColumn,
            this.dONGIADataGridViewTextBoxColumn,
            this.tHANHTIENDataGridViewTextBoxColumn});
            this.drvHDB.DataMember = "HDB";
            this.drvHDB.DataSource = this.dtsHDB;
            this.drvHDB.Location = new System.Drawing.Point(31, 114);
            this.drvHDB.Name = "drvHDB";
            this.drvHDB.Size = new System.Drawing.Size(708, 254);
            this.drvHDB.TabIndex = 3;
            this.drvHDB.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.drvHDB_CellDoubleClick);
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
            this.tENSPDataGridViewTextBoxColumn.HeaderText = "TENSP";
            this.tENSPDataGridViewTextBoxColumn.Name = "tENSPDataGridViewTextBoxColumn";
            // 
            // sOLUONGDataGridViewTextBoxColumn
            // 
            this.sOLUONGDataGridViewTextBoxColumn.DataPropertyName = "SOLUONG";
            this.sOLUONGDataGridViewTextBoxColumn.HeaderText = "SOLUONG";
            this.sOLUONGDataGridViewTextBoxColumn.Name = "sOLUONGDataGridViewTextBoxColumn";
            // 
            // dONGIADataGridViewTextBoxColumn
            // 
            this.dONGIADataGridViewTextBoxColumn.DataPropertyName = "DONGIA";
            this.dONGIADataGridViewTextBoxColumn.HeaderText = "DONGIA";
            this.dONGIADataGridViewTextBoxColumn.Name = "dONGIADataGridViewTextBoxColumn";
            // 
            // tHANHTIENDataGridViewTextBoxColumn
            // 
            this.tHANHTIENDataGridViewTextBoxColumn.DataPropertyName = "THANHTIEN";
            this.tHANHTIENDataGridViewTextBoxColumn.HeaderText = "THANHTIEN";
            this.tHANHTIENDataGridViewTextBoxColumn.Name = "tHANHTIENDataGridViewTextBoxColumn";
            // 
            // dtsHDB
            // 
            this.dtsHDB.DataSetName = "NewDataSet";
            this.dtsHDB.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1});
            // 
            // dataTable1
            // 
            this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5,
            this.dataColumn6});
            this.dataTable1.TableName = "HDB";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "STT";
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "MASP";
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "TENSP";
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "SOLUONG";
            this.dataColumn4.DataType = typeof(int);
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
            // txtThanhtien
            // 
            this.txtThanhtien.Location = new System.Drawing.Point(618, 36);
            this.txtThanhtien.Name = "txtThanhtien";
            this.txtThanhtien.Size = new System.Drawing.Size(121, 22);
            this.txtThanhtien.TabIndex = 2;
            // 
            // txtDongia
            // 
            this.txtDongia.Location = new System.Drawing.Point(375, 70);
            this.txtDongia.Name = "txtDongia";
            this.txtDongia.Size = new System.Drawing.Size(121, 22);
            this.txtDongia.TabIndex = 2;
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(375, 36);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(121, 22);
            this.txtSoluong.TabIndex = 2;
            // 
            // txtTensp
            // 
            this.txtTensp.Location = new System.Drawing.Point(132, 70);
            this.txtTensp.Name = "txtTensp";
            this.txtTensp.Size = new System.Drawing.Size(154, 22);
            this.txtTensp.TabIndex = 2;
            // 
            // cboMasp
            // 
            this.cboMasp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMasp.FormattingEnabled = true;
            this.cboMasp.Location = new System.Drawing.Point(132, 35);
            this.cboMasp.Name = "cboMasp";
            this.cboMasp.Size = new System.Drawing.Size(154, 24);
            this.cboMasp.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label12.Location = new System.Drawing.Point(305, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "Số lượng";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label13.Location = new System.Drawing.Point(534, 39);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 16);
            this.label13.TabIndex = 0;
            this.label13.Text = "Thành tiền";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label11.Location = new System.Drawing.Point(305, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Đơn giá";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label10.Location = new System.Drawing.Point(28, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Tên sản phẩm";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label9.Location = new System.Drawing.Point(31, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Mã sản phẩm";
            // 
            // panelFooter
            // 
            this.panelFooter.Controls.Add(this.rJ_Button5);
            this.panelFooter.Controls.Add(this.rJ_Button4);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 650);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(800, 50);
            this.panelFooter.TabIndex = 5;
            // 
            // lbTongtien
            // 
            this.lbTongtien.AutoSize = true;
            this.lbTongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongtien.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbTongtien.Location = new System.Drawing.Point(147, 401);
            this.lbTongtien.Name = "lbTongtien";
            this.lbTongtien.Size = new System.Drawing.Size(18, 16);
            this.lbTongtien.TabIndex = 4;
            this.lbTongtien.Text = "0.";
            // 
            // rJ_Button5
            // 
            this.rJ_Button5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.rJ_Button5.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.rJ_Button5.BorderColor = System.Drawing.Color.Black;
            this.rJ_Button5.BorderRadius = 20;
            this.rJ_Button5.BorderSize = 1;
            this.rJ_Button5.FlatAppearance.BorderSize = 0;
            this.rJ_Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rJ_Button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rJ_Button5.ForeColor = System.Drawing.Color.Black;
            this.rJ_Button5.Image = ((System.Drawing.Image)(resources.GetObject("rJ_Button5.Image")));
            this.rJ_Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rJ_Button5.Location = new System.Drawing.Point(575, 5);
            this.rJ_Button5.Name = "rJ_Button5";
            this.rJ_Button5.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.rJ_Button5.Size = new System.Drawing.Size(176, 40);
            this.rJ_Button5.TabIndex = 0;
            this.rJ_Button5.Text = "In hoá đơn";
            this.rJ_Button5.TextColor = System.Drawing.Color.Black;
            this.rJ_Button5.UseVisualStyleBackColor = false;
            // 
            // rJ_Button4
            // 
            this.rJ_Button4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.rJ_Button4.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.rJ_Button4.BorderColor = System.Drawing.Color.Black;
            this.rJ_Button4.BorderRadius = 20;
            this.rJ_Button4.BorderSize = 1;
            this.rJ_Button4.FlatAppearance.BorderSize = 0;
            this.rJ_Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rJ_Button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rJ_Button4.ForeColor = System.Drawing.Color.Black;
            this.rJ_Button4.Image = ((System.Drawing.Image)(resources.GetObject("rJ_Button4.Image")));
            this.rJ_Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rJ_Button4.Location = new System.Drawing.Point(381, 5);
            this.rJ_Button4.Name = "rJ_Button4";
            this.rJ_Button4.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.rJ_Button4.Size = new System.Drawing.Size(188, 40);
            this.rJ_Button4.TabIndex = 0;
            this.rJ_Button4.Text = "Lưu hoá đơn";
            this.rJ_Button4.TextColor = System.Drawing.Color.Black;
            this.rJ_Button4.UseVisualStyleBackColor = false;
            // 
            // FormInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 700);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.groupBoxSP);
            this.Controls.Add(this.groupBoxChung);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInvoice";
            this.Load += new System.EventHandler(this.FormInvoice_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptClose)).EndInit();
            this.groupBoxChung.ResumeLayout(false);
            this.groupBoxChung.PerformLayout();
            this.groupBoxSP.ResumeLayout(false);
            this.groupBoxSP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptADD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drvHDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsHDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            this.panelFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ptClose;
        private System.Windows.Forms.GroupBox groupBoxChung;
        private System.Windows.Forms.TextBox txtMahdb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTennv;
        private System.Windows.Forms.DateTimePicker dtpNgayban;
        private System.Windows.Forms.ComboBox cboManv;
        private System.Windows.Forms.ComboBox cboMakh;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txtTenkh;
        private System.Windows.Forms.GroupBox groupBoxSP;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView drvHDB;
        private System.Windows.Forms.TextBox txtThanhtien;
        private System.Windows.Forms.TextBox txtDongia;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.TextBox txtTensp;
        private System.Windows.Forms.ComboBox cboMasp;
        private System.Windows.Forms.TextBox txtTongtien;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panelFooter;
        private RJ_Controls.RJ_Button rJ_Button5;
        private RJ_Controls.RJ_Button rJ_Button4;
        private System.Windows.Forms.PictureBox ptADD;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mASPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOLUONGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dONGIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tHANHTIENDataGridViewTextBoxColumn;
        private System.Data.DataSet dtsHDB;
        private System.Data.DataTable dataTable1;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn6;
        private System.Windows.Forms.TextBox txtdathu;
        private System.Windows.Forms.TextBox txtchuathu;
        private System.Windows.Forms.Label lbTongtien;
    }
}