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
    public partial class BusForm : Form
    {
        public BusForm()
        {
            InitializeComponent();
        }

        private void busBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.busBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.busStationDataSet);

        }

        private void BusForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "busStationDataSet.BusType". При необходимости она может быть перемещена или удалена.
            this.busTypeTableAdapter.Fill(this.busStationDataSet.BusType);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "busStationDataSet.DrivingBus". При необходимости она может быть перемещена или удалена.
            this.drivingBusTableAdapter.Fill(this.busStationDataSet.DrivingBus);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "busStationDataSet.Departure". При необходимости она может быть перемещена или удалена.
            this.departureTableAdapter.Fill(this.busStationDataSet.Departure);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "busStationDataSet.Bus". При необходимости она может быть перемещена или удалена.
            this.busTableAdapter.Fill(this.busStationDataSet.Bus);

        }
    }
}
