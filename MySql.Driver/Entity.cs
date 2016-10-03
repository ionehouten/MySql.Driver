using System;

namespace MySql.Driver
{
    public class Entity
    {
        public Operation OPERATION { get; set; }
        public Object DATA { get; set; }
        public Int32 NO { get; set; }
    }

    public enum Operation : int
    {
        Read = 0,
        Create = 1,
        Update = 2,
        Delete = 3
    }
}
