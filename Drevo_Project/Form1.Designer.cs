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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lbConnectMsg = new System.Windows.Forms.Label();
            this.btnReadDB = new System.Windows.Forms.Button();
            this.dgvViewer = new System.Windows.Forms.DataGridView();
            this.btnToReg = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnToLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lbConnectMsg
            // 
            this.lbConnectMsg.AutoSize = true;
            this.lbConnectMsg.Location = new System.Drawing.Point(687, 9);
            this.lbConnectMsg.Name = "lbConnectMsg";
            this.lbConnectMsg.Size = new System.Drawing.Size(76, 13);
            this.lbConnectMsg.TabIndex = 16;
            this.lbConnectMsg.Text = "Подключение";
            // 
            // btnReadDB
            // 
            this.btnReadDB.Location = new System.Drawing.Point(108, 537);
            this.btnReadDB.Name = "btnReadDB";
            this.btnReadDB.Size = new System.Drawing.Size(113, 40);
            this.btnReadDB.TabIndex = 18;
            this.btnReadDB.Text = "Показать данные";
            this.btnReadDB.UseVisualStyleBackColor = true;
            this.btnReadDB.Click += new System.EventHandler(this.btnReadDB_Click);
            // 
            // dgvViewer
            // 
            this.dgvViewer.AllowUserToAddRows = false;
            this.dgvViewer.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column6,
            this.Column7});
            this.dgvViewer.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvViewer.Location = new System.Drawing.Point(108, 583);
            this.dgvViewer.Name = "dgvViewer";
            this.dgvViewer.ReadOnly = true;
            this.dgvViewer.Size = new System.Drawing.Size(344, 164);
            this.dgvViewer.TabIndex = 19;
            // 
            // btnToReg
            // 
            this.btnToReg.Location = new System.Drawing.Point(359, 361);
            this.btnToReg.Name = "btnToReg";
            this.btnToReg.Size = new System.Drawing.Size(148, 58);
            this.btnToReg.TabIndex = 20;
            this.btnToReg.Text = "Зарегистрироваться";
            this.btnToReg.UseVisualStyleBackColor = true;
            this.btnToReg.Click += new System.EventHandler(this.btnToReg_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(132, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(680, 37);
            this.label2.TabIndex = 22;
            this.label2.Text = "Создайте генеалогическое древо своей семьи";
            // 
            // btnToLogin
            // 
            this.btnToLogin.Location = new System.Drawing.Point(357, 304);
            this.btnToLogin.Name = "btnToLogin";
            this.btnToLogin.Size = new System.Drawing.Size(150, 51);
            this.btnToLogin.TabIndex = 23;
            this.btnToLogin.Text = "Войти";
            this.btnToLogin.UseVisualStyleBackColor = true;
            this.btnToLogin.Click += new System.EventHandler(this.btnToLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(314, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 42);
            this.label3.TabIndex = 24;
            this.label3.Text = "Древо Семьи";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Почта";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Пароль";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 797);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnToLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnToReg);
            this.Controls.Add(this.dgvViewer);
            this.Controls.Add(this.btnReadDB);
            this.Controls.Add(this.lbConnectMsg);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lbConnectMsg;
        private System.Windows.Forms.Button btnReadDB;
        private System.Windows.Forms.DataGridView dgvViewer;
        private System.Windows.Forms.Button btnToReg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnToLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}

