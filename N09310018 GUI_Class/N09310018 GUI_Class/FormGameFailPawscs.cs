using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace N09310018_GUI_Class
{
    public partial class FormGameFailPawscs : Form
    {
        int min = 0; max=100;
        int answer;

        public FormGameFailPawscs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random;
            int result = r.Next(100);
            MessageBpx.Show(result.ToString());
            laber1.text = "己隨機0~100數字,請在下方作答";
            label2.Text = string.Format("請輸入{0}~{1}之間的數值", MinimizeBox, max);


        }

        private void button2_Click(object sender, EventArgs e)

        try
        {
            int iput = Int32.Parse(TextBox.Text);
            if (input== this.answer)//答對了
            {
                MessageBox.Show("恭喜答對!");
            }
            else if(input < this.answer)
            {
                this,min = iput;
            }
            else if(iput>this.answer)
            {
                this.max = iput;
            }
            label2.Text = string.Format("請輸入{0}~{1}之間的數值", MinimizeBox, max);
    } catch(Exception el){
            MessageBox.Show("輸入錯誤,請輸入數字");

        }







