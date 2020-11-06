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

        ConnectBD sql = new ConnectBD();
        public Main()
        {
            InitializeComponent();
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            

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

            SQLiteCommand cmd = new SQLiteCommand(sqlQuery1, sql.connect);
            SQLiteDataAdapter adapter1 = new SQLiteDataAdapter(cmd);

            SQLiteDataReader SQL = cmd.ExecuteReader();

            
            DataClass.CardID = SQL.ToString();
            
            //Этот блок пока не работает так что TO DO

        }
    }
}
