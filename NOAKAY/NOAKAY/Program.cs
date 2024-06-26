using NOAKAY.AUTH;
using NOAKAY.DASHFORM;
using SQLCONNECTION;

namespace NOAKAY
{
    //this is Noakay v.2
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            var connection = new Connection();
            connection.Database.EnsureDeleted();
            connection.Database.EnsureCreated();
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new DashboardMain());
        }
    }
}