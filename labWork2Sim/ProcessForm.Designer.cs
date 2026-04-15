namespace labWork2Sim
{
    partial class ProcessForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            btnSearchFlight = new Button();
            label1 = new Label();
            txtFlightNumber = new TextBox();
            dtpDate = new DateTimePicker();
            label2 = new Label();
            btnSearchPassenger = new Button();
            txtPassengerName = new TextBox();
            btnShowAll = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(445, 68);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(606, 665);
            dataGridView1.TabIndex = 0;
            // 
            // btnSearchFlight
            // 
            btnSearchFlight.Location = new Point(111, 118);
            btnSearchFlight.Name = "btnSearchFlight";
            btnSearchFlight.Size = new Size(188, 23);
            btnSearchFlight.TabIndex = 1;
            btnSearchFlight.Text = "Найти по рейсу и дате";
            btnSearchFlight.UseVisualStyleBackColor = true;
            btnSearchFlight.Click += btnSearchFlight_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 38);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 2;
            label1.Text = "Ввод номера рейса";
            // 
            // txtFlightNumber
            // 
            txtFlightNumber.Location = new Point(31, 68);
            txtFlightNumber.Name = "txtFlightNumber";
            txtFlightNumber.Size = new Size(100, 23);
            txtFlightNumber.TabIndex = 3;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(172, 68);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(200, 23);
            dtpDate.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(142, 200);
            label2.Name = "label2";
            label2.Size = new Size(126, 15);
            label2.TabIndex = 5;
            label2.Text = "Ввод ФИО пассажира";
            // 
            // btnSearchPassenger
            // 
            btnSearchPassenger.Location = new Point(131, 292);
            btnSearchPassenger.Name = "btnSearchPassenger";
            btnSearchPassenger.Size = new Size(137, 23);
            btnSearchPassenger.TabIndex = 6;
            btnSearchPassenger.Text = "Найти по пассажиру";
            btnSearchPassenger.UseVisualStyleBackColor = true;
            btnSearchPassenger.Click += btnSearchPassenger_Click;
            // 
            // txtPassengerName
            // 
            txtPassengerName.Location = new Point(148, 246);
            txtPassengerName.Name = "txtPassengerName";
            txtPassengerName.Size = new Size(100, 23);
            txtPassengerName.TabIndex = 7;
            // 
            // btnShowAll
            // 
            btnShowAll.Location = new Point(131, 451);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(137, 23);
            btnShowAll.TabIndex = 8;
            btnShowAll.Text = "Показать все заявки";
            btnShowAll.UseVisualStyleBackColor = true;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // ProcessForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1094, 773);
            Controls.Add(btnShowAll);
            Controls.Add(txtPassengerName);
            Controls.Add(btnSearchPassenger);
            Controls.Add(label2);
            Controls.Add(dtpDate);
            Controls.Add(txtFlightNumber);
            Controls.Add(label1);
            Controls.Add(btnSearchFlight);
            Controls.Add(dataGridView1);
            Name = "ProcessForm";
            Text = "Обработка";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnSearchFlight;
        private Label label1;
        private TextBox txtFlightNumber;
        private DateTimePicker dtpDate;
        private Label label2;
        private Button btnSearchPassenger;
        private TextBox txtPassengerName;
        private Button btnShowAll;
    }
}