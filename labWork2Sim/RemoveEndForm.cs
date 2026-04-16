using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace labWork2Sim
{
    public partial class RemoveEndForm : Form
    {
        private SingleLinkedList list;

        public RemoveEndForm(SingleLinkedList list)
        {
            InitializeComponent();
            this.list = list;
            UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            list.DisplayAll(dataGridView1);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (list.IsEmpty())
            {
                MessageBox.Show("Список пуст! Нечего удалять.");
            }

            list.RemoveFromEnd();
            UpdateDisplay();
        }
    }
}
