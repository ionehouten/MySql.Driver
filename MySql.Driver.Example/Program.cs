using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //DATABASE CONNECTION SETTINGS
            MySql.Driver.DB.Config.Profile = new System.Collections.Generic.List<MySql.Driver.DB.Profile>();

            //DEFAULT DATABASE
            MySql.Driver.DB.Profile Default = new MySql.Driver.DB.Profile()
            {
                PROFILE = "DEFAULT",/*Do not rename*/
                SERVER = "127.0.0.1",
                DBNAME = "db_employee1",
                DBUSER = "root",
                DBPASS = "",
                PORT = 3306,
            };
            //MULTIPLE DATABASE
            MySql.Driver.DB.Profile Create = new MySql.Driver.DB.Profile()
            {
                PROFILE = "DB1", /*Can be changed*/
                SERVER = "127.0.0.1",
                DBNAME = "db_employee2",
                DBUSER = "root",
                DBPASS = "",
                PORT = 3306,
            };
           
            MySql.Driver.DB.Config.Profile.Add(Default);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}
