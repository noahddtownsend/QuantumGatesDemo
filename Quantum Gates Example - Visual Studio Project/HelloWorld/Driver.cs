using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;
using System;

namespace Quantum.PublicGates
{
    class Driver
    {
        public static int HadamardGate ()
        {
            // create the quantum computer simulator
            using (var sim = new QuantumSimulator())
            {
                var res = Hadamard.Run(sim).Result;

                return (int) res;
            }
        }

        public static int NotGate(int i)
        {
            // create the quantum computer simulator
            using (var sim = new QuantumSimulator())
            {
                var res = NOT.Run(sim, i).Result;

                return (int) res;
            }
        }

        public static Tuple<int, int> CNotGate(int x, int y)
        {
            // create the quantum computer simulator
            using (var sim = new QuantumSimulator())
            {
                var res = CUST_CNOT.Run(sim, x, y).Result;

                var (a, b) = res;

                return new Tuple<int, int>((int)a, (int) b);
            }
        }
    }
}