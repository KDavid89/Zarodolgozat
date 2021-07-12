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
    public partial class AdminForm : Form
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;database=zarodolgozat;uid=root");
        MySqlCommand command;
        bool productsloaded = false;
        bool OrdersAreloaded = false;
        List<Control> Product_Add_controlls = new List<Control>();
        List<Control> Users_Add_controll = new List<Control>();
        public AdminForm()
        {
            InitializeComponent();
            OrdersList.Visible = false;

            Product_Add_controlls.AddRange( new List<Control>() { ProdMainData, ProdName, ProdRole, ProdQuantity, ProdPrice, Faction_label, Faction, Picture_label, Picture,Button_productAdd } );
            foreach (var item in Product_Add_controlls)
            {
                item.Visible = false;
            }

            Users_Add_controll.AddRange(new List<Control> { MaindataUser,Username, Password, Email, Admin_label, Admin,Button_Useradd });
            foreach (var item in Users_Add_controll)
            {
                item.Visible = false;
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

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            var Login = new Form1();
            Login.Show();
        }

        private void Button_ProdLoad_Click(object sender, EventArgs e)
        {
            OrdersList.Visible = false;
            productsloaded = true;
            OrdersAreloaded = false;
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM Products", connection); 
                openConnection(); 
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Products");
                dataGridView1.DataSource = ds.Tables["Products"];
                closeConnection();
            }
            catch (Exception hiba)
            {

                MessageBox.Show(hiba.Message);
            }

            foreach (var item in Product_Add_controlls)
            {
                item.Visible = true;
            }
            foreach (var item in Users_Add_controll)
            {
                item.Visible = false;
            }

        }

        private void Button_UserLoad_Click(object sender, EventArgs e)
        {
            OrdersList.Visible = false;
            productsloaded = false;
            OrdersAreloaded = false;
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM Users", connection);
                openConnection();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Users");
                dataGridView1.DataSource = ds.Tables["Users"];
                closeConnection();
            }
            catch (Exception hiba)
            {

                MessageBox.Show(hiba.Message);
            }


            foreach (var item in Product_Add_controlls)
            {
                item.Visible = false;
            }
            foreach (var item in Users_Add_controll)
            {
                item.Visible = true;
            }
        }

        private void Button_Del_Click(object sender, EventArgs e)
        {

            if (OrdersAreloaded)
            {
                string Del = $"DELETE FROM Orders WHERE OrderID='{Text_DelID.Text}'";
                executeQuery(Del);

                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM Orders", connection);
                openConnection();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Orders");
                dataGridView1.DataSource = ds.Tables["Orders"];
                closeConnection();
            }

            if (productsloaded)
            {
                string Del = $"DELETE FROM Products WHERE ID='{Text_DelID.Text}'";
                executeQuery(Del);

                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM Products", connection);
                openConnection();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Products");
                dataGridView1.DataSource = ds.Tables["Products"];
                closeConnection();
            }
            else
            {
                string Del = $"DELETE FROM Users WHERE UserID='{Text_DelID.Text}'";
                executeQuery(Del);

                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM Users", connection);
                openConnection();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Users");
                dataGridView1.DataSource = ds.Tables["Users"];
                closeConnection();
            }

            
        }

        private void Button_Useradd_Click(object sender, EventArgs e)
        {
            string AddUser = $"INSERT INTO Users VALUES ('','{Username.Text}','{Password.Text}','{Email.Text}','{Admin.Text}');";
            executeQuery(AddUser);

            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM Users", connection);
                openConnection();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Users");
                dataGridView1.DataSource = ds.Tables["Users"];
                closeConnection();
            }
            catch (Exception hiba)
            {

                MessageBox.Show(hiba.Message);
            }
        }

        private void Button_productAdd_Click(object sender, EventArgs e)
        {
            string AddProd = $"INSERT INTO Products VALUES ('','{ProdName.Text}','{ProdRole.Text}','{ProdQuantity.Text}','{ProdPrice.Text}','{Faction.Text}','{Picture.Text}');";
            executeQuery(AddProd);

            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM Products", connection);
                openConnection();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Products");
                dataGridView1.DataSource = ds.Tables["Products"];
                closeConnection();
            }
            catch (Exception hiba)
            {

                MessageBox.Show(hiba.Message);
            }
        }

        private void Button_loadOrders_Click(object sender, EventArgs e)
        {
            OrdersAreloaded = true;
            foreach (var item in Product_Add_controlls)
            {
                item.Visible = false;
            }

            foreach (var item in Users_Add_controll)
            {
                item.Visible = false;
            }

            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM Orders", connection);
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (OrdersAreloaded)
            {
                OrdersList.Items.Clear();
                dataGridView1.CurrentRow.Selected = true;
                OrdersList.Visible = true;
                var ProdsContained = dataGridView1.Rows[e.RowIndex].Cells[7].FormattedValue.ToString().Split(';');
                foreach (var item in ProdsContained)
                {
                    OrdersList.Items.Add(item);
                }
            }
           
        }
    }
}
