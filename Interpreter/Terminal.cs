using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interpreter
{
    public partial class Terminal : Form
    {
        public Terminal()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            Console.ReadOnly = true;
        }
        public void UpdateValue(string Output)
        {
            Console.Text = Console.Text + Output;
        }
    }
}
