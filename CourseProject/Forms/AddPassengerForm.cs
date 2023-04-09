using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CourseProject.Forms
{
    public partial class AddPassengerForm : Form
    {
        public AddPassengerForm()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxNumPas.Text) || String.IsNullOrEmpty(textBoxName.Text) || 
                String.IsNullOrEmpty(textBoxLastName.Text) || String.IsNullOrEmpty(textBoxPatronymic.Text))
            {
                MessageBox.Show("Заполните пустые поля");
                return;
            }
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.
            ConnectionStrings["CourseProject.Properties.Settings.BusStationConnectionString"].ConnectionString;
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.CommandText = "AddPassenger";
            cmd.Parameters.AddWithValue("@passportNumber", textBoxNumPas.Text);
            cmd.Parameters.AddWithValue("@firstName", textBoxName.Text);
            cmd.Parameters.AddWithValue("@lastName", textBoxLastName.Text);
            cmd.Parameters.AddWithValue("@patronymic", textBoxPatronymic.Text);
            cmd.Parameters.AddWithValue("@gender", comboBoxGender.Text);

            var returnParameter = cmd.Parameters.Add("@Code", SqlDbType.Int);
            returnParameter.Direction = ParameterDirection.ReturnValue;
            cmd.ExecuteNonQuery();
            int result = (int)returnParameter.Value;
            if (result != 1)
            {
                MessageBox.Show("Пассажир с таким номером паспорта уже существует");
            }
            conn.Close();

            this.Close();
        }
    }
}
