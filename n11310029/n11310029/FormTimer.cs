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
    public partial class FormTimer : Form
    {
        int second;
        public FormTimer()
        {
            InitializeComponent();
            int second = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //labell.Text= second.ToString()+"秒";
            label1.Text= String.Format("{0}秒", this.second);
            this.second++;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
