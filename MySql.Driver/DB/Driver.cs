using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using MySql.Data.MySqlClient;
using System.Collections;

namespace MySql.Driver.DB
{

    /// <summary>
    /// 
    /// </summary>
    public class Driver : Config
    {
        private MySqlConnection Conn = null;
        private MySqlDataAdapter Adapter = null;
        private MySqlCommand Command = null;
        private MySqlBackup Backup = null;
        private MySqlScript Script = null;
        private MySqlCommandBuilder Builder = null;
        private MySqlConnectionStringBuilder MySql = null;
        private MySqlTransaction Transaction = null;
        private DataTable DataTable = null;
        private DataSet DataSet = null;
        private string sql = string.Empty;

        private string profile { get; set; }
        private string server { get; set; }
        private uint port { get; set; }
        private string dbName { get; set; }
        private string dbUser { get; set; }
        private string dbPass { get; set; }
        


        public Driver(string profileName = "DEFAULT") 
        {

            var config = Config.Profile.Where(x => x.PROFILE == profileName).FirstOrDefault();

            this.profile = config.PROFILE;
            this.server = config.SERVER;
            this.port = config.PORT;
            this.dbName = config.DBNAME;
            this.dbUser = config.DBUSER;
            this.dbPass = config.DBPASS;
            this.Initialize();
        }

        private void Initialize()
        {
            //var ConnectionString = String.Format("server={0};user id={1};password={2};database={3}",
            //    this.server, this.dbUser, this.dbPass, this.dbName);
            
            try
            {
                this.MySql = new MySqlConnectionStringBuilder();
                this.MySql.Server = this.server;
                this.MySql.Port = this.port;
                this.MySql.UserID = this.dbUser;
                this.MySql.Database = this.dbName;
                this.MySql.Password = this.dbPass;
                this.MySql.ConnectionTimeout = 60000;
                this.MySql.DefaultCommandTimeout = 60000;
                this.MySql.UseDefaultCommandTimeoutForEF = true;
                this.MySql.AllowZeroDateTime = true;
                
                //this.MySql.ConvertZeroDateTime = true;
                Conn = new MySqlConnection(this.MySql.ConnectionString);
            }
            catch (MySqlException e)
            {
                Exceptions.MySql(e);
                throw;
            }
        }
        
        private bool OpenConnection()
        {
            try
            {
                Conn.Open();
                return true;
            }
            catch (MySqlException e)
            {
                Exceptions.MySql(e);
                throw;
            }
        }

        public OutputParameters TestConnection()
        {
            OutputParameters output = new OutputParameters();
            try
            {
                if (!Conn.Ping())
                {
                    Conn.Open();
                }

                output.RESULT = "Y";
                output.MESSAGE = "Connection Success";
            }
            catch (MySqlException e)
            {
                output.RESULT = e.Number.ToString();
                output.MESSAGE = e.Message;
                Exceptions.MySql(e);
            }
            catch (Exception ex)
            {
                output.RESULT = ex.InnerException.ToString();
                output.MESSAGE = ex.Message + ex.StackTrace;
                Exceptions.Default(ex);

            }
            return output;
        }

        private bool CloseConnection()
        {
            try
            {
                Conn.Close();
                return true;
            }
            catch (MySqlException e)
            {
                Exceptions.MySql(e);
                return false;
            }
        }

        public DataTable Find(string sql)
        {
            try
            {

                DataTable = new DataTable();
                if (OpenConnection() == true)
                {
                    Adapter = new MySqlDataAdapter(sql, Conn);
                    Builder = new MySqlCommandBuilder(Adapter);
                    DataSet = new DataSet();
                    DataSet.Reset();
                    Adapter.Fill(DataSet);
                    DataTable = DataSet.Tables[0];

                    CloseConnection();
                }
                else
                {
                    Exceptions.Default(new Exception("Close Connection Failed!"));
                }
                return this.DataTable;
            }
            catch (MySqlException e)
            {
                Exceptions.MySql(e);
                throw;
            }
           
        }   

