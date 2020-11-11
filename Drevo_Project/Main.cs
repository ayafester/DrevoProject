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
    }
}
