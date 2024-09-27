using System;
using System.Drawing;
using System.Windows.Forms;

namespace Cars
{
    public partial class CarsForm : Form
    {
        public CarsForm()
        {
            InitializeComponent();
        }
        
        #region back
        private void back_Click(object sender, EventArgs e)
        {
            Form fback = new MainForm();
            fback.Show();
            fback.FormClosed += new FormClosedEventHandler(CarsForm_FormClosed);
            this.Hide();
        }

        // Помощник 
        void CarsForm_FormClosed(object sender, FormClosedEventArgs e)         
        {
            this.Close();
        }
        #endregion
        
        // Установка текста и изображения из конфигурации  
        private void CarsForm_Load(object sender, EventArgs e)
        {
            header.Text = ConfigAuto.Header;
            description.Text = ConfigAuto.Description;
            image.Image = Image.FromFile(ConfigAuto.Image);
        }
    }
}
