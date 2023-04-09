using CourseProject.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject
{
    public partial class AuthForm : Form
    {
        private MainForm mainForm;
        public AuthForm()
        {
            InitializeComponent();
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            pictureBoxSplashScreen.Visible = false;
            timer.Stop();
        }

        private void buttonAuth_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.
                ConnectionStrings["CourseProject.Properties.Settings.BusStationConnectionString"].ConnectionString;
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.CommandText = "AuthAdmin";
            cmd.Parameters.AddWithValue("@login", textBoxLogin.Text);
            cmd.Parameters.AddWithValue("@pass", textBoxPassword.Text);

            var returnParameter = cmd.Parameters.Add("@Code", SqlDbType.Int);
            returnParameter.Direction = ParameterDirection.ReturnValue;

            cmd.ExecuteNonQuery();
            int result = (int)returnParameter.Value;
            conn.Close();

            if (result == 1)
            {
                mainForm = new MainForm();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }

        }
    }
}
