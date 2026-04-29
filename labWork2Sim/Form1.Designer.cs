namespace labWork2Sim
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            заданиеToolStripMenuItem = new ToolStripMenuItem();
            созданиеСпискаToolStripMenuItem = new ToolStripMenuItem();
            редактированиеСпискаToolStripMenuItem = new ToolStripMenuItem();
            добавлениеЭлементаToolStripMenuItem = new ToolStripMenuItem();
            вНачалоToolStripMenuItem = new ToolStripMenuItem();
            вКонецToolStripMenuItem = new ToolStripMenuItem();
            вПроизвольнуюТочкуToolStripMenuItem = new ToolStripMenuItem();
            удалениеЭлементаToolStripMenuItem = new ToolStripMenuItem();
            вНачалеToolStripMenuItem = new ToolStripMenuItem();
            вКонцеToolStripMenuItem = new ToolStripMenuItem();
            вПроизвольнойТочкеToolStripMenuItem = new ToolStripMenuItem();
            обработкаToolStripMenuItem = new ToolStripMenuItem();
            разрушениеToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, заданиеToolStripMenuItem, выходToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(537, 38);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(162, 34);
            toolStripMenuItem1.Text = "О программе";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // заданиеToolStripMenuItem
            // 
            заданиеToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { созданиеСпискаToolStripMenuItem, редактированиеСпискаToolStripMenuItem, обработкаToolStripMenuItem, разрушениеToolStripMenuItem });
            заданиеToolStripMenuItem.Name = "заданиеToolStripMenuItem";
            заданиеToolStripMenuItem.Size = new Size(109, 34);
            заданиеToolStripMenuItem.Text = "Задание";
            // 
            // созданиеСпискаToolStripMenuItem
            // 
            созданиеСпискаToolStripMenuItem.Name = "созданиеСпискаToolStripMenuItem";
            созданиеСпискаToolStripMenuItem.Size = new Size(329, 34);
            созданиеСпискаToolStripMenuItem.Text = "Создание списка";
            созданиеСпискаToolStripMenuItem.Click += созданиеСпискаToolStripMenuItem_Click;
            // 
            // редактированиеСпискаToolStripMenuItem
            // 
            редактированиеСпискаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { добавлениеЭлементаToolStripMenuItem, удалениеЭлементаToolStripMenuItem });
            редактированиеСпискаToolStripMenuItem.Name = "редактированиеСпискаToolStripMenuItem";
            редактированиеСпискаToolStripMenuItem.Size = new Size(329, 34);
            редактированиеСпискаToolStripMenuItem.Text = "Редактирование списка";
            // 
            // добавлениеЭлементаToolStripMenuItem
            // 
            добавлениеЭлементаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { вНачалоToolStripMenuItem, вКонецToolStripMenuItem, вПроизвольнуюТочкуToolStripMenuItem });
            добавлениеЭлементаToolStripMenuItem.Name = "добавлениеЭлементаToolStripMenuItem";
            добавлениеЭлементаToolStripMenuItem.Size = new Size(313, 34);
            добавлениеЭлементаToolStripMenuItem.Text = "Добавление элемента";
            // 
            // вНачалоToolStripMenuItem
            // 
            вНачалоToolStripMenuItem.Name = "вНачалоToolStripMenuItem";
            вНачалоToolStripMenuItem.Size = new Size(325, 34);
            вНачалоToolStripMenuItem.Text = "В начало";
            вНачалоToolStripMenuItem.Click += вНачалоToolStripMenuItem_Click;
            // 
            // вКонецToolStripMenuItem
            // 
            вКонецToolStripMenuItem.Name = "вКонецToolStripMenuItem";
            вКонецToolStripMenuItem.Size = new Size(325, 34);
            вКонецToolStripMenuItem.Text = "В конец";
            вКонецToolStripMenuItem.Click += вКонецToolStripMenuItem_Click;
            // 
            // вПроизвольнуюТочкуToolStripMenuItem
            // 
            вПроизвольнуюТочкуToolStripMenuItem.Name = "вПроизвольнуюТочкуToolStripMenuItem";
            вПроизвольнуюТочкуToolStripMenuItem.Size = new Size(325, 34);
            вПроизвольнуюТочкуToolStripMenuItem.Text = "В произвольную точку";
            вПроизвольнуюТочкуToolStripMenuItem.Click += вПроизвольнуюТочкуToolStripMenuItem_Click;
            // 
            // удалениеЭлементаToolStripMenuItem
            // 
            удалениеЭлементаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { вНачалеToolStripMenuItem, вКонцеToolStripMenuItem, вПроизвольнойТочкеToolStripMenuItem });
            удалениеЭлементаToolStripMenuItem.Name = "удалениеЭлементаToolStripMenuItem";
            удалениеЭлементаToolStripMenuItem.Size = new Size(313, 34);
            удалениеЭлементаToolStripMenuItem.Text = "Удаление элемента";
            удалениеЭлементаToolStripMenuItem.Click += удалениеЭлементаToolStripMenuItem_Click;
            // 
            // вНачалеToolStripMenuItem
            // 
            вНачалеToolStripMenuItem.Name = "вНачалеToolStripMenuItem";
            вНачалеToolStripMenuItem.Size = new Size(321, 34);
            вНачалеToolStripMenuItem.Text = "В начале";
            вНачалеToolStripMenuItem.Click += вНачалеToolStripMenuItem_Click;
            // 
            // вКонцеToolStripMenuItem
            // 
            вКонцеToolStripMenuItem.Name = "вКонцеToolStripMenuItem";
            вКонцеToolStripMenuItem.Size = new Size(321, 34);
            вКонцеToolStripMenuItem.Text = "В конце";
            вКонцеToolStripMenuItem.Click += вКонцеToolStripMenuItem_Click;
            // 
            // вПроизвольнойТочкеToolStripMenuItem
            // 
            вПроизвольнойТочкеToolStripMenuItem.Name = "вПроизвольнойТочкеToolStripMenuItem";
            вПроизвольнойТочкеToolStripMenuItem.Size = new Size(321, 34);
            вПроизвольнойТочкеToolStripMenuItem.Text = "В произвольной точке";
            вПроизвольнойТочкеToolStripMenuItem.Click += вПроизвольнойТочкеToolStripMenuItem_Click;
            // 
            // обработкаToolStripMenuItem
            // 
            обработкаToolStripMenuItem.Name = "обработкаToolStripMenuItem";
            обработкаToolStripMenuItem.Size = new Size(329, 34);
            обработкаToolStripMenuItem.Text = "Обработка";
            обработкаToolStripMenuItem.Click += обработкаToolStripMenuItem_Click;
            // 
            // разрушениеToolStripMenuItem
            // 
            разрушениеToolStripMenuItem.Name = "разрушениеToolStripMenuItem";
            разрушениеToolStripMenuItem.Size = new Size(329, 34);
            разрушениеToolStripMenuItem.Text = "Очистка";
            разрушениеToolStripMenuItem.Click += разрушениеToolStripMenuItem_Click;
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(93, 34);
            выходToolStripMenuItem.Text = "Выход";
            выходToolStripMenuItem.Click += выходToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 193);
            Controls.Add(menuStrip1);
            Name = "Form1";
            Text = "Лабораторная работа 2 «Списки»";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem заданиеToolStripMenuItem;
        private ToolStripMenuItem созданиеСпискаToolStripMenuItem;
        private ToolStripMenuItem редактированиеСпискаToolStripMenuItem;
        private ToolStripMenuItem добавлениеЭлементаToolStripMenuItem;
        private ToolStripMenuItem вНачалоToolStripMenuItem;
        private ToolStripMenuItem вКонецToolStripMenuItem;
        private ToolStripMenuItem вПроизвольнуюТочкуToolStripMenuItem;
        private ToolStripMenuItem удалениеЭлементаToolStripMenuItem;
        private ToolStripMenuItem вНачалеToolStripMenuItem;
        private ToolStripMenuItem вКонцеToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripMenuItem вПроизвольнойТочкеToolStripMenuItem;
        private ToolStripMenuItem обработкаToolStripMenuItem;
        private ToolStripMenuItem разрушениеToolStripMenuItem;
    }
}
