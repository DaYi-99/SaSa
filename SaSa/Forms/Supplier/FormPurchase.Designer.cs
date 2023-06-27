
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ptClose = new System.Windows.Forms.PictureBox();
            this.dtsPurchase = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.dataColumn7 = new System.Data.DataColumn();
            this.dataColumn8 = new System.Data.DataColumn();
            this.panelThongTin = new System.Windows.Forms.Panel();
            this.panelPurchase = new System.Windows.Forms.Panel();
            this.drvPurchase = new System.Windows.Forms.DataGridView();
            this.sTTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENNCUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENSALEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lOAISPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tONGSLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tONGBILLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHUATTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rJ_Textbox1 = new SaSa.RJ_Controls.RJ_Textbox();
            this.rJ_Textbox2 = new SaSa.RJ_Controls.RJ_Textbox();
            this.rJ_Textbox3 = new SaSa.RJ_Controls.RJ_Textbox();
            this.rJ_Textbox4 = new SaSa.RJ_Controls.RJ_Textbox();
            this.rJ_Textbox5 = new SaSa.RJ_Controls.RJ_Textbox();
            this.rJ_Textbox6 = new SaSa.RJ_Controls.RJ_Textbox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsPurchase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            this.panelThongTin.SuspendLayout();
            this.panelPurchase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drvPurchase)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ptClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 40);
            this.panel1.TabIndex = 0;
            // 
            // ptClose
            // 
            this.ptClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5,
            this.dataColumn6,
            this.dataColumn7,
            this.dataColumn8});
            this.dataTable1.TableName = "PURCHASE";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "STT";
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "TENNCU";
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "TENSALE";
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "TENSP";
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "LOAISP";
            // 
            // dataColumn6
            // 
            this.dataColumn6.ColumnName = "TONGSL";
            // 
            // dataColumn7
            // 
            this.dataColumn7.ColumnName = "TONGBILL";
            this.dataColumn7.DataType = typeof(double);
            // 
            // dataColumn8
            // 
            this.dataColumn8.ColumnName = "CHUATT";
            this.dataColumn8.DataType = typeof(double);
            // 
            // panelThongTin
            // 
            this.panelThongTin.Controls.Add(this.comboBox1);
            this.panelThongTin.Controls.Add(this.rJ_Textbox6);
            this.panelThongTin.Controls.Add(this.rJ_Textbox5);
            this.panelThongTin.Controls.Add(this.rJ_Textbox4);
            this.panelThongTin.Controls.Add(this.rJ_Textbox3);
            this.panelThongTin.Controls.Add(this.rJ_Textbox2);
            this.panelThongTin.Controls.Add(this.rJ_Textbox1);
            this.panelThongTin.Controls.Add(this.label7);
            this.panelThongTin.Controls.Add(this.label6);
            this.panelThongTin.Controls.Add(this.label5);
            this.panelThongTin.Controls.Add(this.label4);
            this.panelThongTin.Controls.Add(this.label3);
            this.panelThongTin.Controls.Add(this.label2);
            this.panelThongTin.Controls.Add(this.label1);
            this.panelThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelThongTin.Location = new System.Drawing.Point(0, 40);
            this.panelThongTin.Name = "panelThongTin";
            this.panelThongTin.Size = new System.Drawing.Size(800, 171);
            this.panelThongTin.TabIndex = 2;
            // 
            // panelPurchase
            // 
            this.panelPurchase.Controls.Add(this.drvPurchase);
            this.panelPurchase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPurchase.Location = new System.Drawing.Point(0, 211);
            this.panelPurchase.Name = "panelPurchase";
            this.panelPurchase.Padding = new System.Windows.Forms.Padding(30);
            this.panelPurchase.Size = new System.Drawing.Size(800, 239);
            this.panelPurchase.TabIndex = 3;
            // 
            // drvPurchase
            // 
            this.drvPurchase.AutoGenerateColumns = false;
            this.drvPurchase.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.drvPurchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drvPurchase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sTTDataGridViewTextBoxColumn,
            this.tENNCUDataGridViewTextBoxColumn,
            this.tENSALEDataGridViewTextBoxColumn,
            this.tENSPDataGridViewTextBoxColumn,
            this.lOAISPDataGridViewTextBoxColumn,
            this.tONGSLDataGridViewTextBoxColumn,
            this.tONGBILLDataGridViewTextBoxColumn,
            this.cHUATTDataGridViewTextBoxColumn});
            this.drvPurchase.DataMember = "PURCHASE";
            this.drvPurchase.DataSource = this.dtsPurchase;
            this.drvPurchase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drvPurchase.Location = new System.Drawing.Point(30, 30);
            this.drvPurchase.Name = "drvPurchase";
            this.drvPurchase.Size = new System.Drawing.Size(740, 179);
            this.drvPurchase.TabIndex = 0;
            // 
            // sTTDataGridViewTextBoxColumn
            // 
            this.sTTDataGridViewTextBoxColumn.DataPropertyName = "STT";
            this.sTTDataGridViewTextBoxColumn.HeaderText = "STT";
            this.sTTDataGridViewTextBoxColumn.Name = "sTTDataGridViewTextBoxColumn";
            // 
            // tENNCUDataGridViewTextBoxColumn
            // 
            this.tENNCUDataGridViewTextBoxColumn.DataPropertyName = "TENNCU";
            this.tENNCUDataGridViewTextBoxColumn.HeaderText = "TENNCU";
            this.tENNCUDataGridViewTextBoxColumn.Name = "tENNCUDataGridViewTextBoxColumn";
            // 
            // tENSALEDataGridViewTextBoxColumn
            // 
            this.tENSALEDataGridViewTextBoxColumn.DataPropertyName = "TENSALE";
            this.tENSALEDataGridViewTextBoxColumn.HeaderText = "TENSALE";
            this.tENSALEDataGridViewTextBoxColumn.Name = "tENSALEDataGridViewTextBoxColumn";
            // 
            // tENSPDataGridViewTextBoxColumn
            // 
            this.tENSPDataGridViewTextBoxColumn.DataPropertyName = "TENSP";
            this.tENSPDataGridViewTextBoxColumn.HeaderText = "TENSP";
            this.tENSPDataGridViewTextBoxColumn.Name = "tENSPDataGridViewTextBoxColumn";
            // 
            // lOAISPDataGridViewTextBoxColumn
            // 
            this.lOAISPDataGridViewTextBoxColumn.DataPropertyName = "LOAISP";
            this.lOAISPDataGridViewTextBoxColumn.HeaderText = "LOAISP";
            this.lOAISPDataGridViewTextBoxColumn.Name = "lOAISPDataGridViewTextBoxColumn";
            // 
            // tONGSLDataGridViewTextBoxColumn
            // 
            this.tONGSLDataGridViewTextBoxColumn.DataPropertyName = "TONGSL";
            this.tONGSLDataGridViewTextBoxColumn.HeaderText = "TONGSL";
            this.tONGSLDataGridViewTextBoxColumn.Name = "tONGSLDataGridViewTextBoxColumn";
            // 
            // tONGBILLDataGridViewTextBoxColumn
            // 
            this.tONGBILLDataGridViewTextBoxColumn.DataPropertyName = "TONGBILL";
            this.tONGBILLDataGridViewTextBoxColumn.HeaderText = "TONGBILL";
            this.tONGBILLDataGridViewTextBoxColumn.Name = "tONGBILLDataGridViewTextBoxColumn";
            // 
            // cHUATTDataGridViewTextBoxColumn
            // 
            this.cHUATTDataGridViewTextBoxColumn.DataPropertyName = "CHUATT";
            this.cHUATTDataGridViewTextBoxColumn.HeaderText = "CHUATT";
            this.cHUATTDataGridViewTextBoxColumn.Name = "cHUATTDataGridViewTextBoxColumn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên nhà cung ứng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(317, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên sản phẩm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(317, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Loại sản phẩm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(317, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tổng số lượng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(542, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tổng hoá đơn";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(542, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Chưa thanh toán";
            // 
            // rJ_Textbox1
            // 
            this.rJ_Textbox1.BackColor = System.Drawing.SystemColors.Control;
            this.rJ_Textbox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rJ_Textbox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rJ_Textbox1.BorderRadius = 0;
            this.rJ_Textbox1.BorderSize = 2;
            this.rJ_Textbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rJ_Textbox1.ForeColor = System.Drawing.Color.DimGray;
            this.rJ_Textbox1.Location = new System.Drawing.Point(149, 26);
            this.rJ_Textbox1.Margin = new System.Windows.Forms.Padding(4);
            this.rJ_Textbox1.Multiline = false;
            this.rJ_Textbox1.Name = "rJ_Textbox1";
            this.rJ_Textbox1.Padding = new System.Windows.Forms.Padding(7);
            this.rJ_Textbox1.PasswordChar = false;
            this.rJ_Textbox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rJ_Textbox1.PlaceholderText = "";
            this.rJ_Textbox1.Size = new System.Drawing.Size(161, 31);
            this.rJ_Textbox1.TabIndex = 2;
            this.rJ_Textbox1.Texts = "";
            this.rJ_Textbox1.UnderlinedStyle = true;
            // 
            // rJ_Textbox2
            // 
            this.rJ_Textbox2.BackColor = System.Drawing.SystemColors.Control;
            this.rJ_Textbox2.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rJ_Textbox2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rJ_Textbox2.BorderRadius = 0;
            this.rJ_Textbox2.BorderSize = 2;
            this.rJ_Textbox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rJ_Textbox2.ForeColor = System.Drawing.Color.DimGray;
            this.rJ_Textbox2.Location = new System.Drawing.Point(149, 74);
            this.rJ_Textbox2.Margin = new System.Windows.Forms.Padding(4);
            this.rJ_Textbox2.Multiline = false;
            this.rJ_Textbox2.Name = "rJ_Textbox2";
            this.rJ_Textbox2.Padding = new System.Windows.Forms.Padding(7);
            this.rJ_Textbox2.PasswordChar = false;
            this.rJ_Textbox2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rJ_Textbox2.PlaceholderText = "";
            this.rJ_Textbox2.Size = new System.Drawing.Size(161, 31);
            this.rJ_Textbox2.TabIndex = 3;
            this.rJ_Textbox2.Texts = "";
            this.rJ_Textbox2.UnderlinedStyle = true;
            // 
            // rJ_Textbox3
            // 
            this.rJ_Textbox3.BackColor = System.Drawing.SystemColors.Control;
            this.rJ_Textbox3.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rJ_Textbox3.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rJ_Textbox3.BorderRadius = 0;
            this.rJ_Textbox3.BorderSize = 2;
            this.rJ_Textbox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rJ_Textbox3.ForeColor = System.Drawing.Color.DimGray;
            this.rJ_Textbox3.Location = new System.Drawing.Point(399, 26);
            this.rJ_Textbox3.Margin = new System.Windows.Forms.Padding(4);
            this.rJ_Textbox3.Multiline = false;
            this.rJ_Textbox3.Name = "rJ_Textbox3";
            this.rJ_Textbox3.Padding = new System.Windows.Forms.Padding(7);
            this.rJ_Textbox3.PasswordChar = false;
            this.rJ_Textbox3.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rJ_Textbox3.PlaceholderText = "";
            this.rJ_Textbox3.Size = new System.Drawing.Size(119, 31);
            this.rJ_Textbox3.TabIndex = 4;
            this.rJ_Textbox3.Texts = "";
            this.rJ_Textbox3.UnderlinedStyle = true;
            // 
            // rJ_Textbox4
            // 
            this.rJ_Textbox4.BackColor = System.Drawing.SystemColors.Control;
            this.rJ_Textbox4.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rJ_Textbox4.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rJ_Textbox4.BorderRadius = 0;
            this.rJ_Textbox4.BorderSize = 2;
            this.rJ_Textbox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rJ_Textbox4.ForeColor = System.Drawing.Color.DimGray;
            this.rJ_Textbox4.Location = new System.Drawing.Point(399, 74);
            this.rJ_Textbox4.Margin = new System.Windows.Forms.Padding(4);
            this.rJ_Textbox4.Multiline = false;
            this.rJ_Textbox4.Name = "rJ_Textbox4";
            this.rJ_Textbox4.Padding = new System.Windows.Forms.Padding(7);
            this.rJ_Textbox4.PasswordChar = false;
            this.rJ_Textbox4.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rJ_Textbox4.PlaceholderText = "";
            this.rJ_Textbox4.Size = new System.Drawing.Size(119, 31);
            this.rJ_Textbox4.TabIndex = 5;
            this.rJ_Textbox4.Texts = "";
            this.rJ_Textbox4.UnderlinedStyle = true;
            // 
            // rJ_Textbox5
            // 
            this.rJ_Textbox5.BackColor = System.Drawing.SystemColors.Control;
            this.rJ_Textbox5.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rJ_Textbox5.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rJ_Textbox5.BorderRadius = 0;
            this.rJ_Textbox5.BorderSize = 2;
            this.rJ_Textbox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rJ_Textbox5.ForeColor = System.Drawing.Color.DimGray;
            this.rJ_Textbox5.Location = new System.Drawing.Point(626, 26);
            this.rJ_Textbox5.Margin = new System.Windows.Forms.Padding(4);
            this.rJ_Textbox5.Multiline = false;
            this.rJ_Textbox5.Name = "rJ_Textbox5";
            this.rJ_Textbox5.Padding = new System.Windows.Forms.Padding(7);
            this.rJ_Textbox5.PasswordChar = false;
            this.rJ_Textbox5.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rJ_Textbox5.PlaceholderText = "";
            this.rJ_Textbox5.Size = new System.Drawing.Size(144, 31);
            this.rJ_Textbox5.TabIndex = 6;
            this.rJ_Textbox5.Texts = "";
            this.rJ_Textbox5.UnderlinedStyle = true;
            // 
            // rJ_Textbox6
            // 
            this.rJ_Textbox6.BackColor = System.Drawing.SystemColors.Control;
            this.rJ_Textbox6.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rJ_Textbox6.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rJ_Textbox6.BorderRadius = 0;
            this.rJ_Textbox6.BorderSize = 2;
            this.rJ_Textbox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rJ_Textbox6.ForeColor = System.Drawing.Color.DimGray;
            this.rJ_Textbox6.Location = new System.Drawing.Point(626, 74);
            this.rJ_Textbox6.Margin = new System.Windows.Forms.Padding(4);
            this.rJ_Textbox6.Multiline = false;
            this.rJ_Textbox6.Name = "rJ_Textbox6";
            this.rJ_Textbox6.Padding = new System.Windows.Forms.Padding(7);
            this.rJ_Textbox6.PasswordChar = false;
            this.rJ_Textbox6.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rJ_Textbox6.PlaceholderText = "";
            this.rJ_Textbox6.Size = new System.Drawing.Size(144, 31);
            this.rJ_Textbox6.TabIndex = 7;
            this.rJ_Textbox6.Texts = "";
            this.rJ_Textbox6.UnderlinedStyle = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(399, 123);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // FormPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelPurchase);
            this.Controls.Add(this.panelThongTin);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPurchase";
            this.Text = "FormPurchase";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsPurchase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            this.panelThongTin.ResumeLayout(false);
            this.panelThongTin.PerformLayout();
            this.panelPurchase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.drvPurchase)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ptClose;
        private System.Data.DataSet dtsPurchase;
        private System.Data.DataTable dataTable1;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn6;
        private System.Data.DataColumn dataColumn7;
        private System.Data.DataColumn dataColumn8;
        private System.Windows.Forms.Panel panelThongTin;
        private System.Windows.Forms.ComboBox comboBox1;
        private RJ_Controls.RJ_Textbox rJ_Textbox6;
        private RJ_Controls.RJ_Textbox rJ_Textbox5;
        private RJ_Controls.RJ_Textbox rJ_Textbox4;
        private RJ_Controls.RJ_Textbox rJ_Textbox3;
        private RJ_Controls.RJ_Textbox rJ_Textbox2;
        private RJ_Controls.RJ_Textbox rJ_Textbox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelPurchase;
        private System.Windows.Forms.DataGridView drvPurchase;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENNCUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENSALEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lOAISPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tONGSLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tONGBILLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHUATTDataGridViewTextBoxColumn;
    }
}