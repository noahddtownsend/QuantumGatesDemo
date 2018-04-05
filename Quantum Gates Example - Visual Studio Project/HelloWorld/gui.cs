using System;
using System.Drawing;
using System.Windows.Forms;


namespace Quantum.Gates
{


    enum QuantumGates : int
    {
        Hadamard = 0,
        NOT = 1,
        CNOT = 2
    }

    enum ClassicalGates : int
    {
        OR = 0,
        AND = 1,
        NOT = 2
    }



    public partial class Gui : Form
    {
        private BitStates firstBitState = BitStates.Zero;
        private BitStates secondBitState = BitStates.Zero;

        private IOBit firstInputBit;
        private IOBit secondInputBit;
        private IOBit firstOutputBit;
        private IOBit secondOutputBit;

        private Point singleInputLocation;
        private Point dualInputLocation;
        private Point singleOutputLocation;
        private Point dualOutputLocation;

        public Gui()
        {
            InitializeComponent();


            singleInputLocation = new Point(firstInputBitBtn.Location.X, firstInputBitBtn.Location.Y + (int)(firstInputBitBtn.Height * 0.75));
            dualInputLocation = new Point(firstInputBitBtn.Location.X, firstInputBitBtn.Location.Y);
            singleOutputLocation = new Point(firstOutputBitBtn.Location.X, singleInputLocation.Y);
            dualOutputLocation = new Point(firstOutputBitBtn.Location.X, firstOutputBitBtn.Location.Y);

            firstInputBit = new IOBit(firstInputBitBtn);
            secondInputBit = new IOBit(secondInputBitBtn);
            firstOutputBit = new IOBit(firstOutputBitBtn);
            secondOutputBit = new IOBit(secondOutputBitBtn);

            singleInputBitFactory();


            classicalDropDown.SelectedIndex = 0;
            quantumDropDown.SelectedIndex = 0;

            classicalDropDown.Enabled = false;
        }

        private void Evaluate()
        {
            new System.Threading.Thread(() =>
            {
                System.Threading.Thread.CurrentThread.IsBackground = true;

                int returnedValue = 0;
                int numEvals = 0;
                int numOnesFirstBit = 0;
                int numOnesSecondBit = 0;
                int index = 0;

                try
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        index = quantumDropDown.SelectedIndex;
                        numEvals = (int)numEvalsInput.Value;
                    });
                }
                catch (InvalidOperationException e)
                {
                    return;
                }

