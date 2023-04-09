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
    public partial class MainForm : Form
    {
        private PassengersForm passengersForm;
        private BusForm busForm;
        private ReisForm reisForm;
        private DriversForm driversForm;
        private BusStationForm busStationForm;
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonPassenger_Click(object sender, EventArgs e)
        {
            passengersForm = new PassengersForm();
            passengersForm.Show();
        }

        private void buttonBus_Click(object sender, EventArgs e)
        {
            busForm = new BusForm();
            busForm.Show();
        }

        private void buttonReis_Click(object sender, EventArgs e)
        {
            reisForm = new ReisForm();
            reisForm.Show();
        }

        private void buttonDrivers_Click(object sender, EventArgs e)
        {
            driversForm = new DriversForm();
            driversForm.Show();
        }

        private void buttonBusStation_Click(object sender, EventArgs e)
        {
            busStationForm = new BusStationForm();
            busStationForm.Show();
        }
    }
}
