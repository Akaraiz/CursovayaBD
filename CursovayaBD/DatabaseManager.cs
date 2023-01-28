using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPS.DataBase
{

    class DatabaseManager
    {
        //создаем поле данных соеденения с MySql
        public MySqlConnection connection = new MySqlConnection("server=127.0.0.1;port=3306;username=root;password=root;database=teaDB");

        //метод, который открывает соединение
        public void OpenConnection()
        {
            //проверяем состояние подключения
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        //закрываем соеденение
        public void CloseConnection()
        {
            //проверяем, есть ли соединение 
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        //возращаем значения объекта соединения
        public MySqlConnection GetConnection { get { return connection; } }
        
        
    }
}