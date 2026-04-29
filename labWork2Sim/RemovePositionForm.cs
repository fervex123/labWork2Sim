using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace labWork2Sim
{
    public partial class RemovePositionForm : Form
    {
        private CycleDoubleLinkedList list;

        public RemovePositionForm(CycleDoubleLinkedList list)
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
            if (!int.TryParse(textBox1.Text, out int position) || position < 1)
            {
                MessageBox.Show("Введите корректный номер (целое число >= 1)");
                
            }

            bool success = list.RemoveAtPosition(position);

            if (success)
            {
                UpdateDisplay();
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Позиция не найдена!");
            }
        }
    }
}
