using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Example.Entities;
namespace Example.Models
{
    class ModelEmployee : MySql.Driver.Model
    {
        public ModelEmployee() : base()
        {
            this.setTable("employees");
            this.setEntity(typeof(Employee));
        }
    }

}
