namespace labWork2Sim
{
    partial class AddEndForm
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
            button1 = new Button();
            dtpDate = new DateTimePicker();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtName = new TextBox();
            txtFlight = new TextBox();
            txtDest = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(126, 350);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 11;
            button1.Text = "добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnAdd_Click;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(71, 263);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(200, 23);
            dtpDate.TabIndex = 10;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(323, 24);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(396, 382);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(101, 178);
            label3.Name = "label3";
            label3.Size = new Size(108, 15);
            label3.TabIndex = 17;
            label3.Text = "пункт назначения ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(120, 106);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 16;
            label2.Text = "рейс";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(123, 29);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 15;
            label1.Text = "фио";
            // 
            // txtName
            // 
            txtName.Location = new Point(101, 62);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 14;
            // 
            // txtFlight
            // 
            txtFlight.Location = new Point(101, 138);
            txtFlight.Name = "txtFlight";
            txtFlight.Size = new Size(100, 23);
            txtFlight.TabIndex = 13;
            // 
            // txtDest
            // 
            txtDest.Location = new Point(101, 209);
            txtDest.Name = "txtDest";
            txtDest.Size = new Size(100, 23);
            txtDest.TabIndex = 12;
            // 
            // AddEndForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(txtFlight);
            Controls.Add(txtDest);
            Controls.Add(button1);
            Controls.Add(dtpDate);
            Controls.Add(dataGridView1);
            Name = "AddEndForm";
            Text = "AddEndForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DateTimePicker dtpDate;
        private DataGridView dataGridView1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtName;
        private TextBox txtFlight;
        private TextBox txtDest;
    }
}