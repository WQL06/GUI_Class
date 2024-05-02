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
    public partial class Form_Timer : Form
    {
        public Form_Timer()
        {
            InitializeComponent();
            this.second = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //label1.Text=second.T0String()+"秒";
            label1.Text = string.Format("{0}秒", this.second);
            this.scond++;
        }
    }
}
