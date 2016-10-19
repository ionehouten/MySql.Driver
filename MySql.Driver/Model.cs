using MySql.Driver.DB;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public Type Entity;
        
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
        }
        protected void setFields(string[] value)
        {
            this.Sql.Fields = value;
        }
        protected void setEntity(Type type)
        {
            this.Entity = type;
        }
        //public abstract OutputParameters GetData(InputParameters input);
        //public abstract OutputParameters Execute(Object input);
        //public abstract Int32 CountData(InputParameters input);
        public virtual OutputParameters GetData(InputParameters input)
        {
            OutputParameters output = new OutputParameters();
            Sql.Condition = input.CONDITION;
            Sql.Order = input.ORDER;
            Sql.Limit = input.LIMIT;
            Sql.Offset = input.OFFSET;
            var select = Sql.select();
            Driver = new MySql.Driver.DB.Driver();
            output = Driver.Find(select,Entity);

            return output;
        }
        public virtual OutputParameters GetData(String query)
        {
            OutputParameters output = new OutputParameters();
            Driver = new MySql.Driver.DB.Driver();
            output = Driver.Find(query, Entity);

            return output;
        }

        public virtual OutputParameters GetData(InputParameters input, BindingSource binding, UserControl ctrl)
        {
            OutputParameters output = new OutputParameters();
            Sql.Condition = input.CONDITION;
            Sql.Order = input.ORDER;
            Sql.Limit = input.LIMIT;
            Sql.Offset = input.OFFSET;
            var select = Sql.select();
            Driver = new MySql.Driver.DB.Driver();
            DataTable = Driver.Find(select);
            GetDataAsync(binding, ctrl);
            return output;
        }

        public virtual async void GetDataAsync(BindingSource binding, UserControl ctrl)
        {
            try
            {
                await Task.Run(() => DataTable.ToList(this.Entity, binding, ctrl));
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public virtual DataTable GetDataTable(InputParameters input)
        {
            DataTable = new DataTable();
            Sql.Condition = input.CONDITION;
            Sql.Order = input.ORDER;
            Sql.Limit = input.LIMIT;
            Sql.Offset = input.OFFSET;
            var select = Sql.select();
            Driver = new MySql.Driver.DB.Driver();
            DataTable = Driver.Find(select);

            return DataTable;
        }

        public virtual OutputParameters Execute(object input)
        {
            OutputParameters output = new OutputParameters();
            try
            {
                Sql.Table = this.Table;
                Entity data = input as Entity;
                List<Parameters> param = data.ToParamMySqlNotNull(Entity);
                if (data != null)
                {
                    MySql.Data.MySqlClient.MySqlCommand Command = new MySql.Data.MySqlClient.MySqlCommand();
                    switch (data.OPERATION)
                    {
                        case Operation.Create:
                            Command = Sql.insertCmd(param);
                            break;
                        case Operation.Update:
                            Sql.Condition = data.GetCondition();
                            Command = Sql.updateCmd(param);
                            break;
                        case Operation.Delete:
                            Sql.Condition = data.GetCondition();
                            Command = Sql.deleteCmd();
                            break;
                    }
                    Driver = new MySql.Driver.DB.Driver();
                    output = Driver.Cmd(Command, Operation.Create);
                    if (output.ID != null)
                    {
                        (input as Entity).SetPrimaryKey(output.ID);
                    }
                    if(data.OPERATION == Operation.Create && output.RESULT == "Y")
                    {
                        data.OPERATION = Operation.Update;
                        data.NO = -1;
                    }
                    output.DATA = data;

                }
                else
                {
                    output.RESULT = "0";
                    output.MESSAGE = "No Input Parameters";
                }
            }
            catch (Exception e)
            {
                Exceptions.Db(e, this.Table);
                output.MESSAGE = e.Message;
            }
            return output;
        }

        public virtual Int32 CountData(InputParameters input)
        {
            TotalData = 0;
            try
            {
                Sql.Condition = input.CONDITION;
                var query = Sql.count();

                Driver = new MySql.Driver.DB.Driver();
                TotalData = Driver.Count(query);
            }
            catch (Exception e)
            {
                Exceptions.Db(e, this.Table);
            }
            return TotalData;
        }
        public virtual Int32 CountData(String query)
        {
            TotalData = 0;
            try
            {
                Driver = new MySql.Driver.DB.Driver();
                TotalData = Driver.Count(query);
            }
            catch (Exception e)
            {
                Exceptions.Db(e, this.Table);
            }
            return TotalData;
        }

        public void GetAttribute(Type t)
        {
            // Get instance of the attribute.
            TableAttribute MyAttribute = (TableAttribute)Attribute.GetCustomAttribute(t, typeof(TableAttribute));

            if (MyAttribute == null)
            {
                Console.WriteLine("The attribute was not found.");
            }
            else
            {
                // Get the Name value.
                Console.WriteLine("The Name Attribute is: {0}.", MyAttribute.Name);
                
            }
        }
        
    }

}


