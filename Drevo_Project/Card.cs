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
using System.Windows.Markup;

namespace Drevo_Project
{

    public partial class Card : Form
    {
        ConnectBD sql = new ConnectBD();
        public int MyId { get; set; } // это для выгрузки данных по пришедшему айди у человека
        public Card(int id) //когда вызываешь форму эту модальную, надо туда указывать айди человека которого хотим взять данные
        {
            MyId = id;
            InitializeComponent();
        }


        private void Card_Load(object sender, EventArgs e) 
        {
            
            try
            {
                sql.command.CommandText = "SELECT * FROM User WHERE id='" + MyId + "' ";
                //SQLiteDataAdapter adapter1 = new SQLiteDataAdapter(sql.command.Connection);

                SQLiteDataReader read = sql.command.ExecuteReader();

                while (read.Read())
                {
                    DataClass.CardID = read["idCard"].ToString();
                }
                read.Close();

                sql.command.CommandText = "SELECT * FROM Card WHERE id = '" + MyId + "' ";
                SQLiteDataReader read2 = sql.command.ExecuteReader();
                while (read2.Read())
                {
                    labelFioCard.Text = read2["surname"].ToString() + " " + read2["name"].ToString() + " " + read2["middlename"].ToString();

                    labelBioCard.Text = Convert.ToString(read2["bio"]);
                    if (read2["deathday"].ToString() == "")
                    {
                        labelDataBornCard.Text = read2["birthday"].ToString() + "";
                    }
                    else
                    {
                        labelDataBornCard.Text = read2["birthday"].ToString() + "-" + read2["deathday"].ToString();
                    }
                }
                read2.Close();

                sql.command.CommandText = "SELECT * FROM Card WHERE id = '" + MyId + "' ";
                SQLiteDataReader read3 = sql.command.ExecuteReader();

                while (read3.Read())
                {
                    NumberBoxCard.Text = read3["number"].ToString();
                    MailBoxCard.Text = read3["mail"].ToString();
                    

                }
                read3.Close();


            }

            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: стр рег" + ex.Message);
            }
        }

        private void buttonEditCard_Click(object sender, EventArgs e)
        {
            EditCard editCard = new EditCard();
            //editCard.Show();

            if (editCard.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
