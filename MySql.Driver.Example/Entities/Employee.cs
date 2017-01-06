using MySql.Driver;
using System;
using System.ComponentModel.DataAnnotations;

namespace Example.Entities
{
    [Serializable]
    public class Employee : Entity
    {
        [Key]
        public Int32 EMPLOYEENUMBER{ get; set; }
        public String LASTNAME { get; set; }
        public String FIRSTNAME { get; set; }
        public String EXTENSION { get; set; }
        public String EMAIL { get; set; }
        public String OFFICECODE { get; set; }
        public String REPORTSTO { get; set; }
        public String JOBTITLE { get; set; }

    }
}
