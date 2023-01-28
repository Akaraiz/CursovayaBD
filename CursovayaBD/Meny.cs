using FPS.DataBase;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace CursovayaBD
{
    public partial class Meny : Form
    {
        public static double score = 0;
        
        
        public Meny()
        {
            InitializeComponent();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
       
      
      public void on_Click(object sender, EventArgs e)
        {

            DatabaseManager _databaseManager = new DatabaseManager();
            DataTable _dataTable = new DataTable();
            MySqlDataAdapter _mysqlDataAdapter = new MySqlDataAdapter();
            
            MySqlCommand _mySqlCommand = new MySqlCommand("SELECT * FROM `drinks` WHERE `name`=@tText", _databaseManager.GetConnection);
            MySqlDataReader reader;
            _mySqlCommand.Parameters.Add("@tText", MySqlDbType.VarChar).Value = sender.ToString().Substring(35);


            //try
            //{
                _databaseManager.OpenConnection();
                reader = _mySqlCommand.ExecuteReader();
                
            

            
            if(reader.Read())
             LoginForm.zakaz.listBox1.Items.Add(reader["name"].ToString()+" " + reader["value"] +" " + Convert.ToDouble(reader["price"])*Convert.ToDouble(colvo.Text) +" "+ colvo.Text);
            score += (double)reader["price"]*Convert.ToDouble(colvo.Text);
            LoginForm.zakaz.textBox1.Text = score.ToString();






            this.Hide();
            DatabaseManager _databaseManagerB = new DatabaseManager();
            MySqlCommand _mySqlCommandB = new MySqlCommand("SELECT balance FROM balance", _databaseManagerB.GetConnection);
            MySqlDataReader readerB;
            _databaseManagerB.OpenConnection();
            readerB = _mySqlCommandB.ExecuteReader();
            if (readerB.Read())
            {
                Zakaz.oldscore  = Convert.ToDouble(readerB["balance"]);
              
            }
            _databaseManagerB.CloseConnection();
            
            LoginForm.zakaz.Show();
            //}
            //catch
            //{
            //    MessageBox.Show("ahahah");
            //}
        }
    

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Meny_Load(object sender, EventArgs e)
        {

        }
    }
}
