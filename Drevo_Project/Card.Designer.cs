namespace Drevo_Project
{
    partial class Card
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
            this.buttonEditCard = new System.Windows.Forms.Button();
            this.labelDataBornCard = new System.Windows.Forms.Label();
            this.labelFioCard = new System.Windows.Forms.Label();
            this.pictureCard = new System.Windows.Forms.PictureBox();
            this.tabInfoCard = new System.Windows.Forms.TabControl();
            this.tabBioCard = new System.Windows.Forms.TabPage();
            this.labelBioCard = new System.Windows.Forms.Label();
            this.labelBio = new System.Windows.Forms.Label();
            this.tabPhotoCard = new System.Windows.Forms.TabPage();
            this.tabContactsCard = new System.Windows.Forms.TabPage();
            this.MailBoxCard = new System.Windows.Forms.Label();
            this.NumberBoxCard = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCard)).BeginInit();
            this.tabInfoCard.SuspendLayout();
            this.tabBioCard.SuspendLayout();
            this.tabContactsCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonEditCard
            // 
            this.buttonEditCard.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonEditCard.FlatAppearance.BorderSize = 0;
            this.buttonEditCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEditCard.Location = new System.Drawing.Point(594, 600);
            this.buttonEditCard.Name = "buttonEditCard";
            this.buttonEditCard.Size = new System.Drawing.Size(163, 51);
            this.buttonEditCard.TabIndex = 9;
            this.buttonEditCard.Text = "Редактировать";
            this.buttonEditCard.UseVisualStyleBackColor = false;
            this.buttonEditCard.Click += new System.EventHandler(this.buttonEditCard_Click);
            // 
            // labelDataBornCard
            // 
            this.labelDataBornCard.AutoSize = true;
            this.labelDataBornCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDataBornCard.Location = new System.Drawing.Point(497, 88);
            this.labelDataBornCard.Name = "labelDataBornCard";
            this.labelDataBornCard.Size = new System.Drawing.Size(86, 20);
            this.labelDataBornCard.TabIndex = 8;
            this.labelDataBornCard.Text = "1900-2000";
            // 
            // labelFioCard
            // 
            this.labelFioCard.AutoSize = true;
            this.labelFioCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFioCard.Location = new System.Drawing.Point(497, 49);
            this.labelFioCard.Name = "labelFioCard";
            this.labelFioCard.Size = new System.Drawing.Size(194, 20);
            this.labelFioCard.TabIndex = 7;
            this.labelFioCard.Text = "Фамилия Имя Отчество";
            // 
            // pictureCard
            // 
            this.pictureCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureCard.Image = global::Drevo_Project.Properties.Resources.logo;
            this.pictureCard.Location = new System.Drawing.Point(516, 186);
            this.pictureCard.Name = "pictureCard";
            this.pictureCard.Size = new System.Drawing.Size(305, 389);
            this.pictureCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureCard.TabIndex = 6;
            this.pictureCard.TabStop = false;
            // 
            // tabInfoCard
            // 
            this.tabInfoCard.Controls.Add(this.tabBioCard);
            this.tabInfoCard.Controls.Add(this.tabPhotoCard);
            this.tabInfoCard.Controls.Add(this.tabContactsCard);
            this.tabInfoCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabInfoCard.Location = new System.Drawing.Point(12, 20);
            this.tabInfoCard.Name = "tabInfoCard";
            this.tabInfoCard.SelectedIndex = 0;
            this.tabInfoCard.Size = new System.Drawing.Size(461, 647);
            this.tabInfoCard.TabIndex = 5;
            // 
            // tabBioCard
            // 
            this.tabBioCard.AutoScroll = true;
            this.tabBioCard.Controls.Add(this.labelBioCard);
            this.tabBioCard.Controls.Add(this.labelBio);
            this.tabBioCard.Location = new System.Drawing.Point(4, 29);
            this.tabBioCard.Name = "tabBioCard";
            this.tabBioCard.Padding = new System.Windows.Forms.Padding(3);
            this.tabBioCard.Size = new System.Drawing.Size(453, 614);
            this.tabBioCard.TabIndex = 0;
            this.tabBioCard.Text = "Биография";
            this.tabBioCard.UseVisualStyleBackColor = true;
            // 
            // labelBioCard
            // 
            this.labelBioCard.AutoSize = true;
            this.labelBioCard.Location = new System.Drawing.Point(6, 3);
            this.labelBioCard.MaximumSize = new System.Drawing.Size(400, 0);
            this.labelBioCard.Name = "labelBioCard";
            this.labelBioCard.Size = new System.Drawing.Size(51, 20);
            this.labelBioCard.TabIndex = 1;
            this.labelBioCard.Text = "label1";
            // 
            // labelBio
            // 
            this.labelBio.AutoSize = true;
            this.labelBio.Location = new System.Drawing.Point(16, 17);
            this.labelBio.MaximumSize = new System.Drawing.Size(500, 0);
            this.labelBio.Name = "labelBio";
            this.labelBio.Size = new System.Drawing.Size(0, 20);
            this.labelBio.TabIndex = 0;
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
            this.tabContactsCard.Controls.Add(this.MailBoxCard);
            this.tabContactsCard.Controls.Add(this.NumberBoxCard);
            this.tabContactsCard.Controls.Add(this.label5);
            this.tabContactsCard.Controls.Add(this.label4);
            this.tabContactsCard.Location = new System.Drawing.Point(4, 29);
            this.tabContactsCard.Name = "tabContactsCard";
            this.tabContactsCard.Size = new System.Drawing.Size(453, 614);
            this.tabContactsCard.TabIndex = 2;
            this.tabContactsCard.Text = "Контакты";
            this.tabContactsCard.UseVisualStyleBackColor = true;
            // 
            // MailBoxCard
            // 
            this.MailBoxCard.AutoSize = true;
            this.MailBoxCard.Location = new System.Drawing.Point(107, 72);
            this.MailBoxCard.Name = "MailBoxCard";
            this.MailBoxCard.Size = new System.Drawing.Size(13, 20);
            this.MailBoxCard.TabIndex = 11;
            this.MailBoxCard.Text = " ";
            // 
            // NumberBoxCard
            // 
            this.NumberBoxCard.AutoSize = true;
            this.NumberBoxCard.Location = new System.Drawing.Point(107, 27);
            this.NumberBoxCard.Name = "NumberBoxCard";
            this.NumberBoxCard.Size = new System.Drawing.Size(13, 20);
            this.NumberBoxCard.TabIndex = 10;
            this.NumberBoxCard.Text = " ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Почта: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Номер: ";
            // 
            // Card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(888, 690);
            this.Controls.Add(this.buttonEditCard);
            this.Controls.Add(this.labelDataBornCard);
            this.Controls.Add(this.labelFioCard);
            this.Controls.Add(this.pictureCard);
            this.Controls.Add(this.tabInfoCard);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "Card";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.Card_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureCard)).EndInit();
            this.tabInfoCard.ResumeLayout(false);
            this.tabBioCard.ResumeLayout(false);
            this.tabBioCard.PerformLayout();
            this.tabContactsCard.ResumeLayout(false);
            this.tabContactsCard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEditCard;
        private System.Windows.Forms.Label labelDataBornCard;
        private System.Windows.Forms.Label labelFioCard;
        private System.Windows.Forms.TabControl tabInfoCard;
        private System.Windows.Forms.TabPage tabBioCard;
        private System.Windows.Forms.TabPage tabPhotoCard;
        private System.Windows.Forms.TabPage tabContactsCard;
        private System.Windows.Forms.Label labelBio;
        private System.Windows.Forms.Label labelBioCard;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label MailBoxCard;
        private System.Windows.Forms.Label NumberBoxCard;
        public System.Windows.Forms.PictureBox pictureCard;
    }
}