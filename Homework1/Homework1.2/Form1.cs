using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void elementHost1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    textBox3.Text = Convert.ToString(Int32.Parse(textBox1.Text) + Int32.Parse(textBox2.Text));
                    break;
                case 1:
                    textBox3.Text = Convert.ToString(Int32.Parse(textBox1.Text) - Int32.Parse(textBox2.Text));
                    break;
                case 2:
                    if (textBox2.Text == "0") { textBox3.Text = "除数不能为0";break ; }
                    textBox3.Text = Convert.ToString(Int32.Parse(textBox1.Text) * Int32.Parse(textBox2.Text));
                    break;
                case 3:
                    textBox3.Text = Convert.ToString(Int32.Parse(textBox1.Text) / Int32.Parse(textBox2.Text));
                    break;
                default:
                    break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
