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

namespace Ocenka_mer_svyzei
{
    public partial class SaveRegression : Form
    {
        public SaveRegression()
        {
            InitializeComponent();

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(richTextBox2.Text) || string.IsNullOrWhiteSpace(richTextBox1.Text))
            {
                MessageBox.Show("Заполните все поля");
            }

            else
            {
                SqlConnection sqlConnection;

                string Path = Environment.CurrentDirectory;
                string[] appPath = Path.Split(new string[] { "bin" }, StringSplitOptions.None);
                AppDomain.CurrentDomain.SetData("DataDirectory", appPath[0]);

                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Regress.mdf;Integrated Security=True";

                sqlConnection = new SqlConnection(connectionString);

                await sqlConnection.OpenAsync();

                SqlCommand sqlCommand = new SqlCommand("INSERT INTO [Regression] (Study_Name, Date, Comment, NumberOfScale, NumberOfVariable, NumberOfUqVariable, TypeIOfScale, DistType, AverV, StandardDeviation, Slope, Mechanics, TypeMethod) Values(@Study_Name, @Date, @Comment, @NumberOfScale, @NumberOfVariable, @NumberOfUqVariable, @TypeIOfScale, @DistType, @AverV, @StandardDeviation, @Slope, @Mechanics, @TypeMethod)", sqlConnection);

                sqlCommand.Parameters.AddWithValue("@Study_Name", richTextBox2.Text);
                sqlCommand.Parameters.AddWithValue("@Date", DateTime.Now);
                sqlCommand.Parameters.AddWithValue("@Comment", richTextBox1.Text);
                sqlCommand.Parameters.AddWithValue("@NumberOfScale", DateRegression.NumberOfScale);
                sqlCommand.Parameters.AddWithValue("@NumberOfVariable", DateRegression.NumberOfVariable);
                sqlCommand.Parameters.AddWithValue("@NumberOfUqVariable", DateRegression.NumberOfUqVariable);
                sqlCommand.Parameters.AddWithValue("@TypeIOfScale", DateRegression.TypeOfScale);
                sqlCommand.Parameters.AddWithValue("@DistType", DateRegression.DistType);
                sqlCommand.Parameters.AddWithValue("@AverV", DateRegression.AGV);
                sqlCommand.Parameters.AddWithValue("@StandardDeviation", DateRegression.StandardDeviation);
                sqlCommand.Parameters.AddWithValue("@Slope", DateRegression.Slope);
                sqlCommand.Parameters.AddWithValue("@Mechanics", DateRegression.Mechanics);
                sqlCommand.Parameters.AddWithValue("@TypeMethod", DateRegression.TypeMethod);

                await sqlCommand.ExecuteNonQueryAsync();

                sqlConnection.Close();

                System.Threading.Thread.Sleep(1000);

                MessageBox.Show("Данные сохранены");
            }
        }

        private void SaveRegression_Load(object sender, EventArgs e)
        {
            richTextBox3.Text = DateRegression.GetString();
        }
    }
}
