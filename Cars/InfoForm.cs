using System;
using System.Windows.Forms;

namespace Cars
{
    public partial class InfoForm : Form
    {
        public InfoForm()
        {
            InitializeComponent();
        }
        #region Кнопки

        private void close_Click(object sender, EventArgs e)
        {
            // Закрытие программы
            Application.Exit();
        }
        // Помощник 
        void InfoForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void back_Click(object sender, EventArgs e)
        {
            // Переход в другую форму
            Form fback = new FirstForm();
            fback.Show();
            fback.FormClosed += new FormClosedEventHandler(InfoForm_FormClosed);
            this.Hide();
        }
        #endregion
    }
}
