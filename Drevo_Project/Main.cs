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
    public partial class Main : Form
    {
        

        ConnectBD sql = new ConnectBD();
        public Main()
        {
            InitializeComponent();
            


        }
      

        private void buttonEdit_Click(object sender, EventArgs e) //реализовать после вывода данных в БИО табличку админа
        {
            EditCard editCard = new EditCard();
           

            if (editCard.ShowDialog() == DialogResult.OK)
            {
                editCard.Close();
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



        private void buttonAddCard_Click(object sender, EventArgs e) //кнопка добавления человека в дерево
        {
            NewCard newCard = new NewCard();

            if (newCard.ShowDialog() == DialogResult.OK)
            {
                newCard.Close();
                //вызвать новую отрисовку древа
                
            }

        }

        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                sql.command.CommandText = "SELECT * FROM User WHERE id='" + DataClass.ID + "' ";
                //SQLiteDataAdapter adapter1 = new SQLiteDataAdapter(sql.command.Connection);

                SQLiteDataReader read = sql.command.ExecuteReader();

                while (read.Read())
                {
                    DataClass.CardID = read["idCard"].ToString();
                }
                read.Close();

                sql.command.CommandText = "SELECT * FROM Card WHERE id = '" + DataClass.CardID + "' ";
                SQLiteDataReader read2 = sql.command.ExecuteReader();
                while (read2.Read())
                {
                    labelFio.Text = read2["surname"].ToString() + " " + read2["name"].ToString() + " " + read2["middlename"].ToString();
                    listBox1.Items.Add(Convert.ToString(read2["bio"]));
                    if (read2["deathday"].ToString()=="")
                    {
                        labelDataBorn.Text = read2["birthday"].ToString() + "-...";
                    }
                    else
                    {
                        labelDataBorn.Text = read2["birthday"].ToString() + "-" + read2["deathday"].ToString();
                    }
                }
                read2.Close();
                


            }

            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: стр рег" + ex.Message);
            }
        }
    }
}
