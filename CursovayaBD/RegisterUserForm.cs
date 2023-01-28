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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CursovayaBD
{
    public partial class RegisterUserForm : Form
    {
        public RegisterUserForm()
        {
            InitializeComponent();
            this.textBoxPassword.AutoSize = false;
            this.textBoxPassword.Size = new Size(this.textBoxPassword.Width, 50);
        }

        private void RegisterUserForm_Load(object sender, EventArgs e)
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
        private void RegisterUserForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void RegisterUserForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "Введите логин")
            {
                MessageBox.Show("Введите логин!");
                return;
            }
            if (textBoxLogin.Text == "")
            {
                MessageBox.Show("Введите логин!");
                return;
            }

            if (textBoxPassword.Text == "")
            {
                MessageBox.Show("Введите пароль!");
                return;
            }


            if (isUserExists())
                return;

            DatabaseManager _databaseManager = new DatabaseManager();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `password`, `role`) VALUES (@login, @pass, @role)", _databaseManager.GetConnection);
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = textBoxLogin.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textBoxPassword.Text;
            command.Parameters.Add("@role", MySqlDbType.VarChar).Value = textBoxJob.Text;
            _databaseManager.OpenConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Аккаунт был создан");
            else
                MessageBox.Show("Аккаунт не был создан");



            _databaseManager.CloseConnection();
        }

        public Boolean isUserExists()
        {
            DatabaseManager _databaseManager = new DatabaseManager();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE  `login`= @uL ", _databaseManager.GetConnection);
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = textBoxLogin.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой логин уже существует, введите другой");
                return true;
            }

            else
            {
                return false;

            }
        }

        private void AuthoLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void AuthoLabel_MouseEnter(object sender, EventArgs e)
        {
            AuthoLabel.ForeColor = Color.Blue;
        }

        private void AuthoLabel_MouseLeave(object sender, EventArgs e)
        {
            AuthoLabel.ForeColor = Color.Black;
        }
    }
}
