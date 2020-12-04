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

    public partial class NewCard : Form
    {
        ConnectBD sql = new ConnectBD();
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
        public int Gender { get; set; }
        public String idCreator { get; set; }
        public int Gener  { get; set; }
        public int isDelete { get; set; }

        public String PathSave { get; set; }

        public NewCard()
        {
            InitializeComponent();
        }

        private void NewCard_Load(object sender, EventArgs e)
        {
            PathSave = "q";
            sql.command.CommandText = "SELECT id,surname|| ' ' || name|| ' ' || middlename, gender, Generation FROM Card WHERE id >= 1";
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


            Females.Insert(0, new Person() { Id = 0, Name = " ", Gender = 0, Generation = 99 });
            comboBox1.DataSource = Females;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";
            comboBox1.SelectedIndex = 0;

            Males.Insert(0, new Person() { Id = 0, Name = " ", Gender = 0, Generation = 99 });
            comboBox2.DataSource = Males;
            comboBox2.DisplayMember = "Name";
            comboBox2.ValueMember = "Id";
            comboBox2.SelectedIndex = 0;

            Names.Insert(0, new Person() { Id = 0, Name = " ", Gender = 0, Generation = 99 });
            comboBox3.DataSource = Names;
            comboBox3.DisplayMember = "Name";
            comboBox3.ValueMember = "Id";
            comboBox3.SelectedIndex = 0;

            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            comboBox2.SelectedIndexChanged += ComboBox2_SelectedIndexChanged;
            comboBox3.SelectedIndexChanged += ComboBox3_SelectedIndexChanged;

            Gener = 99;
        }

        private void buttonSaveInfoAdd_Click(object sender, EventArgs e)
        {
            Mail = textBoxMailAdd.Text;
            Surname = textBoxSurnameAdd.Text;
            NamePerson = textBoxNameAdd.Text;
            Middlename = textBoxMiddlenameAdd.Text;
            DateBirthday = textBoxDateBirthday.Text;
            DateDeathday = textBoxDateDeathDay.Text;
            BIO = textBoxBioAdd.Text;
            Number = textBoxNumberAdd.Text;
            idCreator = DataClass.ID;
            isDelete = 1;

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
                    sql.command.CommandText = "INSERT INTO Card ('surname', 'name', 'middlename', 'gender', 'bio', 'idMom' ,'idDad' , 'birthday' , 'deathday', 'number', 'mail', 'idCreator', 'isDelete', 'Generation', 'idPartner') VALUES ('" + //пока добавление связей нет
                        Surname + "' , '" +
                        NamePerson + "' , '" +
                        Middlename + "' , '" +
                        Gender + "' , '" +
                        BIO + "' , '" +
                        idMom + "' , '" +
                        idDad + "' , '" +
                        DateBirthday + "' ,'" +
                        DateDeathday + "' , '" +
                        Number + "' , '" +
                        Mail + "' , '" +
                        idCreator + "' , '" +
                        isDelete + "' , '" +
                        Gener + "' , '" +
                        idPartner + "')";

                    sql.command.ExecuteNonQuery();
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Error:" + ex.Message);
                }


            DialogResult = DialogResult.OK;
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Person Female = comboBox1.SelectedItem as Person;
            idMom = Female.Id;
            if (Female.Generation!=99)
            {
                Gener = Female.Generation - 1;
            }
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Person Male = comboBox2.SelectedItem as Person;
            idDad = Male.Id;
            if(Male.Generation != 99)
            {
                Gener = Male.Generation - 1;
            }
        }

        private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Person Person = comboBox3.SelectedItem as Person;
            idPartner = Person.Id;
            if(Person.Generation != 99)
            {
                Gener = Person.Generation;
            }
        }

        private void buttonAddAva_Click(object sender, EventArgs e)
        {
            /*OpenFileDialog ofd = new OpenFileDialog();
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
            }*/
        }
    }
    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Gender { get; set; }
        public int Generation { get; set; }
    }
}
