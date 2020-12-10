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

    public partial class Card : Form
    {
        ConnectBD sql = new ConnectBD();

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



        }
        public static int MomToNewGen { get; set; }
        public static int DadToNewGen { get; set; }

        public static int CreatedID { get; set; }
        public int MyId { get; set; } // это для выгрузки данных по пришедшему айди у человека
        public Card(int id) //когда вызываешь форму эту модальную, надо туда указывать айди человека которого хотим взять данные
        {
            MyId = id;
            InitializeComponent();
            if (DataClass.ID != "1")
            {
                buttonEditCard.Enabled = false;
            }
        }
        private List<Cards> GetDataFromBD()
        {
            sql.command.CommandText = "SELECT Generation, id, idPartner, idMom, idDad, surname|| ' ' || name || ' ' || middlename, isDelete, birthday FROM Card WHERE id >= 1 ";
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
        private void Card_Load(object sender, EventArgs e)
        {

            try
            {
                sql.command.CommandText = "SELECT * FROM User WHERE id='" + MyId + "' ";
                //SQLiteDataAdapter adapter1 = new SQLiteDataAdapter(sql.command.Connection);

                SQLiteDataReader read = sql.command.ExecuteReader();

                while (read.Read())
                {
                    DataClass.CardID = read["idCard"].ToString();
                }
                read.Close();

                sql.command.CommandText = "SELECT * FROM Card WHERE id = '" + MyId + "' ";
                SQLiteDataReader read2 = sql.command.ExecuteReader();
                while (read2.Read())
                {
                    labelFioCard.Text = read2["surname"].ToString() + " " + read2["name"].ToString() + " " + read2["middlename"].ToString();

                    labelBioCard.Text = Convert.ToString(read2["bio"]);
                    if (read2["deathday"].ToString() == "")
                    {
                        labelDataBornCard.Text = read2["birthday"].ToString() + "";
                    }
                    else
                    {
                        labelDataBornCard.Text = read2["birthday"].ToString() + "-" + read2["deathday"].ToString();
                    }
                }
                read2.Close();

                sql.command.CommandText = "SELECT * FROM Card WHERE id = '" + MyId + "' ";
                SQLiteDataReader read3 = sql.command.ExecuteReader();

                while (read3.Read())
                {
                    NumberBoxCard.Text = read3["number"].ToString();
                    MailBoxCard.Text = read3["mail"].ToString();


                }
                read3.Close();

                sql.command.CommandText = "SELECT * FROM Card WHERE id = '" + MyId + "' ";
                SQLiteDataReader read4 = sql.command.ExecuteReader();

                while (read4.Read())
                {
                    if (Convert.ToInt32(read4["ifAva"]) == 1)//Вывод Аватарки
                    {
                        byte[] imgg = (byte[])(read4["PhotoOnAva"]);
                        MemoryStream mstream = new MemoryStream(imgg);
                        pictureCard.Image = Image.FromStream(mstream);
                    }

                }
                read4.Close();

            }

            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: стр рег" + ex.Message);
            }
        }

        private void buttonEditCard_Click(object sender, EventArgs e)
        {
            EditCard editCard = new EditCard(MyId);


            if (editCard.ShowDialog() == DialogResult.OK)
            {

                editCard.Close();
                List<Cards> personesFind = GetDataFromBD();
                Cards created = personesFind.Find(find => find.Id == CreatedID); //нашли персонажа которого изменили только что
                if (DadToNewGen != 0)
                {
                    Cards dad = personesFind.Find(find => find.Id == DadToNewGen); //нашли отца его
                    int gen = created.Gener + 1;
                    sql.command.CommandText = " UPDATE Card SET Generation = '" + gen + "' WHERE id = '" + dad.Id + "' ";
                    sql.command.ExecuteNonQuery();
                }

                if (MomToNewGen != 0)
                {
                    Cards mom = personesFind.Find(find => find.Id == MomToNewGen); //нашли мать
                    int gen = created.Gener + 1;
                    sql.command.CommandText = " UPDATE Card SET Generation = '" + gen + "' WHERE id = '" + mom.Id + "' ";
                    sql.command.ExecuteNonQuery();
                }

                DialogResult = DialogResult.OK;
            }
        }
    }
}
