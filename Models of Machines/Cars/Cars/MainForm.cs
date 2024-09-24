using System;
using System.Windows.Forms;

namespace Cars
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form fe24 = new E24Form();
            fe24.Show();
            fe24.FormClosed += new FormClosedEventHandler(MainForm_FormClosed);
            this.Hide();    
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form fe30 = new E30Form();
            fe30.Show();
            fe30.FormClosed += new FormClosedEventHandler(MainForm_FormClosed);
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form fe32 = new E32Form();
            fe32.Show();
            fe32.FormClosed += new FormClosedEventHandler(MainForm_FormClosed);
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

            Form fe34 = new E34Form();
            fe34.Show();
            fe34.FormClosed += new FormClosedEventHandler(MainForm_FormClosed);
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form fe36 = new E36Form();
            fe36.Show();
            fe36.FormClosed += new FormClosedEventHandler(MainForm_FormClosed);
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form fe38 = new E38Form();
            fe38.Show();
            fe38.FormClosed += new FormClosedEventHandler(MainForm_FormClosed);
            this.Hide();
        }
        void MainForm_FormClosed(object sender, FormClosedEventArgs e) // Помощник 
        {
            this.Close();
        }
    }
}
