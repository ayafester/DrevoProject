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

    public class ConnectBD
    {
        public String dbName;
        public SQLiteConnection connect;
        public SQLiteCommand command;
        public ConnectBD ()
        {
            connect = new SQLiteConnection();
            command = new SQLiteCommand();

            dbName = "DrevoBD.sqlite";

            connect = new SQLiteConnection("Data Source=" + dbName + ";Version=3;");
            connect.Open();
            command.Connection = connect;

            if (!File.Exists(dbName))
                SQLiteConnection.CreateFile(dbName);

            try
            {

                command.CommandText = "CREATE TABLE IF NOT EXISTS User (id INTEGER PRIMARY KEY AUTOINCREMENT, mail TEXT, password TEXT, idCard INTEGER DEFAULT 1)";
                command.ExecuteNonQuery();

                command.CommandText = "CREATE TABLE IF NOT EXISTS Card (id INTEGER PRIMARY KEY AUTOINCREMENT, surname TEXT, name TEXT, middlename TEXT, gender INTEGER, " +
                    "bio TEXT, birthday TEXT, deathday TEXT, number TEXT, idCreator INTEGER REFERENCES User(id), idMom INTEGER REFERENCES Card(id) DEFAULT 0, " +
                    "idDad INTEGER REFERENCES Card(id) DEFAULT 0, idPartner INTEGER REFERENCES Card(id) DEFAULT 0, PhotoOnAva TEXT, Generation INTEGER)";
                command.ExecuteNonQuery();

                command.CommandText = "CREATE TABLE IF NOT EXISTS Photos (id INTEGER PRIMARY KEY AUTOINCREMENT, link TEXT, idCard INTEGER REFERENCES Card(id) DEFAULT 0)"; //Создали таблицу Фото ... если много фото?
                command.ExecuteNonQuery();

                


            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: стр датакласс" + ex.Message);
            }
        }
    }
}
