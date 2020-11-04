namespace Drevo_Project
{
    partial class EditCard
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
            this.textBoxFioEdit = new System.Windows.Forms.TextBox();
            this.textBoxDataBornEdit = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.buttonSaveInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(112, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Редактировать информацию";
            // 
            // textBoxFioEdit
            // 
            this.textBoxFioEdit.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxFioEdit.Location = new System.Drawing.Point(44, 85);
            this.textBoxFioEdit.Name = "textBoxFioEdit";
            this.textBoxFioEdit.Size = new System.Drawing.Size(406, 20);
            this.textBoxFioEdit.TabIndex = 1;
            this.textBoxFioEdit.Text = "Введите фамилию";
            // 
            // textBoxDataBornEdit
            // 
            this.textBoxDataBornEdit.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxDataBornEdit.Location = new System.Drawing.Point(44, 120);
            this.textBoxDataBornEdit.Name = "textBoxDataBornEdit";
            this.textBoxDataBornEdit.Size = new System.Drawing.Size(406, 20);
            this.textBoxDataBornEdit.TabIndex = 2;
            this.textBoxDataBornEdit.Text = "Введите годы жизни";
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Location = new System.Drawing.Point(44, 157);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(406, 217);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Введите биографию";
            // 
            // textBox2
            // 
            this.textBox2.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox2.Location = new System.Drawing.Point(44, 398);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(406, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "Введите номер телефона";
            // 
            // textBox3
            // 
            this.textBox3.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox3.Location = new System.Drawing.Point(44, 441);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(406, 20);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "Введите почту";
            // 
            // buttonSaveInfo
            // 
            this.buttonSaveInfo.Location = new System.Drawing.Point(200, 690);
            this.buttonSaveInfo.Name = "buttonSaveInfo";
            this.buttonSaveInfo.Size = new System.Drawing.Size(88, 53);
            this.buttonSaveInfo.TabIndex = 6;
            this.buttonSaveInfo.Text = "Сохранить";
            this.buttonSaveInfo.UseVisualStyleBackColor = true;
            this.buttonSaveInfo.Click += new System.EventHandler(this.buttonSaveInfo_Click);
            // 
            // EditCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 755);
            this.Controls.Add(this.buttonSaveInfo);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxDataBornEdit);
            this.Controls.Add(this.textBoxFioEdit);
            this.Controls.Add(this.label1);
            this.Name = "EditCard";
            this.Text = "EditCard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFioEdit;
        private System.Windows.Forms.TextBox textBoxDataBornEdit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button buttonSaveInfo;
    }
}