using MySql.Driver.DB;
using System;
using System.Data;

namespace MySql.Driver
{

    public abstract class Model : IModel
    {
        public MySql.Driver.DB.Driver Driver { get; set; }
        public DataTable DataTable { get; set; }
        public DataTable DataDetail { get; set; }
        public int TotalData { get; set; }
        public Sql Sql { get; set; }
        public string Table { get; set; }
        public string View { get; set; }

        public Model()
        {
            Sql = new Sql();
            this.setFields(new string[] { "*" });
        }
        protected void setTable(string value)
        {
            this.Table = value;
            this.Sql.Table = value;
        }
        protected void setView(string value)
        {
            this.View = View;
            this.Sql.Table = value;
        }
        protected void setFields(string[] value)
        {
            this.Sql.Fields = value;
        }
        public abstract OutputParameters GetData(InputParameters input);
        public abstract OutputParameters Execute(Object input);
        public abstract Int32 CountData(InputParameters input) ;


    }

}


