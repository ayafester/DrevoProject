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
    public partial class EditCard : Form
    {
        ConnectBD sql = new ConnectBD();
        public int MyId { get; set; }
        public String Mail { get; set; }
        public String Surname { get; set; }
        public String NamePerson { get; set; }
        public String Middlename { get; set; }

        public String DateBirthday { get; set; }
        public String DateDeathday { get; set; }

        public String BIO { get; set; }
        public String Number { get; set; }
        public int idMom { get; set; }
        public int idDad { get; set; }
        public int idPartner { get; set; }
        public int GenerT { get; set; }
        public int Gener { get; set; }

        public String PathSave { get; set; }
        public String PathSave2 { get; set; }

        public EditCard(int id)
        {
            MyId = id;
            InitializeComponent();
            
        }


        private void EditCard_Load(object sender, EventArgs e)
        {
            try
            {

                sql.command.CommandText = "SELECT * FROM Card WHERE id = '" + MyId + "' ";
                SQLiteDataReader read = sql.command.ExecuteReader();
                while (read.Read())
                {
                    textBoxSurnameEdit.Text = read["surname"].ToString();
                    textBoxDataNameEdit.Text = read["name"].ToString();
                    textBoxMiddlenameEdit.Text = read["middlename"].ToString();

                    textBoxBioEdit.Text = Convert.ToString(read["bio"]);
                    textBoxDateBirthday.Text = read["birthday"].ToString();
                    textBoxDateDeathDay.Text = read["deathday"].ToString();
                    textBoxMailEdit.Text = read["mail"].ToString();
                    textBoxNumberEdit.Text = read["number"].ToString();
                }
                read.Close();

                sql.command.CommandText = "SELECT idMom,idDad,idPartner,Generation FROM Card WHERE id = '" + MyId + "' ";
                SQLiteDataReader read1 = sql.command.ExecuteReader();
                while (read1.Read())
                {
                    idMom = read1.GetInt32(0);
                    idDad = read1.GetInt32(1);
                    idPartner = read1.GetInt32(2);
                    Gener = read1.GetInt32(3);
                }
                read1.Close();

                sql.command.CommandText = "SELECT id,surname|| ' ' || name|| ' ' || middlename, gender, Generation FROM Card WHERE id >= 1 and isDelete!=0";
                List<Person> Names = new List<Person>();
                try
                {
                    SQLiteDataReader r = sql.command.ExecuteReader();

                    while (r.Read())
                    {
                        Person entity = new Person
                        {
                            Id = r.GetInt32(0),
                            Name = r.GetString(1),
                            Gender = r.GetInt32(2),
                            Generation = r.GetInt32(3),
                        };
                        Names.Add(entity);
                    }
                    r.Close();
                    sql.command.ExecuteNonQuery();
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                List<Person> Males = new List<Person>();
                List<Person> Females = new List<Person>();
                foreach (var item in Names)
                {
                    if (item.Gender == 0)
                    {
                        Females.Add(item);
                    }
                    else
                    {
                        Males.Add(item);
                    }
                };
                int ind = 0;
                if (idMom != 0)
                {
                    Person Mom = Females.Find(find => find.Id == idMom);
                    ind = Females.IndexOf(Mom);
                }
                else
                {
                    Females.Insert(0, new Person() { Id = 0, Name = " ", Gender = 0, Generation = 99 });
                }


                comboBox1.DataSource = Females;
                comboBox1.DisplayMember = "Name";
                comboBox1.ValueMember = "Id";
                comboBox1.SelectedIndex = ind;

                ind = 0;
                if (idDad != 0)
                {
                    Person Dad = Males.Find(find => find.Id == idDad);
                    ind = Males.IndexOf(Dad);
                }
                else
                {
                    Males.Insert(0, new Person() { Id = 0, Name = " ", Gender = 0, Generation = 99 });
                }
                comboBox2.DataSource = Males;
                comboBox2.DisplayMember = "Name";
                comboBox2.ValueMember = "Id";
                comboBox2.SelectedIndex = ind;

                ind = 0;
                if (idPartner != 0)
                {
                    Person Partner = Names.Find(find => find.Id == idPartner);
                    ind = Names.IndexOf(Partner);
                }
                else
                {
                    Names.Insert(0, new Person() { Id = 0, Name = " ", Gender = 0, Generation = 99 });
                }
                comboBox3.DataSource = Names;
                comboBox3.DisplayMember = "Name";
                comboBox3.ValueMember = "Id";
                comboBox3.SelectedIndex = ind;

                comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
                comboBox2.SelectedIndexChanged += ComboBox2_SelectedIndexChanged;
                comboBox3.SelectedIndexChanged += ComboBox3_SelectedIndexChanged;

            }

            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: стр рег" + ex.Message);
            }

            ShowPhotoEdit();
        }

        private void buttonSaveInfo_Click(object sender, EventArgs e)
        {

            Mail = textBoxMailEdit.Text;
            Surname = textBoxSurnameEdit.Text;
            NamePerson = textBoxDataNameEdit.Text;
            Middlename = textBoxMiddlenameEdit.Text;
            DateBirthday = textBoxDateBirthday.Text;
            DateDeathday = textBoxDateDeathDay.Text;
            BIO = textBoxBioEdit.Text;
            Number = textBoxNumberEdit.Text;


            if (Gener != GenerT)
            {
                Gener = GenerT;
            }


            try
            {
                sql.command.CommandText = "UPDATE Card SET surname= '" + Surname +
                    "', name='" + NamePerson +
                    "' , middlename='" + Middlename +
                    "' , bio='" + BIO +
                    "' , idMom='" + idMom +
                    "'  ,idDad='" + idDad +
                    "'  , birthday='" + DateBirthday +
                    "'  , deathday='" + DateDeathday +
                    "' , number='" + Number +
                    "' , mail='" + Mail +
                    "' , Generation='" + Gener +
                    "' , idPartner='" + idPartner + "' WHERE id ='" + MyId + "'  ";

                sql.command.ExecuteNonQuery();
                MessageBox.Show("Данные успешно изменены");
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }

            if (idDad != 0)
            {
                Card.DadToNewGen = idDad;
            }
            if (idMom != 0)
            {
                Card.MomToNewGen = idMom;
            }

            Card.CreatedID = MyId;

            DialogResult = DialogResult.OK;
        }


        class Person
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Gender { get; set; }
            public int Generation { get; set; }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Person Female = comboBox1.SelectedItem as Person;
            idMom = Female.Id;

            if (Female.Generation != 99)
            {
                GenerT = Female.Generation - 1;
            }
            else GenerT = Gener;
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Person Male = comboBox2.SelectedItem as Person;
            idDad = Male.Id;

            if (Male.Generation != 99)
            {
                GenerT = Male.Generation - 1;
            }
            else GenerT = Gener;
        }

        private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Person Person = comboBox3.SelectedItem as Person;
            idPartner = Person.Id;
            if (Person.Generation != 99)
            {
                GenerT = Person.Generation;
            }
            else GenerT = Gener;
        }

        private void buttonAddAva_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.BPM;*.JPG;*.GIF;*.PNG)|*.BPM;*.JPG;*.GIF;*.PNG|All Files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    PathSave = ofd.FileName.ToString();
                }
                catch
                {
                    MessageBox.Show("Невозможно открыть выбранный файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                MessageBox.Show("Выберите файл");
            }
            if (PathSave != "q")
            {
                byte[] ImageBt = null;
                FileStream fstream = new FileStream(this.PathSave, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fstream);
                ImageBt = br.ReadBytes((int)fstream.Length);

                sql.command.CommandText = "UPDATE Card SET PhotoOnAva =@img , ifAva = 1 WHERE id= '" + MyId + "'";
                sql.command.Parameters.AddWithValue("@img", ImageBt);
                sql.command.ExecuteNonQuery();

                MessageBox.Show("Фото успешно изменено");
                PathSave = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.BPM;*.JPG;*.GIF;*.PNG)|*.BPM;*.JPG;*.GIF;*.PNG|All Files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBoxCard.Image = new Bitmap(ofd.FileName);
                    PathSave2 = ofd.FileName.ToString();
                }
                catch
                {
                    MessageBox.Show("Невозможно открыть выбранный файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Выберите файл");
            }
        }

        private void button4_Click(object sender, EventArgs e) //сохранить
        {
            if (PathSave2 != "q")
            {
                byte[] ImageBt = null;
                FileStream fstream = new FileStream(this.PathSave2, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fstream);
                ImageBt = br.ReadBytes((int)fstream.Length);

                sql.command.CommandText = "INSERT INTO Photos (photo, IfEx, idCard) VALUES ( @img , 1 , '" + MyId + "') ";
                sql.command.Parameters.AddWithValue("@img", ImageBt);
                sql.command.ExecuteNonQuery();

                MessageBox.Show("Фото успешно добавлено");
                PathSave2 = "";
                listViewCard.Clear();
                ShowPhotoEdit();
            }
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < listViewCard.CheckedItems.Count; i++)
            {
                int id = Convert.ToInt32(listViewCard.CheckedItems[i].Tag);

                sql.command.CommandText = "UPDATE Photos SET ifEx = '0' WHERE id = '" + id + "'  ";
                sql.command.ExecuteNonQuery();
                MessageBox.Show("Фото успешно удалено.");
                listViewCard.CheckedItems[i].Remove();

            }
            ShowPhotoEdit();
        }

        private void ShowPhotoEdit()
        {
            sql.command.CommandText = "SELECT * FROM Photos WHERE idCard ='" +  MyId + "' ";
            SQLiteDataReader read4 = sql.command.ExecuteReader();
            ImageList ImageList = new ImageList();
            ImageList.ImageSize = new Size(225, 150);
            int i = 0;
            while (read4.Read())//Вывод фотоальбома
            {
                if (Convert.ToInt32(read4["ifEx"]) == 1)
                {
                   
                    byte[] img = (byte[])(read4["photo"]);
                    MemoryStream mstr = new MemoryStream(img);
                    ImageList.Images.Add(Image.FromStream(mstr));
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.ImageIndex = i; // Convert.ToInt32(read4["id"]);
                    listViewItem.Tag = Convert.ToInt32(read4["id"]);
                    listViewCard.Items.Add(listViewItem);
                    i += 1;
                    
                }
            }
            read4.Close();
            listViewCard.SmallImageList = ImageList;
        }
    }
}
