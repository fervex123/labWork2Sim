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
        private CycleDoubleLinkedList list;

        public RemoveEndForm(CycleDoubleLinkedList list)
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
            if (list==null)
            {
                MessageBox.Show("Список пуст! Нечего удалять.");
            }

            list.RemoveFromEnd();
            UpdateDisplay();
        }
    }
}
