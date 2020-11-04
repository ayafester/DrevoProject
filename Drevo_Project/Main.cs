using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Drawing.Text;

namespace Drevo_Project
{
    public partial class Main : Form
    {

        private String dbName;
        private SQLiteConnection connect;
        private SQLiteCommand command;
        public Main()
        {
            InitializeComponent();
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            connect = new SQLiteConnection();
            command = new SQLiteCommand();

            dbName = "DrevoBD.sqlite";
            labelChk.Text = "Не соединено с БД";

            if (!File.Exists(dbName))
                SQLiteConnection.CreateFile(dbName);



            try
            {
                connect = new SQLiteConnection("Data Source=" + dbName + ";Version=3;");
                connect.Open();
                command.Connection = connect;

                command.CommandText = "CREATE TABLE IF NOT EXISTS Card (id INTEGER PRIMARY KEY AUTOINCREMENT, surname TEXT, name TEXT, middlename TEXT, bio TEXT, idContacts INTEGER, idPhotos INTEGER)";
                command.ExecuteNonQuery();

                labelChk.Text = "Cоединено с БД";
            }
            catch (SQLiteException ex)
            {
                labelChk.Text = "Не соединено с БД";
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            EditCard editCard = new EditCard();
            //editCard.Show();

            if(editCard.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void tabBioProfile_Click(object sender, EventArgs e) //Тут должен выполнятся вывод Биографии в поле tabBioProfile.Text
        {
            String sqlQuery1;
            sqlQuery1 = "SELECT CardID FROM User WHERE id = @DataCard.ID";

            SQLiteConnection connect2 = new SQLiteConnection("Data Source=" + dbName + ";Version=3;");
            connect2.Open();

            SQLiteCommand cmd = new SQLiteCommand(sqlQuery1, connect2);
            SQLiteDataAdapter adapter1 = new SQLiteDataAdapter(cmd);


            SQLiteDataReader SQL = cmd.ExecuteReader();

            while (SQL.Read())
            {
                DataClass.CardID = SQL["CardID"].ToString();
            }
            tabBioProfile.Text = DataClass.CardID; //Этот блок пока не работает так что TO DO

        }
    }
}
