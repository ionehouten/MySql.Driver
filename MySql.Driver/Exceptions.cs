using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.IO;
using System.Runtime.CompilerServices;
using System.Diagnostics;
namespace MySql.Driver
{
    public static class Exceptions
    {
        static Exceptions()
        {
            if (!Directory.Exists(Path.Combine(Config.pathApp,"logs")))
                Directory.CreateDirectory(Path.Combine(Config.pathApp,"logs"));
        }
        
        public static void Default(Exception e, string voidname = "")
        {
            try
            {
                List<string> dataLog = new List<string>();
                string pathLog = Path.Combine(Config.pathApp, "logs", "Default.log");
                if (File.Exists(pathLog))
                {
                    string[] readText = File.ReadAllLines(pathLog);
                    foreach (string s in readText)
                    {
                        dataLog.Add(s);
                    }
                }
                dataLog.Add("=============================================================================");
                dataLog.Add(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
                dataLog.Add("Error Void         : " + voidname);
                dataLog.Add("Error Message      : " + e.Message);
                dataLog.Add("Error Data         : " + e.Data);
                dataLog.Add("Stack Trace        : " + e.StackTrace);
                dataLog.Add("=============================================================================");

                int jmlLog = dataLog.Count;
                int removeLog = 0;
                if (jmlLog > 255)
                {
                    removeLog = jmlLog - 255;
                    dataLog.RemoveRange(0, removeLog);
                }
                File.WriteAllLines(pathLog, dataLog);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void Db(Exception e, string table = "")
        {
            try
            {
                List<string> dataLog = new List<string>();
                string pathLog = Path.Combine(Config.pathApp, "logs", "Db.log");
                if (File.Exists(pathLog))
                {
                    string[] readText = File.ReadAllLines(pathLog);
                    foreach (string s in readText)
                    {
                        dataLog.Add(s);
                    }
                }
                dataLog.Add("=============================================================================");
                dataLog.Add(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
                dataLog.Add("Error Table    : " + table);
                dataLog.Add("Error Message  : " + e.Message);
                dataLog.Add("Error Data     : " + e.Data);
                dataLog.Add("Stack Trace    : " + e.StackTrace);
                dataLog.Add("=============================================================================");

                int jmlLog = dataLog.Count;
                int removeLog = 0;
                if (jmlLog > 255)
                {
                    removeLog = jmlLog - 255;
                    dataLog.RemoveRange(0, removeLog);
                }
                File.WriteAllLines(pathLog, dataLog);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void MySql(MySqlException e)
        {
            try
            {
                List<string> dataLog = new List<string>();
                string pathLog = Path.Combine(Config.pathApp, "logs", "MySql.log");
                if (File.Exists(pathLog))
                {
                    string[] readText = File.ReadAllLines(pathLog);
                    foreach (string s in readText)
                    {
                        dataLog.Add(s);
                    }
                }
                dataLog.Add("=============================================================================");
                dataLog.Add(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
                dataLog.Add("Error Code     : " + e.ErrorCode);
                dataLog.Add("Error Message  : " + e.Message);
                dataLog.Add("Stack Trace    : " + e.StackTrace);
                dataLog.Add("=============================================================================");

                int jmlLog = dataLog.Count;
                int removeLog = 0;
                if (jmlLog > 255)
                {
                    removeLog = jmlLog - 255;
                    dataLog.RemoveRange(0, removeLog);
                }
                File.WriteAllLines(pathLog, dataLog);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
       
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static string GetCurrentMethod()
        {
            StackTrace st = new StackTrace();
            StackFrame sf = st.GetFrame(1);

            return sf.GetMethod().Name;
        }
    }
}
