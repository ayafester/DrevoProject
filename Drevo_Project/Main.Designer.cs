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
            this.components = new System.ComponentModel.Container();
            this.labelChk = new System.Windows.Forms.Label();
            this.tabMenu = new System.Windows.Forms.TabControl();
            this.tabMyProfile = new System.Windows.Forms.TabPage();
            this.ChangeNameAndYearsButton = new System.Windows.Forms.Button();
            this.MiddlenameBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.DeathdayBox = new System.Windows.Forms.TextBox();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.BirthdayBox = new System.Windows.Forms.TextBox();
            this.SurnameBox = new System.Windows.Forms.TextBox();
            this.pictureBoxAva = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.tabInfoCard = new System.Windows.Forms.TabControl();
            this.tabBioProfile = new System.Windows.Forms.TabPage();
            this.tabPhotoCard = new System.Windows.Forms.TabPage();
            this.listBoxPhoto = new System.Windows.Forms.ListBox();
            this.tabContactsCard = new System.Windows.Forms.TabPage();
            this.ChangeContactsButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MailBox = new System.Windows.Forms.TextBox();
            this.NumberBox = new System.Windows.Forms.TextBox();
            this.listBoxContacts = new System.Windows.Forms.ListBox();
            this.tabDrevo = new System.Windows.Forms.TabPage();
            this.panelTree = new System.Windows.Forms.Panel();
            this.pictureBoxTree = new System.Windows.Forms.PictureBox();
            this.tabRelatives = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAddCard = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.tabPhotoAlbum = new System.Windows.Forms.TabPage();
            this.textBoxBio = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ChangeBioButton = new System.Windows.Forms.Button();
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
            this.tabRelatives.SuspendLayout();
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
            this.tabMenu.Controls.Add(this.tabRelatives);
            this.tabMenu.Controls.Add(this.tabPhotoAlbum);
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
            this.tabMyProfile.Controls.Add(this.ChangeNameAndYearsButton);
            this.tabMyProfile.Controls.Add(this.MiddlenameBox);
            this.tabMyProfile.Controls.Add(this.NameBox);
            this.tabMyProfile.Controls.Add(this.DeathdayBox);
            this.tabMyProfile.Controls.Add(this.AgeLabel);
            this.tabMyProfile.Controls.Add(this.BirthdayBox);
            this.tabMyProfile.Controls.Add(this.SurnameBox);
            this.tabMyProfile.Controls.Add(this.pictureBoxAva);
            this.tabMyProfile.Controls.Add(this.button1);
            this.tabMyProfile.Controls.Add(this.buttonEdit);
            this.tabMyProfile.Controls.Add(this.tabInfoCard);
            this.tabMyProfile.Location = new System.Drawing.Point(4, 29);
            this.tabMyProfile.Name = "tabMyProfile";
            this.tabMyProfile.Padding = new System.Windows.Forms.Padding(10);
            this.tabMyProfile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabMyProfile.Size = new System.Drawing.Size(842, 678);
            this.tabMyProfile.TabIndex = 0;
            this.tabMyProfile.Text = "Мой профиль";
            // 
            // ChangeNameAndYearsButton
            // 
            this.ChangeNameAndYearsButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ChangeNameAndYearsButton.FlatAppearance.BorderSize = 0;
            this.ChangeNameAndYearsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeNameAndYearsButton.Location = new System.Drawing.Point(485, 178);
            this.ChangeNameAndYearsButton.Name = "ChangeNameAndYearsButton";
            this.ChangeNameAndYearsButton.Size = new System.Drawing.Size(97, 33);
            this.ChangeNameAndYearsButton.TabIndex = 27;
            this.ChangeNameAndYearsButton.Text = "Изменить";
            this.ChangeNameAndYearsButton.UseVisualStyleBackColor = false;
            // 
            // MiddlenameBox
            // 
            this.MiddlenameBox.Location = new System.Drawing.Point(485, 134);
            this.MiddlenameBox.Name = "MiddlenameBox";
            this.MiddlenameBox.Size = new System.Drawing.Size(153, 26);
            this.MiddlenameBox.TabIndex = 32;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(485, 102);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(153, 26);
            this.NameBox.TabIndex = 31;
            // 
            // DeathdayBox
            // 
            this.DeathdayBox.Location = new System.Drawing.Point(668, 102);
            this.DeathdayBox.Name = "DeathdayBox";
            this.DeathdayBox.Size = new System.Drawing.Size(87, 26);
            this.DeathdayBox.TabIndex = 30;
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Location = new System.Drawing.Point(664, 137);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(0, 20);
            this.AgeLabel.TabIndex = 29;
            // 
            // BirthdayBox
            // 
            this.BirthdayBox.Location = new System.Drawing.Point(668, 71);
            this.BirthdayBox.Name = "BirthdayBox";
            this.BirthdayBox.Size = new System.Drawing.Size(87, 26);
            this.BirthdayBox.TabIndex = 28;
            // 
            // SurnameBox
            // 
            this.SurnameBox.Location = new System.Drawing.Point(485, 70);
            this.SurnameBox.Name = "SurnameBox";
            this.SurnameBox.Size = new System.Drawing.Size(153, 26);
            this.SurnameBox.TabIndex = 26;
            // 
            // pictureBoxAva
            // 
            this.pictureBoxAva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxAva.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pictureBoxAva.ErrorImage = null;
            this.pictureBoxAva.Image = global::Drevo_Project.Properties.Resources.logo;
            this.pictureBoxAva.InitialImage = null;
            this.pictureBoxAva.Location = new System.Drawing.Point(530, 239);
            this.pictureBoxAva.Name = "pictureBoxAva";
            this.pictureBoxAva.Size = new System.Drawing.Size(249, 280);
            this.pictureBoxAva.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAva.TabIndex = 25;
            this.pictureBoxAva.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(570, 608);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 38);
            this.button1.TabIndex = 5;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.DarkSeaGreen;
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
            this.tabBioProfile.AutoScroll = true;
            this.tabBioProfile.BackColor = System.Drawing.Color.White;
            this.tabBioProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabBioProfile.Controls.Add(this.ChangeBioButton);
            this.tabBioProfile.Controls.Add(this.textBoxBio);
            this.tabBioProfile.Location = new System.Drawing.Point(4, 29);
            this.tabBioProfile.Name = "tabBioProfile";
            this.tabBioProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tabBioProfile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabBioProfile.Size = new System.Drawing.Size(453, 602);
            this.tabBioProfile.TabIndex = 0;
            this.tabBioProfile.Text = "Биография";
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
            this.tabContactsCard.Controls.Add(this.ChangeContactsButton);
            this.tabContactsCard.Controls.Add(this.label5);
            this.tabContactsCard.Controls.Add(this.label4);
            this.tabContactsCard.Controls.Add(this.MailBox);
            this.tabContactsCard.Controls.Add(this.NumberBox);
            this.tabContactsCard.Controls.Add(this.listBoxContacts);
            this.tabContactsCard.Location = new System.Drawing.Point(4, 29);
            this.tabContactsCard.Name = "tabContactsCard";
            this.tabContactsCard.Size = new System.Drawing.Size(453, 602);
            this.tabContactsCard.TabIndex = 2;
            this.tabContactsCard.Text = "Контакты";
            // 
            // ChangeContactsButton
            // 
            this.ChangeContactsButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ChangeContactsButton.FlatAppearance.BorderSize = 0;
            this.ChangeContactsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeContactsButton.Location = new System.Drawing.Point(90, 135);
            this.ChangeContactsButton.Name = "ChangeContactsButton";
            this.ChangeContactsButton.Size = new System.Drawing.Size(97, 33);
            this.ChangeContactsButton.TabIndex = 8;
            this.ChangeContactsButton.Text = "Изменить";
            this.ChangeContactsButton.UseVisualStyleBackColor = false;
            this.ChangeContactsButton.Click += new System.EventHandler(this.ChangeContactsButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Почта: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Номер: ";
            // 
            // MailBox
            // 
            this.MailBox.Location = new System.Drawing.Point(101, 86);
            this.MailBox.Name = "MailBox";
            this.MailBox.Size = new System.Drawing.Size(170, 26);
            this.MailBox.TabIndex = 7;
            // 
            // NumberBox
            // 
            this.NumberBox.Location = new System.Drawing.Point(101, 36);
            this.NumberBox.Name = "NumberBox";
            this.NumberBox.Size = new System.Drawing.Size(170, 26);
            this.NumberBox.TabIndex = 4;
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
            this.tabDrevo.Location = new System.Drawing.Point(4, 29);
            this.tabDrevo.Name = "tabDrevo";
            this.tabDrevo.Padding = new System.Windows.Forms.Padding(10, 10, 10, 3);
            this.tabDrevo.Size = new System.Drawing.Size(842, 678);
            this.tabDrevo.TabIndex = 1;
            this.tabDrevo.Text = "Древо семьи";
            // 
            // panelTree
            // 
            this.panelTree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTree.Controls.Add(this.pictureBoxTree);
            this.panelTree.Location = new System.Drawing.Point(9, 13);
            this.panelTree.Name = "panelTree";
            this.panelTree.Size = new System.Drawing.Size(809, 650);
            this.panelTree.TabIndex = 6;
            // 
            // pictureBoxTree
            // 
            this.pictureBoxTree.Location = new System.Drawing.Point(4, 3);
            this.pictureBoxTree.Name = "pictureBoxTree";
            this.pictureBoxTree.Size = new System.Drawing.Size(802, 634);
            this.pictureBoxTree.TabIndex = 0;
            this.pictureBoxTree.TabStop = false;
            // 
            // tabRelatives
            // 
            this.tabRelatives.BackColor = System.Drawing.Color.White;
            this.tabRelatives.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabRelatives.Controls.Add(this.label3);
            this.tabRelatives.Controls.Add(this.label2);
            this.tabRelatives.Controls.Add(this.buttonDelete);
            this.tabRelatives.Controls.Add(this.buttonAddCard);
            this.tabRelatives.Controls.Add(this.searchBox);
            this.tabRelatives.Controls.Add(this.buttonSearch);
            this.tabRelatives.Location = new System.Drawing.Point(4, 29);
            this.tabRelatives.Name = "tabRelatives";
            this.tabRelatives.Padding = new System.Windows.Forms.Padding(3);
            this.tabRelatives.Size = new System.Drawing.Size(842, 678);
            this.tabRelatives.TabIndex = 2;
            this.tabRelatives.Text = "Родственники";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Поиск:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Список родственников:";
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.Location = new System.Drawing.Point(215, 621);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(154, 31);
            this.buttonDelete.TabIndex = 9;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = false;
            // 
            // buttonAddCard
            // 
            this.buttonAddCard.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonAddCard.FlatAppearance.BorderSize = 0;
            this.buttonAddCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddCard.Location = new System.Drawing.Point(46, 621);
            this.buttonAddCard.Name = "buttonAddCard";
            this.buttonAddCard.Size = new System.Drawing.Size(154, 31);
            this.buttonAddCard.TabIndex = 8;
            this.buttonAddCard.Text = "Добавить";
            this.buttonAddCard.UseVisualStyleBackColor = false;
            this.buttonAddCard.Click += new System.EventHandler(this.buttonAddCard_Click);
            // 
            // searchBox
            // 
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBox.Location = new System.Drawing.Point(107, 21);
            this.searchBox.Multiline = true;
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(555, 27);
            this.searchBox.TabIndex = 5;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Location = new System.Drawing.Point(679, 20);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(119, 28);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "Искать";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // tabPhotoAlbum
            // 
            this.tabPhotoAlbum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPhotoAlbum.Location = new System.Drawing.Point(4, 29);
            this.tabPhotoAlbum.Name = "tabPhotoAlbum";
            this.tabPhotoAlbum.Size = new System.Drawing.Size(842, 678);
            this.tabPhotoAlbum.TabIndex = 3;
            this.tabPhotoAlbum.Text = "Общий фотоальбом";
            this.tabPhotoAlbum.UseVisualStyleBackColor = true;
            // 
            // textBoxBio
            // 
            this.textBoxBio.Location = new System.Drawing.Point(-1, -1);
            this.textBoxBio.Multiline = true;
            this.textBoxBio.Name = "textBoxBio";
            this.textBoxBio.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxBio.Size = new System.Drawing.Size(447, 554);
            this.textBoxBio.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ChangeBioButton
            // 
            this.ChangeBioButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ChangeBioButton.FlatAppearance.BorderSize = 0;
            this.ChangeBioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeBioButton.Location = new System.Drawing.Point(6, 560);
            this.ChangeBioButton.Name = "ChangeBioButton";
            this.ChangeBioButton.Size = new System.Drawing.Size(97, 33);
            this.ChangeBioButton.TabIndex = 33;
            this.ChangeBioButton.Text = "Изменить";
            this.ChangeBioButton.UseVisualStyleBackColor = false;
            this.ChangeBioButton.Click += new System.EventHandler(this.ChangeBioButton_Click);
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
            this.tabBioProfile.PerformLayout();
            this.tabPhotoCard.ResumeLayout(false);
            this.tabContactsCard.ResumeLayout(false);
            this.tabContactsCard.PerformLayout();
            this.tabDrevo.ResumeLayout(false);
            this.panelTree.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTree)).EndInit();
            this.tabRelatives.ResumeLayout(false);
            this.tabRelatives.PerformLayout();
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
        private System.Windows.Forms.TabControl tabInfoCard;
        private System.Windows.Forms.TabPage tabBioProfile;
        private System.Windows.Forms.TabPage tabPhotoCard;
        private System.Windows.Forms.TabPage tabContactsCard;
        private System.Windows.Forms.TabPage tabDrevo;
        private System.Windows.Forms.TabPage tabRelatives;
        private Panel panelTree;
        private PictureBox pictureBoxTree;
        private ListBox listBoxPhoto;
        private ListBox listBoxContacts;
        private Button button1;
        private Label label3;
        private Label label2;
        private Button buttonDelete;
        private Button buttonAddCard;
        private TextBox searchBox;
        private Button buttonSearch;
        private TabPage tabPhotoAlbum;
        private Button ChangeContactsButton;
        private Label label5;
        private Label label4;
        private TextBox MailBox;
        private TextBox NumberBox;
        private Button ChangeNameAndYearsButton;
        private TextBox MiddlenameBox;
        private TextBox NameBox;
        private TextBox DeathdayBox;
        private Label AgeLabel;
        private TextBox BirthdayBox;
        private TextBox SurnameBox;
        private PictureBox pictureBoxAva;
        private TextBox textBoxBio;
        private ContextMenuStrip contextMenuStrip1;
        private Button ChangeBioButton;
    }
}