        public int Count(string sql)
        {
            var count = 0;
            try
            {
                if (OpenConnection() == true)
                {
                    Command = new MySqlCommand();
                    Command.CommandText = sql;
                    Command.Connection = Conn;

                    count = Convert.ToInt32(Command.ExecuteScalar());

                    CloseConnection();
                }
                return count;
            }
            catch (MySqlException e)
            {
                Exceptions.MySql(e);
                throw;
            }
           
        }
        
        public OutputParameters Cmd(string sql, string mode)
        {
            OutputParameters Output = new OutputParameters();
            try
            {
                var result = string.Empty;
                var message = string.Empty;


                switch (mode)
                {
                    case "C":
                        this.sql = sql + " SELECT last_insert_id();";
                        break;
                    default:
                        this.sql = sql;
                        break;
                }

                if (OpenConnection() == true)
                {
                    Command = new MySqlCommand();
                    Command.CommandText = this.sql;
                    Command.Connection = Conn;

                    switch (mode)
                    {
                        case "C":
                            result = "Y";
                            message = Command.ExecuteScalar().ToString();
                            break;
                        case "U":
                        case "D":
                            Command.ExecuteNonQuery();
                            result = "Y";
                            message = (mode == "U") ? Messages.UpdateSucceed : Messages.DeleteSucceed;
                            break;
                        case "Truncate":
                            Command.ExecuteNonQuery();
                            result = "Y";
                            message = "";
                            break;
                        default :
                            Command.ExecuteNonQuery();
                            result = "Y";
                            message = Messages.UpdateSucceed;
                            break;
                    }
                    CloseConnection();
                }
                Output.RESULT = result;
                Output.MESSAGE = message;
            }
            catch (MySqlException e)
            {
                Output.RESULT = "N";
                Output.MESSAGE = e.Message;
                Exceptions.MySql(e);
            }
            return Output;
        }

        public OutputParameters Cmd(MySqlCommand Command)
        {
            OutputParameters Output = new OutputParameters();

            var message = string.Empty;
            try
            {
                if (OpenConnection() == true)
                {
                    using (this.Conn)
                    {

                        Transaction = Conn.BeginTransaction();
                        this.Command = Command;
                        this.Command.Connection = Conn;
                        this.Command.Transaction = Transaction;

                        try
                        {

                            this.Command.ExecuteNonQuery();
                            
                            Transaction.Commit();
                            Output.RESULT = "Y";
                            Output.MESSAGE = "";
                        }
                        catch (MySqlException e)
                        {
                            Transaction.Rollback();
                            Output.RESULT = "N";
                            Output.MESSAGE = e.Message;
                        }
                    }
                }

            }
            catch (MySqlException e)
            {
                Output.RESULT = "N";
                Output.MESSAGE = e.Message;
                Exceptions.MySql(e);
            }
            return Output;
        }

        public OutputParameters Cmd(List<string> sql)
        {
            OutputParameters Output = new OutputParameters();
            Output.MESSAGE = "";
            var message = string.Empty;

            try
            {
                if (OpenConnection() == true)
                {
                    using (this.Conn)
                    {
                        Command = new MySqlCommand();
                        Command = Conn.CreateCommand();
                        Command.Connection = Conn;


                        for (int i = 0; i < sql.Count(); i++)
                        {
                            try
                            {

                                Command.CommandText = sql[i];
                                Command.ExecuteNonQuery();

                                Output.RESULT = "Y";
                            }
                            catch (MySqlException e)
                            {
                                Output.RESULT = "N";
                                Output.MESSAGE += i + " : (" + sql[i] + ") " + e.Message + "\n";
                            }
                        }

                        
                    }
                }

            }
            catch (MySqlException e)
            {
                Output.RESULT = "N";
                Output.MESSAGE = e.Message;
                Exceptions.MySql(e);
            }
            return Output;
        }

