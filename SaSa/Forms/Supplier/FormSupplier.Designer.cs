
namespace SaSa.Forms.Supplier
{
    partial class FormSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSupplier));
            this.panelTopBar = new System.Windows.Forms.Panel();
            this.ptClose = new System.Windows.Forms.PictureBox();
            this.panelSupplier = new System.Windows.Forms.Panel();
            this.drvSupplier = new System.Windows.Forms.DataGridView();
            this.dsSupplier = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.sTTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENNCUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIACHIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENSALEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTSEPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptClose)).BeginInit();
            this.panelSupplier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drvSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTopBar
            // 
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
            this.ptClose.Image = ((System.Drawing.Image)(resources.GetObject("ptClose.Image")));
            this.ptClose.Location = new System.Drawing.Point(762, 4);
            this.ptClose.Name = "ptClose";
            this.ptClose.Size = new System.Drawing.Size(35, 33);
            this.ptClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptClose.TabIndex = 0;
            this.ptClose.TabStop = false;
            this.ptClose.Click += new System.EventHandler(this.ptClose_Click);
            // 
            // panelSupplier
            // 
            this.panelSupplier.Controls.Add(this.drvSupplier);
            this.panelSupplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSupplier.Location = new System.Drawing.Point(0, 40);
            this.panelSupplier.Name = "panelSupplier";
            this.panelSupplier.Padding = new System.Windows.Forms.Padding(30);
            this.panelSupplier.Size = new System.Drawing.Size(800, 410);
            this.panelSupplier.TabIndex = 1;
            // 
            // drvSupplier
            // 
            this.drvSupplier.AutoGenerateColumns = false;
            this.drvSupplier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.drvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drvSupplier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sTTDataGridViewTextBoxColumn,
            this.tENNCUDataGridViewTextBoxColumn,
            this.sDTDataGridViewTextBoxColumn,
            this.dIACHIDataGridViewTextBoxColumn,
            this.tENSALEDataGridViewTextBoxColumn,
            this.sDTSEPDataGridViewTextBoxColumn});
            this.drvSupplier.DataMember = "SUPPLIER";
            this.drvSupplier.DataSource = this.dsSupplier;
            this.drvSupplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drvSupplier.Location = new System.Drawing.Point(30, 30);
            this.drvSupplier.Name = "drvSupplier";
            this.drvSupplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.drvSupplier.Size = new System.Drawing.Size(740, 350);
            this.drvSupplier.TabIndex = 0;
            // 
            // dsSupplier
            // 
            this.dsSupplier.DataSetName = "NewDataSet";
            this.dsSupplier.Tables.AddRange(new System.Data.DataTable[] {
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
            this.dataTable1.TableName = "SUPPLIER";
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
            this.dataColumn3.ColumnName = "SDT";
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "DIACHI";
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "TENSALE";
            // 
            // dataColumn6
            // 
            this.dataColumn6.ColumnName = "SDTSEP";
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
            // tENSALEDataGridViewTextBoxColumn
            // 
            this.tENSALEDataGridViewTextBoxColumn.DataPropertyName = "TENSALE";
            this.tENSALEDataGridViewTextBoxColumn.HeaderText = "TENSALE";
            this.tENSALEDataGridViewTextBoxColumn.Name = "tENSALEDataGridViewTextBoxColumn";
            // 
            // sDTSEPDataGridViewTextBoxColumn
            // 
            this.sDTSEPDataGridViewTextBoxColumn.DataPropertyName = "SDTSEP";
            this.sDTSEPDataGridViewTextBoxColumn.HeaderText = "SDTSEP";
            this.sDTSEPDataGridViewTextBoxColumn.Name = "sDTSEPDataGridViewTextBoxColumn";
            // 
            // FormSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelSupplier);
            this.Controls.Add(this.panelTopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSupplier";
            this.Text = "FormSupplier";
            this.panelTopBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptClose)).EndInit();
            this.panelSupplier.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.drvSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopBar;
        private System.Windows.Forms.PictureBox ptClose;
        private System.Windows.Forms.Panel panelSupplier;
        private System.Windows.Forms.DataGridView drvSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENNCUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIACHIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENSALEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTSEPDataGridViewTextBoxColumn;
        private System.Data.DataSet dsSupplier;
        private System.Data.DataTable dataTable1;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn6;
    }
}