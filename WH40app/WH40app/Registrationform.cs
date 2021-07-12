using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WH40app
{
    public partial class Registrationform : Form
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;database=zarodolgozat;uid=root");
        MySqlCommand command;
        public Registrationform()
        {
            InitializeComponent();
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
                    MessageBox.Show("Sikeres regisztráció!");
                }
                else
                {
                    MessageBox.Show("Hiba történt a regisztráció során.");
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
        private void Registration_Click(object sender, EventArgs e)
        {
            if (UserText.Text!="" && PasswordText.Text!="" && Emailtext.Text!="")
            {
                string reg = $"INSERT INTO Users VALUES ('','{UserText.Text}','{PasswordText.Text}','{Emailtext.Text}','0')";
                executeQuery(reg);
                
                this.Close();
            }
            else
            {
                MessageBox.Show("You must fill all fields!");
            }
        }

        private void Registrationform_FormClosed(object sender, FormClosedEventArgs e)
        {
            var Login = new Form1();
            Login.Show();
        }
    }
}
