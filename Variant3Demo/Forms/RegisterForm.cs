using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Variant3Demo
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void BackToMainButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Close();
        }

        private void RegisterAcceptButton_Click(object sender, EventArgs e)
        {
            string connection = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = BaseData";
            SqlConnection sqlConnection = new SqlConnection(connection);
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("insert into clients values ('" + NameText.Text + "', '" + SecondNameText.Text + "', '" + ThirdNameText + "', '" + PhoneText.Text + "', '" + AddressText.Text + "', '" + Logintext.Text + "', '" + PasswordText.Text + "')", sqlConnection);
            cmd.ExecuteNonQuery();
            SqlCommand sql = new SqlCommand("select * from clients where phone = '" + PhoneText.Text + "'", sqlConnection);
            SqlDataReader reader = sql.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("Пользователь успешно добавлен");
            }
            else
            {
                MessageBox.Show("Что-то пошло не так");
            }
        }
    }
}
