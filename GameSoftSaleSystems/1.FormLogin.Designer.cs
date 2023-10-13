
namespace GameSoftSaleSystems
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
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.ButtonSignUp = new System.Windows.Forms.Button();
            this.TextBoxUserId = new System.Windows.Forms.TextBox();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.ButtonLogin.Location = new System.Drawing.Point(700, 672);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(110, 39);
            this.ButtonLogin.TabIndex = 0;
            this.ButtonLogin.Text = "ログイン";
            this.ButtonLogin.UseVisualStyleBackColor = true;
            // 
            // ButtonSignUp
            // 
            this.ButtonSignUp.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.ButtonSignUp.Location = new System.Drawing.Point(1146, 672);
            this.ButtonSignUp.Name = "ButtonSignUp";
            this.ButtonSignUp.Size = new System.Drawing.Size(110, 39);
            this.ButtonSignUp.TabIndex = 1;
            this.ButtonSignUp.Text = "新規登録";
            this.ButtonSignUp.UseVisualStyleBackColor = true;
            this.ButtonSignUp.Click += new System.EventHandler(this.button2_Click);
            // 
            // TextBoxUserId
            // 
            this.TextBoxUserId.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.TextBoxUserId.Location = new System.Drawing.Point(853, 350);
            this.TextBoxUserId.Name = "TextBoxUserId";
            this.TextBoxUserId.Size = new System.Drawing.Size(216, 31);
            this.TextBoxUserId.TabIndex = 2;
            this.TextBoxUserId.Text = "ID";
            this.TextBoxUserId.TextChanged += new System.EventHandler(this.TextBoxUserId_TextChanged);
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.TextBoxPassword.ForeColor = System.Drawing.Color.Black;
            this.TextBoxPassword.Location = new System.Drawing.Point(853, 485);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.Size = new System.Drawing.Size(216, 31);
            this.TextBoxPassword.TabIndex = 3;
            this.TextBoxPassword.Text = "Password";
            this.TextBoxPassword.Click += new System.EventHandler(this.TextBoxPassword_Click);
            this.TextBoxPassword.TextChanged += new System.EventHandler(this.TextBoxPassword_TextChanged);
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.BackColor = System.Drawing.Color.Fuchsia;
            this.LabelTitle.Font = new System.Drawing.Font("HGP創英ﾌﾟﾚｾﾞﾝｽEB", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LabelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LabelTitle.Location = new System.Drawing.Point(873, 116);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(173, 67);
            this.LabelTitle.TabIndex = 4;
            this.LabelTitle.Text = "GSSS";
            this.LabelTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-23, -46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LabelTitle);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.TextBoxUserId);
            this.Controls.Add(this.ButtonSignUp);
            this.Controls.Add(this.ButtonLogin);
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonLogin;
        private System.Windows.Forms.Button ButtonSignUp;
        private System.Windows.Forms.TextBox TextBoxUserId;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}