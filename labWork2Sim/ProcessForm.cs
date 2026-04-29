using System;
using System.Windows.Forms;

namespace labWork2Sim
{
    public partial class ProcessForm : Form
    {
        private CycleDoubleLinkedList list;
        private bool isCellEdited = false;
        public ProcessForm(CycleDoubleLinkedList list)
        {
            InitializeComponent();
            this.list = list;
            this.Text = "Обработка списка заявок";
        }


        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            int savedCount = 0;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataGridViewRow row = dataGridView1.Rows[i];
                if (row.IsNewRow) continue;

                int position = i + 1; 

                DoubleNode node = list.GetNodeAtPosition(position);
                if (node == null) continue;

                string passengerName = row.Cells["ColPassenger"].Value?.ToString();
                string flightNumber = row.Cells["ColFlight"].Value?.ToString();
                string destination = row.Cells["ColDest"].Value?.ToString();
                string dateStr = row.Cells["ColDate"].Value?.ToString();

                bool changed = false;

                if (!string.IsNullOrEmpty(passengerName) && node.PassengerName != passengerName)
                {
                    node.PassengerName = passengerName;
                    changed = true;
                }

                if (!string.IsNullOrEmpty(flightNumber) && node.FlightNumber != flightNumber)
                {
                    node.FlightNumber = flightNumber;
                    changed = true;
                }

                if (!string.IsNullOrEmpty(destination) && node.Destination != destination)
                {
                    node.Destination = destination;
                    changed = true;
                }

                if (DateTime.TryParse(dateStr, out DateTime newDate) && node.DepartureDate != newDate)
                {
                    node.DepartureDate = newDate;
                    changed = true;
                }

                if (changed) savedCount++;
            }

            list.DisplayAll(dataGridView1);

            MessageBox.Show($"Сохранено изменений: {savedCount}", "Успех");
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