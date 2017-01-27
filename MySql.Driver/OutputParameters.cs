using System;
using System.Collections.Generic;

namespace MySql.Driver
{
    public class OutputParameters
    {
        public Object DATA { get; set; }
        public String RESULT { get; set; }
        public String MESSAGE { get; set; }
        public Int64? ID { get; set; }
        public Boolean DATA_EXIST{ get; set; }
    }
}
