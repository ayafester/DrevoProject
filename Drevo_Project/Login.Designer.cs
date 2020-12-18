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
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(142, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Войти";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(48, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Почта:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(38, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Пароль:";
            // 
            // tbCheckMail
            // 
            this.tbCheckMail.BackColor = System.Drawing.Color.White;
            this.tbCheckMail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCheckMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCheckMail.Location = new System.Drawing.Point(131, 147);
            this.tbCheckMail.Name = "tbCheckMail";
            this.tbCheckMail.Size = new System.Drawing.Size(174, 26);
            this.tbCheckMail.TabIndex = 3;
            // 
            // tbCheckPassword
            // 
            this.tbCheckPassword.BackColor = System.Drawing.Color.White;
            this.tbCheckPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCheckPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCheckPassword.Location = new System.Drawing.Point(131, 194);
            this.tbCheckPassword.Name = "tbCheckPassword";
            this.tbCheckPassword.Size = new System.Drawing.Size(174, 26);
            this.tbCheckPassword.TabIndex = 4;
            // 
            // btnCheckLogin
            // 
            this.btnCheckLogin.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnCheckLogin.FlatAppearance.BorderSize = 0;
            this.btnCheckLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCheckLogin.ForeColor = System.Drawing.Color.Black;
            this.btnCheckLogin.Location = new System.Drawing.Point(117, 268);
            this.btnCheckLogin.Name = "btnCheckLogin";
            this.btnCheckLogin.Size = new System.Drawing.Size(132, 52);
            this.btnCheckLogin.TabIndex = 5;
            this.btnCheckLogin.Text = "Войти";
            this.btnCheckLogin.UseVisualStyleBackColor = false;
            this.btnCheckLogin.Click += new System.EventHandler(this.btnCheckLogin_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(128, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Забыли пароль?";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(372, 429);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCheckLogin);
            this.Controls.Add(this.tbCheckPassword);
            this.Controls.Add(this.tbCheckMail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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
        private System.Windows.Forms.Label label4;
    }
}