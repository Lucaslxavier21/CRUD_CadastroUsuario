using Microsoft.Extensions.Configuration;
using System;
using Microsoft.Data.SqlClient;
using CRUD2.Models;

namespace CRUD2
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            var cfg = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile("appsettings.devlop.json", optional: true, reloadOnChange: true)
                .Build();

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1(cfg)); 
        }
    }
}