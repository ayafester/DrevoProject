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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ChangeNameAndYearsButton = new System.Windows.Forms.Button();
            this.MiddlenameBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.DeathdayBox = new System.Windows.Forms.TextBox();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.BirthdayBox = new System.Windows.Forms.TextBox();
            this.SurnameBox = new System.Windows.Forms.TextBox();
            this.pictureBoxAva = new System.Windows.Forms.PictureBox();
            this.tabInfoCard = new System.Windows.Forms.TabControl();
            this.tabBioProfile = new System.Windows.Forms.TabPage();
            this.ChangeBioButton = new System.Windows.Forms.Button();
            this.textBoxBio = new System.Windows.Forms.TextBox();
            this.tabPhotoCard = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabContactsCard = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxFather = new System.Windows.Forms.ComboBox();
            this.comboBoxMother = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
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
            this.comboBoxSearch = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAddCard = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.tabMenu.SuspendLayout();
            this.tabMyProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAva)).BeginInit();
            this.tabInfoCard.SuspendLayout();
            this.tabBioProfile.SuspendLayout();
            this.tabPhotoCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.tabMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabMenu.Location = new System.Drawing.Point(12, 5);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedIndex = 0;
            this.tabMenu.Size = new System.Drawing.Size(850, 718);
            this.tabMenu.TabIndex = 3;
            // 
            // tabMyProfile
            // 
            this.tabMyProfile.BackColor = System.Drawing.Color.White;
            this.tabMyProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabMyProfile.Controls.Add(this.button3);
            this.tabMyProfile.Controls.Add(this.button2);
            this.tabMyProfile.Controls.Add(this.label6);
            this.tabMyProfile.Controls.Add(this.label1);
            this.tabMyProfile.Controls.Add(this.ChangeNameAndYearsButton);
            this.tabMyProfile.Controls.Add(this.MiddlenameBox);
            this.tabMyProfile.Controls.Add(this.NameBox);
            this.tabMyProfile.Controls.Add(this.DeathdayBox);
            this.tabMyProfile.Controls.Add(this.AgeLabel);
            this.tabMyProfile.Controls.Add(this.BirthdayBox);
            this.tabMyProfile.Controls.Add(this.SurnameBox);
            this.tabMyProfile.Controls.Add(this.pictureBoxAva);
            this.tabMyProfile.Controls.Add(this.tabInfoCard);
            this.tabMyProfile.Location = new System.Drawing.Point(4, 29);
            this.tabMyProfile.Name = "tabMyProfile";
            this.tabMyProfile.Padding = new System.Windows.Forms.Padding(10);
            this.tabMyProfile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabMyProfile.Size = new System.Drawing.Size(842, 685);
            this.tabMyProfile.TabIndex = 0;
            this.tabMyProfile.Text = "Мой профиль";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(539, 637);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 33);
            this.button3.TabIndex = 36;
            this.button3.Text = "Сменить";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(662, 637);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 33);
            this.button2.TabIndex = 35;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(667, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 20);
            this.label6.TabIndex = 34;
            this.label6.Text = "д.с.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(667, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "д.р.";
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
            this.ChangeNameAndYearsButton.Click += new System.EventHandler(this.ChangeNameAndYearsButton_Click_1);
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
            this.DeathdayBox.Location = new System.Drawing.Point(708, 100);
            this.DeathdayBox.Name = "DeathdayBox";
            this.DeathdayBox.Size = new System.Drawing.Size(87, 26);
            this.DeathdayBox.TabIndex = 30;
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Location = new System.Drawing.Point(704, 135);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(0, 20);
            this.AgeLabel.TabIndex = 29;
            // 
            // BirthdayBox
            // 
            this.BirthdayBox.Location = new System.Drawing.Point(708, 69);
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
            this.pictureBoxAva.Location = new System.Drawing.Point(515, 239);
            this.pictureBoxAva.Name = "pictureBoxAva";
            this.pictureBoxAva.Size = new System.Drawing.Size(280, 384);
            this.pictureBoxAva.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAva.TabIndex = 25;
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
            // textBoxBio
            // 
            this.textBoxBio.Location = new System.Drawing.Point(-1, -1);
            this.textBoxBio.Multiline = true;
            this.textBoxBio.Name = "textBoxBio";
            this.textBoxBio.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxBio.Size = new System.Drawing.Size(447, 554);
            this.textBoxBio.TabIndex = 2;
            // 
            // tabPhotoCard
            // 
            this.tabPhotoCard.BackColor = System.Drawing.Color.White;
            this.tabPhotoCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPhotoCard.Controls.Add(this.button5);
            this.tabPhotoCard.Controls.Add(this.listView1);
            this.tabPhotoCard.Controls.Add(this.button4);
            this.tabPhotoCard.Controls.Add(this.button1);
            this.tabPhotoCard.Controls.Add(this.pictureBox1);
            this.tabPhotoCard.Location = new System.Drawing.Point(4, 29);
            this.tabPhotoCard.Name = "tabPhotoCard";
            this.tabPhotoCard.Padding = new System.Windows.Forms.Padding(3);
            this.tabPhotoCard.Size = new System.Drawing.Size(453, 602);
            this.tabPhotoCard.TabIndex = 1;
            this.tabPhotoCard.Text = "Фотоальбом";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(237, 560);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(103, 33);
            this.button5.TabIndex = 42;
            this.button5.Text = "Удалить";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(-1, 164);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(453, 390);
            this.listView1.TabIndex = 41;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.SmallIcon;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Изображение";
            this.columnHeader1.Width = 150;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(118, 560);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 33);
            this.button4.TabIndex = 39;
            this.button4.Text = "Сохранить";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(6, 560);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 33);
            this.button1.TabIndex = 38;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::Drevo_Project.Properties.Resources.logo;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // tabContactsCard
            // 
            this.tabContactsCard.BackColor = System.Drawing.Color.White;
            this.tabContactsCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabContactsCard.Controls.Add(this.label10);
            this.tabContactsCard.Controls.Add(this.label9);
            this.tabContactsCard.Controls.Add(this.label8);
            this.tabContactsCard.Controls.Add(this.comboBoxFather);
            this.tabContactsCard.Controls.Add(this.comboBoxMother);
            this.tabContactsCard.Controls.Add(this.label7);
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(67, 268);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Папа:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(64, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Мама:";
            // 
            // comboBoxFather
            // 
            this.comboBoxFather.FormattingEnabled = true;
            this.comboBoxFather.Location = new System.Drawing.Point(157, 268);
            this.comboBoxFather.Name = "comboBoxFather";
            this.comboBoxFather.Size = new System.Drawing.Size(172, 28);
            this.comboBoxFather.TabIndex = 11;
            this.comboBoxFather.SelectedIndexChanged += new System.EventHandler(this.ComboBoxFather_SelectedIndexChanged);
            // 
            // comboBoxMother
            // 
            this.comboBoxMother.FormattingEnabled = true;
            this.comboBoxMother.Location = new System.Drawing.Point(159, 217);
            this.comboBoxMother.Name = "comboBoxMother";
            this.comboBoxMother.Size = new System.Drawing.Size(172, 28);
            this.comboBoxMother.TabIndex = 10;
            this.comboBoxMother.SelectedIndexChanged += new System.EventHandler(this.ComboBoxMother_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Родители:";
            // 
            // ChangeContactsButton
            // 
            this.ChangeContactsButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ChangeContactsButton.FlatAppearance.BorderSize = 0;
            this.ChangeContactsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeContactsButton.Location = new System.Drawing.Point(6, 560);
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
            this.label5.Location = new System.Drawing.Point(64, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Почта: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Номер: ";
            // 
            // MailBox
            // 
            this.MailBox.Location = new System.Drawing.Point(159, 89);
            this.MailBox.Name = "MailBox";
            this.MailBox.Size = new System.Drawing.Size(170, 26);
            this.MailBox.TabIndex = 7;
            // 
            // NumberBox
            // 
            this.NumberBox.Location = new System.Drawing.Point(159, 39);
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
            this.tabDrevo.Size = new System.Drawing.Size(842, 685);
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
            this.tabRelatives.Controls.Add(this.comboBoxSearch);
            this.tabRelatives.Controls.Add(this.listBox1);
            this.tabRelatives.Controls.Add(this.label3);
            this.tabRelatives.Controls.Add(this.label2);
            this.tabRelatives.Controls.Add(this.buttonDelete);
            this.tabRelatives.Controls.Add(this.buttonAddCard);
            this.tabRelatives.Controls.Add(this.buttonSearch);
            this.tabRelatives.Location = new System.Drawing.Point(4, 29);
            this.tabRelatives.Name = "tabRelatives";
            this.tabRelatives.Padding = new System.Windows.Forms.Padding(3);
            this.tabRelatives.Size = new System.Drawing.Size(842, 685);
            this.tabRelatives.TabIndex = 2;
            this.tabRelatives.Text = "Родственники";
            // 
            // comboBoxSearch
            // 
            this.comboBoxSearch.FormattingEnabled = true;
            this.comboBoxSearch.Location = new System.Drawing.Point(117, 20);
            this.comboBoxSearch.Name = "comboBoxSearch";
            this.comboBoxSearch.Size = new System.Drawing.Size(543, 28);
            this.comboBoxSearch.TabIndex = 13;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(46, 104);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(752, 484);
            this.listBox1.TabIndex = 12;
            this.listBox1.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.listBox1_Format);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Поиск:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 68);
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
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
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
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Location = new System.Drawing.Point(679, 20);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(119, 28);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "Показать";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(178, 404);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 20);
            this.label10.TabIndex = 14;
            this.label10.Text = "label10";
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
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabMenu.ResumeLayout(false);
            this.tabMyProfile.ResumeLayout(false);
            this.tabMyProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAva)).EndInit();
            this.tabInfoCard.ResumeLayout(false);
            this.tabBioProfile.ResumeLayout(false);
            this.tabBioProfile.PerformLayout();
            this.tabPhotoCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.TabControl tabInfoCard;
        private System.Windows.Forms.TabPage tabBioProfile;
        private System.Windows.Forms.TabPage tabContactsCard;
        private System.Windows.Forms.TabPage tabDrevo;
        private System.Windows.Forms.TabPage tabRelatives;
        private Panel panelTree;
        private PictureBox pictureBoxTree;
        private ListBox listBoxContacts;
        private Label label3;
        private Label label2;
        private Button buttonDelete;
        private Button buttonAddCard;
        private Button buttonSearch;
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
        private Label label1;
        private Label label6;
        private Button button2;
        private Button button3;
        private ListBox listBox1;
        private TabPage tabPhotoCard;
        private Button button4;
        private Button button1;
        private PictureBox pictureBox1;
        private ComboBox comboBoxSearch;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private Label label9;
        private Label label8;
        private ComboBox comboBoxFather;
        private ComboBox comboBoxMother;
        private Label label7;
        private Button button5;
        private Label label10;
    }
}