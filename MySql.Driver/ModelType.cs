using MySql.Driver.DB;
using System;
using System.Data;

namespace MySql.Driver
{

    public abstract class ModelType<T> : IModelType where T : new()
    {
        public MySql.Driver.DB.Driver Driver { get; set; }
        public DataTable DataTable { get; set; }
        public DataTable DataDetail { get; set; }
        public int TotalData { get; set; }
        public Sql Sql { get; set; }
        public string Table { get; set; }
        public string View { get; set; }
        
        
        public ModelType()
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
        }
        protected void setFields(string[] value)
        {
            this.Sql.Fields = value;
        }
        public virtual OutputParameters GetData(InputParameters input)
        {
            OutputParameters output = new OutputParameters();
            Sql.Condition = input.CONDITION;
            Sql.Order = input.ORDER;
            Sql.Limit = input.LIMIT;
            Sql.Offset = input.OFFSET;
            var select = Sql.select();
            Driver = new MySql.Driver.DB.Driver();
            output = Driver.Find<T>(select);
            return output;
        }
        public abstract OutputParameters Execute(Object input);
        public abstract Int32 CountData(InputParameters input);


    }

}


