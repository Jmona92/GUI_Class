using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace n11310029
{
    public partial class FormButton : Form
    {
        public FormButton()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text =="請按我一下") 
                button1.Text ="我已經被按過了";
            else if (button1.Text=="我已經被按過了")
                button1.Text ="請按我一下";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "下方按鈕已被按過";
            label1.Size = new System.Drawing.Size(100, 20);
            label1.BackColor = System.Drawing.Color.Green;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            string tmp = labCount.Text;
            int sum = Int32.Parse(tmp)+1;
            labCount.Text = sum.ToString();
        }

        private void btnCount2_Click(object sender, EventArgs e)
        {
            string tmp = labCount2.Text;
            int sum = Int32.Parse(tmp)-1;
            labCount2.Text = sum.ToString();
        }
    }
}
