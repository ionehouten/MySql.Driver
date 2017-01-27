using MySql.Driver.DB;
using System;
using System.Data;

namespace MySql.Driver
{
    public interface IModel 
    {
        String Profile { get; set; }
        MySql.Driver.DB.Driver Driver { get; set; }
        DataTable DataTable { get; set; }
        DataTable DataDetail { get; set; }
        int TotalData { get; set; }
        Sql Sql { get; set; }
    }
}
