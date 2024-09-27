using System;
using System.Windows.Forms;

namespace Cars
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FirstForm());
        }
    }
    public static class Database
    {
        public static string connectionString = @"Data Source=Сars.db;Integrated Security=False; MultipleActiveResultSets=True";
    }
    public static class ConfigAuto
    {
        public static string ID_Car { get; set; }
        public static string Header { get; set; }
        public static string Description { get; set; }
        public static string Image { get; set; }
    }
    public static class CarsTable
    {
        public static string Main = "Eseries";
        public static string ID_Car = "ID_Car";
        public static string Header = "Header";
        public static string Description = "Description";
        public static string Image = "Image";
    }
}
