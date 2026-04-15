using System;
using System.Windows.Forms;

namespace labWork2Sim
{
    public partial class ProcessForm : Form
    {
        private SingleLinkedList list;

        public ProcessForm(SingleLinkedList list)
        {
            InitializeComponent();
            this.list = list;
            this.Text = "Обработка списка заявок";
        }




        private void btnSearchFlight_Click(object sender, EventArgs e)
        {
            list.DisplayByFlightAndDate(dataGridView1, txtFlightNumber.Text, dtpDate.Value);
        }

        private void btnSearchPassenger_Click(object sender, EventArgs e)
        {
            list.DisplayByPassenger(dataGridView1, txtPassengerName.Text);
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            list.DisplayAll(dataGridView1);
        }
    }
}