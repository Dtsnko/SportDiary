using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SportDiary
{
    public class DBProductsConnect
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public DBProductsConnect()
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
                        MessageBox.Show("Невозможно подключиться к базе данных");
                        break;
                    case 1045:
                        MessageBox.Show("Не правильный логин/пароль");
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
        public void InsertProduct(Product prod)
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

        public void UpdateName(int id, string newName = "newName")
        {
            string query = $"UPDATE Products SET name='{newName} WHERE id='{id}'";

            if (OpenConnection() == true)
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                CloseConnection();
            }
        }
        public void UpdateCalories(int id, Product newProduct)
        {
            string query = $"UPDATE products SET calories='{newProduct.Calories}, proteins='{newProduct.Proteins}', fats='{newProduct.Fats}', carbohydrates='{newProduct.Carbohydrates}' WHERE id='{id}'";

            if (OpenConnection() == true)
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                CloseConnection();
            }
        }
       

        public void DeleteProduct(List<int> id)
        {
            for (int i = 0; i < id.Count; i++)
            {
                string query = $"DELETE FROM products WHERE id = '{id[i]}';";

                if (OpenConnection() == true)
                {
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    CloseConnection();
                    MessageBox.Show("Успешно удалено");
                }
            }
        }
        public List<string>[] SelectSeveralProducts(string name) 
        {
            string query;
            if (name == "")
            {
                query = "SELECT * FROM products;";
                
            }
            else
                query = $"SELECT * FROM products WHERE name ='{name}';";
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
        public List<string>[] SelectAllProducts()
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

        public void ExecuteCommand(string command)
        {
            if(OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(command, connection);
                cmd.ExecuteNonQuery();
                CloseConnection();
            }
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
