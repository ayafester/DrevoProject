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
    public partial class RegForm : Form
    {

        ConnectBD sql = new ConnectBD();
        public String Mail { get; set; }
        public String Number { get; set; }
        public String Password { get; set; }
        public String Surname { get; set; }
        public String NamePerson { get; set; }
        public String Middlename { get; set; }

        public String DateBirthday { get; set; }

        public int Gender { get; set; }


        public RegForm()
        {
            InitializeComponent();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            Number = NumberBox.Text;
            Mail = textBoxMail.Text;
            Password = textBoxPassword.Text;
            Surname = textBoxSurname.Text;
            NamePerson = textBoxName.Text;
            Middlename = textBoxMiddlename.Text;
            DateBirthday = dttBirthday.Value.ToString("dd/MM/yyyy");

            if (radioButtonFemale.Checked == true)
            {
                Gender = 0;
            }
            else if (radioButtonMen.Checked == true)
            {
                Gender = 1;
            }
            

            if (Surname == "")
            {
                MessageBox.Show("Введите фамилию!");
            } else if (NamePerson == "")
            {
                MessageBox.Show("Введите имя!");
            } 
            else if (DateBirthday == "")
            {
                MessageBox.Show("Введите дату рождения!");
            }
            else if (Number == "")
            {
                MessageBox.Show("Введите номер!");
            } else if(Mail == "")
            {
                MessageBox.Show("Введите почту!");
            } else if(Password == "")
            {
                MessageBox.Show("Введите пароль!");
            } else if(radioButtonFemale.Checked == false && radioButtonMen.Checked == false)
            {
                MessageBox.Show("Выберите пол!");
            }
            else
            {
                try
                {
                    sql.command.CommandText = "INSERT INTO User ('mail', 'password') VALUES ('" +
                        Mail + "' , '" +
                        Password + "') ";

                    sql.command.ExecuteNonQuery();

                    sql.command.CommandText = "SELECT * FROM User WHERE mail ='" + Mail + "' AND password ='" + Password + "' ";
                    SQLiteDataReader read = sql.command.ExecuteReader();
                    while (read.Read())
                    {
                        DataClass.ID = read["id"].ToString(); //Забрали и записали ID юзера
                    }
                    read.Close();

                    sql.command.CommandText = "INSERT INTO Card ('surname', 'name', 'middlename', 'gender', 'birthday', 'number', 'mail', 'idCreator') VALUES ('" +
                        Surname + "' , '" +
                        NamePerson + "' , '" +
                        Middlename + "' , '" +
                        Gender + "' , '" +
                        DateBirthday + "' , '" +
                        Number + "' , '" +
                        Mail + "' , '" +
                        DataClass.ID + "')";

                    sql.command.ExecuteNonQuery();

                    sql.command.CommandText = "SELECT * FROM Card WHERE  idCreator = '" + DataClass.ID + "' ";
                    SQLiteDataReader read2 = sql.command.ExecuteReader();
                    while (read2.Read())
                    {
                        DataClass.CardID = read2["id"].ToString();
                    }
                    read2.Close();

                    sql.command.CommandText = " UPDATE User SET idCard = '" + DataClass.CardID + "' WHERE id = '" + DataClass.ID + "' ";
                    sql.command.ExecuteNonQuery(); // Записали ID его карты
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Error:" + ex.Message);
                }

                MessageBox.Show("Войдите в систему");
                DialogResult = DialogResult.OK;
            }



        }

        

        
    }
}
