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
    public partial class FormTryCath : Form
    {
        public FormTryCath()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double input = Double.Parse(textBox1.Text);
                double sum = input + 100;
                button1.Text = sum.ToString();
            }
            catch (System.FormatException)
            {
                MessageBox.Show("輸入格式有問題");
            }
            catch (Exception)
            {
                MessageBox.Show("發生問題了,什麼問題不知道");
            }
            finally
            {
                MessageBOX.Show("執行到最後");
            }
        }   



    }
}
