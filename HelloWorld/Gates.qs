
namespace Quantum.SuperdenseCoding
{
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;


	operation Hadamard () : (Int)
    {
        body
        {
			mutable result = 0;

			using (qubits = Qubit[1]) 
			{				
				Quantum.Core.Set (Zero, qubits[0]);
				
				H (qubits[0]);
				H (qubits[0]);
				H (qubits[0]);
				H (qubits[0]);
				H (qubits[0]);
				H (qubits[0]);
				H (qubits[0]);
				H (qubits[0]);
				H (qubits[0]);
				H (qubits[0]);
				H (qubits[0]);

				set result = Quantum.Core.MeasureToInt(qubits[0]);

				Quantum.Core.Set (Zero, qubits[0]);
			}

			return (result);
        }
    }
}