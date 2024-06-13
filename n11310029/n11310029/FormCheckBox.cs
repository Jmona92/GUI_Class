using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace n11310029
{
    public partial class FormCheckBox : Form
    {
        public FormCheckBox()
        {
            InitializeComponent();

            if (!File.Exists("OrderData.csv"))
            File.WriteAllText("OrderData.csv", "Time,staples,side,beverages\n", Encoding.UTF8);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            String main = "", drinking = "";

            foreach (Control c in panel1.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox chk = (CheckBox)c;
                    if (chk.Checked)
                    {
                        main += chk.Text+" ";
                    }
                }
            }
            foreach (Control c in panel2.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox chk = (CheckBox)c;
                    if (chk.Checked)
                    {
                        drinking+= chk.Text+" ";
                       
                    }
                }
            }
            main=main.Remove(main.Length-1, 1);
            drinking=drinking.Remove(drinking.Length-1, 1);
            DateTime currentDateTime = DateTime.Now;
            String orderTime = currentDateTime.ToString("yyyy/MM/dd HH:mm:ss");

            File.AppendAllText("OrderData.csv", orderTime+","+main+","+drinking+"\n");
            // MessageBox.Show("Host:"+main+ "\nDrinks:"+drinking+"\nSide dishes:"+s
            MessageBox.Show("Host:"+main+ "\nDrinks:"+drinking);
        }
    }
}
