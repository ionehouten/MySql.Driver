using MySql.Driver.DB;
using System.Data;

namespace MySql.Driver
{
    public interface IModelType
    {
        MySql.Driver.DB.Driver Driver { get; set; }
        DataTable DataTable { get; set; }
        DataTable DataDetail { get; set; }
        int TotalData { get; set; }
        string Table { get; set; }
        string View { get; set; }
        Sql Sql { get; set; }
    }
}
