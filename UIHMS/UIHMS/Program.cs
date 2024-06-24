
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace UIHMS
{
    internal static class Program

    {
        public static Connection? Connection;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            //Connection = new Connection();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            Application.Run(new Form2());
        }
    }
}