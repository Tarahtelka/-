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
    public partial class SelectRegression : Form
    {
        public SelectRegression()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(selectComboBox.Text))
            {
                SqlConnection sqlConnection;

                String[] values = selectComboBox.Text.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                string studyName = values[0];
                DateTime dateTime1 = Convert.ToDateTime(values[1]);
                var dateTime2 = dateTime1.AddSeconds(1);
                string Path = Environment.CurrentDirectory;
                string[] appPath = Path.Split(new string[] { "bin" }, StringSplitOptions.None);
                AppDomain.CurrentDomain.SetData("DataDirectory", appPath[0]);

                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Regress.mdf;Integrated Security=True";

                sqlConnection = new SqlConnection(connectionString);

                await sqlConnection.OpenAsync();

                SqlDataReader sqlDataReader = null;

                SqlCommand sqlCommand = new SqlCommand("Select * From [Regression] WHERE Date >= @Date and Date <= @Date1 and Study_Name = @Study_Name", sqlConnection);

                sqlCommand.Parameters.AddWithValue("@Date", dateTime1);
                sqlCommand.Parameters.AddWithValue("@Date1", dateTime2);
                sqlCommand.Parameters.AddWithValue("@Study_Name", studyName);

                sqlDataReader = await sqlCommand.ExecuteReaderAsync();

                while (sqlDataReader.Read())
                {
                    DateRegression.Study_Name = sqlDataReader["Study_Name"].ToString();
                    DateRegression.Date = (DateTime)sqlDataReader["Date"];
                    DateRegression.Comment = sqlDataReader["Comment"].ToString();
                    DateRegression.NumberOfScale = (int)sqlDataReader["NumberOfScale"];
                    DateRegression.NumberOfVariable = sqlDataReader["NumberOfVariable"].ToString();
                    DateRegression.NumberOfUqVariable = sqlDataReader["NumberOfUqVariable"].ToString();
                    DateRegression.AGV = sqlDataReader["AverV"].ToString();
                    DateRegression.Mechanics = sqlDataReader["Mechanics"].ToString();
                    DateRegression.Slope = sqlDataReader["Slope"].ToString();
                    DateRegression.StandardDeviation = sqlDataReader["StandardDeviation"].ToString();
                    DateRegression.TypeMethod = sqlDataReader["TypeMethod"].ToString();
                    DateRegression.TypeOfScale = sqlDataReader["TypeIOfScale"].ToString();
                    DateRegression.DistType = sqlDataReader["DistType"].ToString();

                }
                richTextBox1.Text = DateRegression.GetString();
                sqlConnection.Close();
            }
            else
            {
                MessageBox.Show("Выберете исследования которые хотите посмотреть");
            }
            
        }

        private async void SelectRegression_Load(object sender, EventArgs e)
        {
            SqlConnection sqlConnection;

            string Path = Environment.CurrentDirectory;
            string[] appPath = Path.Split(new string[] { "bin" }, StringSplitOptions.None);
            AppDomain.CurrentDomain.SetData("DataDirectory", appPath[0]);

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Regress.mdf;Integrated Security=True";

            sqlConnection = new SqlConnection(connectionString);

            await sqlConnection.OpenAsync();

            SqlDataReader sqlDataReader = null;

            SqlCommand sqlCommand = new SqlCommand("Select * From [Regression] ", sqlConnection);

            sqlDataReader = await sqlCommand.ExecuteReaderAsync();

            while (await sqlDataReader.ReadAsync())
            {
                selectComboBox.Items.Add(Convert.ToString(sqlDataReader["Study_Name"]) + " | " + Convert.ToString(sqlDataReader["Date"]));
            }
            sqlConnection.Close();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(selectComboBox.Text))
            {
                SqlConnection sqlConnection;

                String[] values = selectComboBox.Text.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                string studyName = values[0];
                DateTime dateTime1 = Convert.ToDateTime(values[1]);
                var dateTime2 = dateTime1.AddSeconds(1);
                string Path = Environment.CurrentDirectory;
                string[] appPath = Path.Split(new string[] { "bin" }, StringSplitOptions.None);
                AppDomain.CurrentDomain.SetData("DataDirectory", appPath[0]);

                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Regress.mdf;Integrated Security=True";

                sqlConnection = new SqlConnection(connectionString);

                await sqlConnection.OpenAsync();

                SqlDataReader sqlDataReader = null;

                SqlCommand sqlCommand = new SqlCommand("Delete From [Regression] WHERE Date >= @Date and Date <= @Date1 and Study_Name = @Study_Name", sqlConnection);

                sqlCommand.Parameters.AddWithValue("@Date", dateTime1);
                sqlCommand.Parameters.AddWithValue("@Date1", dateTime2);
                sqlCommand.Parameters.AddWithValue("@Study_Name", studyName);

                await sqlCommand.ExecuteNonQueryAsync();

                sqlCommand = new SqlCommand("Select * From [Regression] ", sqlConnection);

                sqlDataReader = await sqlCommand.ExecuteReaderAsync();

                selectComboBox.Items.Clear();

                while (await sqlDataReader.ReadAsync())
                {
                    selectComboBox.Items.Add(Convert.ToString(sqlDataReader["Study_Name"]) + " | " + Convert.ToString(sqlDataReader["Date"]));
                }
                sqlConnection.Close();

                richTextBox1.Clear();
            }
            else
            {
                MessageBox.Show("Выберете исследования которые хотите удалить");
            }
        }
    }
}
