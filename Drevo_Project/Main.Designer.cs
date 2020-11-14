using System.Windows.Forms;

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
            this.pictureBoxAva = new System.Windows.Forms.PictureBox();
            this.tabInfoCard = new System.Windows.Forms.TabControl();
            this.tabBioProfile = new System.Windows.Forms.TabPage();
            this.listBoxBio = new System.Windows.Forms.ListBox();
            this.tabPhotoCard = new System.Windows.Forms.TabPage();
            this.listBoxPhoto = new System.Windows.Forms.ListBox();
            this.tabContactsCard = new System.Windows.Forms.TabPage();
            this.listBoxContacts = new System.Windows.Forms.ListBox();
            this.tabDrevo = new System.Windows.Forms.TabPage();
            this.panelTree = new System.Windows.Forms.Panel();
            this.pictureBoxTree = new System.Windows.Forms.PictureBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAddCard = new System.Windows.Forms.Button();
            this.tabSearch = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabMenu.SuspendLayout();
            this.tabMyProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAva)).BeginInit();
            this.tabInfoCard.SuspendLayout();
            this.tabBioProfile.SuspendLayout();
            this.tabPhotoCard.SuspendLayout();
            this.tabContactsCard.SuspendLayout();
            this.tabDrevo.SuspendLayout();
            this.panelTree.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTree)).BeginInit();
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
            this.tabMenu.Size = new System.Drawing.Size(850, 711);
            this.tabMenu.TabIndex = 3;
            // 
            // tabMyProfile
            // 
            this.tabMyProfile.BackColor = System.Drawing.Color.White;
            this.tabMyProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabMyProfile.Controls.Add(this.button1);
            this.tabMyProfile.Controls.Add(this.buttonEdit);
            this.tabMyProfile.Controls.Add(this.labelDataBorn);
            this.tabMyProfile.Controls.Add(this.labelFio);
            this.tabMyProfile.Controls.Add(this.pictureBoxAva);
            this.tabMyProfile.Controls.Add(this.tabInfoCard);
            this.tabMyProfile.Location = new System.Drawing.Point(4, 29);
            this.tabMyProfile.Name = "tabMyProfile";
            this.tabMyProfile.Padding = new System.Windows.Forms.Padding(10);
            this.tabMyProfile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabMyProfile.Size = new System.Drawing.Size(842, 678);
            this.tabMyProfile.TabIndex = 0;
            this.tabMyProfile.Text = "Мой профиль";
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonEdit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonEdit.FlatAppearance.BorderSize = 0;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Location = new System.Drawing.Point(570, 542);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(163, 51);
            this.buttonEdit.TabIndex = 4;
            this.buttonEdit.Text = "Редактировать";
            this.buttonEdit.UseVisualStyleBackColor = false;
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
            // pictureBoxAva
            // 
            this.pictureBoxAva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxAva.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pictureBoxAva.ErrorImage = null;
            this.pictureBoxAva.Image = global::Drevo_Project.Properties.Resources.logo;
            this.pictureBoxAva.InitialImage = null;
            this.pictureBoxAva.Location = new System.Drawing.Point(497, 142);
            this.pictureBoxAva.Name = "pictureBoxAva";
            this.pictureBoxAva.Size = new System.Drawing.Size(305, 357);
            this.pictureBoxAva.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAva.TabIndex = 1;
            this.pictureBoxAva.TabStop = false;
            // 
            // tabInfoCard
            // 
            this.tabInfoCard.Controls.Add(this.tabBioProfile);
            this.tabInfoCard.Controls.Add(this.tabPhotoCard);
            this.tabInfoCard.Controls.Add(this.tabContactsCard);
            this.tabInfoCard.Location = new System.Drawing.Point(13, 40);
            this.tabInfoCard.Name = "tabInfoCard";
            this.tabInfoCard.SelectedIndex = 0;
            this.tabInfoCard.Size = new System.Drawing.Size(461, 635);
            this.tabInfoCard.TabIndex = 0;
            // 
            // tabBioProfile
            // 
            this.tabBioProfile.BackColor = System.Drawing.Color.White;
            this.tabBioProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabBioProfile.Controls.Add(this.listBoxBio);
            this.tabBioProfile.Location = new System.Drawing.Point(4, 29);
            this.tabBioProfile.Name = "tabBioProfile";
            this.tabBioProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tabBioProfile.Size = new System.Drawing.Size(453, 602);
            this.tabBioProfile.TabIndex = 0;
            this.tabBioProfile.Text = "Биография";
            // 
            // listBoxBio
            // 
            this.listBoxBio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxBio.ColumnWidth = 50;
            this.listBoxBio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxBio.FormattingEnabled = true;
            this.listBoxBio.HorizontalScrollbar = true;
            this.listBoxBio.ItemHeight = 20;
            this.listBoxBio.Location = new System.Drawing.Point(3, 3);
            this.listBoxBio.Name = "listBoxBio";
            this.listBoxBio.ScrollAlwaysVisible = true;
            this.listBoxBio.Size = new System.Drawing.Size(445, 594);
            this.listBoxBio.TabIndex = 0;
            // 
            // tabPhotoCard
            // 
            this.tabPhotoCard.BackColor = System.Drawing.Color.White;
            this.tabPhotoCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPhotoCard.Controls.Add(this.listBoxPhoto);
            this.tabPhotoCard.Location = new System.Drawing.Point(4, 29);
            this.tabPhotoCard.Name = "tabPhotoCard";
            this.tabPhotoCard.Padding = new System.Windows.Forms.Padding(3);
            this.tabPhotoCard.Size = new System.Drawing.Size(453, 602);
            this.tabPhotoCard.TabIndex = 1;
            this.tabPhotoCard.Text = "Фотоальбом";
            //
            // listBoxPhoto
            // 
            this.listBoxPhoto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxPhoto.FormattingEnabled = true;
            this.listBoxPhoto.ItemHeight = 20;
            this.listBoxPhoto.Location = new System.Drawing.Point(3, 3);
            this.listBoxPhoto.Name = "listBoxPhoto";
            this.listBoxPhoto.Size = new System.Drawing.Size(445, 594);
            this.listBoxPhoto.TabIndex = 3;
            // 
            // tabContactsCard
            // 
            this.tabContactsCard.BackColor = System.Drawing.Color.White;
            this.tabContactsCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabContactsCard.Controls.Add(this.listBoxContacts);
            this.tabContactsCard.Location = new System.Drawing.Point(4, 29);
            this.tabContactsCard.Name = "tabContactsCard";
            this.tabContactsCard.Size = new System.Drawing.Size(453, 602);
            this.tabContactsCard.TabIndex = 2;
            this.tabContactsCard.Text = "Контакты";
            // 
            // listBoxContacts
            // 
            this.listBoxContacts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxContacts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxContacts.FormattingEnabled = true;
            this.listBoxContacts.ItemHeight = 20;
            this.listBoxContacts.Location = new System.Drawing.Point(0, 0);
            this.listBoxContacts.Name = "listBoxContacts";
            this.listBoxContacts.Size = new System.Drawing.Size(451, 600);
            this.listBoxContacts.TabIndex = 3;
            // 
            // tabDrevo
            // 
            this.tabDrevo.BackColor = System.Drawing.Color.White;
            this.tabDrevo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabDrevo.Controls.Add(this.panelTree);
            this.tabDrevo.Controls.Add(this.buttonDelete);
            this.tabDrevo.Controls.Add(this.buttonAddCard);
            this.tabDrevo.Location = new System.Drawing.Point(4, 29);
            this.tabDrevo.Name = "tabDrevo";
            this.tabDrevo.Padding = new System.Windows.Forms.Padding(10, 10, 10, 3);
            this.tabDrevo.Size = new System.Drawing.Size(839, 678);
            this.tabDrevo.TabIndex = 1;
            this.tabDrevo.Text = "Древо семьи";
            // 
            // panelTree
            // 
            this.panelTree.Controls.Add(this.pictureBoxTree);
            this.panelTree.Location = new System.Drawing.Point(9, 63);
            this.panelTree.Name = "panelTree";
            this.panelTree.Size = new System.Drawing.Size(809, 600);
            this.panelTree.TabIndex = 6;
            // 
            // pictureBoxTree
            // 
            this.pictureBoxTree.Location = new System.Drawing.Point(11, 12);
            this.pictureBoxTree.Name = "pictureBoxTree";
            this.pictureBoxTree.Size = new System.Drawing.Size(785, 587);
            this.pictureBoxTree.TabIndex = 0;
            this.pictureBoxTree.TabStop = false;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonDelete.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.Location = new System.Drawing.Point(677, 13);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(142, 31);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = false;
            //             
            // buttonAddCard
            // 
            this.buttonAddCard.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonAddCard.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAddCard.FlatAppearance.BorderSize = 0;
            this.buttonAddCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddCard.Location = new System.Drawing.Point(517, 13);
            this.buttonAddCard.Name = "buttonAddCard";
            this.buttonAddCard.Size = new System.Drawing.Size(154, 31);
            this.buttonAddCard.TabIndex = 1;
            this.buttonAddCard.Text = "Добавить";
            this.buttonAddCard.UseVisualStyleBackColor = false;
            this.buttonAddCard.Click += new System.EventHandler(this.buttonAddCard_Click);
            // 
            // tabSearch
            // 
            this.tabSearch.BackColor = System.Drawing.Color.White;
            this.tabSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabSearch.Controls.Add(this.label1);
            this.tabSearch.Controls.Add(this.panel1);
            this.tabSearch.Controls.Add(this.textBox1);
            this.tabSearch.Controls.Add(this.buttonSearch);
            this.tabSearch.Location = new System.Drawing.Point(4, 29);
            this.tabSearch.Name = "tabSearch";
            this.tabSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabSearch.Size = new System.Drawing.Size(839, 678);
            this.tabSearch.TabIndex = 2;
            this.tabSearch.Text = "Поиск";
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
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(38, 25);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(616, 28);
            this.textBox1.TabIndex = 1;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonSearch.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Location = new System.Drawing.Point(671, 24);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(119, 29);
            this.buttonSearch.TabIndex = 0;
            this.buttonSearch.Text = "Искать";
            this.buttonSearch.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button1.Location = new System.Drawing.Point(570, 613);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(874, 749);
            this.Controls.Add(this.tabMenu);
            this.Controls.Add(this.labelChk);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabMenu.ResumeLayout(false);
            this.tabMyProfile.ResumeLayout(false);
            this.tabMyProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAva)).EndInit();
            this.tabInfoCard.ResumeLayout(false);
            this.tabBioProfile.ResumeLayout(false);
            this.tabPhotoCard.ResumeLayout(false);
            this.tabContactsCard.ResumeLayout(false);
            this.tabDrevo.ResumeLayout(false);
            this.panelTree.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTree)).EndInit();
            this.tabSearch.ResumeLayout(false);
            this.tabSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Main_FormClosing1(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        #endregion
        private System.Windows.Forms.Label labelChk;
        private System.Windows.Forms.TabControl tabMenu;
        private System.Windows.Forms.TabPage tabMyProfile;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Label labelDataBorn;
        private System.Windows.Forms.Label labelFio;
        private System.Windows.Forms.PictureBox pictureBoxAva;
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
        private System.Windows.Forms.Button buttonDelete;
        private Panel panelTree;
        private PictureBox pictureBoxTree;
        private ListBox listBoxBio;
        private ListBox listBoxPhoto;
        private ListBox listBoxContacts;
        private Button button1;
    }
}