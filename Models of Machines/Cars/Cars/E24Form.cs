﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cars
{
    public partial class E24Form : Form
    {
        public E24Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form fback = new MainForm();
            fback.Show();
            fback.FormClosed += new FormClosedEventHandler(E24Form_FormClosed);
            this.Hide();
        }
        void E24Form_FormClosed(object sender, FormClosedEventArgs e) // Помощник 
        {
            this.Close();
        }
    }
}
