
namespace SaSa.Forms.Customer
{
    partial class FormCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCustomer));
            this.panelTopBar = new System.Windows.Forms.Panel();
            this.ptClose = new System.Windows.Forms.PictureBox();
            this.dtsCustomer = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.panelThongTin = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelCustomer = new System.Windows.Forms.Panel();
            this.drvCustomer = new System.Windows.Forms.DataGridView();
            this.sTTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIACHIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongSLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.btnHuy = new SaSa.RJ_Controls.RJ_Button();
            this.btnLuu = new SaSa.RJ_Controls.RJ_Button();
            this.btnSua = new SaSa.RJ_Controls.RJ_Button();
            this.btnXoa = new SaSa.RJ_Controls.RJ_Button();
            this.btnThem = new SaSa.RJ_Controls.RJ_Button();
            this.txtdc = new SaSa.RJ_Controls.RJ_Textbox();
            this.txtsdt = new SaSa.RJ_Controls.RJ_Textbox();
            this.txttenkh = new SaSa.RJ_Controls.RJ_Textbox();
            this.txtmakh = new SaSa.RJ_Controls.RJ_Textbox();
            this.panelTopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            this.panelThongTin.SuspendLayout();
            this.panelCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drvCustomer)).BeginInit();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTopBar
            // 
            this.panelTopBar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelTopBar.Controls.Add(this.ptClose);
            this.panelTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopBar.Location = new System.Drawing.Point(0, 0);
            this.panelTopBar.Name = "panelTopBar";
            this.panelTopBar.Size = new System.Drawing.Size(800, 40);
            this.panelTopBar.TabIndex = 0;
            // 
            // ptClose
            // 
            this.ptClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptClose.Image = ((System.Drawing.Image)(resources.GetObject("ptClose.Image")));
            this.ptClose.Location = new System.Drawing.Point(760, 0);
            this.ptClose.Name = "ptClose";
            this.ptClose.Size = new System.Drawing.Size(37, 37);
            this.ptClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptClose.TabIndex = 0;
            this.ptClose.TabStop = false;
            this.ptClose.Click += new System.EventHandler(this.ptClose_Click);
            // 
            // dtsCustomer
            // 
            this.dtsCustomer.DataSetName = "NewDataSet";
            this.dtsCustomer.Tables.AddRange(new System.Data.DataTable[] {
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
            this.dataTable1.TableName = "CUSTOMER";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "STT";
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "MAKH";
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "TENKH";
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "SDT";
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "DIACHI";
            // 
            // dataColumn6
            // 
            this.dataColumn6.ColumnName = "TongSL";
            this.dataColumn6.DataType = typeof(int);
            // 
            // panelThongTin
            // 
            this.panelThongTin.Controls.Add(this.txtdc);
            this.panelThongTin.Controls.Add(this.txtsdt);
            this.panelThongTin.Controls.Add(this.txttenkh);
            this.panelThongTin.Controls.Add(this.txtmakh);
            this.panelThongTin.Controls.Add(this.label4);
            this.panelThongTin.Controls.Add(this.label3);
            this.panelThongTin.Controls.Add(this.label2);
            this.panelThongTin.Controls.Add(this.label1);
            this.panelThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelThongTin.Location = new System.Drawing.Point(0, 40);
            this.panelThongTin.Name = "panelThongTin";
            this.panelThongTin.Size = new System.Drawing.Size(800, 92);
            this.panelThongTin.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(317, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Điạ chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(317, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Điện thoại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã khách hàng";
            // 
            // panelCustomer
            // 
            this.panelCustomer.Controls.Add(this.drvCustomer);
            this.panelCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCustomer.Location = new System.Drawing.Point(0, 132);
            this.panelCustomer.Name = "panelCustomer";
            this.panelCustomer.Padding = new System.Windows.Forms.Padding(30);
            this.panelCustomer.Size = new System.Drawing.Size(800, 268);
            this.panelCustomer.TabIndex = 4;
            // 
            // drvCustomer
            // 
            this.drvCustomer.AutoGenerateColumns = false;
            this.drvCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.drvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sTTDataGridViewTextBoxColumn,
            this.mAKHDataGridViewTextBoxColumn,
            this.tENKHDataGridViewTextBoxColumn,
            this.sDTDataGridViewTextBoxColumn,
            this.dIACHIDataGridViewTextBoxColumn,
            this.tongSLDataGridViewTextBoxColumn});
            this.drvCustomer.DataMember = "CUSTOMER";
            this.drvCustomer.DataSource = this.dtsCustomer;
            this.drvCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drvCustomer.Location = new System.Drawing.Point(30, 30);
            this.drvCustomer.Name = "drvCustomer";
            this.drvCustomer.Size = new System.Drawing.Size(740, 208);
            this.drvCustomer.TabIndex = 0;
            this.drvCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.drvCustomer_CellClick);
            this.drvCustomer.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.drvCustomer_CellDoubleClick);
            // 
            // sTTDataGridViewTextBoxColumn
            // 
            this.sTTDataGridViewTextBoxColumn.DataPropertyName = "STT";
            this.sTTDataGridViewTextBoxColumn.HeaderText = "STT";
            this.sTTDataGridViewTextBoxColumn.Name = "sTTDataGridViewTextBoxColumn";
            // 
            // mAKHDataGridViewTextBoxColumn
            // 
            this.mAKHDataGridViewTextBoxColumn.DataPropertyName = "MAKH";
            this.mAKHDataGridViewTextBoxColumn.HeaderText = "MAKH";
            this.mAKHDataGridViewTextBoxColumn.Name = "mAKHDataGridViewTextBoxColumn";
            // 
            // tENKHDataGridViewTextBoxColumn
            // 
            this.tENKHDataGridViewTextBoxColumn.DataPropertyName = "TENKH";
            this.tENKHDataGridViewTextBoxColumn.HeaderText = "TENKH";
            this.tENKHDataGridViewTextBoxColumn.Name = "tENKHDataGridViewTextBoxColumn";
            // 
            // sDTDataGridViewTextBoxColumn
            // 
            this.sDTDataGridViewTextBoxColumn.DataPropertyName = "SDT";
            this.sDTDataGridViewTextBoxColumn.HeaderText = "SDT";
            this.sDTDataGridViewTextBoxColumn.Name = "sDTDataGridViewTextBoxColumn";
            // 
            // dIACHIDataGridViewTextBoxColumn
            // 
            this.dIACHIDataGridViewTextBoxColumn.DataPropertyName = "DIACHI";
            this.dIACHIDataGridViewTextBoxColumn.HeaderText = "DIACHI";
            this.dIACHIDataGridViewTextBoxColumn.Name = "dIACHIDataGridViewTextBoxColumn";
            // 
            // tongSLDataGridViewTextBoxColumn
            // 
            this.tongSLDataGridViewTextBoxColumn.DataPropertyName = "TongSL";
            this.tongSLDataGridViewTextBoxColumn.HeaderText = "TongSL";
            this.tongSLDataGridViewTextBoxColumn.Name = "tongSLDataGridViewTextBoxColumn";
            // 
            // panelFooter
            // 
            this.panelFooter.Controls.Add(this.btnHuy);
            this.panelFooter.Controls.Add(this.btnLuu);
            this.panelFooter.Controls.Add(this.btnSua);
            this.panelFooter.Controls.Add(this.btnXoa);
            this.panelFooter.Controls.Add(this.btnThem);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 400);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(800, 50);
            this.panelFooter.TabIndex = 2;
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
            this.btnHuy.Location = new System.Drawing.Point(686, 3);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnHuy.Size = new System.Drawing.Size(84, 40);
            this.btnHuy.TabIndex = 0;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuy.TextColor = System.Drawing.Color.Black;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
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
            this.btnLuu.Location = new System.Drawing.Point(595, 3);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnLuu.Size = new System.Drawing.Size(85, 40);
            this.btnLuu.TabIndex = 0;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.TextColor = System.Drawing.Color.Black;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSua.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.btnSua.BorderColor = System.Drawing.Color.Black;
            this.btnSua.BorderRadius = 20;
            this.btnSua.BorderSize = 1;
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(220, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnSua.Size = new System.Drawing.Size(85, 40);
            this.btnSua.TabIndex = 0;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.TextColor = System.Drawing.Color.Black;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnXoa.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.btnXoa.BorderColor = System.Drawing.Color.Black;
            this.btnXoa.BorderRadius = 20;
            this.btnXoa.BorderSize = 1;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(133, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnXoa.Size = new System.Drawing.Size(81, 40);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.TextColor = System.Drawing.Color.Black;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnThem.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.btnThem.BorderColor = System.Drawing.Color.Black;
            this.btnThem.BorderRadius = 20;
            this.btnThem.BorderSize = 1;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(33, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnThem.Size = new System.Drawing.Size(93, 40);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.TextColor = System.Drawing.Color.Black;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtdc
            // 
            this.txtdc.BorderColor = System.Drawing.Color.Maroon;
            this.txtdc.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtdc.BorderRadius = 0;
            this.txtdc.BorderSize = 0;
            this.txtdc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdc.ForeColor = System.Drawing.Color.DimGray;
            this.txtdc.Location = new System.Drawing.Point(399, 46);
            this.txtdc.Margin = new System.Windows.Forms.Padding(4);
            this.txtdc.Multiline = false;
            this.txtdc.Name = "txtdc";
            this.txtdc.Padding = new System.Windows.Forms.Padding(7);
            this.txtdc.PasswordChar = false;
            this.txtdc.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtdc.PlaceholderText = "";
            this.txtdc.Size = new System.Drawing.Size(116, 31);
            this.txtdc.TabIndex = 1;
            this.txtdc.Texts = "";
            this.txtdc.UnderlinedStyle = true;
            // 
            // txtsdt
            // 
            this.txtsdt.BorderColor = System.Drawing.Color.Maroon;
            this.txtsdt.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtsdt.BorderRadius = 0;
            this.txtsdt.BorderSize = 0;
            this.txtsdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsdt.ForeColor = System.Drawing.Color.DimGray;
            this.txtsdt.Location = new System.Drawing.Point(399, 7);
            this.txtsdt.Margin = new System.Windows.Forms.Padding(4);
            this.txtsdt.Multiline = false;
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Padding = new System.Windows.Forms.Padding(7);
            this.txtsdt.PasswordChar = false;
            this.txtsdt.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtsdt.PlaceholderText = "";
            this.txtsdt.Size = new System.Drawing.Size(116, 31);
            this.txtsdt.TabIndex = 1;
            this.txtsdt.Texts = "";
            this.txtsdt.UnderlinedStyle = true;
            // 
            // txttenkh
            // 
            this.txttenkh.BorderColor = System.Drawing.Color.Maroon;
            this.txttenkh.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txttenkh.BorderRadius = 0;
            this.txttenkh.BorderSize = 0;
            this.txttenkh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttenkh.ForeColor = System.Drawing.Color.DimGray;
            this.txttenkh.Location = new System.Drawing.Point(133, 46);
            this.txttenkh.Margin = new System.Windows.Forms.Padding(4);
            this.txttenkh.Multiline = false;
            this.txttenkh.Name = "txttenkh";
            this.txttenkh.Padding = new System.Windows.Forms.Padding(7);
            this.txttenkh.PasswordChar = false;
            this.txttenkh.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txttenkh.PlaceholderText = "";
            this.txttenkh.Size = new System.Drawing.Size(116, 31);
            this.txttenkh.TabIndex = 1;
            this.txttenkh.Texts = "";
            this.txttenkh.UnderlinedStyle = true;
            // 
            // txtmakh
            // 
            this.txtmakh.BorderColor = System.Drawing.Color.Maroon;
            this.txtmakh.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtmakh.BorderRadius = 0;
            this.txtmakh.BorderSize = 0;
            this.txtmakh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmakh.ForeColor = System.Drawing.Color.DimGray;
            this.txtmakh.Location = new System.Drawing.Point(133, 7);
            this.txtmakh.Margin = new System.Windows.Forms.Padding(4);
            this.txtmakh.Multiline = false;
            this.txtmakh.Name = "txtmakh";
            this.txtmakh.Padding = new System.Windows.Forms.Padding(7);
            this.txtmakh.PasswordChar = false;
            this.txtmakh.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtmakh.PlaceholderText = "";
            this.txtmakh.Size = new System.Drawing.Size(116, 31);
            this.txtmakh.TabIndex = 1;
            this.txtmakh.Texts = "";
            this.txtmakh.UnderlinedStyle = true;
            // 
            // FormCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelCustomer);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelThongTin);
            this.Controls.Add(this.panelTopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCustomer";
            this.Load += new System.EventHandler(this.FormCustomer_Load);
            this.panelTopBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            this.panelThongTin.ResumeLayout(false);
            this.panelThongTin.PerformLayout();
            this.panelCustomer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.drvCustomer)).EndInit();
            this.panelFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopBar;
        private System.Windows.Forms.PictureBox ptClose;
        private System.Data.DataSet dtsCustomer;
        private System.Data.DataTable dataTable1;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn6;
        private System.Windows.Forms.Panel panelThongTin;
        private RJ_Controls.RJ_Textbox txtdc;
        private RJ_Controls.RJ_Textbox txtsdt;
        private RJ_Controls.RJ_Textbox txttenkh;
        private RJ_Controls.RJ_Textbox txtmakh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelCustomer;
        private System.Windows.Forms.DataGridView drvCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIACHIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongSLDataGridViewTextBoxColumn;
        private RJ_Controls.RJ_Button btnLuu;
        private RJ_Controls.RJ_Button btnHuy;
        private System.Windows.Forms.Panel panelFooter;
        private RJ_Controls.RJ_Button btnSua;
        private RJ_Controls.RJ_Button btnXoa;
        private RJ_Controls.RJ_Button btnThem;
    }
}