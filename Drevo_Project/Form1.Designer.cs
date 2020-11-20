namespace Drevo_Project
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnToReg = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnToLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnToReg
            // 
            this.btnToReg.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnToReg.FlatAppearance.BorderSize = 0;
            this.btnToReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnToReg.Location = new System.Drawing.Point(276, 425);
            this.btnToReg.Name = "btnToReg";
            this.btnToReg.Size = new System.Drawing.Size(184, 58);
            this.btnToReg.TabIndex = 20;
            this.btnToReg.Text = "Зарегистрироваться";
            this.btnToReg.UseVisualStyleBackColor = false;
            this.btnToReg.Click += new System.EventHandler(this.btnToReg_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(30, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(680, 37);
            this.label2.TabIndex = 22;
            this.label2.Text = "Создайте генеалогическое древо своей семьи";
            // 
            // btnToLogin
            // 
            this.btnToLogin.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnToLogin.FlatAppearance.BorderSize = 0;
            this.btnToLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnToLogin.ForeColor = System.Drawing.Color.Black;
            this.btnToLogin.Location = new System.Drawing.Point(274, 368);
            this.btnToLogin.Name = "btnToLogin";
            this.btnToLogin.Size = new System.Drawing.Size(186, 51);
            this.btnToLogin.TabIndex = 23;
            this.btnToLogin.Text = "Войти";
            this.btnToLogin.UseVisualStyleBackColor = false;
            this.btnToLogin.Click += new System.EventHandler(this.btnToLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(103, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 42);
            this.label3.TabIndex = 24;
            this.label3.Text = "Древо Семьи";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::Drevo_Project.Properties.Resources.Tree1;
            this.pictureBox1.Image = global::Drevo_Project.Properties.Resources.Tree1;
            this.pictureBox1.InitialImage = global::Drevo_Project.Properties.Resources.Tree1;
            this.pictureBox1.Location = new System.Drawing.Point(18, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(739, 562);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnToLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnToReg);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnToReg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnToLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

