
namespace SaSa
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.pt_Close = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPW = new SaSa.RJ_Controls.RJ_Textbox();
            this.txtUN = new SaSa.RJ_Controls.RJ_Textbox();
            this.btn_Login = new SaSa.RJ_Controls.RJ_Button();
            ((System.ComponentModel.ISupportInitialize)(this.pt_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pt_Close
            // 
            this.pt_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pt_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pt_Close.Image = ((System.Drawing.Image)(resources.GetObject("pt_Close.Image")));
            this.pt_Close.Location = new System.Drawing.Point(338, 2);
            this.pt_Close.Name = "pt_Close";
            this.pt_Close.Size = new System.Drawing.Size(28, 22);
            this.pt_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pt_Close.TabIndex = 1;
            this.pt_Close.TabStop = false;
            this.pt_Close.Click += new System.EventHandler(this.pt_Close_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(132, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // txtPW
            // 
            this.txtPW.BackColor = System.Drawing.Color.Aquamarine;
            this.txtPW.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtPW.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPW.BorderRadius = 1;
            this.txtPW.BorderSize = 2;
            this.txtPW.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPW.ForeColor = System.Drawing.Color.DimGray;
            this.txtPW.Location = new System.Drawing.Point(98, 229);
            this.txtPW.Margin = new System.Windows.Forms.Padding(4);
            this.txtPW.Multiline = false;
            this.txtPW.Name = "txtPW";
            this.txtPW.Padding = new System.Windows.Forms.Padding(7);
            this.txtPW.PasswordChar = false;
            this.txtPW.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPW.PlaceholderText = "Mật khẩu";
            this.txtPW.Size = new System.Drawing.Size(185, 31);
            this.txtPW.TabIndex = 5;
            this.txtPW.Texts = "";
            this.txtPW.UnderlinedStyle = true;
            // 
            // txtUN
            // 
            this.txtUN.BackColor = System.Drawing.Color.Aquamarine;
            this.txtUN.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtUN.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtUN.BorderRadius = 0;
            this.txtUN.BorderSize = 2;
            this.txtUN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUN.ForeColor = System.Drawing.Color.DimGray;
            this.txtUN.Location = new System.Drawing.Point(98, 190);
            this.txtUN.Margin = new System.Windows.Forms.Padding(4);
            this.txtUN.Multiline = false;
            this.txtUN.Name = "txtUN";
            this.txtUN.Padding = new System.Windows.Forms.Padding(7);
            this.txtUN.PasswordChar = false;
            this.txtUN.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtUN.PlaceholderText = "Tên đăng nhập";
            this.txtUN.Size = new System.Drawing.Size(185, 31);
            this.txtUN.TabIndex = 5;
            this.txtUN.Texts = "";
            this.txtUN.UnderlinedStyle = true;
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_Login.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_Login.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Login.BorderRadius = 20;
            this.btn_Login.BorderSize = 0;
            this.btn_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Login.FlatAppearance.BorderSize = 0;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.ForeColor = System.Drawing.Color.White;
            this.btn_Login.Location = new System.Drawing.Point(113, 282);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(150, 40);
            this.btn_Login.TabIndex = 0;
            this.btn_Login.Text = "LOGIN";
            this.btn_Login.TextColor = System.Drawing.Color.White;
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(369, 356);
            this.Controls.Add(this.txtPW);
            this.Controls.Add(this.txtUN);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pt_Close);
            this.Controls.Add(this.btn_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pt_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RJ_Controls.RJ_Button btn_Login;
        private System.Windows.Forms.PictureBox pt_Close;
        private System.Windows.Forms.PictureBox pictureBox1;
        private RJ_Controls.RJ_Textbox txtUN;
        private RJ_Controls.RJ_Textbox txtPW;
    }
}