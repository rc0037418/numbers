using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace numbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            double pi = 3.1415926589793;
            double c = 299792458;
            richTextBox1.AppendText(pi.ToString("0.000") + "\n");
            richTextBox1.AppendText(pi.ToString("0.00000") + "\n");
            richTextBox1.AppendText(pi.ToString("0.000000000000000") + "\n");
            richTextBox1.AppendText(c.ToString() + "\n");
            richTextBox1.AppendText(c.ToString("N3") + "\n");
            richTextBox1.AppendText(c.ToString("0.000000000000000") + "\n");
            richTextBox1.AppendText(c.ToString("0.000") + "\n");
        }
    }
}
