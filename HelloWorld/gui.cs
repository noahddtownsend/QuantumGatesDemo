using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quantum.Gates
{
    public partial class Gui : Form
    {
        public Gui()
        {
            InitializeComponent();
        }

        private void runSimClick(object sender, EventArgs e)
        {
            int i = Quantum.SuperdenseCoding.Driver.HadamardGate();
            resultLabel.Text = $"The gate returned {i, -4}";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
