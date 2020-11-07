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
            DrawTree();
        }
      

        private void buttonEdit_Click(object sender, EventArgs e) //реализовать после вывода данных в БИО табличку админа
        {
            EditCard editCard = new EditCard();
           

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

        private void DrawTree() //вынести в класс для отрисовки древа
        {
            //код вывода фотографий для древа 
            /* List<PictureBox> picturebox = new List<PictureBox>(); //написать как грамотно выводить дерево. Данные в отдельном файле сохранять в listы данных
             List<Label> labeltext = new List<Label>();
             DirectoryInfo directoryInfo = new DirectoryInfo(@"C:\Server\data\htdocs\img\alb");
             var recentpics = directoryInfo.GetFiles().ToList();
             var y = 10;

             foreach (var file in recentpics)
             {
                 var pb = new PictureBox();
                 var label = new Label();
                 label.Location = new Point(labeltext.Count * 120 + 20, y);
                 label.Size = new Size(80, 30);
                 label.Text = "фио";
                 pb.Location = new Point(picturebox.Count * 120 + 20, y);
                 pb.Size = new Size(100, 100);
                 try
                 {
                     pb.Image = Image.FromFile(file.FullName);
                 }
                 catch (OutOfMemoryException) { continue; }
                 pb.SizeMode = PictureBoxSizeMode.StretchImage;
                 flowLayoutPanelTree.Controls.Add(pb);
                 flowLayoutPanelTree.Controls.Add(label);
                 picturebox.Add(pb);
             }*/





        }

        private void buttonAddCard_Click(object sender, EventArgs e) //кнопка добавления человека в дерево
        {
            NewCard newCard = new NewCard();
            

            if (newCard.ShowDialog() == DialogResult.OK)
            {
                //вызвать новую отрисовку древа
                
            }

        }
    }
}
