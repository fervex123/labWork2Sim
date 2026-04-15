using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace labWork2Sim
{
    public partial class AddEndForm : Form
    {

        private SingleLinkedList list;

        public AddEndForm(SingleLinkedList list)
        {
            InitializeComponent();
            this.list = list;
            UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            list.DisplayAll(dataGridView1);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDest.Text) ||
                string.IsNullOrWhiteSpace(txtFlight.Text) ||
                string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }

            list.AddToEnd(txtDest.Text, txtFlight.Text, txtName.Text, dtpDate.Value);
            UpdateDisplay();

            txtDest.Clear();
            txtFlight.Clear();
            txtName.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
