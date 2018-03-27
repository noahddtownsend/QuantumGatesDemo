namespace Quantum.Core 
{

    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;

    // sets the qubit to the desiered state (|0> or |1>)
    operation Set (desired: Result, q1: Qubit) : ()
    {
        body
        {
			// M measures the current state of the qubit
            let current = M(q1);

			if (desired != current) 
			{
				// flips the qubit about the x-axis (i.e. |0> -> |1>)
				X(q1);
			}
        }
    }

	// This is a Bell gate
	operation Bell (x : Qubit, y : Qubit) : ()
	{
		body 
		{
			H (x);
			CNOT (x, y);
		}
	}

	// This is the inverse of a Bell gate
	operation InverseBell (x : Qubit, y : Qubit) : ()
	{
		body 
		{
			CNOT (x, y);
			H (x);
		}
	}

	operation SD (qubit : Qubit, x : Int, y : Int) : () 
	{
		body 
		{
			if (x == 0) 
			{
				if (y == 1)
				{
					X (qubit);
				}
			} else 
			{
				if (y == 0) {
					Z (qubit);
				} else
				{
					Y (qubit);
				}
			}
		}
	}

	// One is not the same as the integer 1, and there is no direct conversion between them. The same is true for Zero and 0
	// This function returns the integer equivalent to the measured value of a qubit
	operation MeasureToInt (qubit : Qubit) : (Int)
	{
		body 
		{
			mutable toReturn = 0;
			
			if (M (qubit) == One) 
			{
				set toReturn = 1;
			}

			return toReturn;
		}
	}
}
