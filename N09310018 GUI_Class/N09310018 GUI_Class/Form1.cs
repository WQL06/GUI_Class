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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnbutton_Click(object sender, EventArgs e)
        {
            //btnbutton.Text ="我己經被按過了";
            Form form = new FormButton();
            form.Show();

        }

        private void BtnTextBox_Click(object sender, EventArgs e)
        { }
            Form formTextBox = new FormTextBox();
                 formTextBox.Show();
        }
    }
}