                if (quantumRadioButton.Checked)
                {
                    switch (index)
                    {
                        case (int)QuantumGates.Hadamard:
                            
                            for (int i = 0; i < numEvals; ++i)
                            {
                                returnedValue = Quantum.PublicGates.Driver.HadamardGate((int)firstInputBit.getBitState());
                                if (returnedValue == 1)
                                {
                                    ++numOnesFirstBit;
                                }
                            }

                            if (returnedValue == 0)
                            {
                                this.Invoke((MethodInvoker)delegate
                                {
                                    firstOutputBit.setBitStateZero();
                                });
                            }
                            else if (returnedValue == 1)
                            {
                                this.Invoke((MethodInvoker)delegate
                                {
                                    firstOutputBit.setBitStateOne();
                                });
                            }
                            this.Invoke((MethodInvoker)delegate
                            {
                                resultLabel.Text = $"The gate returned {numOnesFirstBit} |1> and {(numEvals - numOnesFirstBit)} |0>";
                            });
                            break;
                        case (int)QuantumGates.NOT:
                            for (int i = 0; i < numEvals; ++i)
                            {
                                returnedValue = Quantum.PublicGates.Driver.NotGate((int)firstInputBit.getBitState());
                                if (returnedValue == 1)
                                {
                                    ++numOnesFirstBit;
                                }
                            }
                            
                            if (returnedValue == 0)
                            {
                                this.Invoke((MethodInvoker)delegate
                                {
                                    firstOutputBit.setBitStateZero();
                                });
                            }
                            else if (returnedValue == 1)
                            {
                                this.Invoke((MethodInvoker)delegate
                                {
                                    firstOutputBit.setBitStateOne();
                                });
                            }
                            this.Invoke((MethodInvoker)delegate
                            {
                                resultLabel.Text = $"The gate returned {numOnesFirstBit} |1> and {(numEvals - numOnesFirstBit)} |0>";
                            });
                            break;
                        case (int)QuantumGates.CNOT:
                            Tuple<int, int> j = new Tuple<int, int>(0,0);

                            for (int i = 0; i < numEvals; ++i)
                            {
                                j = Quantum.PublicGates.Driver.CNotGate((int)firstInputBit.getBitState(), (int)secondInputBit.getBitState());
                                if (j.Item1 == 1)
                                {
                                    ++numOnesFirstBit;
                                }
                                
                                if (j.Item2 == 1)
                                {
                                    ++numOnesSecondBit;
                                }

                            }

                            
                             var (a, b) = j;

                            if (a == 0)
                            {
                                this.Invoke((MethodInvoker)delegate
                                {
                                    firstOutputBit.setBitStateZero();
                                });
                            }
                            else
                            {
                                this.Invoke((MethodInvoker)delegate
                                {
                                    firstOutputBit.setBitStateOne();
                                });
                            }

                            if (b == 0)
                            {
                                this.Invoke((MethodInvoker)delegate
                                {
                                    secondOutputBit.setBitStateZero();
                                });
                            }
                            else
                            {
                                this.Invoke((MethodInvoker)delegate
                                {
                                    secondOutputBit.setBitStateOne();
                                });
                            }

                            this.Invoke((MethodInvoker)delegate
                            {
                                resultLabel.Text = $"The gate returned {numOnesFirstBit} |1> and {(numEvals - numOnesFirstBit)} |0> the first bit and {numOnesSecondBit} |1> and {(numEvals - numOnesSecondBit)} |0> on the second bit";
                            });
                            break;
                    }
                }
                else
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        index = classicalDropDown.SelectedIndex;
                    });
                    switch (index)
                    {
                        case (int)ClassicalGates.OR:
                            if (firstInputBit.getBitState() == BitStates.One || secondInputBit.getBitState() == BitStates.One)
                            {
                                this.Invoke((MethodInvoker)delegate
                                {
                                    firstOutputBit.setBitStateOne();
                                });
                            }
                            else
                            {
                                this.Invoke((MethodInvoker)delegate
                                {
                                    firstOutputBit.setBitStateZero();
                                });
                            }
                            break;

                        case (int)ClassicalGates.AND:
                            if (firstInputBit.getBitState() == BitStates.One && secondInputBit.getBitState() == BitStates.One)
                            {
                                this.Invoke((MethodInvoker)delegate
                                {
                                    firstOutputBit.setBitStateOne();
                                });
                            }
                            else
                            {
                                this.Invoke((MethodInvoker)delegate
                                {
                                    firstOutputBit.setBitStateZero();
                                });
                            }
                            break;

                        case (int)ClassicalGates.NOT:
                            if (firstInputBit.getBitState() == BitStates.Zero)
                            {
                                this.Invoke((MethodInvoker)delegate
                                {
                                    firstOutputBit.setBitStateOne();
                                });
                            }
                            else
                            {
                                this.Invoke((MethodInvoker)delegate
                                {
                                    firstOutputBit.setBitStateZero();
                                });
                            }
                            break;
                    }
                }
            }).Start();
        }

        private void runSimClick(object sender, EventArgs e)
        {
            Evaluate();
        }

        private void quantumDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            quantumGateFactory();
        }

        private void quantumGateFactory()
        {
            switch (quantumDropDown.SelectedIndex)
            {
                case (int)QuantumGates.Hadamard:
                    gatePictureBox.Image = Properties.Resources.QuantumHadamardGate;
                    Evaluate();
                    singleInputBitFactory();
                    break;
                case (int)QuantumGates.NOT:
                    gatePictureBox.Image = Properties.Resources.QuantumNOTGate;
                    Evaluate();
                    singleInputBitFactory();
                    break;
                case (int)QuantumGates.CNOT:
                    gatePictureBox.Image = Properties.Resources.QuantumCNOTGate;
                    Evaluate();
                    dualIOBitFactory();
                    break;
                default:
                    gatePictureBox.Image = null;
                    break;
            }
        }

        private void firstBit_Paint(object sender, PaintEventArgs e)
        {

        }

        private void firstInputBit_Click(object sender, EventArgs e)
        {
            if (firstInputBit.getBitState() == BitStates.Zero)
            {
                firstInputBit.setBitStateOne();
            }
            else if (firstInputBit.getBitState() == BitStates.One && quantumRadioButton.Checked)
            {
                firstInputBit.setBitStateQuantum();
            }
            else
            {
                firstInputBit.setBitStateZero();
            }

            Evaluate();
        }

        private void secondInputBit_Click(object sender, EventArgs e)
        {

            if (secondInputBit.getBitState() == BitStates.Zero)
            {
                secondInputBit.setBitStateOne();
            }
            else if (secondInputBit.getBitState() == BitStates.One && quantumRadioButton.Checked)
            {
                secondInputBit.setBitStateQuantum();
            }
            else
            {
                secondInputBit.setBitStateZero();
            }

            Evaluate();
        }

        private void quantumRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (quantumRadioButton.Checked)
            {
                quantumDropDown.Enabled = true;
                numEvalsInput.Enabled = true;
                quantumGateFactory();
            }
            else
            {
                quantumDropDown.Enabled = false;
            }
        }

        private void classicalRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (classicalRadioButton.Checked)
            {
                classicalDropDown.Enabled = true;
                numEvalsInput.Enabled = false;
                classicalGateFactory();
            }
            else
            {
                classicalDropDown.Enabled = false;
            }

            if (firstInputBit.getBitState() == BitStates.QSuper)
            {
                firstInputBit.setBitStateZero();
            }

            if (secondInputBit.getBitState() == BitStates.QSuper)
            {
                secondInputBit.setBitStateZero();
            }
        }

        private void classicalDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            classicalGateFactory();
        }

        private void classicalGateFactory()
        {
            switch (classicalDropDown.SelectedIndex)
            {
                case (int)ClassicalGates.OR:
                    gatePictureBox.Image = Properties.Resources.ClassicalORGate;
                    Evaluate();
                    dualInputBitFactory();
                    break;

                case (int)ClassicalGates.AND:
                    gatePictureBox.Image = Properties.Resources.ClassicalANDGate;
                    Evaluate();
                    dualInputBitFactory();
                    break;

                case (int)ClassicalGates.NOT:
                    gatePictureBox.Image = Properties.Resources.ClassicalNOTGate;
                    Evaluate();
                    singleInputBitFactory();
                    break;
                default:
                    gatePictureBox.Image = null;
                    break;

            }
        }

        private void singleInputBitFactory()
        {
            secondInputBitBtn.Visible = false;
            secondOutputBitBtn.Visible = false;
            firstInputBitBtn.Location = singleInputLocation;
            firstOutputBitBtn.Location = singleOutputLocation;
        }

        private void dualInputBitFactory()
        {
            secondInputBitBtn.Visible = true;
            secondOutputBitBtn.Visible = false;
            firstInputBitBtn.Location = dualInputLocation;
            firstOutputBitBtn.Location = singleOutputLocation;
        }

        private void dualIOBitFactory()
        {
            secondInputBitBtn.Visible = true;
            secondOutputBitBtn.Visible = true;
            firstInputBitBtn.Location = dualInputLocation;
            firstOutputBitBtn.Location = dualOutputLocation;
        }



    }
}
