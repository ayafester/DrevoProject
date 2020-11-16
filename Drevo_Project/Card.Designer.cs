﻿namespace Drevo_Project
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
            this.tabPhotoCard = new System.Windows.Forms.TabPage();
            this.tabContactsCard = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCard)).BeginInit();
            this.tabInfoCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonEditCard
            // 
            this.buttonEditCard.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonEditCard.FlatAppearance.BorderSize = 0;
            this.buttonEditCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEditCard.Location = new System.Drawing.Point(592, 537);
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
            this.labelDataBornCard.Location = new System.Drawing.Point(524, 76);
            this.labelDataBornCard.Name = "labelDataBornCard";
            this.labelDataBornCard.Size = new System.Drawing.Size(86, 20);
            this.labelDataBornCard.TabIndex = 8;
            this.labelDataBornCard.Text = "1900-2000";
            // 
            // labelFioCard
            // 
            this.labelFioCard.AutoSize = true;
            this.labelFioCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFioCard.Location = new System.Drawing.Point(524, 42);
            this.labelFioCard.Name = "labelFioCard";
            this.labelFioCard.Size = new System.Drawing.Size(194, 20);
            this.labelFioCard.TabIndex = 7;
            this.labelFioCard.Text = "Фамилия Имя Отчество";
            // 
            // pictureCard
            // 
            this.pictureCard.Location = new System.Drawing.Point(527, 121);
            this.pictureCard.Name = "pictureCard";
            this.pictureCard.Size = new System.Drawing.Size(305, 389);
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
            this.tabBioCard.Location = new System.Drawing.Point(4, 29);
            this.tabBioCard.Name = "tabBioCard";
            this.tabBioCard.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabBioCard.Size = new System.Drawing.Size(453, 614);
            this.tabBioCard.TabIndex = 0;
            this.tabBioCard.Text = "Биография";
            this.tabBioCard.UseVisualStyleBackColor = true;
            // 
            // tabPhotoCard
            // 
            this.tabPhotoCard.Location = new System.Drawing.Point(4, 29);
            this.tabPhotoCard.Name = "tabPhotoCard";
            this.tabPhotoCard.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureCard)).EndInit();
            this.tabInfoCard.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEditCard;
        private System.Windows.Forms.Label labelDataBornCard;
        private System.Windows.Forms.Label labelFioCard;
        private System.Windows.Forms.PictureBox pictureCard;
        private System.Windows.Forms.TabControl tabInfoCard;
        private System.Windows.Forms.TabPage tabBioCard;
        private System.Windows.Forms.TabPage tabPhotoCard;
        private System.Windows.Forms.TabPage tabContactsCard;
    }
}