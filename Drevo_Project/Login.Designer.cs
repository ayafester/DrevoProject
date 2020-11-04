namespace Drevo_Project
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCheckMail = new System.Windows.Forms.TextBox();
            this.tbCheckPassword = new System.Windows.Forms.TextBox();
            this.btnCheckLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(136, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Войти";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(59, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Почта:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(49, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Пароль:";
            // 
            // tbCheckMail
            // 
            this.tbCheckMail.Location = new System.Drawing.Point(142, 153);
            this.tbCheckMail.Name = "tbCheckMail";
            this.tbCheckMail.Size = new System.Drawing.Size(147, 20);
            this.tbCheckMail.TabIndex = 3;
            // 
            // tbCheckPassword
            // 
            this.tbCheckPassword.Location = new System.Drawing.Point(142, 194);
            this.tbCheckPassword.Name = "tbCheckPassword";
            this.tbCheckPassword.Size = new System.Drawing.Size(147, 20);
            this.tbCheckPassword.TabIndex = 4;
            // 
            // btnCheckLogin
            // 
            this.btnCheckLogin.Location = new System.Drawing.Point(110, 272);
            this.btnCheckLogin.Name = "btnCheckLogin";
            this.btnCheckLogin.Size = new System.Drawing.Size(132, 52);
            this.btnCheckLogin.TabIndex = 5;
            this.btnCheckLogin.Text = "Войти";
            this.btnCheckLogin.UseVisualStyleBackColor = true;
            this.btnCheckLogin.Click += new System.EventHandler(this.btnCheckLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 429);
            this.Controls.Add(this.btnCheckLogin);
            this.Controls.Add(this.tbCheckPassword);
            this.Controls.Add(this.tbCheckMail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCheckMail;
        private System.Windows.Forms.TextBox tbCheckPassword;
        private System.Windows.Forms.Button btnCheckLogin;
    }
}