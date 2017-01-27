using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;

namespace MySql.Driver.DB
{
    public class Sql
    {
        public Sql() { }

        private string SqlBuilder;
        public string Schema { get; set; }
        public string Table { get; set; }
        public string View { get; set; }
        public string[] Fields { get; set; }
        public string Index { get; set; }
        public string Condition { get; set; }
        public string Group { get; set; }
        public string Having { get; set; }
        public string Order { get; set; }
        public int Limit { get; set; }
        public int Offset { get; set; }
        public string Query { get; set; }

        public string getTable()
        {
            return  (!String.IsNullOrEmpty(Schema)) ? String.Format("`{0}`.`{1}`", Schema, (!String.IsNullOrEmpty(View)) ? View : Table) : String.Format("`{0}`", (!String.IsNullOrEmpty(View)) ? View : Table);
        }
        public string select()
        {
            var query = (Query != null) ? Query.Trim() : null;
            var table = getTable();
            var fields = string.Join(",", Fields);
            var index = Index;
            var condition = (!String.IsNullOrEmpty(Condition)) ? Condition.Trim() : null;
            var group = (!String.IsNullOrEmpty(Group)) ? Group.Trim() : null;
            var having = (!String.IsNullOrEmpty(Having)) ? Having.Trim() : null;
            var order = (!String.IsNullOrEmpty(Order)) ? Order.Trim() : null;
            var limit = (Limit != 0) ? Limit.ToString().Trim() : null;
            var offset = (Offset != 0) ? Offset.ToString().Trim() : null;



            if (Query == null)
            {
                SqlBuilder = "SELECT " + fields + " FROM " + table + "";
            }
            else
            {
                SqlBuilder = Regex.Replace(query, @"\s+", " ");
            }
            if (condition != null && condition != string.Empty)
                SqlBuilder += " WHERE " + condition + " ";
           
            if (group != null)
                SqlBuilder += " GROUP BY " + group + " ";

            if (having != null)
                SqlBuilder += " HAVING " + having + " ";

            if (order != null)
                SqlBuilder += " ORDER BY " + order + " ";

            if (limit != null)
                SqlBuilder += "LIMIT " + limit + " ";

            if (offset != null)
                SqlBuilder += "OFFSET " + offset + " ";

            SqlBuilder += " ;";

            return SqlBuilder;
        }
        public string count()
        {
            var table = getTable();
            var condition = (Condition != null) ? Condition.Trim() : null;
            SqlBuilder = "SELECT COUNT(*) FROM " + table + " ";

            if (condition != null && condition != string.Empty)
            {
                SqlBuilder += "WHERE " + condition + " ";
            }
            return SqlBuilder;
        }
        public string insert(Hashtable data)
        {
            ICollection key = data.Keys;
            var field = string.Empty;
            var value = string.Empty;

            foreach (string k in key)
            {
                field += "`" + k + "`,";
                value += "" + data[k] + ",";
            }
            field = field.Substring(0, field.Length - 1);
            value = value.Substring(0, value.Length - 1);
            SqlBuilder = @"INSERT INTO `" + Table + "` (" + field + ") VALUES (" + value + ") ;";
            return SqlBuilder;
        }
        public string insert(List<Parameters> data)
        {

            var field = string.Empty;
            var value = string.Empty;

            for (int i = 0; i < data.Count; i++)
            {
                field += "`" + data[i].FIELD + "`,";
                value += "'" + data[i].VALUE + "',";
            }
            field = field.Substring(0, field.Length - 1);
            value = value.Substring(0, value.Length - 1);
            SqlBuilder = @"INSERT INTO `" + Table + "` (" + field + ") VALUES (" + value + ") ;";
            return SqlBuilder;
        }
        public string update(Hashtable data)
        {
            var table = (!String.IsNullOrEmpty(Schema)) ? String.Format("`{0}`.`{1}`", Schema, (!String.IsNullOrEmpty(View)) ? View : Table) : String.Format("`{0}`", (!String.IsNullOrEmpty(View)) ? View : Table);

            ICollection key = data.Keys;
            var field = string.Empty;
            var value = string.Empty;
            var update = string.Empty;
            foreach (string k in key)
            {
                field = "`" + k + "`";
                value = data[k].ToString();

                update += field + "=" + value + ",";
            }
            update = update.Substring(0, update.Length - 1);
            SqlBuilder = @"UPDATE `" + Table + "` SET  " + update + "  WHERE " + this.Condition + ";";
            return SqlBuilder;
        }
        public string update(List<Parameters> data)
        {
            string field = string.Empty;
            string value = string.Empty;
            var update = string.Empty;

            for (int i = 0; i < data.Count; i++)
            {
                field = "`" + data[i].FIELD + "`";
                value = data[i].VALUE.ToString();

                update += field + "=" + value + ",";
            }
            update = update.Substring(0, update.Length - 1);
            SqlBuilder = "UPDATE `" + Table + "` SET  " + update + "  WHERE " + this.Condition + ";";
            return SqlBuilder;
        }
        public string delete(String condition)
        {
            SqlBuilder = "DELETE FROM `" + Table + "` WHERE " + condition + ";";
            return SqlBuilder;
        }
        public string delete()
        {
            SqlBuilder = "DELETE FROM `" + Table + "` WHERE " + this.Condition + ";";
            return SqlBuilder;
        }
        public string truncate()
        {
            SqlBuilder = "TRUNCATE TABLE `" + Table + "`;";
            return SqlBuilder;
        }
        public MySqlCommand insertCmd(List<Parameters> data = null)
        {
            MySqlCommand Command = new MySqlCommand();
            var field = string.Empty;
            var param = string.Empty;
            object value = new object();
            
            
            for (int i = 0; i < data.Count(); i++)
            {

                field += "`" + data[i].FIELD + "`,";
                param += "@" + data[i].FIELD + ",";
                value = data[i].VALUE;

                if (!data[i].SIZE.Equals(null))
                {
                    if (value.Equals(null))
                        Command.Parameters.Add("@" + data[i].FIELD, data[i].TYPE, Convert.ToInt32(data[i].SIZE)).Value = DBNull.Value;
                    else
                        Command.Parameters.Add("@" + data[i].FIELD, data[i].TYPE, Convert.ToInt32(data[i].SIZE)).Value = data[i].VALUE;
                }
                else
                {
                    if (value == null)
                        Command.Parameters.AddWithValue("@" + data[i].FIELD, DBNull.Value);
                    else
                        Command.Parameters.AddWithValue("@" + data[i].FIELD, data[i].VALUE);
                }
                
            }
            field = field.Substring(0, field.Length - 1);
            param = param.Substring(0, param.Length - 1);

            SqlBuilder = "INSERT INTO `" + Table + "` (" + field + ") VALUES (" + param + ") ;";
            Command.CommandText = SqlBuilder;


            return Command;

        }
        public MySqlCommand updateCmd(List<Parameters> data = null)
        {
            MySqlCommand Command = new MySqlCommand();
            var update = string.Empty;
            object value = new object();


            for (int i = 0; i < data.Count(); i++)
            {
                update += "`" + data[i].FIELD + "`=@" + data[i].FIELD + ",";
                value = data[i].VALUE;

                if (!data[i].SIZE.Equals(null))
                {
                    if (value.Equals(null))
                        Command.Parameters.Add("@" + data[i].FIELD, data[i].TYPE, Convert.ToInt32(data[i].SIZE)).Value = DBNull.Value;
                    else
                        Command.Parameters.Add("@" + data[i].FIELD, data[i].TYPE, Convert.ToInt32(data[i].SIZE)).Value = data[i].VALUE;
                }
                else
                {
                    if (value == null)
                        Command.Parameters.AddWithValue("@" + data[i].FIELD, DBNull.Value);
                    else
                        Command.Parameters.AddWithValue("@" + data[i].FIELD, data[i].VALUE);
                }
                
            }
      

            update = update.Substring(0, update.Length - 1);
            SqlBuilder = "UPDATE `" + Table + "` SET  " + update + "  WHERE " + this.Condition + ";";
            Command.CommandText = SqlBuilder;



            return Command;
        }
        public MySqlCommand deleteCmd()
        {
            MySqlCommand Command = new MySqlCommand();
            SqlBuilder = "DELETE FROM `" + Table + "` WHERE " + this.Condition + " ;";
            Command.CommandText = SqlBuilder;

            return Command;
        }


    }
}
