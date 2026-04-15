using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace labWork2Sim
{
    public partial class AddPositionForm : Form
    {
        private SingleLinkedList list;
        public AddPositionForm(SingleLinkedList list)
        {
            InitializeComponent();
            this.list = list;
            UpdateDisplay();
        }
        private void UpdateDisplay()
        {
            list.DisplayAll(dataGridView1);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(number.Text, out int position) || position < 1)
            {
                MessageBox.Show("Введите корректный номер (целое число >= 1)");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDest.Text) ||
                string.IsNullOrWhiteSpace(txtFlight.Text) ||
                string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }

            bool success = list.AddAtPosition(position, txtDest.Text, txtFlight.Text, txtName.Text, dtpDate.Value);

            if (success)
            {
                UpdateDisplay();
                number.Clear();
                txtDest.Clear();
                txtFlight.Clear();
                txtName.Clear();
            }
            else
            {
                MessageBox.Show("Позиция не найдена!");
            }
        }
    }
}
