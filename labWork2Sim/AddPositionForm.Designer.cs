namespace labWork2Sim
{
    partial class AddPositionForm
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
            txtName = new TextBox();
            txtFlight = new TextBox();
            txtDest = new TextBox();
            dataGridView1 = new DataGridView();
            number = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(96, 346);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 17;
            button1.Text = "добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(56, 270);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(200, 23);
            dtpDate.TabIndex = 16;
            // 
            // txtName
            // 
            txtName.Location = new Point(96, 80);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 15;
            // 
            // txtFlight
            // 
            txtFlight.Location = new Point(96, 136);
            txtFlight.Name = "txtFlight";
            txtFlight.Size = new Size(100, 23);
            txtFlight.TabIndex = 14;
            // 
            // txtDest
            // 
            txtDest.Location = new Point(96, 192);
            txtDest.Name = "txtDest";
            txtDest.Size = new Size(100, 23);
            txtDest.TabIndex = 13;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(356, 34);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(396, 382);
            dataGridView1.TabIndex = 12;
            // 
            // number
            // 
            number.Location = new Point(96, 34);
            number.Name = "number";
            number.Size = new Size(100, 23);
            number.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(123, 9);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 19;
            label1.Text = "позиция";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(123, 62);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 20;
            label2.Text = "фио";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(123, 118);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 21;
            label3.Text = "рейс";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(91, 174);
            label4.Name = "label4";
            label4.Size = new Size(105, 15);
            label4.TabIndex = 22;
            label4.Text = "пункт назначения";
            // 
            // AddPositionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(number);
            Controls.Add(button1);
            Controls.Add(dtpDate);
            Controls.Add(txtName);
            Controls.Add(txtFlight);
            Controls.Add(txtDest);
            Controls.Add(dataGridView1);
            Name = "AddPositionForm";
            Text = "Добавить в произвольную позицию";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DateTimePicker dtpDate;
        private TextBox txtName;
        private TextBox txtFlight;
        private TextBox txtDest;
        private DataGridView dataGridView1;
        private TextBox number;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}