using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject.Forms
{
    public partial class PassengersForm : Form
    {
        AddPassengerForm addPassengerForm;
        public PassengersForm()
        {
            InitializeComponent();
        }

        private void passengerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.passengerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.busStationDataSet);

        }

        private void PassengersForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "busStationDataSet.Ticket". При необходимости она может быть перемещена или удалена.
            this.ticketTableAdapter.Fill(this.busStationDataSet.Ticket);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "busStationDataSet.Passenger". При необходимости она может быть перемещена или удалена.
            this.passengerTableAdapter.Fill(this.busStationDataSet.Passenger);

        }

        private void buttonAddPassenger_Click(object sender, EventArgs e)
        {
            addPassengerForm = new AddPassengerForm();
            addPassengerForm.Show();
            passengerTableAdapter.Fill(this.busStationDataSet.Passenger);
        }
    }
}
