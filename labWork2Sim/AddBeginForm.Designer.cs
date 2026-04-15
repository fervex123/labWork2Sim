namespace labWork2Sim
{
    partial class AddBeginForm
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
            txtDest = new TextBox();
            txtFlight = new TextBox();
            txtName = new TextBox();
            dtpDate = new DateTimePicker();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(357, 42);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(396, 382);
            dataGridView1.TabIndex = 0;
            // 
            // txtDest
            // 
            txtDest.Location = new Point(93, 189);
            txtDest.Name = "txtDest";
            txtDest.Size = new Size(100, 23);
            txtDest.TabIndex = 1;
            // 
            // txtFlight
            // 
            txtFlight.Location = new Point(93, 118);
            txtFlight.Name = "txtFlight";
            txtFlight.Size = new Size(100, 23);
            txtFlight.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(93, 42);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 3;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(73, 271);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(200, 23);
            dtpDate.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(128, 358);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(115, 9);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 6;
            label1.Text = "фио";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(112, 86);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 7;
            label2.Text = "рейс";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(93, 158);
            label3.Name = "label3";
            label3.Size = new Size(108, 15);
            label3.TabIndex = 8;
            label3.Text = "пункт назначения ";
            // 
            // AddBeginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(dtpDate);
            Controls.Add(txtName);
            Controls.Add(txtFlight);
            Controls.Add(txtDest);
            Controls.Add(dataGridView1);
            Name = "AddBeginForm";
            Text = "Добавить в начало";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtDest;
        private TextBox txtFlight;
        private TextBox txtName;
        private DateTimePicker dtpDate;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}