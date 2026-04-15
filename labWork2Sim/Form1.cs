namespace labWork2Sim
{
    public partial class Form1 : Form
    {
        private SingleLinkedList ticketList;
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вишняков Вячеслав Павлович\nГруппа:6102-09.03.01D\nВариант:38", "О программе");

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void созданиеСпискаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateForm cf = new CreateForm();
            cf.ShowDialog();

            
            ticketList = cf.NewList;
        }
    }
}
