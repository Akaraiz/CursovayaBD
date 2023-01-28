using FPS.DataBase;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursovayaBD
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void test_Load(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void AuthoLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginClient loginClient = new LoginClient();
            loginClient.Show();
        }

        private void AuthoLabel_MouseEnter(object sender, EventArgs e)
        {
            AuthoLabel.ForeColor = Color.Blue;
        }

        private void AuthoLabel_MouseLeave(object sender, EventArgs e)
        {
            AuthoLabel.ForeColor = Color.Black;
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
        private void RegisterForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void RegisterForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (textBoxPhone.Text == "Введите номер телефона")
            {
                MessageBox.Show("Введите телефон!");
                return;
            }
            if (textBoxPhone.Text == "")
            {
                MessageBox.Show("Введите телефон!");
                return;
            }

            if (textBoxName.Text == "")
            {
                MessageBox.Show("Введите имя!");
                return;
            }
            if (textBoxName.Text == "Введите имя")
            {
                MessageBox.Show("Введите имя!");
                return;
            }


            if (isClientExists())
                return;

            DatabaseManager _databaseManager = new DatabaseManager();
            MySqlCommand command = new MySqlCommand("INSERT INTO `clients` (`phone`, `name`, `surname`, `patronim`) VALUES (@cP, @N, @SN, @cpat)", _databaseManager.GetConnection);
            command.Parameters.Add("@cP", MySqlDbType.VarChar).Value = textBoxPhone.Text;
            command.Parameters.Add("@N", MySqlDbType.VarChar).Value = textBoxName.Text;
            command.Parameters.Add("@SN", MySqlDbType.VarChar).Value = textBoxSecondName.Text;
            command.Parameters.Add("@cpat", MySqlDbType.VarChar).Value = textBoxPatronim.Text;

            _databaseManager.OpenConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Клиент добавлен в базу данных");
            else
                MessageBox.Show("Клиент не был добавлен в базу данных");



            _databaseManager.CloseConnection();
        }
        public Boolean isClientExists()
        {
            DatabaseManager _databaseManager = new DatabaseManager();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `clients` WHERE  `phone`= @cP ", _databaseManager.GetConnection);
            command.Parameters.Add("@cP", MySqlDbType.VarChar).Value = textBoxPhone.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Номер телефона уже зарегистрирован в базе данных");
                return true;
            }

            else
            {
                return false;

            }
        }


    }
}