        public OutputParameters TCmd(List<string> sql)
        {
            OutputParameters Output = new OutputParameters();

            var message = string.Empty;
            try
            {
                if (OpenConnection() == true)
                {
                    using (this.Conn)
                    {

                        Transaction = Conn.BeginTransaction();
                        Command = new MySqlCommand();
                        Command = Conn.CreateCommand();
                        Command.Connection = Conn;
                        Command.Transaction = Transaction;

                        try
                        {

                            for (int i = 0; i < sql.Count(); i++)
                            {
                                Command.CommandText = sql[i];
                                Command.ExecuteNonQuery();
                            }

                            Transaction.Commit();
                            Output.RESULT = "Y";
                            Output.MESSAGE = "";
                        }
                        catch (MySqlException e)
                        {
                            Transaction.Rollback();
                            Output.RESULT = "N";
                            Output.MESSAGE = e.Message;
                        }
                    }
                }

            }
            catch (MySqlException e)
            {
                Output.RESULT = "N";
                Output.MESSAGE = e.Message;
                Exceptions.MySql(e);
            }
            return Output;
        }

        public OutputParameters Cmd(MySqlScript Script)
        {
            OutputParameters Output = new OutputParameters();

            var message = string.Empty;
            try
            {
                if (OpenConnection() == true)
                {
                    using (this.Conn)
                    {
                        this.Script = Script;
                        this.Script.Connection = Conn;

                        try
                        {

                            this.Script.Execute();
                            Output.RESULT = "Y";
                            Output.MESSAGE = "";
                        }
                        catch (MySqlException e)
                        {
                            Output.RESULT = "N";
                            Output.MESSAGE = e.Message;
                        }
                    }
                }

            }
            catch (MySqlException e)
            {
                Output.RESULT = "N";
                Output.MESSAGE = e.Message;
                Exceptions.MySql(e);
            }
            return Output;
        }

        public OutputParameters Export(string filepath, bool createdatabase, bool tablestructure, bool rows, bool views, bool triggers, bool functions, bool procedures)
        {
            OutputParameters Output = new OutputParameters();
            Output.MESSAGE = "";
            var message = string.Empty;

            try
            {
                if (OpenConnection() == true)
                {
                    using (this.Conn)
                    {
                        Command = new MySqlCommand();
                        Command = Conn.CreateCommand();
                        Command.Connection = Conn;

                        using (Backup = new MySqlBackup())
                        {
                            Backup.Command = Command;
                            Backup.ExportInfo.AddCreateDatabase = createdatabase;
                            Backup.ExportInfo.ExportTableStructure = tablestructure;
                            Backup.ExportInfo.ExportRows = rows;
                            Backup.ExportInfo.ExportViews = views;
                            Backup.ExportInfo.ExportTriggers = triggers;
                            Backup.ExportInfo.ExportFunctions = functions;
                            Backup.ExportInfo.ExportProcedures = procedures;
                            Backup.ExportToFile(filepath);

                        }

                        Output.RESULT = "Y";


                    }
                }

            }
            catch (MySqlException e)
            {
                Output.RESULT = "N";
                Output.MESSAGE = e.Message;
                Exceptions.MySql(e);
            }
            return Output;
        }

        public OutputParameters Import(string filepath, string targetdb, string charset = "utf8")
        {
            OutputParameters Output = new OutputParameters();
            Output.MESSAGE = "";
            var message = string.Empty;

            try
            {
                this.MySql = new MySqlConnectionStringBuilder();
                this.MySql.Server = this.server;
                this.MySql.Port = this.port;
                this.MySql.UserID = this.dbUser;
                this.MySql.Database = "";
                this.MySql.Password = this.dbPass;
                this.MySql.ConnectionTimeout = 10;
                this.MySql.AllowZeroDateTime = true;

                Conn = new MySqlConnection(this.MySql.ConnectionString);
                if (OpenConnection() == true)
                {
                    using (this.Conn)
                    {
                        Command = new MySqlCommand();
                        Command = Conn.CreateCommand();
                        Command.Connection = Conn;

                        using (Backup = new MySqlBackup())
                        {
                            Backup.Command = Command;
                            Backup.ImportInfo.TargetDatabase = targetdb;
                            Backup.ImportInfo.DatabaseDefaultCharSet = charset;
                            Backup.ImportFromFile(filepath);
                        }

                        Output.RESULT = "Y";


                    }
                }

            }
            catch (MySqlException e)
            {
                Output.RESULT = "N";
                Output.MESSAGE = e.Message;
                Exceptions.MySql(e);
            }
            return Output;
        }

    }
}
