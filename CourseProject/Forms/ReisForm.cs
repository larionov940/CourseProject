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
    public partial class ReisForm : Form
    {
        public ReisForm()
        {
            InitializeComponent();
        }

        private void reisBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.reisBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.busStationDataSet);

        }

        private void ReisForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "busStationDataSet.Ticket". При необходимости она может быть перемещена или удалена.
            this.ticketTableAdapter.Fill(this.busStationDataSet.Ticket);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "busStationDataSet.Departure". При необходимости она может быть перемещена или удалена.
            this.departureTableAdapter.Fill(this.busStationDataSet.Departure);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "busStationDataSet.Reis". При необходимости она может быть перемещена или удалена.
            this.reisTableAdapter.Fill(this.busStationDataSet.Reis);

        }
    }
}
