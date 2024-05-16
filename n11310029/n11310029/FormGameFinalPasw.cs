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
    public partial class FormGameFinalPasw : Form
    {
        int min = 0, max = 100;
        int answer;
        public FormGameFinalPasw()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            this.answer = r.Next(100);
            MessageBox.Show(this.answer.ToString());
            label1.Text = string.Format("已隨機產生0~100的數字,請在下方作,請輸入{0}~{1}之間的數值", min, max);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            { 
                int input = Int32.Parse(textBox1.Text);
                if (input == this.answer)//答對了
                {
                    MessageBox.Show("恭喜答對!");
                }
                else if(input > this.answer)
                {
                    this.max = input;
                }
                else if (input < this.answer)
                {
                    this.min = input;

                }

                label1.Text = string.Format("已隨機產生0~100的數字,請在下方作,請輸入{0}~{1}之間的數值", min, max);
            }
            catch(Exception el){
                MessageBox.Show("輸入錯誤,請輸入文字");
            }
        }

        
    }
}
