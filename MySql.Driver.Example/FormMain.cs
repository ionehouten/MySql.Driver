using Example.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example
{
    public partial class FormMain : Form
    {
        private ucEmployee ucEmployee = null;
        public FormMain()
        {
            InitializeComponent();
        }

        private void menuItemBasic_Click(object sender, EventArgs e)
        {
            Config.setPanel(ucEmployee = new ucEmployee(),panelMain);
            ucEmployee.Init();
        }
    }
}
