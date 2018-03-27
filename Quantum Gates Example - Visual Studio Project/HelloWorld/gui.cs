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
            int i = 0;

            if (quantumRadioButton.Checked)
            {

                switch (quantumDropDown.SelectedIndex)
                {
                    case 0:
                        i = Quantum.PublicGates.Driver.HadamardGate();
                        resultLabel.Text = $"The gate returned {i,-4}";
                        break;
                    case 1:
                        i = Quantum.PublicGates.Driver.NotGate(2);
                        resultLabel.Text = $"The gate returned {i,-4}";
                        break;
                    case 2:
                        var j = Quantum.PublicGates.Driver.CNotGate(0, 1);
                        var (a, b) = j;
                        resultLabel.Text = $"The gate returned {a}, {b,-4}";
                        break;
                }
            } else
            {
                switch (classicalDropDown.SelectedIndex)
                {
                    case 0:
                        resultLabel.Text = $"The gate returned 0";
                        break;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
