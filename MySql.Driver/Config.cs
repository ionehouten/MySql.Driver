using System;
using System.IO;
using System.Reflection;

namespace MySql.Driver
{
    public static class Config
    {
        public static int day = (int)DateTime.Now.DayOfWeek;
        
        public static string pathApp = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        public static string dirMySql = Path.Combine(pathApp, "mysql");
        public static string dirSdk = Path.Combine(pathApp, "sdk");
        public static string dirSys = Path.GetPathRoot(Environment.SystemDirectory); // C:\
        public static string dirWin = Environment.SystemDirectory; // C:\windows\system32
        public static string dirUsr = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile));
        public static string dirMsc = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic));
        public static string dirPly = Path.Combine(dirMsc, "playlists");
        public static string dirSet = Path.Combine(pathApp, "settings");
        public static string dirPhoto
        {
            get
            {
                if (!Directory.Exists(Path.Combine(pathApp, "photo")))
                    Directory.CreateDirectory(Path.Combine(pathApp, "photo"));
                return Path.Combine(pathApp, "photo");
            }
        }
        public static string dirPrg
        {
            get
            {
                if (Environment.Is64BitOperatingSystem)
                {
                    return Path.Combine(dirSys, "Program Files (x86)");
                }
                else
                {
                    return Path.Combine(dirSys, "Program Files");
                }
            }

        }

      
       

    }
}

