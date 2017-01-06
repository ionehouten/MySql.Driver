using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example
{
    class Config
    {
        /*if limit and offset == 0  == All Data*/
        public static int limit = 0;
        public static int offset = 0;
        public static void setPanel(UserControl uc, Panel pc)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                clearPanel(pc);

                uc.Visible = false;
                uc.Size = pc.Size;
                pc.Parent.SuspendLayout();
                pc.SuspendLayout();

                uc.Dock = DockStyle.Fill;
                uc.Bounds = pc.DisplayRectangle;
                uc.BringToFront();
                uc.Focus();
                pc.Controls.Add(uc);

            }
            finally
            {
                pc.ResumeLayout();
                pc.Parent.ResumeLayout();
                uc.Visible = true;
                uc.Refresh();
                pc.Refresh();
                Cursor.Current = Cursors.Default;
            }
        }
        public static void clearPanel(Panel pc)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                for (int i = 0; i > pc.Controls.Count; i++)
                {
                    pc.Controls.RemoveAt(i);
                }
                pc.Controls.Clear();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
    }
}
