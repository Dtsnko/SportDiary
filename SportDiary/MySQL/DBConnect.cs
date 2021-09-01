using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SportDiary
{
    public class DBConnect
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public DBConnect()
        {
            Initialize();

        }
        private void Initialize()
        {
            server = "localhost";
            database = "sportdiary";
            uid = "right";
            password = "root";
            string connectionString = "SERVER=" + server + ";" + "DATABASE=" +
        database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);
        }
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch(ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to database");
                        break;
                    case 1045:
                        MessageBox.Show("Invalid password/username");
                        break;
                }
                return false;


            }
        }
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public void Insert(Product prod)
        {
            if(prod.controlBit < 5 || prod.Name == null)
            {
                MessageBox.Show("Не правильно заданы параметры");
                return;
            }
            string query = $"INSERT INTO products (name, calories, proteins, fats, carbohydrates) VALUES ('{prod.Name}', {prod.Calories}, {prod.Proteins}, {prod.Fats}, {prod.Carbohydrates})";
            if(OpenConnection() == true)
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                CloseConnection();
                MessageBox.Show("Успешно добавлено");
                
            }
        }

        //public void Update(int id, string newName = "newName", int newCalories = 0)
        //{
        //    string query = $"UPDATE Products SET name='{newName}, calories='{newCalories}' WHERE id='{id}'";

        //    if (OpenConnection() == true)
        //    {
        //        MySqlCommand command = new MySqlCommand(query, connection);
        //        command.ExecuteNonQuery();
        //        CloseConnection();
        //    }
        //}
        public void Delete(List<int> id)
        {
            for (int i = 0; i < id.Count; i++)
            {
                string query = $"DELETE FROM products WHERE id = '{id[i]}';";

                if (OpenConnection() == true)
                {
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    CloseConnection();
                }
            }
        }
        public List<string>[] Select()
        {
            string query = "SELECT * FROM products";
            List<string>[] list = new List<string>[3];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();

            if (OpenConnection() == true)
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    list[0].Add(reader["id"] + "");
                    list[1].Add(reader["name"] + "");
                    list[2].Add(reader["calories"] + "");
                }
                reader.Close();
                CloseConnection();
                return list;

            }
            else
                return list;
        }

        ////Count statement
        //public int Count()
        //{
        //}

        ////Backup
        //public void Backup()
        //{
        //}

        ////Restore
        //public void Restore()
        //{
        //}
    }
}
