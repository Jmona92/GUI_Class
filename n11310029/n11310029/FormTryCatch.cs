using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace n11310029
{
    public partial class Form_TryCatch : Form
    {
        public Form_TryCatch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)

        {
            try
            {
                double input = Double.Parse(textBox1.Text);
                double sum = input+100;
                button1.Text=sum.ToString();
                throw new IndexOutOfRangeException();
            }
            catch (System.FormatException)
            {
                MessageBox.Show("輸入的格式有問題");

            }
            catch (Exception ex)
            {
                MessageBox.Show("發生問題了,甚麼問題餔知道");
            }
            finally
            {
                MessageBox.Show("執行到最後");
            }

        }
    }
}
