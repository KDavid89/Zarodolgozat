using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WH40app
{
    public partial class Form1 : Form
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;database=zarodolgozat;uid=root");
        MySqlCommand command;
        
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            HelperGrid.Visible = false;
            List<Label> Texts = new List<Label>() {UserNamelabel,PasswordLabel,Infotext,Infotext2};
            foreach (var label in Texts)
            {
                label.BackColor = Color.Transparent;
            }
        }

        public void openConnection() 
        {
            if (connection.State == ConnectionState.Closed) 
            {
                connection.Open();
            }
        }
        public void closeConnection() 
        {
            if (connection.State == ConnectionState.Open)

            {
                connection.Close();
            }
        }
        public void executeQuery(string query) 
        {
            try
            {
                openConnection();
                command = new MySqlCommand(query, connection);
                if (command.ExecuteNonQuery() >= 1) 
                {
                    //MessageBox.Show("Sikeres Bejelentkezés");
                }
                else
                {
                    //MessageBox.Show("Sikertelen bejelentkezés");
                }
            }
            catch (Exception kivétel) 
            {

                MessageBox.Show(kivétel.Message);
            }
            finally 

            {
                closeConnection(); 
            }
        }

        private void Enterpress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string UserName = UserText.Text;
                string Password = PasswordText.Text;
                try
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter($"SELECT * FROM Users WHERE Username='{UserName}' " +
                        $"AND Password='{Password}' ", connection);
                    openConnection();
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "Users");
                    HelperGrid.DataSource = ds.Tables["Users"];
                    closeConnection();
                }
                catch (Exception hiba)
                {

                    MessageBox.Show(hiba.Message); 
                }

                if (HelperGrid.Rows[0].Cells[0].FormattedValue.ToString() == "")
                {
                    MessageBox.Show("Sikertelen bejelentkezés! Nem megfelelő adatok.");

                }
                else
                {
                    if (HelperGrid.Rows[0].Cells[4].FormattedValue.ToString() == "True")
                    {

                        var Admin = new AdminForm();
                        Admin.Show();
                        this.Hide();
                    }
                    if (HelperGrid.Rows[0].Cells[4].FormattedValue.ToString() == "False")
                    {
                        string Email = HelperGrid.Rows[0].Cells[3].FormattedValue.ToString();
                        string name = UserText.Text;
                        var User = new Userform(name, Email);
                        User.Show();
                        this.Hide();
                    }
                }

               
               

            }

            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Registration_Click(object sender, EventArgs e)
        {
            var reg= new Registrationform();
            reg.Show();
            this.Hide();
        }
    }
}
