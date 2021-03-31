using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWinfrom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button(object sender, EventArgs e)
        {
            if(sender.Equals(button1))
            {
                MessageBox.Show("첫 번재 버튼 와우!");
            }
            else
            {
                MessageBox.Show("첫 번재 버튼 와우!");
            }
        }
    }
}
