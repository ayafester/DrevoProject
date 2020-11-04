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
        private String dbName1;
        public String userMail { get; set; } //??
        public String userPassword { get; set; }
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            dbName1 = "DrevoBD.sqlite";
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

                SQLiteConnection connect2 = new SQLiteConnection("Data Source=" + dbName1 + ";Version=3;");
                connect2.Open();

                SQLiteCommand cmd = new SQLiteCommand(sqlQuery1, connect2);
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
                    MessageBox.Show("Вы успешно вошли");

                    DialogResult = DialogResult.OK; //Переход к след файлу

                } else
                {
                    MessageBox.Show("Почта или пароль неправильный");
                }
            }



        }
    }
}
