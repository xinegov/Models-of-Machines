using System;
using System.Windows.Forms;

namespace Cars
{
    public partial class FirstForm : Form
    {
        public FirstForm()
        {
            InitializeComponent();
        }
        #region Кнопки
        private void eseries_Click(object sender, EventArgs e)
        {
            // Переход в другую форму
            Form ffirst = new MainForm();
            ffirst.Show();
            ffirst.FormClosed += new FormClosedEventHandler(FirstForm_FormClosed);
            this.Hide();
        }
        private void info_Click(object sender, EventArgs e)
        {
            // Переход в другую форму
            Form finfo = new InfoForm();
            finfo.Show();
            finfo.FormClosed += new FormClosedEventHandler(FirstForm_FormClosed);
            this.Hide();
        }

        // Помощник 
        void FirstForm_FormClosed(object sender, FormClosedEventArgs e) 
        {
            this.Close();
        }

        #endregion

        
    }
}
