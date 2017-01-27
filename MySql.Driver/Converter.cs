using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Globalization;
using System.Reflection;
using System.ComponentModel;
using System.Web;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;
using MySql.Driver;
using MySql.Driver.DB;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using System.Collections;
using System.Threading;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations.Schema;

namespace MySql.Driver
{
    public static class Converter
    {
        public static Decimal toDecimal(object input)
        {
            Decimal output;
            try
            {
                if ((input != null) && (!input.Equals(DBNull.Value)))
                {
                    return Convert.ToDecimal(input);
                }
                else
                {
                    output = 0;
                }
            }
            catch (Exception e)
            {
                output = 0;
                Console.WriteLine(e.Message);
            }
            return output;

        }
        public static Double toDouble(object input)
        {
            Double output = 0;
            try
            {
                if ((input != null) && (!input.Equals(DBNull.Value)))
                {
                    return Convert.ToDouble(input, CultureInfo.InvariantCulture);
                }
            }
            catch
            {
            }
            return output;
        }
        public static Nullable<Decimal> toDecimalNull(object input)
        {
            Nullable<Decimal> output = null;
            try
            {
                if ((input != null) && (!input.Equals(DBNull.Value)))
                {
                    return Convert.ToDecimal(input);
                }
            }
            catch
            {
            }
            return output;
            
        }
        public static Nullable<Double> toDoubleNull(object input)
        {
            Nullable<Double> output = null;
            try
            {
                if ((input != null) && (!input.Equals(DBNull.Value)))
                {
                    return Convert.ToDouble(input);
                }
            }
            catch
            {
            }
            return output;

        }
        public static Int16 toInt16(object input)
        {
            Int16 output = 0;
            try
            {
                if ((input != null) && (!input.Equals(DBNull.Value)))
                {
                    return Convert.ToInt16(input);
                }
            }
            catch
            {
            }
            return output;
        }
        public static UInt16 toUInt16(object input)
        {
            UInt16 output = 0;
            try
            {
                if ((input != null) && (!input.Equals(DBNull.Value)))
                {
                    return Convert.ToUInt16(input);
                }
            }
            catch
            {
            }
            return output;
        }
        public static Int32 toInt32(object input)
        {
            Int32 output = 0;
            try
            {
                if ((input != null) && (!input.Equals(DBNull.Value)))
                {
                    return Convert.ToInt32(input);
                }
            }
            catch
            {
            }
            return output;
        }
        public static UInt32 toUInt32(object input)
        {
            UInt32 output = 0;
            try
            {
                if ((input != null) && (!input.Equals(DBNull.Value)))
                {
                    return Convert.ToUInt32(input);
                }
            }
            catch
            {
            }
            return output;
        }
        public static Int64 toInt64(object input)
        {
            Int64 output = 0;
            try
            {
                if ((input != null) && (!input.Equals(DBNull.Value)))
                {
                    return Convert.ToInt64(input);
                }
            }
            catch
            {
            }
            return output;
        }
        public static Int64 toUInt64(object input)
        {
            Int64 output = 0;
            try
            {
                if ((input != null) && (!input.Equals(DBNull.Value)))
                {
                    return Convert.ToInt64(input);
                }
            }
            catch
            {
            }
            return output;
        }
        public static Nullable<Int16> toInt16Null(object input)
        {
            Nullable<Int16> output = null;
            try
            {
                if ((input != null) && (!input.Equals(DBNull.Value)))
                {
                    return Convert.ToInt16(input);
                }
            }
            catch
            {
            }
            return output;
        }
        public static Nullable<UInt16> toUInt16Null(object input)
        {
            Nullable<UInt16> output = null;
            try
            {
                if ((input != null) && (!input.Equals(DBNull.Value)))
                {
                    return Convert.ToUInt16(input);
                }
            }
            catch
            {
            }
            return output;
        }
        public static Nullable<Int32> toInt32Null(object input)
        {
            Nullable<Int32> output = null;
            try
            {
                if ((input != null) && (!input.Equals(DBNull.Value)))
                {
                    return Convert.ToInt32(input);
                }
            }
            catch
            {
            }
            return output;
        }
        public static Nullable<UInt32> toUInt32Null(object input)
        {
            Nullable<UInt32> output = null;
            try
            {
                if ((input != null) && (!input.Equals(DBNull.Value)))
                {
                    return Convert.ToUInt32(input);
                }
            }
            catch
            {
            }
            return output;
        }
        public static Nullable<Int64> toInt64Null(object input)
        {
            Nullable<Int64> output = null;
            try
            {
                if ((input != null) && (!input.Equals(DBNull.Value)))
                {
                    return Convert.ToInt64(input);
                }
            }
            catch
            {
            }
            return output;
        }
        public static Nullable<UInt64> toUInt64Null(object input)
        {
            Nullable<UInt64> output = null;
            try
            {
                if ((input != null) && (!input.Equals(DBNull.Value)))
                {
                    return Convert.ToUInt64(input);
                }
            }
            catch
            {
            }
            return output;
        }
        public static String toString(object input)
        {
            string output = null;
            try
            {
                if ((input != null) && (!input.Equals(DBNull.Value)))
                {
                    return Convert.ToString(input).Trim();
                }
            }
            catch
            {
            }
            return output;
            
        }
        public static Boolean toBoolean(object input)
        {
            bool output = false;
            try
            {
                if ((input != null) && (!input.Equals(DBNull.Value)))
                {
                    return Convert.ToBoolean(input);
                }
            }
            catch
            {
            }
            return output;
        }
        public static Nullable<TimeSpan> toTimeSpanNull(object input)
        {
            Nullable<TimeSpan> output = null;
            try
            {
                if ((input != null) && (!input.Equals(DBNull.Value)))
                {
                    output = TimeSpan.Parse(input.ToString());
                }
            }
            catch
            {
            }
            return output;
        }
        public static Nullable<DateTime> toDateTime(object input)
        {
            DateTime? output = null;
            try
            {
                if ((input != null) && (!input.Equals(DBNull.Value)))
                {
                    string str_date = String.Format("{0:yyyy-MM-dd}", input);
                    if (str_date.Length > 8)
                    {
                        str_date = str_date.Substring(0, 8);
                    }
                    if (str_date != "0/0/0000")
                    {
                        output = Convert.ToDateTime(input);
                    }
                    else
                    {
                        output = null;
                    }
                    
                }
            }
            catch
            {
            }
            return output;
        }
        public static DateTime toDateTime(string input)
        {
            DateTime output  = new DateTime(1999, 09, 09);
            try
            {
                if ((input != null) && (!input.Equals(DBNull.Value)))
                {
                    output = Convert.ToDateTime(input);
                }

            }
            catch
            {
            }
            return output;
        }
        public static TimeSpan toTimeSpan(object input)
        {
            TimeSpan output = new TimeSpan(00, 00, 00);
            try
            {
                if ((input != null) && (!input.Equals(DBNull.Value)))
                {
                    TimeSpan.TryParse(input.ToString(), out output);
                }
            }
            catch
            {
            }
            return output;
        }
        public static String formatDate(object input, string format = "dd-MM-yyyy")
        {
            string output = "";
            DateTime? toDateTime;
            try
            {
                if ((input != null) && (!input.Equals(DBNull.Value)))
                {
                    toDateTime = Converter.toDateTime(input);
                    if (toDateTime != null)
                    {
                        output = toDateTime.Value.ToString(format);
                    }
                }
            }
            catch
            {
            }
            return output;
        }
        public static String formatTime(object input, string format = "HH:mm:ss")
        {
            string output = "";
            DateTime? toDateTime;
            try
            {
                if ((input != null) && (!input.Equals(DBNull.Value)))
                {
                    toDateTime = Converter.toDateTime(input);
                    if (toDateTime != null)
                    {
                        output = toDateTime.Value.ToString(format);
                    }
                }
            }
            catch
            {
            }
            return output;
        }
        public static Image toImage(object input)
        {
            Image output = null;
            using (output = null)
            {
                try
                {
                    if ((input != null) && (!input.Equals(DBNull.Value)))
                    {
                        if (!String.IsNullOrEmpty(input.ToString()))
                        {
                            byte[] bytes = (byte[])input;
                            MemoryStream ms = new MemoryStream(bytes);
                            output = Image.FromStream(ms);
                        }
                    }
                }
                catch
                {
                }
                return output;
            }
            
        }

      
        public static byte[] toByteArray(string input)
        {
            byte[] output = null;
            try
            {
                if (!String.IsNullOrEmpty(input))
                {
                    FileStream fs = new FileStream(input,
                                           FileMode.Open,
                                           FileAccess.Read);
                    output = new byte[fs.Length];
                    fs.Read(output, 0, Convert.ToInt32(fs.Length));
                }
            }
            catch
            {
            }
            return output;
            
        }
        public static byte[] toByteArray(Image input)
        {
            byte[] output = null;
            try
            {
                if ((input != null) && (!input.Equals(DBNull.Value)))
                {
                    MemoryStream ms = new MemoryStream();
                    //input.Save(ms, input.RawFormat);
                    input.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    output = ms.ToArray();
                }
            }
            catch
            {
            }

            return output;
        }
        public static Byte[] toByteArray(Object input)
        {
            if (input == null)
                return null;
            BinaryFormatter bf = new BinaryFormatter();
            using (MemoryStream ms = new MemoryStream())
            {
                bf.Serialize(ms, input);
                return ms.ToArray();
            }
        }
        public static Nullable<Byte> toByte(Object input)
        {
            Nullable<Byte> output = null;
            try
            {
                if ((input != null) && (!input.Equals(DBNull.Value)))
                {
                    output = Convert.ToByte(input);
                }
            }
            catch
            {
            }
            return output;

            
            
        }
        public static byte[] rawSerialize(object anything)
        {
            int rawsize = Marshal.SizeOf(anything);
            IntPtr buffer = Marshal.AllocHGlobal(rawsize);
            Marshal.StructureToPtr(anything, buffer, false);
            byte[] rawdatas = new byte[rawsize];
            Marshal.Copy(buffer, rawdatas, 0, rawsize);
            Marshal.FreeHGlobal(buffer);
            return rawdatas;
        }
        public static Image resizeImage(Image img, Size size)
        {
            Bitmap newImage = new Bitmap(size.Width, size.Height);
            if (img != null)
            {
                using (Graphics gr = Graphics.FromImage(newImage))
                {
                    gr.SmoothingMode = SmoothingMode.HighQuality;
                    gr.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    gr.PixelOffsetMode = PixelOffsetMode.HighQuality;
                    gr.DrawImage(img, new Rectangle(0, 0, size.Width, size.Height));

                }
            }
            
            return (Image)newImage;
        }
        public static Byte[] toByteArrayFromBase64(Object input)
        {
            byte[] output = null;
            try
            {
                if ((input != null) && (!input.Equals(DBNull.Value)))
                {
                    output = Convert.FromBase64String(input.ToString());
                }
            }
            catch
            {
            }

            return output;
        }
        public static string toHexStringUsingBit(byte[] input)
        {

            string output = null;
            try
            {
                if (input != null)
                {
                    output = BitConverter.ToString(input).Replace("-", "");//Str to Hex
                }
            }
            catch
            {
            }
            return output;

        }
        public static string toHexStringUsingASCIIEncoding(byte[] input)
        {

            string output = null;
            try
            {
                if (input != null)
                {
                    output = ASCIIEncoding.Default.GetString(input);
                }
            }
            catch
            {
            }
            return output;

        }
        public static string toHexStringUsingBase64(byte[] input)
        {
            /*
            StringBuilder hex = new StringBuilder(input.Length * 2);
            foreach (byte b in input)
                hex.AppendFormat("{0:x2}", b);
            return hex.ToString();*/
            string output = null;
            try
            {
                if (input != null)
                {
                    output = Convert.ToBase64String(input);
                    //output = Encoding.UTF8.GetString(input);
                    //output = HttpServerUtility.UrlTokenEncode(bytes); 
                    /*
                    StringBuilder hex = new StringBuilder(input.Length * 2);
                    foreach (byte b in input)
                        hex.AppendFormat("{0:x2}", b);
                    output =  hex.ToString();*/

                    //output = BitConverter.ToString(input);
                    //return output.Replace("-", "");
                }
            }
            catch
            {
            }
            return output;

        }
        public static string toHexStringUsingUrlToken(byte[] input)
        {

            string output = null;
            try
            {
                if (input != null)
                {
                    output = HttpServerUtility.UrlTokenEncode(input);
                }
            }
            catch
            {
            }
            return output;

        }
        public static string toHexStringUsingStringBuilder(byte[] input)
        {
            string output = null;
            try
            {
                if (input != null)
                {
                    
                    StringBuilder hex = new StringBuilder(input.Length * 2);
                    foreach (byte b in input)
                        hex.AppendFormat("{0:x2}", b);
                    output =  hex.ToString();
                }
            }
            catch
            {
            }
            return output;

        }
        public static Int32 getAge(string birthday)
        {
            Int32 output;
            try
            {
                if (!String.IsNullOrEmpty(birthday))
                {
                    int yearNow = DateTime.Today.Year;
                    int yearHis = Convert.ToInt32(birthday);
                    output = yearNow - yearHis;
                }
                else
                {
                    output = 0;
                }
            }
            catch (Exception e)
            {
                output = 0;

                Exceptions.Default(e, "getAge");

            }
            
            return output;
        }
        public static String getSex(object input)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member 'Converter.getSex(object)'
        {
            string output;
            try
            {
                if ((input != null) && (!input.Equals(DBNull.Value)))
                {
                    if (!String.IsNullOrEmpty(input.ToString().Trim()))
                    {
                        switch (input.ToString().Trim())
                        {
                            case "L":
                                output = "Laki-Laki";
                                break;
                            case "M":
                                output = "Male";
                                break;
                            case "P":
                                output = "Perempuan";
                                break;
                            case "F":
                                output = "Female";
                                break;
                            default:
                                output = "";
                                break;
                        }
                    }
                    else
                    {

                        output = "";
                    }
                }
                else
                {
                    output = "";
                }
            }
            catch (Exception e)
            {
                output = "";

                Exceptions.Default(e, "getSex");

            }
            
            return output;
        }
        public static String toSql(string input)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member 'Converter.toSql(string)'
        {
            string output = "";

    
            output = input.Replace("\n", " ").Replace(";",";\n");
            
            return output;
        }
        public static String toLiteral(string input)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member 'Converter.toLiteral(string)'
        {
            var literal = new StringBuilder(input.Length + 2);
            //literal.Append("\"");
            foreach (var c in input)
            {
                switch (c)
                {
                    case '\'': literal.Append(@"\'"); break;
                    case '\"': literal.Append("\\\""); break;
                    case '\\': literal.Append(@"\\"); break;
                    case '\0': literal.Append(@"\0"); break;
                    case '\a': literal.Append(@"\a"); break;
                    case '\b': literal.Append(@"\b"); break;
                    case '\f': literal.Append(@"\f"); break;
                    case '\n': literal.Append(@"\n"); break;
                    case '\r': literal.Append(@"\r"); break;
                    case '\t': literal.Append(@"\t"); break;
                    case '\v': literal.Append(@"\v"); break;
                    default:
                        if (Char.GetUnicodeCategory(c) != System.Globalization.UnicodeCategory.Control)
                        {
                            literal.Append(c);
                        }
                        else
                        {
                            literal.Append(@"\u");
                            literal.Append(((ushort)c).ToString("x4"));
                        }
                        break;
                }
            }
            //literal.Append("\"");
            return literal.ToString();
        }
        public static Boolean isNumeric(Object input)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member 'Converter.isNumeric(object)'
        {
            if (input == null || input is DateTime)
                return false;

            if (input is Int16 || input is Int32 || input is Int64 || input is Decimal || input is Single || input is Double || input is Boolean)
                return true;

            try
            {
                if (input is string)
                    Double.Parse(input as string);
                else
                    Double.Parse(input.ToString());
                return true;
            }
            catch(Exception e)
            {

                Exceptions.Default(e, "isNumeric");

            }
            return false;
        }
        public static String getDay(Object input)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member 'Converter.getDay(object)'
        {
            string output = "";
            string day; 
            string[] days = new string[] { };
            
            try
            {
                if ((input != null) && (!input.Equals(DBNull.Value)))
                {
                    day =  Convert.ToString(input).Trim();
                    days = day.Split(';');
                    Array.Sort(days);

                    for (int i = 0; i < days.Count(); i++)
                    {
                        output += String.Concat(getDayInString(days[i]),",");
                    }
                    output = output.Substring(0, output.Length - 1);
                }
                else
                {
                    return "";
                }
            }
            catch (Exception e)
            {
                output = "";

                Exceptions.Default(e, "Models.getDay(" + input + ")");

            }
            return output;
        }
        public static String getDayInString(string input)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member 'Converter.getDayInString(string)'
        {
            string output;
            try
            {
                switch (input)
                {
                    case "0":
                        output = "Minggu";
                        break;
                    case "1":
                        output = "Senin";
                        break;
                    case "2":
                        output = "Selasa";
                        break;
                    case "3":
                        output = "Rabu";
                        break;
                    case "4":
                        output = "Kamis";
                        break;
                    case "5":
                        output = "Jumat";
                        break;
                    case "6":
                        output = "Sabtu";
                        break;
                    default:
                        output = "";
                        break;
                }
            }
            catch (Exception e)
            {
                output = "";

                Exceptions.Default(e, "Models.getDayId(" + input + ")");

            }
            return output;
        }
        public static String getDayInNumber(string input)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member 'Converter.getDayInNumber(string)'
        {
            string output;
            try
            {
                switch (input)
                {
                    case "Minggu":
                        output = "0";
                        break;
                    case "Senin":
                        output = "1";
                        break;
                    case "Selasa":
                        output = "2";
                        break;
                    case "Rabu":
                        output = "3";
                        break;
                    case "Kamis":
                        output = "4";
                        break;
                    case "Jumat":
                        output = "5";
                        break;
                    case "Sabtu":
                        output = "6";
                        break;
                    default:
                        output = "";
                        break;
                }
            }
            catch (Exception e)
            {
                output = "";

                Exceptions.Default(e, "Models.getDayId(" + input + ")");

            }
            return output;
        }
        public static Nullable<Decimal> getDayInNumberDb(string input)
        {
            decimal? output = null;
            
            try
            {
                if (!String.IsNullOrEmpty(input))
                {
                    input = input.ToUpper().Trim().Replace(" ", String.Empty);
                }
                switch (input)
                {
                    case "MINGGU":
                        output = 1;
                        break;
                    case "SENIN":
                        output = 2;
                        break;
                    case "SELASA":
                        output = 3;
                        break;
                    case "RABU":
                        output = 4;
                        break;
                    case "KAMIS":
                        output = 5;
                        break;
                    case "JUMAT":
                    case "JUM'AT":
                        output = 6;
                        break;
                    case "SABTU":
                        output = 7;
                        break;
                    default:
                        output = null;
                        break;
                }
            }
            catch (Exception e)
            {
                output = null;

                Exceptions.Default(e, "Models.getDayInNumberDb(" + input + ")");

            }
            return output;
        }
        public static DateTime getFirstDayOfMonth(DateTime dtDate)
        {
            DateTime dtFrom = dtDate;

            dtFrom = dtFrom.AddDays(-(dtFrom.Day - 1));

            return dtFrom;

        }
        public static DateTime getFirstDayOfMonth(int iMonth)
        {
            DateTime dtFrom = new DateTime(DateTime.Now.Year, iMonth, 1);

            dtFrom = dtFrom.AddDays(-(dtFrom.Day - 1));
            return dtFrom;

        }
        public static DateTime getLastDayOfMonth(DateTime dtDate)
        {
            DateTime dtTo = dtDate;
            dtTo = dtTo.AddMonths(1);
            dtTo = dtTo.AddDays(-(dtTo.Day));

            return dtTo;

        }
        public static DateTime getLastDayOfMonth(int iMonth)
        {
            DateTime dtTo = new DateTime(DateTime.Now.Year, iMonth, 1);

            dtTo = dtTo.AddMonths(1);
            dtTo = dtTo.AddDays(-(dtTo.Day));
            return dtTo;

        }
        public static IEnumerable<DateTime> eachDay(DateTime from, DateTime thru)
        {
            for (var day = from.Date; day.Date <= thru.Date; day = day.AddDays(1))
                yield return day;
            /*Penggunaan*/
            /*
             foreach (DateTime day in EachDay(StartDate, EndDate)){}
             */
        }
        public static bool thumbnailCallback()
        {
            return false;
        }
        public static Image thumbnailImage(Image image)
        {
            Image thumbnail;
            try
            {
                Image.GetThumbnailImageAbort callbackAbort = new Image.GetThumbnailImageAbort(thumbnailCallback);
                thumbnail = image.GetThumbnailImage(64, 64, callbackAbort, IntPtr.Zero);
            }
            catch(Exception e)
            {
                thumbnail = new Bitmap(32, 32);

                Exceptions.Default(e, "Models.thumbnailImage");

            }
            return thumbnail;
        }
        public static Image thumbnailImage(Image image, int width, int height)
        {
            Image thumbnail;
            try
            {
                
                Image.GetThumbnailImageAbort callbackAbort = new Image.GetThumbnailImageAbort(thumbnailCallback);
                thumbnail = image.GetThumbnailImage(width, height, callbackAbort, IntPtr.Zero);

            }
            catch (Exception e)
            {
                thumbnail = new Bitmap(32, 32);

                Exceptions.Default(e, "Models.thumbnailImage");

            }
            return thumbnail;
;
        }
        public static Bitmap thumbnailBitmap(Image image, int width, int height)
        {
            Bitmap resizedImage;
            try
            {

                Image.GetThumbnailImageAbort callbackAbort = new Image.GetThumbnailImageAbort(thumbnailCallback);
                resizedImage = (Bitmap)image.GetThumbnailImage(width, height, callbackAbort, IntPtr.Zero);
                resizedImage.SetResolution(50, 50);

                var bmp = new Bitmap(resizedImage.Width, resizedImage.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                using (var gr = Graphics.FromImage(bmp))
                    gr.DrawImage(resizedImage, new Rectangle(0, 0, resizedImage.Width, resizedImage.Height));
                return bmp;
            }
            catch (Exception e)
            {
                resizedImage = new Bitmap(32, 32);

                Exceptions.Default(e, "Models.thumbnailImage");

            }
            return resizedImage;

            
        }
        public static MySqlDbType getMySqlDbTtype(object input)
        {
            string type = input.GetType().ToString();
            MySqlDbType output = MySqlDbType.String;

            switch (type)
            {
                case "System.String":
                    output = MySqlDbType.String;
                    break;
                case "System.Byte":
                    output = MySqlDbType.Byte;
                    break;
                case "System.Byte[]":
                case "System.Drawing.Bitmap":
                    output = MySqlDbType.Blob;
                    break;
                case "System.DateTime":
                    output = MySqlDbType.DateTime;
                    break;
                case "System.TimeSpan":
                    output = MySqlDbType.DateTime;
                    break;
                case "System.DBNull":
                    output = MySqlDbType.String;
                    break;
                case "System.Function":
                    output = MySqlDbType.String;
                    break;
                case "System.Decimal":
                    output = MySqlDbType.Decimal;
                    break;
                case "System.Int16":
                    output = MySqlDbType.Int16;
                    break;
                case "System.Int24":
                    output = MySqlDbType.Int24;
                    break;
                case "System.Int32":
                    output = MySqlDbType.Int32;
                    break;
                case "System.Int64":
                    output = MySqlDbType.Int64;
                    break;
                case "System.Double":
                    output = MySqlDbType.Double;
                    break;
                default:
                    output = MySqlDbType.String;
                    break;
            }


            return output;
        }

    }

