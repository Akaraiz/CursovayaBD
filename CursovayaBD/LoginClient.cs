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
    public partial class LoginClient : Form
    {
        public LoginClient()
        {
            InitializeComponent();
        }


        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
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
        private void LoginClient_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void LoginClient_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void RegisterUserLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }
        private void RegisterUserLabel_MouseEnter(object sender, EventArgs e)
        {
            RegisterUserLabel.ForeColor = Color.Blue;
        }

        private void RegisterUserLabel_MouseLeave(object sender, EventArgs e)
        {
            RegisterUserLabel.ForeColor = Color.Black;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            String PhoneClient = textBoxPhone.Text;//переменные-заглушки в SQL запросе для безопасности
            String NameClient = textBoxName.Text;

            DatabaseManager _databaseManager = new DatabaseManager();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `clients` WHERE  `phone`= @cP AND `name` = @cN ", _databaseManager.GetConnection);
            command.Parameters.Add("@cP", MySqlDbType.VarChar).Value = PhoneClient;
            command.Parameters.Add("@cN", MySqlDbType.VarChar).Value = NameClient;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                this.Close();
    
            }

            else
                MessageBox.Show("Клиента нет в базе данных!");
        }
    }
}
