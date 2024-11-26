using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Variant3Demo.Models;

namespace Variant3Demo
{
    public partial class ProductViewForm : Form
    {
        public string filter;
        public ProductViewForm()
        {
            InitializeComponent();
        }

        private void BackToMainButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Close();
        }

        public void GetProduct()
        {
            List<string> list = new List<string>();
            string connection = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = BaseData";
            SqlConnection sqlConnection = new SqlConnection(connection);
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("select * from product", sqlConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Product product = new Product(reader.GetString(1), reader.GetString(2));
                list.Add(product.ToString());
            }
            ProductList.DataSource = list;
        }

        private void ProductShowButton_Click(object sender, EventArgs e)
        {
            GetProduct();

        }

        private void FilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void  GetProductFilter()
        {
            List<string> list = new List<string>();
            string connString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = BaseData;";
            SqlConnection sqlConnection = new SqlConnection(connString);
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("select * from product where " + filter, sqlConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Product product = new Product(reader.GetString(1), reader.GetString(2));
                list.Add(product.ToString());
            }
            ProductList.DataSource = list;
        }
        private void FilterButton_Click(object sender, EventArgs e)
        {
            if (FilterComboBox.SelectedIndex == 0)
            {
                filter = "name = 'TEXT'";
                GetProductFilter();
            }
            else if (FilterComboBox.SelectedIndex == 1)
            {
                filter = "name = 'NETEXT'";
                GetProductFilter();
            }
            else if (FilterComboBox.SelectedIndex == 2)
            {
                GetProduct();
            }
            else
                MessageBox.Show("Ошибка");
        }
    }
}
