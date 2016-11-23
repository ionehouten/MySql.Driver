using System;

namespace MySql.Driver
{
    public class Entity
    {
        public Entity()
        {
            OPERATION = Operation.Create;
            NO = 0;
        }
        public Operation OPERATION { get; set; }
        public Object DATA { get; set; }
        public Int32 NO { get; set; }
    }
  
    public enum Operation : int
    {
        ReadOnly = -1,
        Read = 0,
        Create = 1,
        Update = 2,
        Delete = 3,
        Detail = 4,
        Disable = 5,
        Cancel = 6,
        Revision = 7,
    }
}
