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
    public partial class RemoveBeginForm : Form
    {
         private SingleLinkedList list;

        public RemoveBeginForm(SingleLinkedList list)
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
            if (list.IsEmpty())
            {
                MessageBox.Show("Список пуст! Нечего удалять.");
            }

            list.RemoveFromBeginning();
            UpdateDisplay();
        }
    }
}
