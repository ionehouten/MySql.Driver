using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Example.Controllers;
using Example.Models;
using System.ComponentModel.Design;

namespace Example.Views
{
    [Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(IDesigner))]

    public partial class ucEmployee : ucControllerMain
    {
        public ucEmployee()
        {
            InitializeComponent();
            base.model = new ModelEmployee();
        }
    }
}
