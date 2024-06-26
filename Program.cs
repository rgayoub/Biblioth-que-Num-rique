using System.Data.SqlClient;

namespace EFMbiblio
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new utilisateurForm());
        }
        public static SqlConnection GetSqlConnection()
        {
            SqlConnection cnx = new SqlConnection();
            cnx.ConnectionString = "Server=.; database=BIBLIO_DB; Integrated Security = True";
            return cnx;
        }
        
    }
}