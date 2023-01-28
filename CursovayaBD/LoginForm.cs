using FPS.DataBase;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CursovayaBD
{
    public partial class LoginForm : Form
    {
        public static Zakaz zakaz = new Zakaz();
        public LoginForm()
        {
            InitializeComponent();

            this.textBoxPassword.AutoSize = false;
            this.textBoxPassword.Size = new Size(this.textBoxPassword.Width, 38);
        }
        DatabaseManager _databaseManagerB = new DatabaseManager();
        private void Registration_Load(object sender, EventArgs e)
        {

        }
        public static double kassa;

        private void button1_Click(object sender, EventArgs e)
        {
            string loginUser = textBoxName.Text;
            string passwordUser = textBoxPassword.Text;
            DatabaseManager _databaseManager = new DatabaseManager();
            DataTable _dataTable = new DataTable();
            MySqlDataAdapter _mysqlDataAdapter = new MySqlDataAdapter();
            MySqlCommand _mySqlCommand = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @lUser AND `password` = @pUser", _databaseManager.GetConnection);

           

            //меняем заглушки на переменные
            _mySqlCommand.Parameters.Add("@lUser", MySqlDbType.VarChar).Value = loginUser;
            _mySqlCommand.Parameters.Add("@pUser", MySqlDbType.VarChar).Value = passwordUser;

            _databaseManager.OpenConnection();//открываем соеденения 

            _mysqlDataAdapter.SelectCommand = _mySqlCommand;//выбираем команду
            _mysqlDataAdapter.Fill(_dataTable);//заполянем данные в табличку



            DatabaseManager _databaseManagerA = new DatabaseManager();
            DataTable _dataTableA = new DataTable();
            MySqlDataAdapter _mysqlDataAdapterA = new MySqlDataAdapter();
            MySqlCommand _mySqlCommandA = new MySqlCommand("SELECT * FROM `drinks`", _databaseManager.GetConnection);
            MySqlDataReader reader;
            if (loginUser == "admin" && passwordUser == "admin")
            {
                Admin_panel admin = new Admin_panel();



                this.Hide();

                    List<Zakaz.Stroka> _data = new List<Zakaz.Stroka>();
                    int xX, yY;
                    xX = 48;
                    yY = 93;
                  




                    try
                    {
                        _databaseManagerA.OpenConnection();
                        reader = _mySqlCommandA.ExecuteReader();

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
            }
            else if (_dataTable.Rows.Count > 0)
            {
                //еclи уже зарегестрирован
                
                zakaz.Show();
                

                //запомним кто вошел 
                User user = new User(loginUser);
                this.Hide();
                
            }


            else
                MessageBox.Show("Ошибка работы с базой данных!", "Ошибка");
            MySqlCommand _mySqlCommandB = new MySqlCommand("SELECT balance FROM balance", _databaseManagerB.GetConnection);
            MySqlDataReader readerB;
            _databaseManagerB.OpenConnection();
            readerB = _mySqlCommandB.ExecuteReader();
            if (readerB.Read())
            {
                zakaz.textBox2.Text = readerB["balance"].ToString();
                kassa = Convert.ToDouble(readerB["balance"]);
            }
            

            _databaseManagerB.CloseConnection();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
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
        private void LoginForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegisterUserLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterUserForm registerUserForm = new RegisterUserForm();
            registerUserForm.Show();
        }

        private void RegisterUserLabel_MouseEnter(object sender, EventArgs e)
        {
            RegisterUserLabel.ForeColor = Color.Blue;
        }

        private void RegisterUserLabel_MouseLeave(object sender, EventArgs e)
        {
            RegisterUserLabel.ForeColor = Color.Black;
        }
    }
    }

