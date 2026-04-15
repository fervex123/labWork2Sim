using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace labWork2Sim
{
    public partial class AddBeginForm : Form
    {
        private SingleLinkedList list;

        public AddBeginForm(SingleLinkedList list)
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
            if (string.IsNullOrWhiteSpace(txtDest.Text) ||
            string.IsNullOrWhiteSpace(txtFlight.Text) ||
            string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }

            list.AddToBeginning(txtDest.Text, txtFlight.Text, txtName.Text, dtpDate.Value);
            UpdateDisplay();

            txtDest.Clear();
            txtFlight.Clear();
            txtName.Clear();
        }
    }
}

