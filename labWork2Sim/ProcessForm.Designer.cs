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
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;
            dataGridView1.Location = new Point(509, 91);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(693, 887);
            dataGridView1.TabIndex = 0;
            // 
            // btnSearchFlight
            // 
            btnSearchFlight.Location = new Point(127, 157);
            btnSearchFlight.Margin = new Padding(3, 4, 3, 4);
            btnSearchFlight.Name = "btnSearchFlight";
            btnSearchFlight.Size = new Size(215, 31);
            btnSearchFlight.TabIndex = 1;
            btnSearchFlight.Text = "Найти по рейсу и дате";
            btnSearchFlight.UseVisualStyleBackColor = true;
            btnSearchFlight.Click += btnSearchFlight_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 51);
            label1.Name = "label1";
            label1.Size = new Size(146, 20);
            label1.TabIndex = 2;
            label1.Text = "Ввод номера рейса";
            // 
            // txtFlightNumber
            // 
            txtFlightNumber.Location = new Point(35, 91);
            txtFlightNumber.Margin = new Padding(3, 4, 3, 4);
            txtFlightNumber.Name = "txtFlightNumber";
            txtFlightNumber.Size = new Size(114, 27);
            txtFlightNumber.TabIndex = 3;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(197, 91);
            dtpDate.Margin = new Padding(3, 4, 3, 4);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(228, 27);
            dtpDate.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(162, 267);
            label2.Name = "label2";
            label2.Size = new Size(160, 20);
            label2.TabIndex = 5;
            label2.Text = "Ввод ФИО пассажира";
            // 
            // btnSearchPassenger
            // 
            btnSearchPassenger.Location = new Point(150, 389);
            btnSearchPassenger.Margin = new Padding(3, 4, 3, 4);
            btnSearchPassenger.Name = "btnSearchPassenger";
            btnSearchPassenger.Size = new Size(157, 31);
            btnSearchPassenger.TabIndex = 6;
            btnSearchPassenger.Text = "Найти по пассажиру";
            btnSearchPassenger.UseVisualStyleBackColor = true;
            btnSearchPassenger.Click += btnSearchPassenger_Click;
            // 
            // txtPassengerName
            // 
            txtPassengerName.Location = new Point(169, 328);
            txtPassengerName.Margin = new Padding(3, 4, 3, 4);
            txtPassengerName.Name = "txtPassengerName";
            txtPassengerName.Size = new Size(114, 27);
            txtPassengerName.TabIndex = 7;
            // 
            // btnShowAll
            // 
            btnShowAll.Location = new Point(150, 601);
            btnShowAll.Margin = new Padding(3, 4, 3, 4);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(157, 31);
            btnShowAll.TabIndex = 8;
            btnShowAll.Text = "Показать все заявки";
            btnShowAll.UseVisualStyleBackColor = true;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // button1
            // 
            button1.Location = new Point(314, 896);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(157, 31);
            button1.TabIndex = 9;
            button1.Text = "сохранить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnSaveChanges_Click;
            // 
            // ProcessForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1250, 1031);
            Controls.Add(button1);
            Controls.Add(btnShowAll);
            Controls.Add(txtPassengerName);
            Controls.Add(btnSearchPassenger);
            Controls.Add(label2);
            Controls.Add(dtpDate);
            Controls.Add(txtFlightNumber);
            Controls.Add(label1);
            Controls.Add(btnSearchFlight);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 4, 3, 4);
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
        private Button button1;
    }
}