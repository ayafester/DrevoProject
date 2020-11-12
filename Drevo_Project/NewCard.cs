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
    
    public partial class NewCard : Form
    {
        ConnectBD sql = new ConnectBD();
        public String Mail { get; set; }

        
        public String Surname { get; set; }
        public String NamePerson { get; set; }
        public String Middlename { get; set; }

        public String DateBirthday { get; set; }
        public String DateDeathday { get; set; }

        public String BIO {get; set; }
        public String Number { get; set; }
        public int idMom { get; set; }
        public int idDad { get; set; }

        public int idPartner{ get; set; }




        public int Gender { get; set; }
        public NewCard()
        {
            InitializeComponent();
        }

        private void buttonSaveInfoAdd_Click(object sender, EventArgs e)
        {
            Mail = textBoxMailAdd.Text;
            
            Surname = textBoxSurnameAdd.Text;
            NamePerson = textBoxNameAdd.Text;
            Middlename = textBoxMiddlenameAdd.Text;
            DateBirthday = dateTimePickerBirthdayAdd.Value.ToString("dd/MM/yyyy");
            DateDeathday = dateTimePickerDeathdayAdd.Value.ToString("dd/MM/yyyy");
            BIO = textBoxBioAdd.Text;
            Number = textBoxNumberAdd.Text;
            
            //для idMom.. реализовать получение списка людей в карте и извлечение из человека его ID

            if (radioButtonFemaleAdd.Checked == true)
            {
                Gender = 0;
            }
            else if (radioButtonMenAdd.Checked == true)
            {
                Gender = 1;
            }

            try
            {
                sql.command.CommandText = "INSERT INTO Card ('surname', 'name', 'middlename', 'gender', 'bio', 'birthday' , 'deathday', 'number') VALUES ('" + //пока добавление связей нет
                    Surname + "' , '" +
                    NamePerson + "' , '" +
                    Middlename + "' , '" +
                    Gender + "' , '" +
                    BIO + "' , '" +
                    DateBirthday + "' ,'" +
                    DateDeathday + "' , '" +
                    Number + "')";
                    ;

                sql.command.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: стр рег" + ex.Message);
            }


            DialogResult = DialogResult.OK;
        }
    }
}
