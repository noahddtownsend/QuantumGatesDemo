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
        private IOBit firstInputBit;
        private IOBit secondInputBit;
        private IOBit firstOutputBit;
        private IOBit secondOutputBit;

        private Point singleInputLocation;
        private Point dualInputLocation;
        private Point singleOutputLocation;
        private Point dualOutputLocation;

        public String[] HADAMARD_DESC = { "The Quantum Hadamard gate rotates the qubit ", "π", " about the X-axis and ", "π", "/2 about the Y-axis.\nThis results in an equal chance that the qubit will be a |1> or a |0> when measured." };
        public String[] QNOT_DESC = { "The Quantum NOT gate will invert the qubit to the opposite of its current classical value.\nThis is done by rotating the qubit by ", "π", " about the X-axis." };
        public String CNOT_DESC = "The CNOT gate will invert the second (bottom) qubit to the opposite of its current classical value\nif the control (top) qubit is measured to be a |1>";
        public String OR_DESC = "The OR gate will output a 1 if either of its input bits are a 1";
        public String AND_DESC = "The AND gate will output a 1 if both of its input bits are a 1";
        public String CLASS_NOT_DESC = "The classical NOT will invert the current state of its input bit";

        public Gui()
        {
            InitializeComponent();

            AcceptButton = RunGateSim;

            MaximizeBox = false;

            singleInputLocation = new Point(firstInputBitBtn.Location.X, firstInputBitBtn.Location.Y + (int)(firstInputBitBtn.Height * 0.75));
            dualInputLocation = new Point(firstInputBitBtn.Location.X, firstInputBitBtn.Location.Y);
            singleOutputLocation = new Point(firstOutputBitBtn.Location.X, singleInputLocation.Y);
            dualOutputLocation = new Point(firstOutputBitBtn.Location.X, firstOutputBitBtn.Location.Y);

            firstInputBit = new IOBit(firstInputBitBtn, quantumRadioButton.Checked);
            secondInputBit = new IOBit(secondInputBitBtn, quantumRadioButton.Checked);
            firstOutputBit = new IOBit(firstOutputBitBtn, quantumRadioButton.Checked);
            secondOutputBit = new IOBit(secondOutputBitBtn, quantumRadioButton.Checked);

            SingleInputBitFactory();


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
                                returnedValue = Quantum.PublicGates.Driver.HadamardGate((int)firstInputBit.GetBitState());
                                if (returnedValue == 1)
                                {
                                    ++numOnesFirstBit;
                                }
                            }

                            if (returnedValue == 0)
                            {
                                this.Invoke((MethodInvoker)delegate
                                {
                                    firstOutputBit.SetBitStateZero(true);
                                });
                            }
                            else if (returnedValue == 1)
                            {
                                this.Invoke((MethodInvoker)delegate
                                {
                                    firstOutputBit.SetBitStateOne(true);
                                });
                            }
                            this.Invoke((MethodInvoker)delegate
                            {
                                resultLabel.Text = $"The gate returned {numOnesFirstBit} |1>s and {(numEvals - numOnesFirstBit)} |0>s";
                            });
                            break;
                        case (int)QuantumGates.NOT:
                            for (int i = 0; i < numEvals; ++i)
                            {
                                returnedValue = Quantum.PublicGates.Driver.NotGate((int)firstInputBit.GetBitState());
                                if (returnedValue == 1)
                                {
                                    ++numOnesFirstBit;
                                }
                            }
                            
                            if (returnedValue == 0)
                            {
                                this.Invoke((MethodInvoker)delegate
                                {
                                    firstOutputBit.SetBitStateZero(true);
                                });
                            }
                            else if (returnedValue == 1)
                            {
                                this.Invoke((MethodInvoker)delegate
                                {
                                    firstOutputBit.SetBitStateOne(true);
                                });
                            }
                            this.Invoke((MethodInvoker)delegate
                            {
                                resultLabel.Text = $"The gate returned {numOnesFirstBit} |1>s and {(numEvals - numOnesFirstBit)} |0>s";
                            });
                            break;
                        case (int)QuantumGates.CNOT:
                            Tuple<int, int> j = new Tuple<int, int>(0,0);

                            for (int i = 0; i < numEvals; ++i)
                            {
                                j = Quantum.PublicGates.Driver.CNotGate((int)firstInputBit.GetBitState(), (int)secondInputBit.GetBitState());
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
                                    firstOutputBit.SetBitStateZero(true);
                                });
                            }
                            else
                            {
                                this.Invoke((MethodInvoker)delegate
                                {
                                    firstOutputBit.SetBitStateOne(true);
                                });
                            }

                            if (b == 0)
                            {
                                this.Invoke((MethodInvoker)delegate
                                {
                                    secondOutputBit.SetBitStateZero(true);
                                });
                            }
                            else
                            {
                                this.Invoke((MethodInvoker)delegate
                                {
                                    secondOutputBit.SetBitStateOne(true);
                                });
                            }

                            this.Invoke((MethodInvoker)delegate
                            {
                                resultLabel.Text = $"The gate returned {numOnesFirstBit} |1>s and {(numEvals - numOnesFirstBit)} |0>s the first bit and {numOnesSecondBit} |1>s and {(numEvals - numOnesSecondBit)} |0>s on the second bit";
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
                            if (firstInputBit.GetBitState() == BitStates.One || secondInputBit.GetBitState() == BitStates.One)
                            {
                                this.Invoke((MethodInvoker)delegate
                                {
                                    firstOutputBit.SetBitStateOne(false);
                                    resultLabel.Text = $"The gate returned a 1";
                                });
                            }
                            else
                            {
                                this.Invoke((MethodInvoker)delegate
                                {
                                    firstOutputBit.SetBitStateZero(false);
                                    resultLabel.Text = $"The gate returned a 0";
                                });
                            }

                            

                            break;

                        case (int)ClassicalGates.AND:
                            if (firstInputBit.GetBitState() == BitStates.One && secondInputBit.GetBitState() == BitStates.One)
                            {
                                this.Invoke((MethodInvoker)delegate
                                {
                                    firstOutputBit.SetBitStateOne(false);
                                    resultLabel.Text = $"The gate returned a 1";
                                });
                            }
                            else
                            {
                                this.Invoke((MethodInvoker)delegate
                                {
                                    firstOutputBit.SetBitStateZero(false);
                                    resultLabel.Text = $"The gate returned a 0";
                                });
                            }
                            break;

                        case (int)ClassicalGates.NOT:
                            if (firstInputBit.GetBitState() == BitStates.Zero)
                            {
                                this.Invoke((MethodInvoker)delegate
                                {
                                    firstOutputBit.SetBitStateOne(false);
                                    resultLabel.Text = $"The gate returned a 1";
                                });
                            }
                            else
                            {
                                this.Invoke((MethodInvoker)delegate
                                {
                                    firstOutputBit.SetBitStateZero(false);
                                    resultLabel.Text = $"The gate returned a 0";
                                });
                            }
                            break;
                    }
                }
            }).Start();
        }

        private void RunSimClick(object sender, EventArgs e)
        {
            Evaluate();
        }

        private void QuantumDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            QuantumGateFactory();
        }

        private void QuantumGateFactory()
        {

            descriptionLabel.ResetText();
            descriptionLabel.SelectionAlignment = HorizontalAlignment.Left;

            switch (quantumDropDown.SelectedIndex)
            {
                case (int)QuantumGates.Hadamard:
                    gatePictureBox.Image = Properties.Resources.QuantumHadamardGate;
                    
                    descriptionLabel.AppendText(HADAMARD_DESC[0]);
                    descriptionLabel.SelectionFont = new Font("Times New Roman", 12);
                    descriptionLabel.AppendText(HADAMARD_DESC[1]);
                    descriptionLabel.SelectionFont = new Font("Microsoft Sans", 10);
                    descriptionLabel.AppendText(HADAMARD_DESC[2]);
                    descriptionLabel.SelectionFont = new Font("Times New Roman", 12);
                    descriptionLabel.AppendText(HADAMARD_DESC[3]);
                    descriptionLabel.SelectionFont = new Font("Microsoft Sans", 10);
                    descriptionLabel.AppendText(HADAMARD_DESC[4]);

                    Evaluate();
                    SingleInputBitFactory();
                    break;
                case (int)QuantumGates.NOT:
                    gatePictureBox.Image = Properties.Resources.QuantumNOTGate;

                    descriptionLabel.AppendText(QNOT_DESC[0]);
                    descriptionLabel.SelectionFont = new Font("Times New Roman", 12);
                    descriptionLabel.AppendText(QNOT_DESC[1]);
                    descriptionLabel.SelectionFont = new Font("Microsoft Sans", 10);
                    descriptionLabel.AppendText(QNOT_DESC[2]);

                    Evaluate();
                    SingleInputBitFactory();
                    break;
                case (int)QuantumGates.CNOT:
                    gatePictureBox.Image = Properties.Resources.QuantumCNOTGate;

                    descriptionLabel.AppendText(CNOT_DESC);

                    Evaluate();
                    DualIOBitFactory();
                    break;
                default:
                    descriptionLabel.ResetText();
                    gatePictureBox.Image = null;
                    break;
            }
        }



        private void FirstInputBit_Click(object sender, EventArgs e)
        {
            switch (firstInputBit.GetBitState())
            {
                case BitStates.Zero:
                    firstInputBit.SetBitStateOne(quantumRadioButton.Checked);
                    break;
                case BitStates.One:
                    if (quantumRadioButton.Checked)
                    {
                        firstInputBit.SetBitStateQuantum();
                        break;
                    }

                    goto default;
                default:
                    firstInputBit.SetBitStateZero(quantumRadioButton.Checked);
                    break;
            }

            Evaluate();
        }

        private void SecondInputBit_Click(object sender, EventArgs e)
        {

            switch (secondInputBit.GetBitState())
            {
                case BitStates.Zero:
                    secondInputBit.SetBitStateOne(quantumRadioButton.Checked);
                    break;
                case BitStates.One:
                    if (quantumRadioButton.Checked)
                    {
                        secondInputBit.SetBitStateQuantum();
                        break;
                    }

                    goto default;
                default:
                    secondInputBit.SetBitStateZero(quantumRadioButton.Checked);
                    break;
            }

            Evaluate();
        }

        private void QuantumRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (quantumRadioButton.Checked)
            {
                quantumDropDown.Enabled = true;
                numEvalsInput.Enabled = true;
                QuantumGateFactory();
            }
            else
            {
                quantumDropDown.Enabled = false;
            }

            firstInputBit.SetBitStateZero(true);
            secondInputBit.SetBitStateZero(true);

            Evaluate();
        }

        private void ClassicalRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (classicalRadioButton.Checked)
            {
                classicalDropDown.Enabled = true;
                numEvalsInput.Enabled = false;
                ClassicalGateFactory();
            }
            else
            {
                classicalDropDown.Enabled = false;
            }

            
            firstInputBit.SetBitStateZero(false);
            secondInputBit.SetBitStateZero(false);

            Evaluate();
        }

        private void ClassicalDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClassicalGateFactory();
        }

        private void ClassicalGateFactory()
        {
            descriptionLabel.ResetText();
            descriptionLabel.SelectionAlignment = HorizontalAlignment.Center;

            switch (classicalDropDown.SelectedIndex)
            {
                case (int)ClassicalGates.OR:
                    gatePictureBox.Image = Properties.Resources.ClassicalORGate;

                    descriptionLabel.AppendText(OR_DESC);

                    DualInputBitFactory();
                    break;

                case (int)ClassicalGates.AND:
                    gatePictureBox.Image = Properties.Resources.ClassicalANDGate;

                    descriptionLabel.AppendText(AND_DESC);

                    DualInputBitFactory();
                    break;

                case (int)ClassicalGates.NOT:
                    gatePictureBox.Image = Properties.Resources.ClassicalNOTGate;

                    descriptionLabel.AppendText(CLASS_NOT_DESC);

                    SingleInputBitFactory();
                    break;
                default:
                    gatePictureBox.Image = null;
                    break;

            }

            Evaluate();
        }

        private void SingleInputBitFactory()
        {
            secondInputBitBtn.Visible = false;
            secondOutputBitBtn.Visible = false;
            firstInputBitBtn.Location = singleInputLocation;
            firstOutputBitBtn.Location = singleOutputLocation;
        }

        private void DualInputBitFactory()
        {
            secondInputBitBtn.Visible = true;
            secondOutputBitBtn.Visible = false;
            firstInputBitBtn.Location = dualInputLocation;
            firstOutputBitBtn.Location = singleOutputLocation;
        }

        private void DualIOBitFactory()
        {
            secondInputBitBtn.Visible = true;
            secondOutputBitBtn.Visible = true;
            firstInputBitBtn.Location = dualInputLocation;
            firstOutputBitBtn.Location = dualOutputLocation;
        }



    }
}