    public static class DataFiller
    {
        public static IList<T> ConvertTo<T>(IList<DataRow> rows)
        {
            IList<T> list = null;

            if (rows != null)
            {
                list = new List<T>();

                foreach (DataRow row in rows)
                {
                    T item = CreateItem<T>(row);
                    list.Add(item);
                }
            }

            return list;
        }
        public static IList<T> ConvertTo<T>(DataTable table)
        {
            if (table == null)
            {
                return null;
            }

            List<DataRow> rows = new List<DataRow>();

            foreach (DataRow row in table.Rows)
            {
                rows.Add(row);
            }

            return ConvertTo<T>(rows);
        }
        public static T CreateItem<T>(DataRow row)
        {
            T obj = default(T);
            if (row != null)
            {
                obj = Activator.CreateInstance<T>();

                foreach (DataColumn column in row.Table.Columns)
                {
                    PropertyInfo prop = obj.GetType().GetProperty(column.ColumnName);
                    try
                    {
                        object value = row[column.ColumnName];
                        prop.SetValue
                            (obj, value.ToString(), null);
                    }
                    catch
                    {
                        // You can log something here
                        throw;
                    }
                }
            }

            return obj;
        }
        public static DataTable CreateTable<T>()
        {
            Type entityType = typeof(T);
            DataTable table = new DataTable(entityType.Name);
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(entityType);

            foreach (PropertyDescriptor prop in properties)
            {
                table.Columns.Add(prop.Name, prop.PropertyType);
            }

            return table;
        }
        public static T ConvertTo<T>(this object value)
        {
            T returnValue = default(T);

            if (value is T)
            {
                returnValue = (T)value;
            }
            else
            {
                try
                {
                    returnValue = (T)Convert.ChangeType(value, typeof(T));
                }
                catch (InvalidCastException)
                {
                    returnValue = default(T);
                }
            }

            return returnValue;
        }
        public static Nullable<T> ToNullable<T>(this object input)
                where T : struct
        {
            if (input == null)
                return null;
            if (input is Nullable<T> || input is T)
                return (Nullable<T>)input;
            throw new InvalidCastException();
        }
        public static DateTime ParseExcelDate(this string date)
        {

            DateTime dt;
            try
            {
                if (DateTime.TryParse(date, out dt))
                {
                    return dt;
                }

                double oaDate;
                if (double.TryParse(date, out oaDate))
                {
                    return DateTime.FromOADate(oaDate);
                }

            }
            catch (Exception e)
            {

                Exceptions.Default(e, "ParseExcelDate");
            }

            return DateTime.MinValue;
        }
        public static Object GetInstance(Type type)
        {
            return Activator.CreateInstance(type);
        }
        public static IList GetInstanceList(Type type)
        {
            var listType = typeof(List<>);
            var constructedListType = listType.MakeGenericType(type);

            return (IList)Activator.CreateInstance(constructedListType);
        }
        public static List<T> ToList<T>(this DataTable dataTable) where T : new()
        {
            var dataList = new List<T>();

            //Define what attributes to be read from the class
            const BindingFlags flags = BindingFlags.Public | BindingFlags.Instance;

            //Read Attribute Names and Types
            var objFieldNames = typeof(T).GetProperties(flags).Cast<PropertyInfo>().
                Select(item => new
                {
                    Name = item.Name,
                    Type = Nullable.GetUnderlyingType(item.PropertyType) ?? item.PropertyType
                }).ToList();

            //Read Datatable column names and types
            var dtlFieldNames = dataTable.Columns.Cast<DataColumn>().
                Select(item => new {
                    Name = item.ColumnName,
                    Type = item.DataType
                }).ToList();
            var i = 1;
            foreach (DataRow dataRow in dataTable.AsEnumerable().ToList())
            {
                var classObj = new T();
                PropertyInfo propertyNo = classObj.GetType().GetProperty("NO");
                if (propertyNo != null)
                {
                    propertyNo.SetValue(classObj, i, null);
                }
                i++;
                foreach (var dtField in dtlFieldNames)
                {
                    try
                    {
                        PropertyInfo propertyInfos = classObj.GetType().GetProperty(dtField.Name.ToUpper());

                        var field = objFieldNames.Find(x => x.Name.ToUpper() == dtField.Name.ToUpper());

                        if (field != null)
                        {
                            propertyInfos.SetValue(classObj, dataRow[dtField.Name], null);

                            //if (propertyInfos.PropertyType == typeof(DateTime) || propertyInfos.PropertyType == typeof(DateTime?))
                            //{
                            //    propertyInfos.SetValue
                            //    (classObj, Converter.toDateTime(dataRow[dtField.Name]), null);
                            //}
                            //else if (propertyInfos.PropertyType == typeof(Int16) || propertyInfos.PropertyType == typeof(UInt16))
                            //{
                            //    propertyInfos.SetValue
                            //    (classObj, Converter.toInt16(dataRow[dtField.Name]), null);
                            //}
                            //else if (propertyInfos.PropertyType == typeof(Int16?) || propertyInfos.PropertyType == typeof(UInt16?))
                            //{
                            //    propertyInfos.SetValue
                            //    (classObj, Converter.toInt16Null(dataRow[dtField.Name]), null);
                            //}
                            //else if (propertyInfos.PropertyType == typeof(Int32) || propertyInfos.PropertyType == typeof(UInt32))
                            //{
                            //    propertyInfos.SetValue
                            //    (classObj, Converter.toInt32(dataRow[dtField.Name]), null);
                            //}
                            //else if (propertyInfos.PropertyType == typeof(Int32?) || propertyInfos.PropertyType == typeof(UInt32?))
                            //{
                            //    propertyInfos.SetValue
                            //    (classObj, Converter.toInt32Null(dataRow[dtField.Name]), null);
                            //}
                            //else if (propertyInfos.PropertyType == typeof(Int64) || propertyInfos.PropertyType == typeof(UInt64))
                            //{
                            //    propertyInfos.SetValue
                            //    (classObj, Converter.toInt64(dataRow[dtField.Name]), null);
                            //}
                            //else if (propertyInfos.PropertyType == typeof(Int64?) || propertyInfos.PropertyType == typeof(UInt64?))
                            //{
                            //    propertyInfos.SetValue
                            //    (classObj, Converter.toInt64Null(dataRow[dtField.Name]), null);
                            //}
                            //else if (propertyInfos.PropertyType == typeof(Decimal))
                            //{
                            //    propertyInfos.SetValue
                            //    (classObj, Converter.toDecimal(dataRow[dtField.Name]), null);
                            //}
                            //else if (propertyInfos.PropertyType == typeof(Decimal?))
                            //{
                            //    propertyInfos.SetValue
                            //    (classObj, Converter.toDecimalNull(dataRow[dtField.Name]), null);
                            //}
                            //else if (propertyInfos.PropertyType == typeof(Double))
                            //{
                            //    propertyInfos.SetValue
                            //    (classObj, Converter.toDouble(dataRow[dtField.Name]), null);
                            //}
                            //else if (propertyInfos.PropertyType == typeof(Double?))
                            //{
                            //    propertyInfos.SetValue
                            //    (classObj, Converter.toDoubleNull(dataRow[dtField.Name]), null);
                            //}
                            //else if (propertyInfos.PropertyType == typeof(float))
                            //{
                            //    propertyInfos.SetValue
                            //    (classObj, Converter.toDecimal(dataRow[dtField.Name]), null);
                            //}
                            //else if (propertyInfos.PropertyType == typeof(float?))
                            //{
                            //    propertyInfos.SetValue
                            //    (classObj, Converter.toDecimalNull(dataRow[dtField.Name]), null);
                            //}
                            //else if (propertyInfos.PropertyType == typeof(String))
                            //{
                            //    if (dataRow[dtField.Name].GetType() == typeof(DateTime))
                            //    {
                            //        propertyInfos.SetValue
                            //        (classObj, Converter.formatDate(dataRow[dtField.Name]), null);
                            //    }
                            //    else
                            //    {
                            //        propertyInfos.SetValue
                            //        (classObj, Converter.toString(dataRow[dtField.Name]), null);
                            //    }
                            //}
                        }
                    }
                    catch
                    {
                        continue;
                    }
                }
                dataList.Add(classObj);
            }
            return dataList;
        }
        public static IList ToList(this DataTable dataTable, Type type) 
        {
            var dataList = GetInstanceList(type);

            //Define what attributes to be read from the class
            const BindingFlags flags = BindingFlags.Public | BindingFlags.Instance;

            //Read Attribute Names and Types
            var objFieldNames = type.GetProperties(flags).Cast<PropertyInfo>().
                Select(item => new
                {
                    Name = item.Name,
                    Type = Nullable.GetUnderlyingType(item.PropertyType) ?? item.PropertyType
                }).ToList();

            //Read Datatable column names and types
            var dtlFieldNames = dataTable.Columns.Cast<DataColumn>().
                Select(item => new {
                    Name = item.ColumnName,
                    Type = item.DataType
                }).ToList();
            var i = 1;
            foreach (DataRow dataRow in dataTable.AsEnumerable().ToList())
            {
                var classObj = GetInstance(type);
                PropertyInfo propertyNo = classObj.GetType().GetProperty("NO");
                if (propertyNo != null)
                {
                    propertyNo.SetValue(classObj, i, null);
                }
                i++;
                foreach (var dtField in dtlFieldNames)
                {
                    try
                    {
                        PropertyInfo propertyInfos = classObj.GetType().GetProperty(dtField.Name.ToUpper());

                        var field = objFieldNames.Find(x => x.Name.ToUpper() == dtField.Name.ToUpper());

                        if (field != null)
                        {
                            /*
                            if (value == DBNull.Value)
                        {
                            if (vType == typeof(int) || vType == typeof(Int16)
                                                     || vType == typeof(Int32)
                                                     || vType == typeof(Int64)
                                                     || vType == typeof(decimal)
                                                     || vType == typeof(float)
                                                     || vType == typeof(double))
                            {
                                value = 0;
                            }

                            else if (vType == typeof(bool))
                            {
                                value = false;
                            }

                            else if (vType == typeof(DateTime))
                            {
                                value = DateTime.MaxValue;
                            }

                            else
                            {
                                value = null;
                            }

                            prop.SetValue(obj, value, null);
                        }

                        else
                        {
                            prop.SetValue(obj, value, null);
                        }
                            */

                            if (propertyInfos.PropertyType == typeof(DateTime) || propertyInfos.PropertyType == typeof(DateTime?))
                            {
                                propertyInfos.SetValue
                                (classObj, Converter.toDateTime(dataRow[dtField.Name]), null);
                            }
                            else if (propertyInfos.PropertyType == typeof(Int16) || propertyInfos.PropertyType == typeof(UInt16))
                            {
                                propertyInfos.SetValue
                                (classObj, Converter.toInt16(dataRow[dtField.Name]), null);
                            }
                            else if (propertyInfos.PropertyType == typeof(Int16?) || propertyInfos.PropertyType == typeof(UInt16?))
                            {
                                propertyInfos.SetValue
                                (classObj, Converter.toInt16Null(dataRow[dtField.Name]), null);
                            }
                            else if (propertyInfos.PropertyType == typeof(Int32) || propertyInfos.PropertyType == typeof(UInt32))
                            {
                                propertyInfos.SetValue
                                (classObj, Converter.toInt32(dataRow[dtField.Name]), null);
                            }
                            else if (propertyInfos.PropertyType == typeof(Int32?) || propertyInfos.PropertyType == typeof(UInt32?))
                            {
                                propertyInfos.SetValue
                                (classObj, Converter.toInt32Null(dataRow[dtField.Name]), null);
                            }
                            else if (propertyInfos.PropertyType == typeof(Int64) || propertyInfos.PropertyType == typeof(UInt64))
                            {
                                propertyInfos.SetValue
                                (classObj, Converter.toInt64(dataRow[dtField.Name]), null);
                            }
                            else if (propertyInfos.PropertyType == typeof(Int64?) || propertyInfos.PropertyType == typeof(UInt64?))
                            {
                                propertyInfos.SetValue
                                (classObj, Converter.toInt64Null(dataRow[dtField.Name]), null);
                            }
                            else if (propertyInfos.PropertyType == typeof(Decimal))
                            {
                                propertyInfos.SetValue
                                (classObj, Converter.toDecimal(dataRow[dtField.Name]), null);
                            }
                            else if (propertyInfos.PropertyType == typeof(Decimal?))
                            {
                                propertyInfos.SetValue
                                (classObj, Converter.toDecimalNull(dataRow[dtField.Name]), null);
                            }
                            else if (propertyInfos.PropertyType == typeof(Double))
                            {
                                propertyInfos.SetValue
                                (classObj, Converter.toDouble(dataRow[dtField.Name]), null);
                            }
                            else if (propertyInfos.PropertyType == typeof(Double?))
                            {
                                propertyInfos.SetValue
                                (classObj, Converter.toDoubleNull(dataRow[dtField.Name]), null);
                            }
                            else if (propertyInfos.PropertyType == typeof(float))
                            {
                                propertyInfos.SetValue
                                (classObj, Converter.toDecimal(dataRow[dtField.Name]), null);
                            }
                            else if (propertyInfos.PropertyType == typeof(float?))
                            {
                                propertyInfos.SetValue
                                (classObj, Converter.toDecimalNull(dataRow[dtField.Name]), null);
                            }
                            else if (propertyInfos.PropertyType == typeof(byte))
                            {
                                propertyInfos.SetValue
                                (classObj, Converter.toByte(dataRow[dtField.Name]), null);
                            }
                            else if (propertyInfos.PropertyType == typeof(Image))
                            {
                                propertyInfos.SetValue
                                (classObj, Converter.toImage(dataRow[dtField.Name]), null);
                            }
                            else if (propertyInfos.PropertyType == typeof(byte[]))
                            {
                                propertyInfos.SetValue
                                (classObj, Converter.toByteArray(dataRow[dtField.Name]), null);
                            }
                            else if (propertyInfos.PropertyType == typeof(String))
                            {
                                if (dataRow[dtField.Name].GetType() == typeof(DateTime))
                                {
                                    propertyInfos.SetValue
                                    (classObj, Converter.formatDate(dataRow[dtField.Name]), null);
                                }
                                else
                                {
                                    propertyInfos.SetValue
                                    (classObj, Converter.toString(dataRow[dtField.Name]), null);
                                }
                            }
                        }
                    }
                    catch
                    {
                        continue;
                    }
                }
                dataList.Add(classObj);
            }
            return dataList;
        }
        public static IList ToList(this DataTable dataTable, Type type, BindingSource binding, Control ctrl)
        {
            var dataList = MySql.Driver.DataFiller.GetInstanceList(type);
            try
            {
                ctrl.Invoke((MethodInvoker)delegate
                {
                    binding.DataSource = dataList;
                });
                //Define what attributes to be read from the class
                const BindingFlags flags = BindingFlags.Public | BindingFlags.Instance;

                //Read Attribute Names and Types
                var objFieldNames = type.GetProperties(flags).Cast<PropertyInfo>().
                    Select(item => new
                    {
                        Name = item.Name,
                        Type = Nullable.GetUnderlyingType(item.PropertyType) ?? item.PropertyType
                    }).ToList();

                //Read Datatable column names and types
                var dtlFieldNames = dataTable.Columns.Cast<DataColumn>().
                    Select(item => new {
                        Name = item.ColumnName,
                        Type = item.DataType
                    }).ToList();
                var i = 1;
                var j = 1;
                foreach (DataRow dataRow in dataTable.AsEnumerable().ToList())
                {

                    var classObj = MySql.Driver.DataFiller.GetInstance(type);
                    PropertyInfo propertyNo = classObj.GetType().GetProperty("NO");
                    if (propertyNo != null)
                    {
                        propertyNo.SetValue(classObj, i, null);
                    }
                    i++;
                    j++;

                    #region LOOP
                    foreach (var dtField in dtlFieldNames)
                    {
                        try
                        {
                            PropertyInfo propertyInfos = classObj.GetType().GetProperty(dtField.Name.ToUpper());

                            var field = objFieldNames.Find(x => x.Name.ToUpper() == dtField.Name.ToUpper());

                            if (field != null)
                            {

                                if (propertyInfos.PropertyType == typeof(DateTime) || propertyInfos.PropertyType == typeof(DateTime?))
                                {
                                    propertyInfos.SetValue
                                    (classObj, Converter.toDateTime(dataRow[dtField.Name]), null);
                                }
                                else if (propertyInfos.PropertyType == typeof(Int16) || propertyInfos.PropertyType == typeof(UInt16))
                                {
                                    propertyInfos.SetValue
                                    (classObj, Converter.toInt16(dataRow[dtField.Name]), null);
                                }
                                else if (propertyInfos.PropertyType == typeof(Int16?) || propertyInfos.PropertyType == typeof(UInt16?))
                                {
                                    propertyInfos.SetValue
                                    (classObj, Converter.toInt16Null(dataRow[dtField.Name]), null);
                                }
                                else if (propertyInfos.PropertyType == typeof(Int32) || propertyInfos.PropertyType == typeof(UInt32))
                                {
                                    propertyInfos.SetValue
                                    (classObj, Converter.toInt32(dataRow[dtField.Name]), null);
                                }
                                else if (propertyInfos.PropertyType == typeof(Int32?) || propertyInfos.PropertyType == typeof(UInt32?))
                                {
                                    propertyInfos.SetValue
                                    (classObj, Converter.toInt32Null(dataRow[dtField.Name]), null);
                                }
                                else if (propertyInfos.PropertyType == typeof(Int64) || propertyInfos.PropertyType == typeof(UInt64))
                                {
                                    propertyInfos.SetValue
                                    (classObj, Converter.toInt64(dataRow[dtField.Name]), null);
                                }
                                else if (propertyInfos.PropertyType == typeof(Int64?) || propertyInfos.PropertyType == typeof(UInt64?))
                                {
                                    propertyInfos.SetValue
                                    (classObj, Converter.toInt64Null(dataRow[dtField.Name]), null);
                                }
                                else if (propertyInfos.PropertyType == typeof(Decimal))
                                {
                                    propertyInfos.SetValue
                                    (classObj, Converter.toDecimal(dataRow[dtField.Name]), null);
                                }
                                else if (propertyInfos.PropertyType == typeof(Decimal?))
                                {
                                    propertyInfos.SetValue
                                    (classObj, Converter.toDecimalNull(dataRow[dtField.Name]), null);
                                }
                                else if (propertyInfos.PropertyType == typeof(Double))
                                {
                                    propertyInfos.SetValue
                                    (classObj, Converter.toDouble(dataRow[dtField.Name]), null);
                                }
                                else if (propertyInfos.PropertyType == typeof(Double?))
                                {
                                    propertyInfos.SetValue
                                    (classObj, Converter.toDoubleNull(dataRow[dtField.Name]), null);
                                }
                                else if (propertyInfos.PropertyType == typeof(float))
                                {
                                    propertyInfos.SetValue
                                    (classObj, Converter.toDecimal(dataRow[dtField.Name]), null);
                                }
                                else if (propertyInfos.PropertyType == typeof(float?))
                                {
                                    propertyInfos.SetValue
                                    (classObj, Converter.toDecimalNull(dataRow[dtField.Name]), null);
                                }
                                else if (propertyInfos.PropertyType == typeof(byte))
                                {
                                    propertyInfos.SetValue
                                    (classObj, Converter.toByte(dataRow[dtField.Name]), null);
                                }
                                else if (propertyInfos.PropertyType == typeof(Image))
                                {
                                    propertyInfos.SetValue
                                    (classObj, Converter.toImage(dataRow[dtField.Name]), null);
                                }
                                else if (propertyInfos.PropertyType == typeof(byte[]))
                                {
                                    propertyInfos.SetValue
                                    (classObj, Converter.toByteArray(dataRow[dtField.Name]), null);
                                }
                                else if (propertyInfos.PropertyType == typeof(Boolean))
                                {
                                    propertyInfos.SetValue
                                    (classObj, Converter.toBoolean(dataRow[dtField.Name]), null);
                                }
                                else if (propertyInfos.PropertyType == typeof(String))
                                {
                                    if (dataRow[dtField.Name].GetType() == typeof(DateTime))
                                    {
                                        propertyInfos.SetValue
                                        (classObj, Converter.formatDate(dataRow[dtField.Name]), null);
                                    }
                                    else
                                    {
                                        propertyInfos.SetValue
                                        (classObj, Converter.toString(dataRow[dtField.Name]), null);
                                    }
                                }
                            }
                        }
                        catch
                        {
                            continue;
                        }
                    }
                    #endregion

                    if (ctrl.IsDisposed == true)
                    {
                        break;
                    }

                    //if(j < 100)
                    //{
                    //    j = 1;
                    //    ctrl.BeginInvoke((MethodInvoker)delegate
                    //    {
                    //        binding.Add(classObj);
                    //    });
                    //}
                    //else
                    //{
                    //    ctrl.Invoke((MethodInvoker)delegate
                    //    {
                    //        binding.Add(classObj);
                    //    });
                    //}
                   
                    dataList.Add(classObj);
                    if (j == 1000)
                    {
                        j = 1;
                        ctrl.Invoke((MethodInvoker)delegate
                        {
                            binding.ResetBindings(false);
                        });
                    }
                }
                ctrl.Invoke((MethodInvoker)delegate
                {
                    binding.ResetBindings(false);
                    ctrl.Refresh();
                });
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return dataList;
        }
        public static List<Parameters> ToParamMySql<T>(this Entity entity) where T : new()
        {
            return entity.ToParamMySql(typeof(T));
        }
        public static List<Parameters> ToParamMySql(this Entity entity, Type type) 
        {
            List<MySql.Driver.DB.Parameters> parameters = new List<MySql.Driver.DB.Parameters>();

            //Define what attributes to be read from the class
            const BindingFlags flags = BindingFlags.Public | BindingFlags.Instance;

            //Read Attribute Names and Types
            var objFieldNames = type.GetProperties(flags).Cast<PropertyInfo>().
                Select(item => new
                {
                    Name = item.Name,
                    Type = Nullable.GetUnderlyingType(item.PropertyType) ?? item.PropertyType
                }).ToList();

            var objFieldEntity = typeof(Entity).GetProperties(flags).Cast<PropertyInfo>().
                Select(item => new
                {
                    Name = item.Name,
                    Type = Nullable.GetUnderlyingType(item.PropertyType) ?? item.PropertyType
                }).ToList();

            foreach (var item in objFieldNames)
            {
                var itemEntity = objFieldEntity.Where(x => x.Name == item.Name).FirstOrDefault();
                if (itemEntity == null)
                {
                    PropertyInfo property = entity.GetType().GetProperty(item.Name);
                    if (GetAttributeReference(property) == false)
                    {
                        MySql.Driver.DB.Parameters parameter = new MySql.Driver.DB.Parameters();
                        parameter.FIELD = item.Name;
                        parameter.VALUE = property.GetValue(entity);
                        parameters.Add(parameter);
                    }
                }

            }

            return parameters;
        }
        public static List<Parameters> ToParamMySqlNotNull<T>(this Entity entity) where T : new()
        {
            return entity.ToParamMySqlNotNull(typeof(T));
        }
        public static List<Parameters> ToParamMySqlNotNull(this Entity entity, Type type)
        {
            List<Parameters> parameters = new List<Parameters>();

            //Define what attributes to be read from the class
            const BindingFlags flags = BindingFlags.Public | BindingFlags.Instance;

            //Read Attribute Names and Types
            var objFieldNames = type.GetProperties(flags).Cast<PropertyInfo>().
                Select(item => new
                {
                    Name = item.Name,
                    Type = Nullable.GetUnderlyingType(item.PropertyType) ?? item.PropertyType
                }).ToList();

            var objFieldEntity = typeof(Entity).GetProperties(flags).Cast<PropertyInfo>().
                Select(item => new
                {
                    Name = item.Name,
                    Type = Nullable.GetUnderlyingType(item.PropertyType) ?? item.PropertyType
                }).ToList();

            foreach (var item in objFieldNames)
            {
                var itemEntity = objFieldEntity.Where(x => x.Name == item.Name).FirstOrDefault();
                if (itemEntity == null)
                {
                    PropertyInfo property = entity.GetType().GetProperty(item.Name);
                    if (GetAttributeReference(property) == false)
                    {
                        Object value = property.GetValue(entity);
                        if (property.GetValue(entity) != null)
                        {
                            Parameters parameter = new Parameters();
                            parameter.FIELD = item.Name;
                            parameter.TYPE = Converter.getMySqlDbTtype(value);
                            if (property.PropertyType == typeof(Image))
                            {
                                parameter.VALUE = Converter.toByteArray(value as Image);
                            }
                            else
                            {
                                parameter.VALUE = property.GetValue(entity);
                            }
                            parameters.Add(parameter);
                        }
                    }
                }

            }

            return parameters;
        }
        public static OutputParameters Find<Type>(this MySql.Driver.DB.Driver driver, String sql) where Type : new()
        {
            OutputParameters output = new OutputParameters();
            var listData = new List<Type>();
            try
            {

                DataTable DataTable = new DataTable();
                Stopwatch stopwatchQuery = new Stopwatch();
                Stopwatch stopwatchConvert= new Stopwatch();

                stopwatchQuery.Start();
                DataTable = driver.Find(sql);
                stopwatchQuery.Stop();
                
                stopwatchConvert.Start();
                listData = DataTable.ToList<Type>();
                stopwatchConvert.Stop();

                Console.WriteLine("Query : " + sql);
                Console.WriteLine("Lama Waktu Query : " + stopwatchQuery.Elapsed);
                Console.WriteLine("Lama Waktu Convert : " + stopwatchConvert.Elapsed);
                output.DATA = listData;
                output.RESULT = "Y";

            }

            catch (MySqlException e)
            {
                output.DATA = null;
                output.RESULT = "N";
                output.MESSAGE = e.Message;
                Exceptions.MySql(e);
            }
            return output;
        }
        public static OutputParameters Find(this MySql.Driver.DB.Driver driver, String sql, Type type) 
        {
            OutputParameters output = new OutputParameters();
            var listData = GetInstanceList(type);
            try
            {

                DataTable DataTable = new DataTable();
                Stopwatch stopwatchQuery = new Stopwatch();
                Stopwatch stopwatchConvert = new Stopwatch();

                stopwatchQuery.Start();
                DataTable = driver.Find(sql);
                stopwatchQuery.Stop();

                stopwatchConvert.Start();
                listData = DataTable.ToList(type);
                stopwatchConvert.Stop();

                Console.WriteLine("Query : " + sql);
                Console.WriteLine("Lama Waktu Query : " + stopwatchQuery.Elapsed);
                Console.WriteLine("Lama Waktu Convert : " + stopwatchConvert.Elapsed);
                output.DATA = listData;
                output.RESULT = "Y";

            }

            catch (MySqlException e)
            {
                output.DATA = null;
                output.RESULT = "N";
                output.MESSAGE = e.Message;
                Exceptions.MySql(e);
            }
            return output;
        }
        public static String GetCondition(this Entity instance)
        {
            string output = "";
            PropertyInfo[] properties = instance.GetType().GetProperties();
            List<MySql.Driver.DB.Parameters> param = new List<MySql.Driver.DB.Parameters>();
            foreach (PropertyInfo row in properties)
            {
                foreach (CustomAttributeData item in row.CustomAttributes)
                {
                    if (item.AttributeType.Name == "KeyAttribute")
                    {
                        param.Add(new MySql.Driver.DB.Parameters
                        {
                            FIELD = row.Name,
                            TYPE = MySql.Data.MySqlClient.MySqlDbType.String,
                            VALUE = Converter.toString(row.GetValue(instance))
                        });
                    }
                }
            }
            if (param.Count() > 0)
            {

                foreach (MySql.Driver.DB.Parameters item in param)
                {
                    if (!String.IsNullOrEmpty(output)) output += " AND ";
                    if (!String.IsNullOrEmpty(Converter.toString(item.VALUE)))
                    {
                        output += String.Format("`{0}` = '{1}'", item.FIELD, item.VALUE);
                    }
                    else
                    {
                        output += String.Format("(`{0}` IS NULL OR `{0}` = '')", item.FIELD);
                    }
                    
                }
            }

            return output;
        }
        
        public static String SetPrimaryKey(this Entity instance, object key)
        {
            string output = "";
            PropertyInfo[] properties = instance.GetType().GetProperties();
            List<MySql.Driver.DB.Parameters> param = new List<MySql.Driver.DB.Parameters>();
            foreach (PropertyInfo row in properties)
            {
                foreach (CustomAttributeData item in row.CustomAttributes)
                {
                    if (item.AttributeType.Name == "DatabaseGeneratedAttribute")
                    {
                        if (row.PropertyType == typeof(Int16))
                        {
                            row.SetValue(instance, Converter.toInt16(key), null);
                        }
                        else if (row.PropertyType == typeof(Int32))
                        {
                            row.SetValue(instance, Converter.toInt32(key), null);
                        }
                        else if (row.PropertyType == typeof(Int64))
                        {
                            row.SetValue(instance, Converter.toInt64(key), null);
                        }
                        else if (row.PropertyType == typeof(Int16?))
                        {
                            row.SetValue(instance, Converter.toInt16Null(key), null);
                        }
                        else if (row.PropertyType == typeof(Int32?))
                        {
                            row.SetValue(instance, Converter.toInt32Null(key), null);
                        }
                        else if (row.PropertyType == typeof(Int64?))
                        {
                            row.SetValue(instance, Converter.toInt64Null(key), null);
                        }
                        else
                        {

                        }

                        break;
                    }
                }
            }


            return output;
        }
        public static T GetAttributeFrom<T>(this object instance, string propertyName) where T : Attribute
        {
            var attrType = typeof(T);
            var property = instance.GetType().GetProperty(propertyName);
            return (T)property.GetCustomAttributes(attrType, false).First();
        }
        public static Boolean GetAttributeReference(PropertyInfo property)
        {
            Boolean output = false;
            foreach (CustomAttributeData item in property.CustomAttributes)
            {
                if (item.AttributeType.Name == "ReferenceAttribute")
                {
                    output = true;
                }
            }
            return output;
        }
        public static TableAttribute GetAttributeTable(this Type t)
        {
            return (TableAttribute)Attribute.GetCustomAttribute(t, typeof(TableAttribute));
        }
        public static ViewAttribute GetAttributeView(this Type t)
        {
            return (ViewAttribute)Attribute.GetCustomAttribute(t, typeof(ViewAttribute));
        }
        public static EntityAttribute GetAttributeEntity(this Model instance)
        {
            return (EntityAttribute)Attribute.GetCustomAttribute(instance.GetType(), typeof(EntityAttribute));
        }
        public static FieldsAttribute GetAttributeFields(this Type t)
        {
            return (FieldsAttribute)Attribute.GetCustomAttribute(t, typeof(FieldsAttribute));
        }
    }
}

//List<Employee> myList = (List<Employee>)DataFiller.ConvertTo<Employee>(DTEmployee);

