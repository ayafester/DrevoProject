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
    public partial class Form1 : Form
    {

        ConnectBD sql = new ConnectBD();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sql.command.CommandText = "INSERT or REPLACE INTO Card(id, idCreator) VALUES(0,1)";
            sql.command.ExecuteNonQuery();

            int check;
            sql.command.CommandText = "SELECT COUNT(*) FROM User";
            check = Convert.ToInt32(sql.command.ExecuteScalar());
            if (check != 0)
            {

                btnToReg.Enabled = false;
            }
        }

        private void btnToReg_Click(object sender, EventArgs e)
        {
            if (sql.connect.State != ConnectionState.Open)
            {
                MessageBox.Show("Сначала подключитесь к БД!");
                return;
            }

            RegForm addData = new RegForm();

            if (addData.ShowDialog() == DialogResult.OK)
            {
                addData.Close();
               

            }
        }

        private void btnToLogin_Click(object sender, EventArgs e)
        {
            if (sql.connect.State != ConnectionState.Open)
            {
                MessageBox.Show("Сначала подключитесь к БД!");
                return;
            }

            Login checkUser = new Login();

            if(checkUser.ShowDialog() == DialogResult.OK)
            {

                Main mainForm = new Main();
                mainForm.Show();

                checkUser.Close();
                this.Hide();

                
            }

        }

        
    }

}