using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Cars
{
    public partial class MainForm : Form
    {
        private SQLiteConnection DB;
        public MainForm()
        {
            InitializeComponent();
        }
        // Подключение БД
        private async void MainForm_Load(object sender, EventArgs e)
        {
            DB = new SQLiteConnection(Database.connectionString);
            await DB.OpenAsync();
        }
        void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Помощник 
            this.Close();
        }
        #region Создание форм
        // Создание форм через конструктор
        private async void e24_Click(object sender, EventArgs e)
        {
            SQLiteDataReader sqlReader = null;
            SQLiteCommand command = new SQLiteCommand($"SELECT * FROM [{CarsTable.Main}] WHERE ID_Car=1", DB);
            sqlReader = (SQLiteDataReader)await command.ExecuteReaderAsync();

            while (await sqlReader.ReadAsync())
            {
                var name = sqlReader.GetValue(2);
                var description = sqlReader.GetValue(3);
                var image = sqlReader.GetValue(4);
                ConfigAuto.Header = (string)name;
                ConfigAuto.Description = (string)description;
                ConfigAuto.Image = (string)image;
            }
            // Открытие новой формы
            Form fcars = new CarsForm();
            fcars.Show();
            fcars.FormClosed += new FormClosedEventHandler(MainForm_FormClosed);
            this.Hide();
        }
        private async void e30_Click(object sender, EventArgs e)
        {
            SQLiteDataReader sqlReader = null;
            SQLiteCommand command = new SQLiteCommand($"SELECT * FROM [{CarsTable.Main}] WHERE ID_Car=2", DB);
            sqlReader = (SQLiteDataReader)await command.ExecuteReaderAsync();

            while (await sqlReader.ReadAsync())
            {
                var name = sqlReader.GetValue(2);
                var description = sqlReader.GetValue(3);
                var image = sqlReader.GetValue(4);
                ConfigAuto.Header = (string)name;
                ConfigAuto.Description = (string)description;
                ConfigAuto.Image = (string)image;
            }

            Form fcars = new CarsForm();
            fcars.Show();
            fcars.FormClosed += new FormClosedEventHandler(MainForm_FormClosed);
            this.Hide();
        }

        private async void e32_Click(object sender, EventArgs e)
        {
            SQLiteDataReader sqlReader = null;
            SQLiteCommand command = new SQLiteCommand($"SELECT * FROM [{CarsTable.Main}] WHERE ID_Car=3", DB);
            sqlReader = (SQLiteDataReader)await command.ExecuteReaderAsync();

            while (await sqlReader.ReadAsync())
            {
                var name = sqlReader.GetValue(2);
                var description = sqlReader.GetValue(3);
                var image = sqlReader.GetValue(4);
                ConfigAuto.Header = (string)name;
                ConfigAuto.Description = (string)description;
                ConfigAuto.Image = (string)image;
            }

            Form fcars = new CarsForm();
            fcars.Show();
            fcars.FormClosed += new FormClosedEventHandler(MainForm_FormClosed);
            this.Hide();

        }
        private async void e34_Click(object sender, EventArgs e)
        {
            SQLiteDataReader sqlReader = null;
            SQLiteCommand command = new SQLiteCommand($"SELECT * FROM [{CarsTable.Main}] WHERE ID_Car=4", DB);
            sqlReader = (SQLiteDataReader)await command.ExecuteReaderAsync();

            while (await sqlReader.ReadAsync())
            {
                var name = sqlReader.GetValue(2);
                var description = sqlReader.GetValue(3);
                var image = sqlReader.GetValue(4);
                ConfigAuto.Header = (string)name;
                ConfigAuto.Description = (string)description;
                ConfigAuto.Image = (string)image;
            }

            Form fcars = new CarsForm();
            fcars.Show();
            fcars.FormClosed += new FormClosedEventHandler(MainForm_FormClosed);
            this.Hide();
        }
        private async void e36_Click(object sender, EventArgs e)
        {
            SQLiteDataReader sqlReader = null;
            SQLiteCommand command = new SQLiteCommand($"SELECT * FROM [{CarsTable.Main}] WHERE ID_Car=5", DB);
            sqlReader = (SQLiteDataReader)await command.ExecuteReaderAsync();

            while (await sqlReader.ReadAsync())
            {
                var name = sqlReader.GetValue(2);
                var description = sqlReader.GetValue(3);
                var image = sqlReader.GetValue(4);
                ConfigAuto.Header = (string)name;
                ConfigAuto.Description = (string)description;
                ConfigAuto.Image = (string)image;
            }

            Form fcars = new CarsForm();
            fcars.Show();
            fcars.FormClosed += new FormClosedEventHandler(MainForm_FormClosed);
            this.Hide();
        }
        private async void e38_Click(object sender, EventArgs e)
        {
            SQLiteDataReader sqlReader = null;
            SQLiteCommand command = new SQLiteCommand($"SELECT * FROM [{CarsTable.Main}] WHERE ID_Car=4", DB);
            sqlReader = (SQLiteDataReader)await command.ExecuteReaderAsync();

            while (await sqlReader.ReadAsync())
            {
                var name = sqlReader.GetValue(2);
                var description = sqlReader.GetValue(3);
                var image = sqlReader.GetValue(4);
                ConfigAuto.Header = (string)name;
                ConfigAuto.Description = (string)description;
                ConfigAuto.Image = (string)image;
            }

            Form fcars = new CarsForm();
            fcars.Show();
            fcars.FormClosed += new FormClosedEventHandler(MainForm_FormClosed);
            this.Hide();
        }



        #endregion

        #region back
        private void back_Click(object sender, EventArgs e)
        {
            Form fback = new FirstForm();
            fback.Show();
            fback.FormClosed += new FormClosedEventHandler(MainForm_FormClosed);
            this.Hide();
        }
        #endregion
    }
}
