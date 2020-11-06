namespace Drevo_Project
{
    partial class Main
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
            this.labelChk = new System.Windows.Forms.Label();
            this.tabMenu = new System.Windows.Forms.TabControl();
            this.tabMyProfile = new System.Windows.Forms.TabPage();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.labelDataBorn = new System.Windows.Forms.Label();
            this.labelFio = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabInfoCard = new System.Windows.Forms.TabControl();
            this.tabBioProfile = new System.Windows.Forms.TabPage();
            this.tabPhotoCard = new System.Windows.Forms.TabPage();
            this.tabContactsCard = new System.Windows.Forms.TabPage();
            this.tabDrevo = new System.Windows.Forms.TabPage();
            this.flowLayoutPanelTree = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAddCard = new System.Windows.Forms.Button();
            this.tabSearch = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.tabMenu.SuspendLayout();
            this.tabMyProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabInfoCard.SuspendLayout();
            this.tabDrevo.SuspendLayout();
            this.tabSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelChk
            // 
            this.labelChk.AutoSize = true;
            this.labelChk.Location = new System.Drawing.Point(730, 775);
            this.labelChk.Name = "labelChk";
            this.labelChk.Size = new System.Drawing.Size(118, 13);
            this.labelChk.TabIndex = 2;
            this.labelChk.Text = "проверка соединения";
            // 
            // tabMenu
            // 
            this.tabMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabMenu.Controls.Add(this.tabMyProfile);
            this.tabMenu.Controls.Add(this.tabDrevo);
            this.tabMenu.Controls.Add(this.tabSearch);
            this.tabMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabMenu.Location = new System.Drawing.Point(12, 12);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedIndex = 0;
            this.tabMenu.Size = new System.Drawing.Size(840, 711);
            this.tabMenu.TabIndex = 3;
            // 
            // tabMyProfile
            // 
            this.tabMyProfile.Controls.Add(this.buttonEdit);
            this.tabMyProfile.Controls.Add(this.labelDataBorn);
            this.tabMyProfile.Controls.Add(this.labelFio);
            this.tabMyProfile.Controls.Add(this.pictureBox1);
            this.tabMyProfile.Controls.Add(this.tabInfoCard);
            this.tabMyProfile.Location = new System.Drawing.Point(4, 29);
            this.tabMyProfile.Name = "tabMyProfile";
            this.tabMyProfile.Padding = new System.Windows.Forms.Padding(10);
            this.tabMyProfile.Size = new System.Drawing.Size(832, 678);
            this.tabMyProfile.TabIndex = 0;
            this.tabMyProfile.Text = "Мой профиль";
            this.tabMyProfile.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(570, 542);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(163, 51);
            this.buttonEdit.TabIndex = 4;
            this.buttonEdit.Text = "Редактировать";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // labelDataBorn
            // 
            this.labelDataBorn.AutoSize = true;
            this.labelDataBorn.Location = new System.Drawing.Point(493, 106);
            this.labelDataBorn.Name = "labelDataBorn";
            this.labelDataBorn.Size = new System.Drawing.Size(86, 20);
            this.labelDataBorn.TabIndex = 3;
            this.labelDataBorn.Text = "1900-2000";
            // 
            // labelFio
            // 
            this.labelFio.AutoSize = true;
            this.labelFio.Location = new System.Drawing.Point(493, 71);
            this.labelFio.Name = "labelFio";
            this.labelFio.Size = new System.Drawing.Size(194, 20);
            this.labelFio.TabIndex = 2;
            this.labelFio.Text = "Фамилия Имя Отчество";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(492, 178);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(305, 328);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tabInfoCard
            // 
            this.tabInfoCard.Controls.Add(this.tabBioProfile);
            this.tabInfoCard.Controls.Add(this.tabPhotoCard);
            this.tabInfoCard.Controls.Add(this.tabContactsCard);
            this.tabInfoCard.Location = new System.Drawing.Point(13, 40);
            this.tabInfoCard.Name = "tabInfoCard";
            this.tabInfoCard.SelectedIndex = 0;
            this.tabInfoCard.Size = new System.Drawing.Size(461, 647);
            this.tabInfoCard.TabIndex = 0;
            // 
            // tabBioProfile
            // 
            this.tabBioProfile.Location = new System.Drawing.Point(4, 29);
            this.tabBioProfile.Name = "tabBioProfile";
            this.tabBioProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tabBioProfile.Size = new System.Drawing.Size(453, 614);
            this.tabBioProfile.TabIndex = 0;
            this.tabBioProfile.Text = "Биография";
            this.tabBioProfile.UseVisualStyleBackColor = true;
            this.tabBioProfile.Click += new System.EventHandler(this.tabBioProfile_Click);
            // 
            // tabPhotoCard
            // 
            this.tabPhotoCard.Location = new System.Drawing.Point(4, 29);
            this.tabPhotoCard.Name = "tabPhotoCard";
            this.tabPhotoCard.Padding = new System.Windows.Forms.Padding(3);
            this.tabPhotoCard.Size = new System.Drawing.Size(453, 614);
            this.tabPhotoCard.TabIndex = 1;
            this.tabPhotoCard.Text = "Фотоальбом";
            this.tabPhotoCard.UseVisualStyleBackColor = true;
            // 
            // tabContactsCard
            // 
            this.tabContactsCard.Location = new System.Drawing.Point(4, 29);
            this.tabContactsCard.Name = "tabContactsCard";
            this.tabContactsCard.Size = new System.Drawing.Size(453, 614);
            this.tabContactsCard.TabIndex = 2;
            this.tabContactsCard.Text = "Контакты";
            this.tabContactsCard.UseVisualStyleBackColor = true;
            // 
            // tabDrevo
            // 
            this.tabDrevo.Controls.Add(this.buttonDelete);
            this.tabDrevo.Controls.Add(this.flowLayoutPanelTree);
            this.tabDrevo.Controls.Add(this.buttonAddCard);
            this.tabDrevo.Location = new System.Drawing.Point(4, 29);
            this.tabDrevo.Name = "tabDrevo";
            this.tabDrevo.Padding = new System.Windows.Forms.Padding(10, 10, 10, 3);
            this.tabDrevo.Size = new System.Drawing.Size(832, 678);
            this.tabDrevo.TabIndex = 1;
            this.tabDrevo.Text = "Древо семьи";
            this.tabDrevo.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelTree
            // 
            this.flowLayoutPanelTree.AutoScroll = true;
            this.flowLayoutPanelTree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelTree.Location = new System.Drawing.Point(3, 64);
            this.flowLayoutPanelTree.Name = "flowLayoutPanelTree";
            this.flowLayoutPanelTree.Size = new System.Drawing.Size(820, 606);
            this.flowLayoutPanelTree.TabIndex = 2;
            // 
            // buttonAddCard
            // 
            this.buttonAddCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddCard.Location = new System.Drawing.Point(517, 13);
            this.buttonAddCard.Name = "buttonAddCard";
            this.buttonAddCard.Size = new System.Drawing.Size(154, 31);
            this.buttonAddCard.TabIndex = 1;
            this.buttonAddCard.Text = "Добавить человека";
            this.buttonAddCard.UseVisualStyleBackColor = true;
            this.buttonAddCard.Click += new System.EventHandler(this.buttonAddCard_Click);
            // 
            // tabSearch
            // 
            this.tabSearch.Controls.Add(this.label1);
            this.tabSearch.Controls.Add(this.panel1);
            this.tabSearch.Controls.Add(this.textBox1);
            this.tabSearch.Controls.Add(this.buttonSearch);
            this.tabSearch.Location = new System.Drawing.Point(4, 29);
            this.tabSearch.Name = "tabSearch";
            this.tabSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabSearch.Size = new System.Drawing.Size(832, 678);
            this.tabSearch.TabIndex = 2;
            this.tabSearch.Text = "Поиск";
            this.tabSearch.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Результаты поиска:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(38, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(752, 570);
            this.panel1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(38, 25);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(616, 28);
            this.textBox1.TabIndex = 1;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(671, 24);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(119, 29);
            this.buttonSearch.TabIndex = 0;
            this.buttonSearch.Text = "Искать";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.Location = new System.Drawing.Point(677, 13);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(142, 31);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Удалить человека";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 749);
            this.Controls.Add(this.tabMenu);
            this.Controls.Add(this.labelChk);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Main";
            this.tabMenu.ResumeLayout(false);
            this.tabMyProfile.ResumeLayout(false);
            this.tabMyProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabInfoCard.ResumeLayout(false);
            this.tabDrevo.ResumeLayout(false);
            this.tabSearch.ResumeLayout(false);
            this.tabSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelChk;
        private System.Windows.Forms.TabControl tabMenu;
        private System.Windows.Forms.TabPage tabMyProfile;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Label labelDataBorn;
        private System.Windows.Forms.Label labelFio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabInfoCard;
        private System.Windows.Forms.TabPage tabBioProfile;
        private System.Windows.Forms.TabPage tabPhotoCard;
        private System.Windows.Forms.TabPage tabContactsCard;
        private System.Windows.Forms.TabPage tabDrevo;
        private System.Windows.Forms.TabPage tabSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonAddCard;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTree;
        private System.Windows.Forms.Button buttonDelete;
    }
}