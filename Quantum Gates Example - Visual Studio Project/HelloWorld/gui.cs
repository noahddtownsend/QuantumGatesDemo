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
    enum BitStates : byte {
        Zero = 0,
        One = 1,
        QSuper = 2
    }


    public partial class Gui : Form
    {
        private BitStates firstBitState = BitStates.Zero;
        private BitStates secondBitState = BitStates.Zero;

        public Gui()
        {
            InitializeComponent();

            firstBit.FlatStyle = FlatStyle.Flat;
            secondBit.FlatStyle = FlatStyle.Flat;

            firstBit.BackColor = Color.FromArgb(255, 100, 100, 100);
            firstBit.Text = "0";
            secondBit.BackColor = Color.FromArgb(255, 100, 100, 100);
            secondBit.Text = "0";

            classicalDropDown.Enabled = false;
        }

        private void evaluate()
        {
            int i = 0;

            if (quantumRadioButton.Checked)
            {

                switch (quantumDropDown.SelectedIndex)
                {
                    case 0:
                        i = Quantum.PublicGates.Driver.HadamardGate();
                        if (i == 0)
                        {
                            outputBit.BackColor = Color.FromArgb(255, 100, 100, 100);
                            outputBit.Text = "0";
                        } else if (i == 1)
                        {
                            outputBit.BackColor = Color.FromArgb(255, 255, 0, 0);
                            outputBit.Text = "1";
                        }
                        resultLabel.Text = $"The gate returned {i,-4}";
                        break;
                    case 1:
                        i = Quantum.PublicGates.Driver.NotGate((int)firstBitState);
                        if (i == 0)
                        {
                            outputBit.BackColor = Color.FromArgb(255, 100, 100, 100);
                            outputBit.Text = "0";
                        }
                        else if (i == 1)
                        {
                            outputBit.BackColor = Color.FromArgb(255, 255, 0, 0);
                            outputBit.Text = "1";
                        }
                        resultLabel.Text = $"The gate returned {i,-4}";
                        break;
                    case 2:
                        var j = Quantum.PublicGates.Driver.CNotGate((int)firstBitState, (int)secondBitState);
                        var (a, b) = j;
                        resultLabel.Text = $"The gate returned {a}, {b,-4}";
                        break;
                }
            }
            else
            {
                switch (classicalDropDown.SelectedIndex)
                {
                    case 0:
                        resultLabel.Text = $"The gate returned 0";
                        break;
                }
            }
        }

        private void runSimClick(object sender, EventArgs e)
        {
            evaluate();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void firstBit_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void firstBit_Click(object sender, EventArgs e)
        {
            if (firstBitState == BitStates.Zero)
            {
                ++firstBitState;
                firstBit.BackColor = Color.FromArgb(255, 255, 0, 0);
                firstBit.Text = "1";
            }
            else if (firstBitState == BitStates.One && quantumRadioButton.Checked)
            {
                ++firstBitState;
                firstBit.BackColor = Color.FromArgb(255, 200, 0, 125);
                firstBit.Text = "Quantum";
            }
            else
            {
                firstBitState = BitStates.Zero;
                firstBit.BackColor = Color.FromArgb(255, 100, 100, 100);
                firstBit.Text = "0";
            }

            evaluate();
        }

        private void secondBit_Click(object sender, EventArgs e)
        {
            
            if (secondBitState == BitStates.Zero)
            {
                ++secondBitState;
                secondBit.BackColor = Color.FromArgb(255, 255, 0, 0);
                secondBit.Text = "1";
            }
            else if (secondBitState == BitStates.One && quantumRadioButton.Checked)
            {
                ++secondBitState;
                secondBit.BackColor = Color.FromArgb(255, 200, 0, 125);
                secondBit.Text = "Quantum";
            }
            else
            {
                secondBitState = BitStates.Zero;
                secondBit.BackColor = Color.FromArgb(255, 100, 100, 100);
                secondBit.Text = "0";
            }

            evaluate();
        }

        private void quantumRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (quantumRadioButton.Checked)
            {
                quantumDropDown.Enabled = true;
            } else
            {
                quantumDropDown.Enabled = false;
            }
        }

        private void classicalRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (classicalRadioButton.Checked)
            {
                classicalDropDown.Enabled = true;
            }
            else
            {
                classicalDropDown.Enabled = false;
            }

            if (firstBitState == BitStates.QSuper)
            {
                firstBitState = BitStates.Zero;
                firstBit.BackColor = Color.FromArgb(255, 100, 100, 100);
                firstBit.Text = "0";
            }

            if (secondBitState == BitStates.QSuper)
            {
                secondBitState = BitStates.Zero;
                secondBit.BackColor = Color.FromArgb(255, 100, 100, 100);
                secondBit.Text = "0";
            }
        }
    } 
}
