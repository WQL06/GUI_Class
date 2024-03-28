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
    public partial class FormButton : Form
    {
        public FormButton()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            if (btnClick.Text == "請按我一下")
                btnClick.Text = "我已經被按過了";
            else if (btnClick.Text == "我已經被按過了")
                btnClick.Text = "請按我一下";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "按鈕已經被按過了"; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tmp = label2.Text;
            int sum=Int32.Parse(tmp)+1;
            button2.Text = sum.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
         
    }
}
