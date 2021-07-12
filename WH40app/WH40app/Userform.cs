using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WH40app
{
    public partial class Userform : Form
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;database=zarodolgozat;uid=root");
        MySqlCommand command;
        string[] Detachments = File.ReadAllLines("Detachments.csv", Encoding.GetEncoding("ISO-8859-1"));
        string Email;
        public Userform(string name, string email)
        {
            InitializeComponent();
            Welcome_label.Text = $"> Welcome back {name}";
            Email = email;
            Units.HorizontalScrollbar = true;
            Yourlist.HorizontalScrollbar = true;
            Helpergrid.Visible = false;
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

                }
                else
                {
                    MessageBox.Show("Sikertelen végrehajtás");
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

        private void Userform_FormClosed(object sender, FormClosedEventArgs e)
        {
            var Login = new Form1();
            Login.Show();
        }

        private void Userform_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter($"SELECT * FROM Orders WHERE Email='{Email}'", connection);
                openConnection();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Orders");
                dataGridView1.DataSource = ds.Tables["Orders"];
                closeConnection();
            }
            catch (Exception hiba)
            {

                MessageBox.Show(hiba.Message);
            }

            foreach (var item in Detachments)
            {
                Detachments_list.Items.Add(item.Split(';')[0]);
            }
        }

        private void reload_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter($"SELECT * FROM Orders WHERE Email='{Email}'", connection);
                openConnection();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Orders");
                dataGridView1.DataSource = ds.Tables["Orders"];
                closeConnection();
            }
            catch (Exception hiba)
            {

                MessageBox.Show(hiba.Message);
            }
        }

        private void Detachments_list_SelectedValueChanged(object sender, EventArgs e)
        {
            Requirements.Items.Clear();
            foreach (var Deta in Detachments)
            {
                var splited = Deta.Split(';');
                if (splited[0]==Detachments_list.SelectedItem.ToString())
                {
                    for (int i = 1; i < splited.Length; i++)
                    {
                        Requirements.Items.Add(splited[i]);
                    }
                }
            }
            
        }

        private void Requirements_SelectedValueChanged(object sender, EventArgs e)
        {
            Units.Items.Clear();
            string role = Requirements.SelectedItem.ToString().Split()[0];
            MySqlDataAdapter adapter = new MySqlDataAdapter($"SELECT * FROM Products WHERE Role='{role}'", connection);
            openConnection();
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Products");
            Helpergrid.DataSource = ds.Tables["Products"];
            closeConnection();

            for (int i = 0; i < Helpergrid.Rows.Count; i++)
            {
                var row = Helpergrid.Rows[i];
                Units.Items.Add($"{row.Cells[1].FormattedValue} Role:{row.Cells[2].FormattedValue}");
            }
            Units.Items.RemoveAt(Units.Items.Count-1);

        }

        private void Units_SelectedIndexChanged(object sender, EventArgs e)
        {
            Yourlist.Items.Add(Units.SelectedItem);
        }

        private void Yourlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            Yourlist.Items.Remove(Yourlist.SelectedItem);
        }

        private void Button_Export_Click(object sender, EventArgs e)
        {
            List<string> Createdlist = new List<string>();
            foreach (var item in Yourlist.Items)
            {
                Createdlist.Add(item.ToString());
            }
            File.WriteAllLines("Exported_List.txt",Createdlist);
        }
    }
}
