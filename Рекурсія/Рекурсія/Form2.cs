using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Рекурсія
{
    public partial class Form2 : Form
    {
        Form1 fr1;
        public Form2()
        {
            InitializeComponent();
            fr1 = new Form1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int N = Convert.ToInt32(textBox1.Text);
            fr1.Show();
        }
    }
}
