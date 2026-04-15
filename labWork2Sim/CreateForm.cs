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
        public SingleLinkedList NewList { get; private set; }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            NewList = new SingleLinkedList(); 
            MessageBox.Show("Новый пустой список создан!");
            ListCreated=true;
            this.Close();
        }
    }
    }

