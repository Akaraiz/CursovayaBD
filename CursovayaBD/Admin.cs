using FPS.DataBase;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CursovayaBD
{
    public partial class Admin_panel : Form
    {
        public Admin_panel()
        {
            InitializeComponent();
        }
        public static int schet = 0;
        DatabaseManager _databaseManager = new DatabaseManager();
        DataTable _dataTable = new DataTable();
        MySqlDataAdapter _mysqlDataAdapter = new MySqlDataAdapter();

        private void Admin_Load(object sender, EventArgs e)
        {

        }
         MySqlDataReader reader;
        public void on_Click(object sender, EventArgs e)
        {

            DatabaseManager _databaseManager = new DatabaseManager();
            DataTable _dataTable = new DataTable();
            MySqlDataAdapter _mysqlDataAdapter = new MySqlDataAdapter();
           

            MySqlCommand _mySqlCommand = new MySqlCommand("SELECT * FROM `drinks` WHERE `name`=@tText", _databaseManager.GetConnection);
           
            _mySqlCommand.Parameters.Add("@tText", MySqlDbType.VarChar).Value = sender.ToString().Substring(35);


            //try
            //{
            _databaseManager.OpenConnection();
            reader = _mySqlCommand.ExecuteReader();
            if (reader.Read())
            {
                textBox1.Text = reader["name"].ToString();
                textBox2.Text = reader["value"].ToString();
                textBox3.Text = reader["price"].ToString();
                textBox4.Text = reader["recept"].ToString();
            }
            



        }


        private void InitializeMyScrollBar()
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
        }

        public void NNewBTN()
        {
            Admin_panel admin = new Admin_panel();
            MySqlCommand _mySqlCommand = new MySqlCommand("SELECT * FROM `drinks`", _databaseManager.GetConnection);
            List<Zakaz.Stroka> _data = new List<Zakaz.Stroka>();
            int xX, yY;
            xX = 48;
            yY = 93;

            try
            {
                _databaseManager.OpenConnection();
                reader = _mySqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    Zakaz.Stroka n = new Zakaz.Stroka((int)reader["id"], (string)reader["name"], (double)reader["value"], (double)reader["price"]);
                    _data.Add(n);
                }
                for (int i = 0; i < _data.Count; i++)
                {
                    Button btn = new Button();
                    btn.Location = new Point(xX, yY);
                    btn.Tag = _data[i].id;
                    btn.Size = new Size(200, 60);

                    btn.Text = _data[i].name;

                    btn.Click += new EventHandler(admin.on_Click);
                    admin.Controls.Add(btn);

                    yY += 70;

                }

            }
            catch
            {
                MessageBox.Show("Problema");
            }
            admin.Show();
            this.Close();
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            LoginForm registration = new LoginForm();
            registration.Show();
            this.Close();
            
            
        }

        public void Export(string str)//сохранение дампа БД
        {
            string constring = "server=localhost;port=3306;username=root;password=root; database=teaDB";
            string file = str;
            using (MySqlConnection conn = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        cmd.Connection = conn;
                        conn.Open();
                        mb.ExportToFile(file);
                        conn.Close();
                    }
                }
            }
        }
        public void Import(string s)//загрузка БД
        {
            string constring = "server=localhost;port=3306;username=root;password=root; database=teaDB";
            string file = s;
            using (MySqlConnection conn = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {

                        cmd.Connection = conn;
                        conn.Open();
                        mb.ImportFromFile(file);
                        conn.Close();
                        NNewBTN();

                    }
                }
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
 

        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void greenSearch_Click(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Red;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Black;
        }

        Point lastPoint;

        private void Admin_panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }

        }

        private void Admin_panel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void AccBox(object sender, MouseEventArgs e)
        {
            LoginForm registration = new LoginForm();
            registration.Show();
            this.Close();
        }
        private void AccBox_MouseEnter(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Green;
        }

        private void AccBox_MouseLeave(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Black;
        }

        private void account_Click(object sender, EventArgs e)
        {
            LoginForm registration = new LoginForm();
            registration.Show();
            this.Close();
        }
        private void account_MouseEnter(object sender, EventArgs e)
        {
            closeButton.BackColor = Color.Green;
        }

        private void account_MouseLeave(object sender, EventArgs e)
        {
            closeButton.BackColor = Color.White;
        }

        private void Admin_panel_Load(object sender, EventArgs e)
        {

        }

        private void S_filtr_Click(object sender, EventArgs e)
        {
            Admin_panel admin = new Admin_panel();
            MySqlCommand _mySqlCommand = new MySqlCommand("SELECT * FROM `drinks` WHERE name LIKE '% S';", _databaseManager.GetConnection);
            List<Zakaz.Stroka> _data = new List<Zakaz.Stroka>();
            int xX, yY;
            xX = 48;
            yY = 93;

            try
            {
                _databaseManager.OpenConnection();
                reader = _mySqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    Zakaz.Stroka n = new Zakaz.Stroka((int)reader["id"], (string)reader["name"], (double)reader["value"], (double)reader["price"]);
                    _data.Add(n);
                }
                for (int i = 0; i < _data.Count; i++)
                {
                    Button resultButtonS = new Button();
                    resultButtonS.Location = new Point(xX, yY);
                    resultButtonS.Tag = _data[i].id;
                    resultButtonS.Size = new Size(200, 60);

                    resultButtonS.Text = _data[i].name;

                    resultButtonS.Click += new EventHandler(admin.on_Click);
                    admin.Controls.Add(resultButtonS);

                    yY += 70;

                }

            }
            catch
            {
                MessageBox.Show("Problema");
            }
            admin.Show();
            this.Close();

        }

        private void M_filtr_Click(object sender, EventArgs e)
        {
            Admin_panel admin = new Admin_panel();
            MySqlCommand _mySqlCommand = new MySqlCommand("SELECT * FROM `drinks` WHERE name LIKE '% M';", _databaseManager.GetConnection);
            List<Zakaz.Stroka> _data = new List<Zakaz.Stroka>();
            int xX, yY;
            xX = 48;
            yY = 93;

            try
            {
                _databaseManager.OpenConnection();
                reader = _mySqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    Zakaz.Stroka n = new Zakaz.Stroka((int)reader["id"], (string)reader["name"], (double)reader["value"], (double)reader["price"]);
                    _data.Add(n);
                }
                for (int i = 0; i < _data.Count; i++)
                {
                    Button resultButtonM = new Button();
                    resultButtonM.Location = new Point(xX, yY);
                    resultButtonM.Tag = _data[i].id;
                    resultButtonM.Size = new Size(200, 60);

                    resultButtonM.Text = _data[i].name;

                    resultButtonM.Click += new EventHandler(admin.on_Click);
                    admin.Controls.Add(resultButtonM);

                    yY += 70;

                }

            }
            catch
            {
                MessageBox.Show("Problema");
            }
            admin.Show();
            this.Close();

        }

        private void L_filtr_Click(object sender, EventArgs e)
        {
            Admin_panel admin = new Admin_panel();
            MySqlCommand _mySqlCommand = new MySqlCommand("SELECT * FROM `drinks` WHERE name LIKE '% L';", _databaseManager.GetConnection);
            List<Zakaz.Stroka> _data = new List<Zakaz.Stroka>();
            int xX, yY;
            xX = 48;
            yY = 93;

            try
            {
                _databaseManager.OpenConnection();
                reader = _mySqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    Zakaz.Stroka n = new Zakaz.Stroka((int)reader["id"], (string)reader["name"], (double)reader["value"], (double)reader["price"]);
                    _data.Add(n);
                }
                for (int i = 0; i < _data.Count; i++)
                {
                    Button resultButtonL = new Button();
                    resultButtonL.Location = new Point(xX, yY);
                    resultButtonL.Tag = _data[i].id;
                    resultButtonL.Size = new Size(200, 60);

                    resultButtonL.Text = _data[i].name;

                    resultButtonL.Click += new EventHandler(admin.on_Click);
                    admin.Controls.Add(resultButtonL);

                    yY += 70;

                }

            }
            catch
            {
                MessageBox.Show("Problema");
            }
            admin.Show();
            this.Close();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            Admin_panel admin = new Admin_panel();
            MySqlCommand _mySqlCommand = new MySqlCommand("SELECT * FROM `drinks`;", _databaseManager.GetConnection);
            List<Zakaz.Stroka> _data = new List<Zakaz.Stroka>();
            int xX, yY;
            xX = 48;
            yY = 93;

            try
            {
                _databaseManager.OpenConnection();
                reader = _mySqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    Zakaz.Stroka n = new Zakaz.Stroka((int)reader["id"], (string)reader["name"], (double)reader["value"], (double)reader["price"]);
                    _data.Add(n);
                }
                for (int i = 0; i < _data.Count; i++)
                {
                    Button returnButton = new Button();
                    returnButton.Location = new Point(xX, yY);
                    returnButton.Tag = _data[i].id;
                    returnButton.Size = new Size(200, 60);

                    returnButton.Text = _data[i].name;

                    returnButton.Click += new EventHandler(admin.on_Click);
                    admin.Controls.Add(returnButton);

                    yY += 70;

                }

            }
            catch
            {
                MessageBox.Show("Problema");
            }
            admin.Show();
            this.Close();
        }

        private void AddTea_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                return;
            }
            var _mySqlCommandCh = new MySqlCommand("INSERT INTO `drinks`(name, value, price, recept) VALUES (@name,@value,@price,@recept)", _databaseManager.GetConnection);
            _mySqlCommandCh.Parameters.Add("@name", textBox1.Text);
            _mySqlCommandCh.Parameters.Add("@value", Convert.ToDouble(textBox2.Text));
            _mySqlCommandCh.Parameters.Add("@price", Convert.ToDouble(textBox3.Text));
            _mySqlCommandCh.Parameters.Add("@recept", textBox4.Text);
            _databaseManager.OpenConnection();

            _mySqlCommandCh.ExecuteNonQuery();




            //reload
            NNewBTN();

            schet++;
            //выгрузка
            Export("D:\\BD otkat\\backup" + schet + ".sql");
        }

        private void EditTea_Click(object sender, EventArgs e)
        {
            if (textBox4.Text != "")
            {
                var com = new MySqlCommand("UPDATE drinks SET recept=@Asd WHERE name=@nName", _databaseManager.GetConnection);
                com.Parameters.Add("@Asd", textBox4.Text);
                com.Parameters.Add("@nName", textBox1.Text);
                _databaseManager.OpenConnection();
                com.ExecuteNonQuery();
            }
            if (textBox3.Text != "")
            {
                var com = new MySqlCommand("UPDATE drinks SET price=@Asd WHERE name=@nName", _databaseManager.GetConnection);
                com.Parameters.Add("@Asd", Convert.ToDouble(textBox3.Text));
                com.Parameters.Add("@nName", textBox1.Text);
                _databaseManager.OpenConnection();
                com.ExecuteNonQuery();
            }
            if (textBox2.Text != "")
            {
                var com = new MySqlCommand("UPDATE drinks SET value=@Asd WHERE name=@nName", _databaseManager.GetConnection);
                com.Parameters.Add("@Asd", Convert.ToDouble(textBox2.Text));
                com.Parameters.Add("@nName", textBox1.Text);
                _databaseManager.OpenConnection();
                com.ExecuteNonQuery();
            }
            schet++;
            //выгрузка
            Export("D:\\BD otkat\\backup" + schet + ".sql");
            NNewBTN();
        }

        private void DeleteTea_Click(object sender, EventArgs e)
        {
            _databaseManager.OpenConnection();
            MySqlCommand _mySqlCommandDel = new MySqlCommand("DELETE FROM `drinks` WHERE `name`=@NapitokD", _databaseManager.GetConnection);
            _mySqlCommandDel.Parameters.Add("@NapitokD", textBox1.Text);

            _mySqlCommandDel.ExecuteNonQuery();
            _databaseManager.CloseConnection();


            // reload
            NNewBTN();

            //Выгрузка
            schet++;
            Export("D:\\BD otkat\\backup" + schet + ".sql");
        }

        private void exportDB_Click(object sender, EventArgs e)
        {
            Export("D:\\BD otkat\\backup.sql");
        }

        private void importDB_Click(object sender, EventArgs e)
        {
            Import("D:\\BD otkat\\backup.sql");
        }

        private void rollbackDB_Click(object sender, EventArgs e)
        {
            schet -= 1;
            Import("D:\\BD otkat\\backup" + schet + ".sql");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
