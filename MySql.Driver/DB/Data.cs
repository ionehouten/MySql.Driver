using System;
using System.Collections.Generic;
using System.Globalization;

namespace MySql.Driver.DB
{
    internal class Data
    {
        public List<InputData> InputData;
        public Data()
        {
            this.InputData = new List<InputData>();
        }
        public void Add(object key, object val, bool nullable = true, string typeset = null)
        {
            if (nullable)
            {
                if (val == null)
                    val = DBNull.Value;
                val = this.AdjustValue(val, typeset);
                this.InputData.Add(new InputData { KEY = key, VAL = val });
            }
            else
            {
                if (val != null)
                {
                    val = this.AdjustValue(val, typeset);
                    this.InputData.Add(new InputData{KEY = key,VAL = val});
                }
            }
            
        }
        public List<InputData> Build()
        {
            return this.InputData;
        }
        private object AdjustValue(object input, string typeset = null)
        {
            string type;
            object output = new object();
            if (String.IsNullOrEmpty(typeset))
                type = input.GetType().ToString();
            else
                type = typeset;

            switch (type)
            {
                case "System.String":
                    output = "'" + Converter.toLiteral(input.ToString()) + "'";
                    break;
                case "System.Byte":
                case "System.Byte[]":
                case "System.DateTime":
                case "System.TimeSpan":
                    output = "'" + input + "'";
                    break;
                case "System.DBNull":
                    output = "NULL";
                    break;
                case "System.Function":
                case "System.Decimal":
                case "System.Int16":
                case "System.Int32":
                case "System.Int64":
                    output = "" + input + "";
                    break;
                case "System.Double":
                    output = "'" + Convert.ToString(input, CultureInfo.InvariantCulture) + "'";
                    break;
                default:
                    output = "'" + input + "'";
                    break;
            }
            
           
            return output;
        }
    }
    
    public class InputData
    {
        public object KEY { get; set; }
        public object VAL { get; set; }
    }
}
