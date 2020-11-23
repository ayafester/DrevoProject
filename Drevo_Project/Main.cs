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
        public String Surname { get; set; }
        public String Name { get; set; }
        public String Middlename { get; set; }
        public String Birthday { get; set; }
        public String Deathday { get; set; }
        public int Age { get; set; }
        public int Year { get; set; }
        public int Mounth { get; set; }
        public int Day { get; set; }
        public int Yeartd { get; set; }
        public int Mounthtd { get; set; }
        public int Daytd { get; set; }
        public String Try { get; set; }
        public String PathSave { get; set; }

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

                        String str = read2["birthday"].ToString();
                        // обрезаем начиная с седьмого символа 
                        Year = Convert.ToInt32(str.Substring(6));                       

                        str = read2["birthday"].ToString();
                        // обрезаем начиная с четвертого до последних пяти символов
                        Mounth = Convert.ToInt32(str.Substring(3, 2));
                        
                        str = read2["birthday"].ToString();
                        // обрезаем сначала до последних восьми символов
                        Day = Convert.ToInt32(str.Substring(0, 2));
                        

                        string date = "";
                        DateTime datetime = DateTime.Now; //Добавление настоящей даты 
                        string dateSave = Convert.ToString(datetime);
                        date = dateSave;
                        Daytd = Convert.ToInt32(dateSave.Substring(0, 2));
                        dateSave = date;
                        Mounthtd = Convert.ToInt32(dateSave.Substring(3, 2));
                        dateSave = date;
                        Yeartd = Convert.ToInt32(dateSave.Substring(6, 4));
                        dateSave = date;                       

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
                    else
                    {
                        BirthdayBox.Text = read2["birthday"].ToString();
                        DeathdayBox.Text = read2["deathday"].ToString();                        
                        Birthday = read2["birthday"].ToString();
                        Deathday = read2["deathday"].ToString();

                        //Возраст человека в день смерти
                        String str = read2["birthday"].ToString();
                        Year = Convert.ToInt32(str.Substring(6));
                        str = read2["birthday"].ToString();
                        Mounth = Convert.ToInt32(str.Substring(3, 2));
                        str = read2["birthday"].ToString();
                        Day = Convert.ToInt32(str.Substring(0, 2));

                        string date = "";                       
                        string dateSave = Deathday;
                        date = dateSave;
                        Daytd = Convert.ToInt32(dateSave.Substring(0, 2));
                        dateSave = date;
                        Mounthtd = Convert.ToInt32(dateSave.Substring(3, 2));
                        dateSave = date;
                        Yeartd = Convert.ToInt32(dateSave.Substring(6, 4));
                        dateSave = date;


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
                    if (Convert.ToInt32(read2["ifAva"]) == 1)//Вывод Аватарки
                    {
                        byte[] imgg = (byte[])(read2["PhotoOnAva"]);
                        MemoryStream mstream = new MemoryStream(imgg);
                        pictureBoxAva.Image = Image.FromStream(mstream);
                    }

                    //Вывод фотоальбома TO DO

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
                    MessageBox.Show("Контакты успешно изменены");
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

            /*List<List<int[]>> gener = SortDataToGeneration(); //[generation, id, idPartner, idMom, idDad]
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

            pictureBoxTree.Image = bmp;*/
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
                if (q==1)
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
            if (PathSave != "")
            {
                byte[] ImageBt = null;
                FileStream fstream = new FileStream(this.PathSave, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fstream);
                ImageBt = br.ReadBytes((int)fstream.Length);

                sql.command.CommandText = "UPDATE Card SET PhotoOnAva =@img , ifAva = 1 WHERE id= '" + DataClass.CardID + "'";
                sql.command.Parameters.AddWithValue("@img", ImageBt);
                sql.command.ExecuteNonQuery();

                MessageBox.Show("Фото успешно изменено");
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

                            String str = read2["birthday"].ToString();
                            // обрезаем начиная с седьмого символа 
                            Year = Convert.ToInt32(str.Substring(6));

                            str = read2["birthday"].ToString();
                            // обрезаем начиная с четвертого до последних пяти символов
                            Mounth = Convert.ToInt32(str.Substring(3, 2));

                            str = read2["birthday"].ToString();
                            // обрезаем сначала до последних восьми символов
                            Day = Convert.ToInt32(str.Substring(0, 2));


                            string date = "";
                            DateTime datetime = DateTime.Now; //Добавление настоящей даты 
                            string dateSave = Convert.ToString(datetime);
                            date = dateSave;
                            Daytd = Convert.ToInt32(dateSave.Substring(0, 2));
                            dateSave = date;
                            Mounthtd = Convert.ToInt32(dateSave.Substring(3, 2));
                            dateSave = date;
                            Yeartd = Convert.ToInt32(dateSave.Substring(6, 4));
                            dateSave = date;

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
                        else
                        {
                            BirthdayBox.Text = read2["birthday"].ToString();
                            DeathdayBox.Text = read2["deathday"].ToString();
                            Birthday = read2["birthday"].ToString();
                            Deathday = read2["deathday"].ToString();

                            //Возраст человека в день смерти
                            String str = read2["birthday"].ToString();
                            Year = Convert.ToInt32(str.Substring(6));
                            str = read2["birthday"].ToString();
                            Mounth = Convert.ToInt32(str.Substring(3, 2));
                            str = read2["birthday"].ToString();
                            Day = Convert.ToInt32(str.Substring(0, 2));

                            string date = "";
                            string dateSave = Deathday;
                            date = dateSave;
                            Daytd = Convert.ToInt32(dateSave.Substring(0, 2));
                            dateSave = date;
                            Mounthtd = Convert.ToInt32(dateSave.Substring(3, 2));
                            dateSave = date;
                            Yeartd = Convert.ToInt32(dateSave.Substring(6, 4));
                            dateSave = date;


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

                    }

                    read2.Close();

                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Error: стр рег" + ex.Message);
                }
            }
        }

        private void listBoxPhoto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
