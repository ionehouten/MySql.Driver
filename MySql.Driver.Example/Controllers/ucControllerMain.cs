using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Driver;
using System.Collections;
using System.ComponentModel.Design;

namespace Example.Controllers
{
    /// <summary>
    /// make a UserControl object acts as a control container design-time by using Visual C#
    /// </summary>
    [Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(IDesigner))]

    public partial class ucControllerMain : UserControl
    {
        protected Model model = null;
        protected Entity selected = null;
        protected InputParameters input;
        protected OutputParameters output;
        protected int totalData;
        
        public ucControllerMain()
        {
            InitializeComponent();
            this.bindingSource1.DataSource = new List<Entity>();
        }
        
        public virtual void Init()
        {
            if (this.bindingSource1.List.Count == 0)
            {
                LoadData();
            }
           
        }
        public virtual async void LoadData()
        {
            try
            {

                var model = this.model as MySql.Driver.Model;
                output = new OutputParameters();
                input = new InputParameters();
                input.LIMIT = Config.limit;
                input.OFFSET = Config.offset;
                input.CONDITION = "";
                totalData = model.CountData(input);
                output = await model.GetData(input, bindingSource1, this);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public virtual async Task LoadDataAsync()
        {
            await Task.Run(() => LoadData());
        }
    }
}
