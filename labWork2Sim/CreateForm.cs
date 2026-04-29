using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace labWork2Sim
{
    public partial class CreateForm : Form
    {
        public bool ListCreated { get; private set; }

        public CreateForm()
        {
            InitializeComponent();
            NewList = null;
            ListCreated = false;
        }
        public CycleDoubleLinkedList NewList { get; private set; }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            NewList = new CycleDoubleLinkedList(); 
            MessageBox.Show("Новый пустой список создан!");
            ListCreated=true;
            this.Close();
        }
    }
    }

