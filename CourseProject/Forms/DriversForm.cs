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
    public partial class DriversForm : Form
    {
        public DriversForm()
        {
            InitializeComponent();
        }

        private void driverBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.driverBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.busStationDataSet);

        }

        private void DriversForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "busStationDataSet.DrivingBus". При необходимости она может быть перемещена или удалена.
            this.drivingBusTableAdapter.Fill(this.busStationDataSet.DrivingBus);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "busStationDataSet.Driver". При необходимости она может быть перемещена или удалена.
            this.driverTableAdapter.Fill(this.busStationDataSet.Driver);

        }
    }
}
