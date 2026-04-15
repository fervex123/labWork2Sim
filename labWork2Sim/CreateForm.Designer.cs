namespace labWork2Sim
{
    partial class CreateForm
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
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.Location = new Point(47, 12);
            button1.Name = "button1";
            button1.Size = new Size(123, 57);
            button1.TabIndex = 0;
            button1.Text = "Создать ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnCreate_Click;
            // 
            // CreateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(249, 90);
            Controls.Add(button1);
            Name = "CreateForm";
            Text = "CreateForm";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
    }
}