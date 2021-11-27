using System;
using System.Data.SqlClient;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataView
{
    class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Login());

            /* try
             {
                 SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

                 builder.DataSource = "<w2307.database.windows.net>";
                 builder.UserID = "<demo>";
                 builder.Password = "<0MGq&GHvL@X&>";
                 builder.InitialCatalog = "<db_pim_hml>";

                 using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                 {
                     Console.WriteLine("\nQuery data example:");
                     Console.WriteLine("=========================================\n");

                     connection.Open();

                 }
             }
             catch (SqlException e)
             {
                 Console.WriteLine(e.ToString());
             }
             Console.WriteLine("\nDone. Press enter.");
             Console.ReadLine();*/
        }
    }
}
