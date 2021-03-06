﻿
namespace Quantum.PublicGates
{
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;


	operation Hadamard (i : Int) : (Int)
    {
        body
        {
			mutable result = 0;

			using (qubits = Qubit[1]) 
			{				
				if (i != 2) 
				{
					if (i == 0) {
						Quantum.Core.Set (Zero, qubits[0]);
					}
					else {
						Quantum.Core.Set (One, qubits[0]);
					}					
				} 
				
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

	operation NOT (i: Int) : (Int)
    {
        body
        {
			mutable result = 0;

			using (qubits = Qubit[1]) 
			{	
			
				if (i != 2) 
				{
					if (i == 0) {
						Quantum.Core.Set (Zero, qubits[0]);
					}
					else {
						Quantum.Core.Set (One, qubits[0]);
					}		
				} 
				else 
				{
					H (qubits[0]);
				}
				
				X (qubits[0]);

				set result = Quantum.Core.MeasureToInt(qubits[0]);

				Quantum.Core.Set (Zero, qubits[0]);
			}

			return (result);
        }
    }

	operation CUST_CNOT (x: Int, y: Int) : (Int, Int)
    {
        body
        {
			mutable xResult = 0;
			mutable yResult = 0;

			using (qubits = Qubit[2]) 
			{	
			
				if (x != 2) {
					if (x == 0) {
						Quantum.Core.Set (Zero, qubits[0]);
					}
					else {
						Quantum.Core.Set (One, qubits[0]);
					}		
				} else {
					H (qubits[0]);
				}

				if (y != 2) {
					if (y == 0) {
						Quantum.Core.Set (Zero, qubits[1]);
					}
					else {
						Quantum.Core.Set (One, qubits[1]);
					}		
				} else {
					H (qubits[1]);
				}
				
				CNOT (qubits[0], qubits[1]);

				set xResult = Quantum.Core.MeasureToInt(qubits[0]);
				set yResult = Quantum.Core.MeasureToInt(qubits[1]);

				Quantum.Core.Set (Zero, qubits[0]);
				Quantum.Core.Set (Zero, qubits[1]);
			}

			return (xResult, yResult);
        }
    }
}