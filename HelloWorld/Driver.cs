using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace Quantum.SuperdenseCoding
{
    class Driver
    {
        public static int HadamardGate ()
        {
            // create the quantum computer simulator
            using (var sim = new QuantumSimulator())
            {
                var res = Hadamard.Run(sim).Result;
                System.Console.WriteLine($"Result: {res, -4}");

                return (int) res;
            }

            return -2;
        }
    }
}