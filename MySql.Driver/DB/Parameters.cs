using System;
using MySql.Data.MySqlClient;

namespace MySql.Driver.DB
{
    public class Parameters
    {
        public String FIELD { get; set; }
        public Object VALUE { get; set; }
        public MySqlDbType TYPE { get; set; }
        public Nullable<Int32> SIZE { get; set; }

    }
}
