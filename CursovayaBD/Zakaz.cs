using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using FPS.DataBase;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace CursovayaBD
{
    public partial class Zakaz : Form
    {
        public static double oldscore;
        public static double plusscore;
        DatabaseManager _databaseManagerB = new DatabaseManager();
        public Zakaz()
        {
            InitializeComponent();
            
        }

        public class Stroka
        {
            public int id;
            public string name;
            public double value;
            public double price;
            public Stroka(int _id, string _name, double _value, double _price)
            {
                id = _id;
                name = _name;
                value = _value;
                price = _price;
            }
        }


   
        private void button1_Click(object sender, EventArgs e)
        {
            Meny meny = new Meny();
            meny.Show();
            this.Hide();

            List<Stroka> _data = new List<Stroka>();
            int xX, yY;
            xX = 48;
            yY = 93;
            DatabaseManager _databaseManager = new DatabaseManager();
            DataTable _dataTable = new DataTable();
            MySqlDataAdapter _mysqlDataAdapter = new MySqlDataAdapter();
            MySqlCommand _mySqlCommand = new MySqlCommand("SELECT * FROM `drinks`", _databaseManager.GetConnection);
            MySqlDataReader reader;
            
           
            
            
            try
            {
                _databaseManager.OpenConnection();
                reader = _mySqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    Stroka n = new Stroka((int)reader["id"], (string)reader["name"], (double)reader["value"], (double)reader["price"]);
                    _data.Add(n);
                }
                for (int i = 0; i < _data.Count; i++)
                {
                    Button btn = new Button();
                    btn.Location = new Point(xX, yY);
                    btn.Tag = _data[i].id;
                    btn.Size = new Size(200, 60);
                    
                    btn.Text = _data[i].name;
                    
                    btn.Click += new EventHandler(meny.on_Click);
                    meny.Controls.Add(btn);
                    yY += 70;

                    //panel3.ControlAdded   в панель 3 копию панели 2



                }
               




            }
            catch
            {
                MessageBox.Show("Problema");
            }
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("Нет оплаченных заказов!");

                return;
            }
            
           
            if (checkBox1.Checked)
            {
                
                oldscore = oldscore + Convert.ToDouble(textBox1.Text);
                textBox2.Text = oldscore.ToString();
                checkBox1.Checked = false;
            }
            else
            {
                plusscore = Convert.ToDouble(textBox1.Text);
                oldscore = oldscore + plusscore;
                textBox2.Text = oldscore.ToString();
            }
            string list = " ";
            foreach (var i in listBox1.Items)
                list += i;

            _databaseManagerB.OpenConnection();
            var com = new MySqlCommand("UPDATE balance SET balance=@Old WHERE id = 1", _databaseManagerB.GetConnection);
            com.Parameters.Add("@Old", Math.Round(oldscore));
            com.ExecuteNonQuery();


            //var _mySqlCommandCh = new MySqlCommand("INSERT INTO `checks` SET `checkk`= "+list+ ", `price`=" + Convert.ToDouble(textBox1.Text) + "", _databaseManagerB.GetConnection);
            var _mySqlCommandCh = new MySqlCommand("INSERT INTO `checks`(checkk, price) VALUES (@llist,@textB)", _databaseManagerB.GetConnection);
            _mySqlCommandCh.Parameters.Add("@llist", list);
            _mySqlCommandCh.Parameters.Add("@textB", plusscore);
            _mySqlCommandCh.ExecuteNonQuery();
            

            _databaseManagerB.CloseConnection();
            list = " ";


            
            Meny.score = 0;
            textBox1.Clear();
            listBox1.Items.Clear();






        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Нет товаров!");
                return;
            }
            else
            {
                LoginClient loginClient = new LoginClient();
                loginClient.ShowDialog();
                //this.Hide();
                //RegisterForm registerUser = new RegisterForm();
                //registerUser.Show();
                MessageBox.Show("Скидка активирована!");
                double i = Convert.ToDouble(textBox1.Text) - Convert.ToDouble(textBox1.Text) * 0.1;
                plusscore = i;
                var roundd = Math.Round(i, 2);

                textBox1.Text = roundd.ToString();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var i = oldscore - plusscore;
            var com = new MySqlCommand("UPDATE balance SET balance=@Asd WHERE id = 1", _databaseManagerB.GetConnection);
            com.Parameters.Add("@Asd", i);
            _databaseManagerB.OpenConnection();
            com.ExecuteNonQuery();
            MySqlCommand _mySqlCommandB = new MySqlCommand("SELECT balance FROM balance", _databaseManagerB.GetConnection);
            MySqlDataReader readerB;
            _databaseManagerB.OpenConnection();
            readerB = _mySqlCommandB.ExecuteReader();
            
            if (readerB.Read())
            {
                textBox2.Text = readerB["balance"].ToString();
                LoginForm.kassa = Convert.ToDouble(readerB["balance"]);
                _databaseManagerB.CloseConnection();
                MySqlCommand _mySqlCommandDel = new MySqlCommand("DELETE FROM `checks` ORDER BY `id` DESC LIMIT 1", _databaseManagerB.GetConnection);
                _databaseManagerB.OpenConnection();
                _mySqlCommandDel.ExecuteNonQuery();
            }
        }

        private void Zakaz_Load(object sender, EventArgs e)
        {

        }
        Point lastPoint;
        private void Zakaz_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Zakaz_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoginForm registration = new LoginForm();
            registration.Show();
            this.Close();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
