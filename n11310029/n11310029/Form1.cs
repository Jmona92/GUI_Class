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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            button1.Text="按鈕";
            Form form = new FormButton();
            form.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnTextBox_Click(object sender, EventArgs e)
        {
            Form formTextBox = new FormTextBox();
            formTextBox.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           Form 期中考 = new 期中考();
            期中考.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form formTryCatch = new Form_TryCatch();
            formTryCatch.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form formTimer = new FormTimer();
            formTimer.Show();
        }
    }
}
