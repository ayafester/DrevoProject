﻿using System;
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
        public String Surname { get; set; }
        public String Name { get; set; }
        public String Middlename { get; set; }
        public String Birthday { get; set; }
        public String Deathday { get; set; }
        public int idMom { get; set; }
        public int idDad { get; set; }
        public int idPartner { get; set; }
        public int Age { get; set; }
        public int Year { get; set; }
        public int Mounth { get; set; }
        public int Day { get; set; }
        public int Yeartd { get; set; }
        public int Mounthtd { get; set; }
        public int Daytd { get; set; }
        public String PathSave { get; set; }
        public String PathSave2 { get; set; }

        public static int IdToSearchPartner { get; set; }
        public static String findFIO { get; set; }

        public static int MomToNewGen { get; set; }
        public static int DadToNewGen { get; set; }

        ConnectBD sql = new ConnectBD();
        public Main()
        {
            InitializeComponent();
            DrawTreeBmp();
            SortListFam();
            SearchCard();
            UpdateParents();
            if (DataClass.ID != "1")
            {
                buttonAddCard.Enabled = false;
                buttonDelete.Enabled = false;
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {

            PathSave = "q";
            PathSave2 = "q";
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

                sql.command.CommandText = "SELECT idMom,idDad,idPartner FROM Card WHERE id = '" + DataClass.CardID + "' ";
                SQLiteDataReader read1 = sql.command.ExecuteReader();
                while (read1.Read())
                {
                    idMom = read1.GetInt32(0);
                    idDad = read1.GetInt32(1);
                    idPartner = read1.GetInt32(2);
                }
                read1.Close();

                sql.command.CommandText = "SELECT * FROM Card WHERE id = '" + DataClass.CardID + "' ";
                SQLiteDataReader read2 = sql.command.ExecuteReader();
                while (read2.Read())
                {
                    SurnameBox.Text = read2["surname"].ToString();// Вывод имени
                    Surname = read2["surname"].ToString();
                    NameBox.Text = read2["name"].ToString();
                    Name = read2["name"].ToString();
                    MiddlenameBox.Text = read2["middlename"].ToString();
                    Middlename = read2["middlename"].ToString();

                    textBoxBio.Text = Convert.ToString(read2["bio"]);//Вывод биографии с изменением

                    if (read2["deathday"].ToString() == "")// Вывод дат жизни и возраста
                    {
                        BirthdayBox.Text = read2["birthday"].ToString();
                        Birthday = read2["birthday"].ToString();
                        Deathday = "";

                        //И возраст

                        DateTime datetime = DateTime.Now; //Добавление настоящей даты 
                        string date = Convert.ToString(datetime);
                        CountAge(Birthday, date);
                    }
                    else
                    {
                        BirthdayBox.Text = read2["birthday"].ToString();
                        DeathdayBox.Text = read2["deathday"].ToString();
                        Birthday = read2["birthday"].ToString();
                        Deathday = read2["deathday"].ToString();

                        //Возраст человека в день смерти

                        CountAge(Birthday, Deathday);
                    }
                    if (Convert.ToInt32(read2["ifAva"]) == 1)//Вывод Аватарки
                    {
                        byte[] imgg = (byte[])(read2["PhotoOnAva"]);
                        MemoryStream mstream = new MemoryStream(imgg);
                        pictureBoxAva.Image = Image.FromStream(mstream);
                    }
                }

                read2.Close();

                sql.command.CommandText = "SELECT * FROM Card WHERE id = '" + DataClass.CardID + "' ";
                SQLiteDataReader read3 = sql.command.ExecuteReader();

                while (read3.Read())//Вывод контактов
                {
                    NumberBox.Text = read3["number"].ToString();
                    ContNum = read3["number"].ToString();
                    MailBox.Text = read3["mail"].ToString();
                    ContMail = read3["mail"].ToString();

                }

                read3.Close();


                ShowPhoto();
                
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
            
        }


        private void UpdateParents()
        {
            List<Cards> persones = GetDataFromBD();

            List<Cards> Males = new List<Cards>();
            List<Cards> Females = new List<Cards>();

            Cards User = persones.Find(find => find.Id == Convert.ToInt32(DataClass.ID));

            foreach (var item in persones)
            {
                if(item.isDelete == 1 && item.Id != User.Id) 
                {
                    if (item.Gender == 0)
                    {
                        Females.Add(item);
                    }
                    else
                    {
                        Males.Add(item);
                    }
                }
                
            };
            
            int indM = 0;
            idMom = User.IdMom;
            if (idMom != 0)
            {
                Cards Mom = Females.Find(find => find.Id == idMom);
                indM = Females.IndexOf(Mom);
            } else
            {
                Females.Insert(0, new Cards() { Id = 0, FIO = " ", Gender = 0, Gener = 99 });
            }

            comboBoxMother.DataSource = Females;
            comboBoxMother.DisplayMember = "FIO";
            comboBoxMother.ValueMember = "Id";
            comboBoxMother.SelectedIndex = indM;

            int indF = 0;
            idDad = User.IdDad;

            if (idDad != 0)
            {
                Cards Dad = Males.Find(find => find.Id == idDad);
                indF = Males.IndexOf(Dad);
            } else
            {
                Males.Insert(0, new Cards() { Id = 0, FIO = " ", Gender = 0, Gener = 99 });
            }
            
            comboBoxFather.DataSource = Males;
            comboBoxFather.DisplayMember = "FIO";
            comboBoxFather.ValueMember = "Id";
            comboBoxFather.SelectedIndex = indF;
            

            comboBoxMother.SelectedIndexChanged += ComboBoxMother_SelectedIndexChanged;
            comboBoxFather.SelectedIndexChanged += ComboBoxFather_SelectedIndexChanged;
        }
        private void ComboBoxMother_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cards Mom = comboBoxMother.SelectedItem as Cards;
            if (Mom != null)
            {
                idMom = Mom.Id;
            }

        }

        private void ComboBoxFather_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cards Dad = comboBoxFather.SelectedItem as Cards;
            if (Dad != null)
            {
                idDad = Dad.Id;
            }

        }

        private void ChangeContactsButton_Click(object sender, EventArgs e)
        {
            List<Cards> persones = GetDataFromBD();
            Cards User = persones.Find(find => find.Id == Convert.ToInt32(DataClass.ID));
            int ParGen = User.Gener + 1;
            if (NumberBox.Text != ContNum || MailBox.Text != ContMail)
            {
                try
                {
                    sql.command.CommandText = "UPDATE Card SET number= '" + NumberBox.Text + "', mail='" + MailBox.Text + "' WHERE id = '" + DataClass.CardID + "'  ";
                    sql.command.ExecuteNonQuery();
                    MessageBox.Show("Контакты успешно изменены");
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            if (idMom != 0)
            {
               try 
               {
                    sql.command.CommandText = "UPDATE Card SET idMom = '" + idMom + "' WHERE id = '" + User.Id + "'  ";
                    sql.command.ExecuteNonQuery();
                    sql.command.CommandText = "UPDATE Card SET Generation = '" + ParGen + "' WHERE id = '" + idMom + "'  ";
                    sql.command.ExecuteNonQuery();
                    DrawTreeBmp();
                    SortListFam();
                    SearchCard();
                    
                } 
               catch (SQLiteException ex)
               { 
                     MessageBox.Show("Error:" + ex.Message);
               }
            }

            if (idDad != 0)
            {
                try
                {
                    sql.command.CommandText = "UPDATE Card SET idDad = '" + idDad + "' WHERE id = '" + User.Id + "'  ";
                    sql.command.ExecuteNonQuery();
                    sql.command.CommandText = "UPDATE Card SET Generation = '" + ParGen + "' WHERE id = '" + idDad + "'  ";
                    sql.command.ExecuteNonQuery();
                    DrawTreeBmp();
                    SortListFam();
                    SearchCard();
                   
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Error:" + ex.Message);
                }
            }

            UpdateParents();
        }
        private void ShowPhoto()
        {
            sql.command.CommandText = "SELECT * FROM Photos WHERE idCard ='" + DataClass.CardID + "' ";
            SQLiteDataReader read4 = sql.command.ExecuteReader();
            ImageList ImageList = new ImageList();
            ImageList.ImageSize = new Size(225, 150); 
            int i = 0;
            while (read4.Read())//Вывод фотоальбома
            {
                if (Convert.ToInt32(read4["ifEx"]) == 1)
                {
                    /*if (Convert.ToInt32(read4["idLink"]) == 0) //закоментированно, т. к. нет реализации фотоальбома с общими фото
                    {*/
                    byte[] img = (byte[])(read4["photo"]);
                    MemoryStream mstr = new MemoryStream(img);
                    ImageList.Images.Add(Image.FromStream(mstr));
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.ImageIndex = i; // Convert.ToInt32(read4["id"]);
                    listViewItem.Tag = Convert.ToInt32(read4["id"]);
                    listView1.Items.Add(listViewItem);
                    i += 1;
                    //listView1.Tag = Convert.ToInt32(read4["id"]);
                    /* }*/
                }
            }
            read4.Close();
            listView1.SmallImageList = ImageList;
        }
        private void CountAge(string Birthday, string Deathday)
        {
            String str = Birthday;
            Year = Convert.ToInt32(str.Substring(6));
            str = Birthday;
            Mounth = Convert.ToInt32(str.Substring(3, 2));
            str = Birthday;
            Day = Convert.ToInt32(str.Substring(0, 2));

            string date = Deathday;
            Daytd = Convert.ToInt32(Deathday.Substring(0, 2));
            date = Deathday;
            Mounthtd = Convert.ToInt32(Deathday.Substring(3, 2));
            date = Deathday;
            Yeartd = Convert.ToInt32(Deathday.Substring(6, 4));
            date = Deathday;

            Age = Yeartd - Year;
            if (Age == 0)
            {
                AgeLabel.Text = "Возраст: \nМеньше года";
            }
            else
            {
                if (Mounthtd < Mounth)
                {
                    Age -= 1;
                    if (Age == 0)
                    {
                        AgeLabel.Text = "Возраст: \nМеньше года";
                    }
                    else
                    {
                        AgeLabel.Text = "Возраст: " + Age.ToString();
                    }
                }
                else
                {
                    if (Mounthtd > Mounth)
                    {
                        AgeLabel.Text = "Возраст: " + Age.ToString();
                    }
                    else
                    {
                        if (Daytd < Day)
                        {
                            Age -= 1;
                            AgeLabel.Text = "Возраст: " + Age.ToString();
                        }
                        else
                        {
                            AgeLabel.Text = "Возраст: " + Age.ToString();
                        }
                    }
                }
            }
        }

       


        private void buttonAddCard_Click(object sender, EventArgs e) //кнопка добавления человека в дерево
        {
            NewCard newCard = new NewCard();

            if (newCard.ShowDialog() == DialogResult.OK)
            {
                newCard.Close();

                List<Cards> FindPartnersList = GetDataFromBD();

                if (IdToSearchPartner != 0)
                {
                    Cards partner = FindPartnersList.Find(find => find.Id == IdToSearchPartner); //нашли того партнера


                    Cards newCreated = FindPartnersList.Find(find => find.FIO == findFIO); //нашли которого добавили сделать апдйет в бд

                    partner.IdPartner = newCreated.Id;

                    sql.command.CommandText = " UPDATE Card SET idPartner = '" + newCreated.Id + "' WHERE id = '" + IdToSearchPartner + "' ";
                    sql.command.ExecuteNonQuery();

                }

                DrawTreeBmp();
                SortListFam();
                SearchCard();
                UpdateParents();
            }

        }

        public int[][] GetData() //получение данных в таблицу только для поколений
        {
            DataTable dt = new DataTable();
            String sqlQuery;


            try
            {
                sqlQuery = "SELECT Generation, id, idPartner, idMom, idDad FROM Card WHERE id >= 1 and isDelete!=0 ORDER BY Generation";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, sql.connect);
                adapter.Fill(dt);
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


            int rows = dt.Rows.Count;
            int columns = dt.Columns.Count;


            int[][] arr = new int[rows][]; //двумерный массив


            for (int i = 0; i < rows; i++)
            {
                DataRow row = dt.Rows[i];
                arr[i] = new int[columns];
                for (int j = 0; j < columns; j++)
                {

                    arr[i][j] = Convert.ToInt32(row[j]);
                }
            }

            return arr; //двумерный массив сортированный по поколениям


        }

        private List<List<int[]>> SortDataToGeneration() //преобразование в список по поколениям
        {
            int[][] values = GetData();

            //найти число уникальных чисел из первого столбца двумерного массива


            int rowsVal = values.Length;
            int columnsVal = values.Length;

            List<int> unicNum = new List<int>();
            List<int> gen = new List<int>();

            for (int i = 0; i < rowsVal; i++)
            {
                unicNum.Add(values[i][0]);
            }

            for (int i = 0; i < unicNum.Count; i++)
            {
                if (!gen.Exists(value => value == unicNum[i]))
                {
                    gen.Add(unicNum[i]);
                }
            }

            int generCount = gen.Count;


            List<List<int[]>> generation = new List<List<int[]>>();

            for (int i = 0; i < generCount; i++) //динамический массив
            {
                generation.Add(new List<int[]>());
            }

            for (int k = 0; k < generCount; k++) //
            {
                for (int i = 0; i < rowsVal; i++)
                {
                    if (values[i][0] == gen[k])
                    {
                        generation[k].Add(values[i]);

                    }
                }
            }
            return generation;
        }
        class Cards //человек 
        {
            public int Gener { get; set; }
            public int Id { get; set; }
            public int IdPartner { get; set; }
            public int IdMom { get; set; }
            public int IdDad { get; set; }
            public string FIO { get; set; }
            public string BirthDay { get; set; }
            public int Gender { get; set; }
            public string StepRod { get; set; } = "";

            public int isDelete { get; set; }

            public Pen pen { get; set; }
            public Point coord { get; set; } = new Point(0, 0); //координаты фигуры
            public Point endVertical { get; set; } = new Point(0, 0); //координаты окончания вертикальной линии в поколение вниз


        }
        private Cards GetUser()
        {
            sql.command.CommandText = "SELECT Generation, id, idPartner, idMom, idDad, surname|| ' ' || name || ' ' || middlename, isDelete, birthday FROM Card WHERE id ='" + DataClass.ID + "' ";
            Cards UserT = new Cards();
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
                        BirthDay = r.GetString(7),

                    };
                    UserT = entity;
                }
                r.Close();
                sql.command.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return UserT;
        }
        private List<Cards> GetDataFromBD()
        {
            sql.command.CommandText = "SELECT Generation, id, idPartner, idMom, idDad, surname|| ' ' || name || ' ' || middlename, isDelete, birthday, gender FROM Card WHERE id >= 1 "; //добавить сортировку по пколениям тогда возмоэно не будет двойных людей
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
                        BirthDay = r.GetString(7),
                        Gender = r.GetInt32(8),

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

        private List<Cards> GetSortedFioDataFromBD()
        {
            sql.command.CommandText = "SELECT Generation, id, idPartner, idMom, idDad, surname|| ' ' || name || ' ' || middlename, isDelete, birthday, gender FROM Card WHERE id >= 1 and id!='" + DataClass.ID + "' and isDelete!=0  ORDER BY surname|| ' ' || name || ' ' || middlename";
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
                        BirthDay = r.GetString(7),
                        Gender = r.GetInt32(8),

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

        private void SortListFam()
        {
            int BabTemp, Bab1Temp, DedTemp, Ded1Temp, BrothTemp, SistTemp, SonTemp, DoatTemp;
            BabTemp = Bab1Temp = DedTemp = Ded1Temp = BrothTemp = SistTemp = SonTemp = DoatTemp = 0;
            Cards User = GetUser();
            List<Cards> personesL = GetSortedFioDataFromBD();

            foreach (var item in personesL)
            {
                if (item.Gener == User.Gener)
                {
                    if (item.Id == User.IdPartner)
                    {
                        if (item.Gender == 0)
                        {
                            item.StepRod = "Жена";
                        }
                        else item.StepRod = "Муж";
                    }
                    if (item.IdDad == User.IdDad || item.IdMom == User.IdMom)
                    {
                        if (item.Gender == 0)
                        {
                            item.StepRod = "Сестра";
                            SistTemp = item.Id;
                        }
                        else
                        {
                            item.StepRod = "Брат";
                            BrothTemp = item.Id;
                        }
                    }
                }
                if (item.Gener == User.Gener + 1)
                {
                    if (item.Id == User.IdMom)
                    {
                        item.StepRod = "Мать";
                        BabTemp = item.IdMom;
                        DedTemp = item.IdDad;
                    }
                    else if (item.Id == User.IdDad)
                    {
                        item.StepRod = "Отец";
                        Bab1Temp = item.IdMom;
                        Ded1Temp = item.IdDad;
                    }
                }
                if (item.Gener == User.Gener - 1)
                {
                    if (item.IdDad == User.Id || item.IdMom == User.Id)
                    {
                        if (item.Gender == 0)
                        {
                            item.StepRod = "Дочь";
                            DoatTemp = item.Id;
                        }
                        else
                        {
                            item.StepRod = "Сын";
                            SonTemp = item.Id;
                        }
                    }
                    if (item.IdDad == BrothTemp || item.IdMom == SistTemp)
                    {
                        if (item.Gender == 0)
                        {
                            item.StepRod = "Племянница";
                        }
                        else
                        {
                            item.StepRod = "Племянник";
                        }
                    }
                }

            }
            foreach (var item in personesL)
            {
                if (item.Gener == User.Gener + 2)
                {
                    if (item.Id == BabTemp || item.Id == Bab1Temp)
                    {
                        item.StepRod = "Бабушка";
                    }
                    else if (item.Id == DedTemp || item.Id == Ded1Temp)
                    {
                        item.StepRod = "Дедушка";
                    }
                }
                if (item.Gener == User.Gener - 2)
                {
                    if (item.IdDad == SonTemp || item.IdMom == DoatTemp)
                    {
                        if (item.Gender == 0)
                        {
                            item.StepRod = "Внучка";
                            DoatTemp = item.Id;
                        }
                        else
                        {
                            item.StepRod = "Внук";
                            SonTemp = item.Id;
                        }
                    }
                }
            }
            foreach (var item in personesL)
            {
                if (item.Gener == User.Gener + 1)
                {
                    if ((item.Id != User.IdMom && item.Id != User.IdDad) && (item.IdMom == BabTemp || item.IdMom == Bab1Temp) && (item.IdDad == DedTemp || item.IdDad == Ded1Temp))
                    {
                        if (item.Gender == 0)
                        {
                            item.StepRod = "Тетя";
                        }
                        else
                        {
                            item.StepRod = "Дядя";
                        }
                    }
                }
            }
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = personesL;
        }


        public void DrawTreeBmp()
        {

            List<List<int[]>> gener = SortDataToGeneration(); //[generation, id, idPartner, idMom, idDad]
            int length = gener.Count;
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

            List<Pen> pens = new List<Pen> () {

                new Pen(Color.Orange, 1.5f), 
                new Pen(Color.Blue , 1.5f),
                new Pen(Color.Red, 1.5f),
                new Pen(Color.Green, 1.5f),
                new Pen(Color.Purple, 1.5f),
                new Pen(Color.DarkOliveGreen, 1.5f),
                new Pen(Color.Lavender, 1.5f),
                new Pen(Color.HotPink, 1.5f),
                new Pen(Color.Blue, 1.5f),
                new Pen(Color.DarkTurquoise, 1.5f),
                new Pen(Color.DeepPink, 1.5f),
                new Pen(Color.Red, 1.5f),
                new Pen(Color.Brown, 1.5f),
                new Pen(Color.DarkOrange, 1.5f),
                new Pen(Color.DarkGray, 1.5f),
                new Pen(Color.Orange, 1.5f),
                new Pen(Color.Blue , 1.5f),
                new Pen(Color.Red, 1.5f),
                new Pen(Color.Green, 1.5f),
                new Pen(Color.Purple, 1.5f),
                new Pen(Color.DarkOliveGreen, 1.5f),
                new Pen(Color.Lavender, 1.5f),
                new Pen(Color.HotPink, 1.5f),
                new Pen(Color.Blue, 1.5f),
                new Pen(Color.DarkTurquoise, 1.5f),
                new Pen(Color.DeepPink, 1.5f),
                new Pen(Color.Red, 1.5f),
                new Pen(Color.Brown, 1.5f),
                new Pen(Color.DarkOrange, 1.5f),
                new Pen(Color.DarkGray, 1.5f),
                new Pen(Color.Orange, 1.5f),
                new Pen(Color.Blue , 1.5f),
                new Pen(Color.Red, 1.5f),
                new Pen(Color.Green, 1.5f),
                new Pen(Color.Purple, 1.5f),
                new Pen(Color.DarkOliveGreen, 1.5f),
                new Pen(Color.Lavender, 1.5f),
                new Pen(Color.HotPink, 1.5f),
                new Pen(Color.Blue, 1.5f),
                new Pen(Color.DarkTurquoise, 1.5f),
                new Pen(Color.DeepPink, 1.5f),
                new Pen(Color.Red, 1.5f),
                new Pen(Color.Brown, 1.5f),
                new Pen(Color.DarkOrange, 1.5f),
                new Pen(Color.DarkGray, 1.5f),
                new Pen(Color.Orange, 1.5f),
                new Pen(Color.Blue , 1.5f),
                new Pen(Color.Red, 1.5f),
                new Pen(Color.Green, 1.5f),
                new Pen(Color.Purple, 1.5f),
                new Pen(Color.DarkOliveGreen, 1.5f),
                new Pen(Color.Lavender, 1.5f),
                new Pen(Color.HotPink, 1.5f),
                new Pen(Color.Blue, 1.5f),
                new Pen(Color.DarkTurquoise, 1.5f),
                new Pen(Color.DeepPink, 1.5f),
                new Pen(Color.Red, 1.5f),
                new Pen(Color.Brown, 1.5f),
                new Pen(Color.DarkOrange, 1.5f),
                new Pen(Color.DarkGray, 1.5f)

            };
            Pen penLine = new Pen(Color.Gray, 1.5f);
            Font fnt = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            Brush br = new SolidBrush(Color.Black);


            int m = 0;
            Image image1 = Image.FromFile("" + path + "\\img\\logoLogo.png"); //просто лого-заглушка
            int x = 10, y = 30; //положение точки для верхнего поколения
            int stepHor = 350; //блок для одного чела с партнером 50 отступ 100 эллипс 50 отступ справа снова 100 эллипс 50 отступ
            int stepVert = 200; //блок для пары в высоту 50 100 50 \

            int stepVertLineforCouple = 0;
            
            

            int count = persones.Count; //количество людей

            List<int> usedId = new List<int>(); //список нарисованных людей

            for (int i = length - 1; i >= 0; i--) //прорисовка блоков цикл по поколениям c самого старого
            {
                
               

                for (int k = 0; k < gener[i].Count; k++) //цикл по массивам внутри поколений 
                {
                    int idTemp = gener[i][k][1]; //текущий человек

                    foreach (var item in persones)
                    {
                        if (item.Id == idTemp && item.isDelete == 1) //если такой существует и не удален
                        {
                            if (!usedId.Exists(value => value == idTemp)) //проверка если он уже нарисован
                            {

                                if (item.IdPartner != 0) //если у человека пара не ноль
                                {

                                    if (persones.Exists(value => value.Id == item.IdPartner))
                                    { //ищем в списке людей партнера, если нашли то 

                                        Cards partnerTemp = persones.Find(find => find.IdPartner == item.Id); //присваиваем переменную партнеру

                                        if (partnerTemp.isDelete == 1) //&& !usedId.Exists(value => value == partnerTemp.Id)) и проверяем не удален ли партнер
                                        {

                                           
                                            if (item.IdMom != 0) //ищем мать, если есть для отрисовки линии наверх для связи
                                            {

                                                Cards momTemp = persones.Find(find => find.Id == item.IdMom); //то присваиваем мать в переменную
                                                if (momTemp.isDelete == 1)
                                                {

                                                    graph.DrawLine(momTemp.pen, x + 50, y + 50, x + 50, momTemp.endVertical.Y); //линия вверх
                                                    graph.DrawLine(momTemp.pen, x + 50, momTemp.endVertical.Y, momTemp.endVertical.X, momTemp.endVertical.Y); //линия горизонтальная
                                                    
                                                }

                                            }
                                            if (item.IdDad != 0) //ищем отца, если есть для отрисовки линии наверх для связи
                                            {

                                                Cards dadTemp = persones.Find(find => find.Id == item.IdDad); //то присваиваем отца в переменную

                                                if (dadTemp.isDelete == 1)
                                                {
                                                    graph.DrawLine(dadTemp.pen, x + 50, dadTemp.endVertical.Y, dadTemp.endVertical.X, dadTemp.endVertical.Y);
                                                    graph.DrawLine(dadTemp.pen, x + 50, y + 50, x + 50, dadTemp.endVertical.Y);
                                                    
                                                }

                                            }
                                            Point coord = new Point(x, y + 50);
                                            item.coord = coord;


                                            
                                            graph.DrawImage(image1, item.coord.X, item.coord.Y); //нарисовали человека, по идее надо брать фотографию!! стоит заглушка
                                            graph.DrawString(item.FIO, fnt, br, x, y + 30); //написали имя внизу

                                            if (partnerTemp.IdMom != 0)
                                            {
                                                Cards momPartnerTemp = persones.Find(find => find.Id == partnerTemp.IdMom);//присваиваем в переменную матери партнера
                                                if (momPartnerTemp.isDelete == 1)
                                                {
                                                    graph.DrawLine(momPartnerTemp.pen, x + 200, momPartnerTemp.endVertical.Y, momPartnerTemp.endVertical.X, momPartnerTemp.endVertical.Y);
                                                    graph.DrawLine(momPartnerTemp.pen, x + 200, y + 50, x + 200, momPartnerTemp.endVertical.Y);
                                                   
                                                }

                                            }
                                            if (partnerTemp.IdDad != 0)
                                            {
                                                Cards dadPartnerTemp = persones.Find(find => find.Id == partnerTemp.IdDad);//присваиваем в переменную отца партнера
                                                if (dadPartnerTemp.isDelete == 1)
                                                {
                                                    graph.DrawLine(dadPartnerTemp.pen, x + 200, dadPartnerTemp.endVertical.Y, dadPartnerTemp.endVertical.X, dadPartnerTemp.endVertical.Y);
                                                    graph.DrawLine(dadPartnerTemp.pen, x + 200, y + 50, x + 200, dadPartnerTemp.endVertical.Y);
                                                    
                                                }

                                            }
                                            Point partnerCoord = new Point(x + 150, y + 50);
                                            partnerTemp.coord = partnerCoord; //сохранили координатную точку отрисовки эллипса элемента партнера

                                            graph.DrawImage(image1, partnerTemp.coord.X, partnerTemp.coord.Y); //нарисовали партнера

                                            graph.DrawString(partnerTemp.FIO, fnt, br, x + 200, y + 30); //фио партнера

                                            item.pen = pens[m];
                                            m++;
                                            partnerTemp.pen = item.pen;


                                            graph.DrawLine(item.pen, x + 100, y + 100, x + 150, y + 100); //линия между супругами

                                            if (persones.Exists(find => find.IdDad == item.Id)) //проверка является ли отцом  для линии вниз
                                            {
                                                Cards father = persones.Find(find => find.IdDad == item.Id);
                                                if (father.isDelete == 1)
                                                {

                                                    Point endVert = new Point(x + 125, y + 200 - stepVertLineforCouple);
                                                    item.endVertical = endVert;
                                                    partnerTemp.endVertical = endVert;


                                                    graph.DrawLine(item.pen, x + 125, y + 100, item.endVertical.X, item.endVertical.Y);
                                                    //линия вниз в другое поколение СДЕЛАТЬ С КАЖДОЙ ИТЕРАЦИЕЙ НА ШАГ МЕНЬШЕ


                                                }

                                            }

                                            if (persones.Exists(find => find.IdMom == item.Id)) //проверка является ли этот человек матерью для линии вниз
                                            {
                                                Cards mother = persones.Find(find => find.IdMom == item.Id);
                                                if (mother.isDelete == 1)
                                                {

                                                    Point endVert = new Point(x + 125, y + 200 - stepVertLineforCouple);
                                                    item.endVertical = endVert;
                                                    partnerTemp.endVertical = endVert;


                                                    graph.DrawLine(item.pen, x + 125, y + 100, item.endVertical.X, item.endVertical.Y); //линия вниз в другое поколение


                                                }

                                            }
                                            stepVertLineforCouple += 5;
                                            usedId.Add(item.Id);
                                            usedId.Add(partnerTemp.Id); // добавили в список использованных

                                        }
                                        else //если партнер удален, то рисуем как одинокого человека
                                        {
                                            if (item.IdMom != 0)
                                            {
                                                Cards momTemp2 = persones.Find(find => find.Id == item.IdMom);
                                                if (momTemp2.isDelete == 1)
                                                {

                                                    graph.DrawLine(momTemp2.pen, x + 50, y + 50, x + 50, momTemp2.endVertical.Y);
                                                    graph.DrawLine(momTemp2.pen, x + 50, momTemp2.endVertical.Y, momTemp2.endVertical.X, momTemp2.endVertical.Y);
                                                   
                                                }

                                            }
                                            
                                            if (item.IdDad != 0)
                                            {
                                                Cards dadTemp = persones.Find(find => find.Id == item.IdDad);

                                                if (dadTemp.isDelete == 1)
                                                {
                                                    graph.DrawLine(dadTemp.pen, x + 50, dadTemp.endVertical.Y, dadTemp.endVertical.X, dadTemp.endVertical.Y);
                                                    graph.DrawLine(dadTemp.pen, x + 50, y + 50, x + 50, dadTemp.endVertical.Y);
                                                   
                                                }
                                            }
                                            

                                            if (persones.Exists(find => find.IdDad == item.Id)) //проверка является ли этот человек отцом
                                            {
                                                item.pen = pens[m];
                                                m++;
                                                Cards child = persones.Find(find => find.IdDad == item.Id);
                                                if (child.isDelete == 1)
                                                {
                                                    Point endVert = new Point(x + 50, y + 200 - stepVertLineforCouple);
                                                    item.endVertical = endVert;
                                                    graph.DrawLine(item.pen, x + 50, y + 150, item.endVertical.X, item.endVertical.Y); //линия вниз в другое поколение
                                                }
                                                //линия вниз в другое поколение
                                            }

                                            if (persones.Exists(find => find.IdMom == item.Id)) //проверка является ли этот человек матерью
                                            {
                                                item.pen = pens[m];
                                                m++;
                                                Cards child = persones.Find(find => find.IdMom == item.Id);
                                                if (child.isDelete == 1)
                                                {

                                                    Point endVert = new Point(x + 50, y + 200 - stepVertLineforCouple);
                                                    item.endVertical = endVert;
                                                    graph.DrawLine(item.pen, x + 50, y + 150, item.endVertical.X, item.endVertical.Y);  //линия вниз в другое поколение
                                                }

                                            }

                                            Point coord = new Point(x, y + 50);
                                            item.coord = coord;
                                            stepVertLineforCouple += 5;
                                            
                                            graph.DrawImage(image1, item.coord.X, item.coord.Y); //добавить фото
                                            graph.DrawString(item.FIO, fnt, br, x, y + 30); //строчка внизу
                                            usedId.Add(item.Id);
                                        }
                                    }

                                }
                                if (item.IdPartner == 0) //одинокий человек
                                {
                                    if (item.IdMom != 0)
                                    {
                                        Cards momTemp2 = persones.Find(find => find.Id == item.IdMom);
                                        if (momTemp2.isDelete == 1)
                                        {
                                            graph.DrawLine(momTemp2.pen, x + 50, momTemp2.endVertical.Y, momTemp2.endVertical.X, momTemp2.endVertical.Y);
                                            graph.DrawLine(penLine, x + 50, y + 50, x + 50, momTemp2.endVertical.Y);
                                            
                                        }

                                    }
                                   
                                    if (item.IdDad != 0)
                                    {
                                        Cards dadTemp = persones.Find(find => find.Id == item.IdDad);

                                        if (dadTemp.isDelete == 1)
                                        {
                                            graph.DrawLine(dadTemp.pen, x + 50, dadTemp.endVertical.Y, dadTemp.endVertical.X, dadTemp.endVertical.Y);
                                            graph.DrawLine(dadTemp.pen, x + 50, y + 50, x + 50, dadTemp.endVertical.Y);
                                            
                                        }
                                    }
                                   

                                    if (persones.Exists(find => find.IdDad == item.Id)) //проверка является ли этот человек отцом
                                    {
                                        Cards father = persones.Find(find => find.IdDad == item.Id);
                                        if (father.isDelete == 1)
                                        {
                                            item.pen = pens[m];
                                            m++;
                                            Point endVert = new Point(x + 50, y + 200 - stepVertLineforCouple);
                                            item.endVertical = endVert;
                                            graph.DrawLine(item.pen, x + 50, y + 150, item.endVertical.X, item.endVertical.Y); //линия вниз в другое поколение
                                        }

                                    }

                                    if (persones.Exists(find => find.IdMom == item.Id)) //проверка является ли этот человек матерью
                                    {
                                        Cards mother = persones.Find(find => find.IdMom == item.Id);
                                        if (mother.isDelete == 1)
                                        {
                                            item.pen = pens[m];
                                            m++;
                                            Point endVert = new Point(x + 50, y + 200 - stepVertLineforCouple);
                                            item.endVertical = endVert;
                                            graph.DrawLine(item.pen, x + 50, y + 150, item.endVertical.X, item.endVertical.Y);  //линия вниз в другое поколение
                                        }
                                    }
                                    Point coord = new Point(x, y + 50);
                                    item.coord = coord;
                                   
                                    graph.DrawImage(image1, item.coord.X, item.coord.Y); //добавить фото
                                    graph.DrawString(item.FIO, fnt, br, x, y + 30); //строчка внизу
                                    usedId.Add(item.Id);
                                    stepVertLineforCouple += 5;

                                }

                            }

                        }
                    }

                    x += stepHor;

                }
                x = 10;
                y += stepVert;
                stepVertLineforCouple = 0;

            }

            
            pictureBoxTree.Image = bmp;
        }


        private void buttonSearch_Click(object sender, EventArgs e)
        {
            List<Cards> persones = GetDataFromBD();

            object obj = comboBoxSearch.SelectedItem;


            if (obj == null)
            {
                MessageBox.Show("Выберите родственника");
            }
            else
            {
                string choseen = obj.ToString();
                Cards choseenPerson = persones.Find(find => find.FIO == choseen);
                showCard(choseenPerson.Id);

            }


            comboBoxSearch.SelectedIndex = -1;
        }

        private void showCard(int MyId)
        {
            if (MyId != 0)
            {
                Card cardShow = new Card(MyId);


                if (cardShow.ShowDialog() == DialogResult.OK)
                {

                    cardShow.Close();
                    comboBoxSearch.SelectedIndex = -1;
                    DrawTreeBmp();
                    SortListFam();
                    SearchCard();
                }
            }
        }

        private void SearchCard()
        {
            comboBoxSearch.Items.Clear();
            List<Cards> persones = GetDataFromBD();
            List<String> fioPersones = new List<String>();

            foreach (var item in persones)
            {
                if (item.isDelete == 1 && item.Id != 1) //список из фамилий, которые не удалены
                {
                    fioPersones.Add(item.FIO);
                    comboBoxSearch.Items.Add(item.FIO);
                }

                //заполняем комбобокс
            }

            var values = new AutoCompleteStringCollection();
            values.AddRange(fioPersones.ToArray());
            comboBoxSearch.AutoCompleteCustomSource = values;
            comboBoxSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        private void ChangeBioButton_Click(object sender, EventArgs e)
        {
            try
            {
                sql.command.CommandText = "SELECT * FROM Card WHERE id='" + DataClass.CardID + "' ";
                SQLiteDataReader read0 = sql.command.ExecuteReader();
                int q = 0;
                while (read0.Read())
                {
                    if (Convert.ToString(read0["bio"]) != textBoxBio.Text)
                    {
                        q = 1;
                    }
                }
                read0.Close();
                if (q == 1)
                {
                    sql.command.CommandText = "UPDATE Card SET bio = '" + textBoxBio.Text + "' WHERE id = '" + DataClass.CardID + "' ";
                    sql.command.ExecuteNonQuery();
                    MessageBox.Show("Биография успешно изменена");
                }

            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: стр рег" + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.BPM;*.JPG;*.GIF;*.PNG)|*.BPM;*.JPG;*.GIF;*.PNG|All Files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBoxAva.Image = new Bitmap(ofd.FileName);
                    PathSave = ofd.FileName.ToString();
                }
                catch
                {
                    MessageBox.Show("Невозможно открыть выбранный файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (PathSave != "q")
            {
                byte[] ImageBt = null;
                FileStream fstream = new FileStream(this.PathSave, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fstream);
                ImageBt = br.ReadBytes((int)fstream.Length);

                sql.command.CommandText = "UPDATE Card SET PhotoOnAva =@img , ifAva = 1 WHERE id= '" + DataClass.CardID + "'";
                sql.command.Parameters.AddWithValue("@img", ImageBt);
                sql.command.ExecuteNonQuery();

                MessageBox.Show("Фото успешно изменено");
                PathSave = "";
            }
        }

        private void ChangeNameAndYearsButton_Click_1(object sender, EventArgs e)
        {
            if (SurnameBox.Text != Surname || NameBox.Text != Name || MiddlenameBox.Text != Middlename || BirthdayBox.Text != Birthday || DeathdayBox.Text != Deathday)
            {
                try
                {
                    sql.command.CommandText = "UPDATE Card SET surname= '" + SurnameBox.Text + "', name= '" +
                        NameBox.Text + "', middlename= '" +
                        MiddlenameBox.Text + "', birthday= '" +
                        BirthdayBox.Text + "', deathday = '" +
                        DeathdayBox.Text + "' WHERE id ='" + DataClass.CardID + "'  ";
                    sql.command.ExecuteNonQuery();
                    MessageBox.Show("Данные успешно изменены");
                    DrawTreeBmp();

                    sql.command.CommandText = "SELECT * FROM Card WHERE id = '" + DataClass.CardID + "' ";
                    SQLiteDataReader read2 = sql.command.ExecuteReader();
                    while (read2.Read())
                    {
                        SurnameBox.Text = read2["surname"].ToString();// Вывод имени
                        Surname = read2["surname"].ToString();
                        NameBox.Text = read2["name"].ToString();
                        Name = read2["name"].ToString();
                        MiddlenameBox.Text = read2["middlename"].ToString();
                        Middlename = read2["middlename"].ToString();

                        if (read2["deathday"].ToString() == "")// Вывод дат жизни и возраста
                        {
                            BirthdayBox.Text = read2["birthday"].ToString();
                            Birthday = read2["birthday"].ToString();
                            Deathday = "";

                            //И возраст
                            DateTime datetime = DateTime.Now; //Добавление настоящей даты 
                            string date = Convert.ToString(datetime);
                            CountAge(Birthday, date);
                        }
                        else
                        {
                            BirthdayBox.Text = read2["birthday"].ToString();
                            DeathdayBox.Text = read2["deathday"].ToString();
                            Birthday = read2["birthday"].ToString();
                            Deathday = read2["deathday"].ToString();

                            //Возраст человека в день смерти
                            CountAge(Birthday, Deathday);
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



        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }



        private void listBox1_Format(object sender, ListControlConvertEventArgs e)
        {
            string fio = ((Cards)e.ListItem).FIO.ToString();
            string data = ((Cards)e.ListItem).BirthDay.ToString();
            string steprod = ((Cards)e.ListItem).StepRod.ToString();

            e.Value = fio + " ; Д/Р: " + data + " ; " + steprod;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Cards Person = dataGridView1.CurrentRow.DataBoundItem as Cards;
            if (dataGridView1.SelectedRows.Count ==  1)
            {
                Person.isDelete = 0;
                sql.command.CommandText = "UPDATE Card SET isDelete = '" + Person.isDelete + "' WHERE id = '" + Person.Id + "'  ";
                sql.command.ExecuteNonQuery();
                sql.command.CommandText = "UPDATE Card SET idMom = 0 WHERE idMom = '" + Person.Id + "'  ";
                sql.command.ExecuteNonQuery();
                sql.command.CommandText = "UPDATE Card SET idDad = 0 WHERE idDad = '" + Person.Id + "'  ";
                sql.command.ExecuteNonQuery();
                sql.command.CommandText = "UPDATE Card SET idPartner = 0 WHERE idPartner = '" + Person.Id + "'  ";
                sql.command.ExecuteNonQuery();
            }
            else
                MessageBox.Show("Выберите элемент");

            DrawTreeBmp();
            SortListFam();
            SearchCard();
            UpdateParents();
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.BPM;*.JPG;*.GIF;*.PNG)|*.BPM;*.JPG;*.GIF;*.PNG|All Files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image = new Bitmap(ofd.FileName);
                    PathSave2 = ofd.FileName.ToString();
                }
                catch
                {
                    MessageBox.Show("Невозможно открыть выбранный файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                MessageBox.Show("Выберите файл");
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (PathSave2 != "q")
            {
                byte[] ImageBt = null;
                FileStream fstream = new FileStream(this.PathSave2, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fstream);
                ImageBt = br.ReadBytes((int)fstream.Length);

                sql.command.CommandText = "INSERT INTO Photos (photo, IfEx, idCard) VALUES ( @img , 1 , '" + DataClass.CardID + "') ";
                sql.command.Parameters.AddWithValue("@img", ImageBt);
                sql.command.ExecuteNonQuery();

                MessageBox.Show("Фото успешно добавлено");
                PathSave2 = "";
                listView1.Clear();
                ShowPhoto();
            }
        }

        

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listView1.CheckedItems.Count; i++)
            {
                int id = Convert.ToInt32(listView1.CheckedItems[i].Tag);

                sql.command.CommandText = "UPDATE Photos SET ifEx = '0' WHERE id = '" + id + "'  ";
                sql.command.ExecuteNonQuery();
                MessageBox.Show("Фото успешно удалено.");
                listView1.CheckedItems[i].Remove();

            }
        }        
    }

}
