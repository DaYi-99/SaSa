
namespace SaSa.Forms.Product
{
    partial class FormProductType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProductType));
            this.panelTitle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ptClose = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMAMH = new System.Windows.Forms.TextBox();
            this.txtTENMH = new System.Windows.Forms.TextBox();
            this.drvProductType = new System.Windows.Forms.DataGridView();
            this.sTTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAMHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENMHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtsProductType = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.ptAdd = new System.Windows.Forms.PictureBox();
            this.ptDelete = new System.Windows.Forms.PictureBox();
            this.ptEdit = new System.Windows.Forms.PictureBox();
            this.txtVal = new System.Windows.Forms.TextBox();
            this.lbtb = new System.Windows.Forms.Label();
            this.btnCancel = new SaSa.RJ_Controls.RJ_Button();
            this.btnSave = new SaSa.RJ_Controls.RJ_Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drvProductType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsProductType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelTitle.Controls.Add(this.pictureBox1);
            this.panelTitle.Controls.Add(this.label1);
            this.panelTitle.Controls.Add(this.ptClose);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(479, 40);
            this.panelTitle.TabIndex = 2;
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            this.panelTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseMove);
            this.panelTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(50, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quản lý mặt hàng";
            // 
            // ptClose
            // 
            this.ptClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptClose.Image = ((System.Drawing.Image)(resources.GetObject("ptClose.Image")));
            this.ptClose.Location = new System.Drawing.Point(449, 1);
            this.ptClose.Name = "ptClose";
            this.ptClose.Size = new System.Drawing.Size(29, 28);
            this.ptClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptClose.TabIndex = 1;
            this.ptClose.TabStop = false;
            this.ptClose.Click += new System.EventHandler(this.ptClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã mặt hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên mặt hàng";
            // 
            // txtMAMH
            // 
            this.txtMAMH.Location = new System.Drawing.Point(118, 62);
            this.txtMAMH.Name = "txtMAMH";
            this.txtMAMH.Size = new System.Drawing.Size(100, 20);
            this.txtMAMH.TabIndex = 4;
            // 
            // txtTENMH
            // 
            this.txtTENMH.Location = new System.Drawing.Point(118, 97);
            this.txtTENMH.Name = "txtTENMH";
            this.txtTENMH.Size = new System.Drawing.Size(174, 20);
            this.txtTENMH.TabIndex = 4;
            // 
            // drvProductType
            // 
            this.drvProductType.AutoGenerateColumns = false;
            this.drvProductType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.drvProductType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drvProductType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sTTDataGridViewTextBoxColumn,
            this.mAMHDataGridViewTextBoxColumn,
            this.tENMHDataGridViewTextBoxColumn});
            this.drvProductType.DataMember = "ProductType";
            this.drvProductType.DataSource = this.dtsProductType;
            this.drvProductType.Location = new System.Drawing.Point(34, 176);
            this.drvProductType.Name = "drvProductType";
            this.drvProductType.Size = new System.Drawing.Size(403, 178);
            this.drvProductType.TabIndex = 6;
            this.drvProductType.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.drvProductType_CellClick);
            // 
            // sTTDataGridViewTextBoxColumn
            // 
            this.sTTDataGridViewTextBoxColumn.DataPropertyName = "STT";
            this.sTTDataGridViewTextBoxColumn.HeaderText = "STT";
            this.sTTDataGridViewTextBoxColumn.Name = "sTTDataGridViewTextBoxColumn";
            // 
            // mAMHDataGridViewTextBoxColumn
            // 
            this.mAMHDataGridViewTextBoxColumn.DataPropertyName = "MAMH";
            this.mAMHDataGridViewTextBoxColumn.HeaderText = "MAMH";
            this.mAMHDataGridViewTextBoxColumn.Name = "mAMHDataGridViewTextBoxColumn";
            // 
            // tENMHDataGridViewTextBoxColumn
            // 
            this.tENMHDataGridViewTextBoxColumn.DataPropertyName = "TENMH";
            this.tENMHDataGridViewTextBoxColumn.HeaderText = "TENMH";
            this.tENMHDataGridViewTextBoxColumn.Name = "tENMHDataGridViewTextBoxColumn";
            // 
            // dtsProductType
            // 
            this.dtsProductType.DataSetName = "NewDataSet";
            this.dtsProductType.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1});
            // 
            // dataTable1
            // 
            this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3});
            this.dataTable1.TableName = "ProductType";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "STT";
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "MAMH";
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "TENMH";
            // 
            // ptAdd
            // 
            this.ptAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptAdd.Image = ((System.Drawing.Image)(resources.GetObject("ptAdd.Image")));
            this.ptAdd.Location = new System.Drawing.Point(34, 133);
            this.ptAdd.Name = "ptAdd";
            this.ptAdd.Size = new System.Drawing.Size(36, 30);
            this.ptAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptAdd.TabIndex = 8;
            this.ptAdd.TabStop = false;
            this.ptAdd.Click += new System.EventHandler(this.ptAdd_Click);
            // 
            // ptDelete
            // 
            this.ptDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptDelete.Image = ((System.Drawing.Image)(resources.GetObject("ptDelete.Image")));
            this.ptDelete.Location = new System.Drawing.Point(76, 133);
            this.ptDelete.Name = "ptDelete";
            this.ptDelete.Size = new System.Drawing.Size(36, 30);
            this.ptDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptDelete.TabIndex = 8;
            this.ptDelete.TabStop = false;
            this.ptDelete.Click += new System.EventHandler(this.ptDelete_Click);
            // 
            // ptEdit
            // 
            this.ptEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptEdit.Image = ((System.Drawing.Image)(resources.GetObject("ptEdit.Image")));
            this.ptEdit.Location = new System.Drawing.Point(118, 133);
            this.ptEdit.Name = "ptEdit";
            this.ptEdit.Size = new System.Drawing.Size(36, 30);
            this.ptEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptEdit.TabIndex = 8;
            this.ptEdit.TabStop = false;
            this.ptEdit.Click += new System.EventHandler(this.ptEdit_Click);
            // 
            // txtVal
            // 
            this.txtVal.Location = new System.Drawing.Point(161, 142);
            this.txtVal.Name = "txtVal";
            this.txtVal.Size = new System.Drawing.Size(40, 20);
            this.txtVal.TabIndex = 11;
            this.txtVal.Visible = false;
            // 
            // lbtb
            // 
            this.lbtb.AutoSize = true;
            this.lbtb.ForeColor = System.Drawing.Color.Red;
            this.lbtb.Location = new System.Drawing.Point(35, 360);
            this.lbtb.Name = "lbtb";
            this.lbtb.Size = new System.Drawing.Size(35, 13);
            this.lbtb.TabIndex = 12;
            this.lbtb.Text = "label4";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCancel.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.btnCancel.BorderColor = System.Drawing.Color.Black;
            this.btnCancel.BorderRadius = 20;
            this.btnCancel.BorderSize = 1;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(360, 360);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnCancel.Size = new System.Drawing.Size(77, 40);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Huỷ";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.TextColor = System.Drawing.Color.Black;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSave.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.btnSave.BorderColor = System.Drawing.Color.Black;
            this.btnSave.BorderRadius = 20;
            this.btnSave.BorderSize = 1;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(276, 360);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnSave.Size = new System.Drawing.Size(77, 40);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Lưu";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.TextColor = System.Drawing.Color.Black;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FormProductType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 405);
            this.Controls.Add(this.lbtb);
            this.Controls.Add(this.txtVal);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.ptEdit);
            this.Controls.Add(this.ptDelete);
            this.Controls.Add(this.ptAdd);
            this.Controls.Add(this.drvProductType);
            this.Controls.Add(this.txtTENMH);
            this.Controls.Add(this.txtMAMH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProductType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormProductType";
            this.Load += new System.EventHandler(this.FormProductType_Load);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drvProductType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsProductType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.PictureBox ptClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMAMH;
        private System.Windows.Forms.TextBox txtTENMH;
        private System.Windows.Forms.DataGridView drvProductType;
        private System.Windows.Forms.PictureBox ptAdd;
        private System.Windows.Forms.PictureBox ptDelete;
        private System.Windows.Forms.PictureBox ptEdit;
        private RJ_Controls.RJ_Button btnCancel;
        private RJ_Controls.RJ_Button btnSave;
        private System.Data.DataSet dtsProductType;
        private System.Data.DataTable dataTable1;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAMHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENMHDataGridViewTextBoxColumn;
        private System.Data.DataColumn dataColumn3;
        private System.Windows.Forms.TextBox txtVal;
        private System.Windows.Forms.Label lbtb;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}