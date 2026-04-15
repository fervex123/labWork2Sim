namespace labWork2Sim
{
    public partial class Form1 : Form
    {
        private SingleLinkedList ticketList;
        public Form1()
        {
            InitializeComponent();
            ticketList = null; 
            SetButtonsEnabled(false);
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


            if (cf.ListCreated)
            {
                ticketList = cf.NewList;
                SetButtonsEnabled(true); 
                MessageBox.Show("Список создан! Теперь доступны все функции.");
            }
        }

        private void вНачалоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBeginForm ad = new AddBeginForm(ticketList);
            ad.ShowDialog();
        }

        private void вКонецToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEndForm ad = new AddEndForm(ticketList); ad.ShowDialog();
        }

        private void вПроизвольнуюТочкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPositionForm ad = new AddPositionForm(ticketList);
            ad.ShowDialog();

        }

        private void обработкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessForm ed = new ProcessForm(ticketList);
            ed.ShowDialog();
        }

        private void удалениеЭлементаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void вНачалеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveBeginForm ed = new RemoveBeginForm(ticketList); ed.ShowDialog();
        }

        private void вКонцеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveEndForm ed = new RemoveEndForm(ticketList); ed.ShowDialog();
        }

        private void вПроизвольнойТочкеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemovePositionForm ed = new RemovePositionForm(ticketList); ed.ShowDialog();
        }
        private void SetButtonsEnabled(bool enabled)
        {
            
            редактированиеСпискаToolStripMenuItem.Enabled = enabled;
            обработкаToolStripMenuItem.Enabled = enabled;
            разрушениеToolStripMenuItem.Enabled = enabled;

        }

        private void разрушениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите разрушить список?\nВсе данные будут потеряны!", "Подтверждение",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                ticketList.Destroy();
                SetButtonsEnabled(false);
                MessageBox.Show("Список успешно разрушен!", "Информация");
            }
        }
    }
}
