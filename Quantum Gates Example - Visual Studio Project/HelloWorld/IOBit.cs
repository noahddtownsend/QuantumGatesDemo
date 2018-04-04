using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public IOBit(Button visualRep)
        {
            this.visualRep = visualRep;
            this.visualRep.FlatStyle = FlatStyle.Flat;
            setBitStateZero();
            
        }

        public void setBitStateZero()
        {
            bitState = BitStates.Zero;
            visualRep.BackColor = ZERO_COLOR;
            visualRep.Text = "0";
        }

        public void setBitStateOne()
        {
            bitState = BitStates.One;
            visualRep.BackColor = ONE_COLOR;
            visualRep.Text = "1";
        }

        public void setBitStateQuantum()
        {
            bitState = BitStates.QSuper;
            visualRep.BackColor = QUANTUM_COLOR;
            visualRep.Text = "Quantum";
        }

        public BitStates getBitState()
        {
            return bitState;
        }
        

    }
}
