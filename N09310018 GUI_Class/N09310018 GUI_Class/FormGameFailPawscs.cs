using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N09310018_GUI_Class
{
    public partial class FormGameFailPawscs : Form
    {
        public FormGameFailPawscs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random;
            int result = r.Next(100);
            MessageBpx.Show(result.ToString());



        }
    }
}
