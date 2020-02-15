using System.Drawing;
using System.Windows.Forms;

namespace Quantum.Gates
{
    enum BitStates : byte
    {
        Zero = 0,
        One = 1,
        QSuper = 2
    }

    class IOBit
    {
        private Color ZERO_COLOR = Color.FromArgb(255, 100, 100, 100);
        private Color ONE_COLOR = Color.FromArgb(255, 255, 0, 0);
        private Color QUANTUM_COLOR = Color.FromArgb(255, 200, 0, 125);

        public Button visualRep;
        private BitStates bitState;

        private Font normalFont = new Font("Microsoft Sans", 10);
        private Font smallFont = new Font("Microsoft Sans", 6);

        public IOBit(Button visualRep, bool isQuantum)
        {
            this.visualRep = visualRep;
            this.visualRep.FlatStyle = FlatStyle.Flat;
            SetBitStateZero(isQuantum);
            
        }

        public void SetBitStateZero(bool isQuantum)
        {
            bitState = BitStates.Zero;
            visualRep.BackColor = ZERO_COLOR;
            if (isQuantum)
            {
                visualRep.Text = "|0>";
            } else
            {
                visualRep.Text = "0";
            }
            visualRep.Font = normalFont;
        }

        public void SetBitStateOne(bool isQuantum)
        {
            bitState = BitStates.One;
            visualRep.BackColor = ONE_COLOR;
            if (isQuantum)
            {
                visualRep.Text = "|1>";
            }
            else
            {
                visualRep.Text = "1";
            }
            visualRep.Font = normalFont;
        }

        public void SetBitStateQuantum()
        {
            bitState = BitStates.QSuper;
            visualRep.BackColor = QUANTUM_COLOR;
            visualRep.Text = "Quantum Superposition";
            visualRep.Font = smallFont;
        }

        public BitStates GetBitState()
        {
            return bitState;
        }
        

    }
}
