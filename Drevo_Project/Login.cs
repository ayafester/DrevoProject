using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drevo_Project
{
    public partial class Login : Form
    {
        ConnectBD sql = new ConnectBD();
        public String userMail { get; set; } //??
        public String userPassword { get; set; }
        public Login()
        {
            InitializeComponent();
        }


        private void btnCheckLogin_Click(object sender, EventArgs e)
        {
            String sqlQuery1;

            if (tbCheckMail.Text == "" && tbCheckPassword.Text == "")
            {
                MessageBox.Show("Введите данные");

            } else
            {
                userMail = tbCheckMail.Text;
                userPassword = tbCheckPassword.Text;

                sqlQuery1 = "SELECT * FROM User WHERE mail = @userMail AND password = @userPassword";

                SQLiteCommand cmd = new SQLiteCommand(sqlQuery1, sql.connect);
                cmd.Parameters.AddWithValue("@userMail", tbCheckMail.Text);
                cmd.Parameters.AddWithValue("@userPassword", tbCheckPassword.Text);

                SQLiteDataAdapter adapter1 = new SQLiteDataAdapter(cmd);
                
                DataTable db2 = new DataTable();
                adapter1.Fill(db2);

                SQLiteDataReader SQL = cmd.ExecuteReader();

                while(SQL.Read())
                {
                    DataClass.ID = SQL["id"].ToString();
                }
                
                                

                if (db2.Rows.Count > 0)
                {
                    //MessageBox.Show("Вы успешно вошли");

                    DialogResult = DialogResult.OK; //Переход к след файлу

                } else
                {
                    MessageBox.Show("Почта или пароль неправильный");
                }
            }



        }

        private void label4_Click(object sender, EventArgs e)
        {
            string tempMail = "";
            string tempPass = " ";

            try
            {
                sql.command.CommandText = "SELECT * FROM User WHERE  id = '" + 1 + "' ";
                SQLiteDataReader read2 = sql.command.ExecuteReader();
                while (read2.Read())
                {
                    tempMail = read2["mail"].ToString();
                    tempPass = read2["password"].ToString();
                }
                read2.Close();

               MessageBox.Show($"Ваш пароль: {tempPass}. Ваш логин: {tempMail}");
                
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }
    }
}
