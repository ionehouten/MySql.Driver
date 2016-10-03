using System.Collections.Generic;

namespace MySql.Driver.DB
{
    public class Config
    {
        public static List<Profile> Profile = null;

        public Config()
        {
            Profile = new List<Profile>();
            Profile.Add(
                new Profile { 
                    PROFILE = "DEFAULT",
                    SERVER = "127.0.0.1",
                    PORT = 3306,
                    DBUSER = "root",
                    DBPASS = "",
                    DBNAME = "db_ap4a"
                }
                
            );
            Profile.Add(
                new Profile
                {
                    PROFILE = "CREATE",
                    SERVER = "127.0.0.1",
                    PORT = 3309,
                    DBUSER = "root",
                    DBPASS = "",
                    DBNAME = ""
                }
            );

        }

        public static void setProfile(List<Profile> Profile)
        {
            Config.Profile = Profile;
        }
    }
}
