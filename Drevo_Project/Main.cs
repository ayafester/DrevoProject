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
        public string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location); // путь к папке
        public String ContNum { get; set; }
        public String ContMail { get; set; }

        ConnectBD sql = new ConnectBD();
        public Main()
        {
            InitializeComponent();
            DrawTreeBmp();


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

                    labelBIO.Text = Convert.ToString(read2["bio"]);
                    if (read2["deathday"].ToString() == "")
                    {
                        labelDataBorn.Text = read2["birthday"].ToString() + "";
                    }
                    else
                    {
                        labelDataBorn.Text = read2["birthday"].ToString() + "-" + read2["deathday"].ToString();
                    }
                }
                read2.Close();

                sql.command.CommandText = "SELECT * FROM Card WHERE id = '" + DataClass.CardID + "' ";
                SQLiteDataReader read3 = sql.command.ExecuteReader();

                while (read3.Read())
                {
                    NumberBox.Text = read3["number"].ToString();
                    ContNum = read3["number"].ToString();
                    MailBox.Text = read3["mail"].ToString();
                    ContMail = read3["mail"].ToString();

                }
                read3.Close();


            }

            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: стр рег" + ex.Message);
            }
        }

        private void ChangeContactsButton_Click(object sender, EventArgs e)
        {
            if (NumberBox.Text != ContNum || MailBox.Text != ContMail)
            {
                try
                {
                    sql.command.CommandText = "UPDATE Card SET number= '" + NumberBox.Text + "', mail='" + MailBox.Text + "' WHERE id = '" + DataClass.CardID + "'  ";
                    sql.command.ExecuteNonQuery();
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Error: стр рег" + ex.Message);
                }
            }
        }


        private void buttonEdit_Click(object sender, EventArgs e) //реализовать после вывода данных в БИО табличку админа
        {
            EditCard editCard = new EditCard();
           

            if (editCard.ShowDialog() == DialogResult.OK)
            {
                editCard.Close();
            }
        }

        private void buttonAddCard_Click(object sender, EventArgs e) //кнопка добавления человека в дерево
        {
            NewCard newCard = new NewCard();

            if (newCard.ShowDialog() == DialogResult.OK)
            {
                newCard.Close();
                DrawTreeBmp();
                //вызвать новую отрисовку древа
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }

        public int[][] GetData() //получение данных в таблицу только для поколений
        {
            DataTable dt = new DataTable();
            String sqlQuery;
            

            try
            {
                sqlQuery = "SELECT Generation, id, idPartner, idMom, idDad FROM Card ORDER BY Generation";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, sql.connect);
                adapter.Fill(dt);

                

            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


            int rows = dt.Rows.Count;
            int columns = dt.Columns.Count;


            int[][] arr = new int[rows][];


            for (int i = 0; i < rows; i++)
            {
                DataRow row = dt.Rows[i];
                arr[i] = new int[columns];
                for (int j = 0; j < columns; j++)
                {

                    arr[i][j] = Convert.ToInt32(row[j]);
                }
            }

            return arr;

        }

        private List<List<int[]>> SortDataToGeneration() //преобразование в список по поколениям
        {
            int[][] values = GetData();
            int rowsVal = values.Length;
            int maxGen;

            sql.command.CommandText = "SELECT MAX(Generation) FROM Card";
            SQLiteDataReader read = sql.command.ExecuteReader();
            while (read.Read())
            {
                maxGen = read.GetInt32(0);
            }
            read.Close();

            List<List<int[]>> generation = new List<List<int[]>> { //количество поколений 4 например. сделать динамические изменения поколений
                new List<int[]>(),
                new List<int[]>(),
                new List<int[]>()
                
            };

            for (int i = 1; i < rowsVal; i++)
            {
                if (values[i][0] == 0)
                {
                    generation[0].Add(values[i]);
                }
                else if (values[i][0] == 1)
                {
                    generation[1].Add(values[i]);
                }
                else if (values[i][0] == 2)
                {
                    generation[2].Add(values[i]);
                }
                else if (values[i][0] == 3)
                {
                    generation[3].Add(values[i]);
                }
                

            }

            return generation;
        }
        class Cards //человек (ребята обратите внимание сюда. может будем одним классом пользоваться? дополняйте как нужно
        {
            public int Gener { get; set; }
            public int Id { get; set; }
            public int IdPartner { get; set; }
            public int IdMom { get; set; }
            public int IdDad { get; set; }
            public string FIO { get; set; }

            
            public int isDelete { get; set; }

            public SolidBrush colorLine { get; set; } //для дерева

        }
        private List<Cards> GetDataFromBD() //считывание персон с таблицы эту функцию можно вызывать где надо пример строка 270
        {
            sql.command.CommandText = "SELECT Generation, id, idPartner, idMom, idDad, surname|| ' ' || name || ' ' || middlename, isDelete FROM Card WHERE id >= 1";
            List<Cards> CardsTemp = new List<Cards>();
            try
            {
                SQLiteDataReader r = sql.command.ExecuteReader();

                while (r.Read())
                {
                    Cards entity = new Cards
                    {
                        Gener = r.GetInt32(0),
                        Id = r.GetInt32(1),
                        IdPartner = r.GetInt32(2),
                        IdMom = r.GetInt32(3),
                        IdDad = r.GetInt32(4),
                        FIO = r.GetString(5),     
                        isDelete = r.GetInt32(6),
                        
                    };
                    CardsTemp.Add(entity);
                }
                r.Close();
                sql.command.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return CardsTemp;
        }
        private void DrawTreeBmp()
        {

            List<List<int[]>> gener = SortDataToGeneration(); //[generation, id, idPartner, idMom, idDad]
            int length = gener.Count; //количество поколений 3
            int[] temp = new int[length];
            for (int i = 0; i < length; i++)
            {
                temp[i] = gener[i].Count;
            }

            int maxCounGen = temp.Max(); //максимальная длина поколения

            List<Cards> persones = GetDataFromBD();

            

            panelTree.AutoScroll = true; //автоскролл
            pictureBoxTree.SizeMode = PictureBoxSizeMode.AutoSize;

            Bitmap bmp = new Bitmap(maxCounGen * 380, length * 250);//размер битмапа под количество элементов
            Graphics graph = Graphics.FromImage(bmp);

            List<SolidBrush> pens = new List<SolidBrush>() { 
                new SolidBrush(Color.Blue),
                new SolidBrush(Color.Red),
                new SolidBrush(Color.Green),
                new SolidBrush(Color.Yellow),
                new SolidBrush(Color.Orange),
                new SolidBrush(Color.Pink),
                new SolidBrush(Color.Lavender),
            };
           
            Pen penLine = new Pen(Color.Gray, 1.5f);
            Font fnt = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            Brush br = new SolidBrush(Color.Black);

            

            Image image1 = Image.FromFile("" + path + "\\img\\logoLogo.png"); //просто лого-заглушка
            int x = 10, y = 30; //положение точки для верхнего поколения
            int stepHor = 350; //блок для одного чела с партн11ером 50 отступ 100 эллипс 50 отступ справа снова 100 эллипс 50 отступ
            int stepVert = 200; //блок для пары в высоту 50 100 50 

            int count = persones.Count; //количество людей

            List<int> usedId = new List<int>(); //список нарисованных людей

            for (int i = length - 1; i >= 0; i--) //прорисовка блоков цикл по поколениям
            {

                for (int k = 0; k < gener[i].Count; k++) //цикл по массивам внутри поколений 
                {

                    //graph.DrawRectangle(pen, x, y, stepHor, stepVert);

                    int idTemp = gener[i][k][1]; //текущий человек
 
                    foreach (var item in persones)
                    {
                        if(item.Id == idTemp && item.isDelete == 1) //если такой существует и не удален
                        {
                            if (!usedId.Exists(value => value == idTemp)) //проверка если он уже нарисован
                            {
                                graph.DrawLine(penLine, x, y + stepVert, x + length * 250, y + stepVert);

                                if (item.IdPartner != 0) //пара
                                {
                                    Cards partnerTemp = persones.Find(find => find.IdPartner == item.Id);
                                    item.colorLine = pens[k];
                                    partnerTemp.colorLine = pens[k];

                                    if(item.IdMom != 0) //мать
                                    {
                                        graph.DrawLine(penLine, x + 50, y + 50, x + 50, y);
                                        Cards momTemp = persones.Find(find => find.Id == item.IdMom);
                                        item.colorLine = momTemp.colorLine;
                                    }

                                    graph.FillEllipse(item.colorLine, x - 5, y + 45, 110, 115);
                                    graph.DrawImage(image1, x, y + 50);
                                    graph.DrawString(item.FIO, fnt, br, x, y + 30);

                                    if (partnerTemp.IdMom != 0)
                                    {
                                        Cards momPartnerTemp = persones.Find(find => find.Id == partnerTemp.IdMom);
                                        partnerTemp.colorLine = momPartnerTemp.colorLine;
                                    }
                                    graph.FillEllipse(partnerTemp.colorLine, x + 145, y + 45, 110, 115);
                                    graph.DrawImage(image1, x + 150, y + 50);
                                    graph.DrawString(partnerTemp.FIO, fnt, br, x + 200, y + 30);
                                    

                                    if (partnerTemp.IdMom != 0)
                                    {
                                        graph.DrawLine(penLine, x + 200, y + 50, x + 200, y);
                                    }

                                    graph.DrawLine(penLine, x+100, y + 100, x + 150, y +100); //линия между супругами

                                    if(persones.Exists(find => find.IdDad== item.Id) == true)
                                    {
                                        graph.DrawLine(penLine, x + 125, y + 100, x + 125, y + 200); //линия вниз в другое поколение
                                    }

                                    usedId.Add(idTemp);
                                    usedId.Add(partnerTemp.Id);
                                }
                                if (item.IdPartner == 0) //одинокий человек
                                {
                                    if (item.IdMom != 0)
                                    {
                                        graph.DrawLine(penLine, x + 50, y + 50, x + 50, y);
                                        Cards momTemp = persones.Find(find => find.Id == item.IdMom);
                                        item.colorLine = momTemp.colorLine;
                                    }
                                    graph.FillEllipse(item.colorLine, x - 5, y + 45, 110, 115);
                                    graph.DrawImage(image1, x, y + 50);
                                    graph.DrawString(item.FIO, fnt, br, x, y + 30); //добавить фото
                                    if (item.IdMom != 0)
                                    {
                                        graph.DrawLine(penLine, x + 50, y + 50, x + 50, y);
                                    }
                                }

                            }

                        }
                    }
                    x += stepHor;

                }
                x = 10;
                y += stepVert;
            }

            pictureBoxTree.Image = bmp;
        }


        private void buttonSearch_Click(object sender, EventArgs e)
        {
            int idCardtoShow = SearchCard();
            showCard(idCardtoShow);

        }
        private void showCard(int MyId)
        {
            if (MyId != 0)
            {
                Card cardShow = new Card(MyId);
                cardShow.ShowDialog();
            }


        }
        private int SearchCard()
        {
            List<Cards> persones = GetDataFromBD();

            if (searchBox.Text == "")
            {

                MessageBox.Show("Введите ФИО");
            }
            else
            {
                bool check = persones.Exists(find => find.FIO == searchBox.Text);

                if (check == true)
                {
                    
                    Cards searchPersona = persones.Find(find => find.FIO == searchBox.Text);
                    if (searchPersona.isDelete != 0)
                    {   
                        return searchPersona.Id;
                    }
                    else
                    {
                        MessageBox.Show("Такого человека нет в древе");
                    }
                 
                }
                else
                {
                    
                    MessageBox.Show("Такого человека нет в древе");
                    
                }
            }

            return 0;
        }





    }

}
