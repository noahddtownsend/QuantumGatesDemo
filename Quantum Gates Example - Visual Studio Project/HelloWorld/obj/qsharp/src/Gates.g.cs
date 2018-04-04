#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Quantum.PublicGates", "Hadamard (i : Int) : Int", new string[] { }, "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs", 157L, 9L, 5L)]
[assembly: OperationDeclaration("Quantum.PublicGates", "NOT (i : Int) : Int", new string[] { }, "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs", 837L, 48L, 5L)]
[assembly: OperationDeclaration("Quantum.PublicGates", "CUST_CNOT (x : Int, y : Int) : (Int, Int)", new string[] { }, "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs", 1381L, 82L, 5L)]
#line hidden
namespace Quantum.PublicGates
{
    public class Hadamard : Operation<Int64, Int64>
    {
        public Hadamard(IOperationFactory m) : base(m)
        {
            this.Dependencies = new Type[] { typeof(Microsoft.Quantum.Primitive.Allocate), typeof(Microsoft.Quantum.Primitive.H), typeof(Quantum.Core.MeasureToInt), typeof(Microsoft.Quantum.Primitive.Release), typeof(Quantum.Core.Set) };
        }

        public override Type[] Dependencies
        {
            get;
        }

        protected Allocate Allocate
        {
            get
            {
                return this.Factory.Get<Allocate, Microsoft.Quantum.Primitive.Allocate>();
            }
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveH
        {
            get
            {
                return this.Factory.Get<IUnitary<Qubit>, Microsoft.Quantum.Primitive.H>();
            }
        }

        protected ICallable<Qubit, Int64> QuantumCoreMeasureToInt
        {
            get
            {
                return this.Factory.Get<ICallable<Qubit, Int64>, Quantum.Core.MeasureToInt>();
            }
        }

        protected Release Release
        {
            get
            {
                return this.Factory.Get<Release, Microsoft.Quantum.Primitive.Release>();
            }
        }

        protected ICallable<(Result,Qubit), QVoid> QuantumCoreSet
        {
            get
            {
                return this.Factory.Get<ICallable<(Result,Qubit), QVoid>, Quantum.Core.Set>();
            }
        }

        public override Func<Int64, Int64> Body
        {
            get => (i) =>
            {
#line hidden
                this.Factory.StartOperation("Quantum.PublicGates.Hadamard", OperationFunctor.Body, i);
                var __result__ = default(Int64);
                try
                {
#line 12 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                    var result = 0L;
#line 14 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                    var qubits = Allocate.Apply(1L);
#line 16 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                    if ((i != 2L))
                    {
#line 18 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                        if ((i == 0L))
                        {
#line 19 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                            QuantumCoreSet.Apply((Result.Zero, qubits[0L]));
                        }
                        else
                        {
#line 22 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                            QuantumCoreSet.Apply((Result.One, qubits[0L]));
                        }
                    }

#line 26 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                    MicrosoftQuantumPrimitiveH.Apply(qubits[0L]);
#line 27 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                    MicrosoftQuantumPrimitiveH.Apply(qubits[0L]);
#line 28 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                    MicrosoftQuantumPrimitiveH.Apply(qubits[0L]);
#line 29 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                    MicrosoftQuantumPrimitiveH.Apply(qubits[0L]);
#line 30 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                    MicrosoftQuantumPrimitiveH.Apply(qubits[0L]);
#line 31 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                    MicrosoftQuantumPrimitiveH.Apply(qubits[0L]);
#line 32 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                    MicrosoftQuantumPrimitiveH.Apply(qubits[0L]);
#line 33 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                    MicrosoftQuantumPrimitiveH.Apply(qubits[0L]);
#line 34 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                    MicrosoftQuantumPrimitiveH.Apply(qubits[0L]);
#line 35 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                    MicrosoftQuantumPrimitiveH.Apply(qubits[0L]);
#line 36 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                    MicrosoftQuantumPrimitiveH.Apply(qubits[0L]);
#line 38 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                    result = QuantumCoreMeasureToInt.Apply<Int64>(qubits[0L]);
#line 40 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                    QuantumCoreSet.Apply((Result.Zero, qubits[0L]));
#line hidden
                    Release.Apply(qubits);
#line hidden
                    __result__ = result;
#line 43 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                    return __result__;
                }
                finally
                {
#line hidden
                    this.Factory.EndOperation("Quantum.PublicGates.Hadamard", OperationFunctor.Body, __result__);
                }
            }

            ;
        }

        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, Int64 i)
        {
            return __m__.Run<Hadamard, Int64, Int64>(i);
        }
    }

    public class NOT : Operation<Int64, Int64>
    {
        public NOT(IOperationFactory m) : base(m)
        {
            this.Dependencies = new Type[] { typeof(Microsoft.Quantum.Primitive.Allocate), typeof(Microsoft.Quantum.Primitive.H), typeof(Quantum.Core.MeasureToInt), typeof(Microsoft.Quantum.Primitive.Release), typeof(Quantum.Core.Set), typeof(Microsoft.Quantum.Primitive.X) };
        }

        public override Type[] Dependencies
        {
            get;
        }

        protected Allocate Allocate
        {
            get
            {
                return this.Factory.Get<Allocate, Microsoft.Quantum.Primitive.Allocate>();
            }
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveH
        {
            get
            {
                return this.Factory.Get<IUnitary<Qubit>, Microsoft.Quantum.Primitive.H>();
            }
        }

        protected ICallable<Qubit, Int64> QuantumCoreMeasureToInt
        {
            get
            {
                return this.Factory.Get<ICallable<Qubit, Int64>, Quantum.Core.MeasureToInt>();
            }
        }

        protected Release Release
        {
            get
            {
                return this.Factory.Get<Release, Microsoft.Quantum.Primitive.Release>();
            }
        }

        protected ICallable<(Result,Qubit), QVoid> QuantumCoreSet
        {
            get
            {
                return this.Factory.Get<ICallable<(Result,Qubit), QVoid>, Quantum.Core.Set>();
            }
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get
            {
                return this.Factory.Get<IUnitary<Qubit>, Microsoft.Quantum.Primitive.X>();
            }
        }

        public override Func<Int64, Int64> Body
        {
            get => (i) =>
            {
#line hidden
                this.Factory.StartOperation("Quantum.PublicGates.NOT", OperationFunctor.Body, i);
                var __result__ = default(Int64);
                try
                {
#line 51 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                    var result = 0L;
#line 53 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                    var qubits = Allocate.Apply(1L);
#line 56 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                    if ((i != 2L))
                    {
#line 58 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                        if ((i == 0L))
                        {
#line 59 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                            QuantumCoreSet.Apply((Result.Zero, qubits[0L]));
                        }
                        else
                        {
#line 62 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                            QuantumCoreSet.Apply((Result.One, qubits[0L]));
                        }
                    }
                    else
                    {
#line 67 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                        MicrosoftQuantumPrimitiveH.Apply(qubits[0L]);
                    }

#line 70 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                    MicrosoftQuantumPrimitiveX.Apply(qubits[0L]);
#line 72 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                    result = QuantumCoreMeasureToInt.Apply<Int64>(qubits[0L]);
#line 74 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                    QuantumCoreSet.Apply((Result.Zero, qubits[0L]));
#line hidden
                    Release.Apply(qubits);
#line hidden
                    __result__ = result;
#line 77 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                    return __result__;
                }
                finally
                {
#line hidden
                    this.Factory.EndOperation("Quantum.PublicGates.NOT", OperationFunctor.Body, __result__);
                }
            }

            ;
        }

        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, Int64 i)
        {
            return __m__.Run<NOT, Int64, Int64>(i);
        }
    }

    public class CUST_CNOT : Operation<(Int64,Int64), (Int64,Int64)>
    {
        public CUST_CNOT(IOperationFactory m) : base(m)
        {
            this.Dependencies = new Type[] { typeof(Microsoft.Quantum.Primitive.Allocate), typeof(Microsoft.Quantum.Primitive.CNOT), typeof(Microsoft.Quantum.Primitive.H), typeof(Quantum.Core.MeasureToInt), typeof(Microsoft.Quantum.Primitive.Release), typeof(Quantum.Core.Set) };
        }

        public override Type[] Dependencies
        {
            get;
        }

        protected Allocate Allocate
        {
            get
            {
                return this.Factory.Get<Allocate, Microsoft.Quantum.Primitive.Allocate>();
            }
        }

        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumPrimitiveCNOT
        {
            get
            {
                return this.Factory.Get<IUnitary<(Qubit,Qubit)>, Microsoft.Quantum.Primitive.CNOT>();
            }
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveH
        {
            get
            {
                return this.Factory.Get<IUnitary<Qubit>, Microsoft.Quantum.Primitive.H>();
            }
        }

        protected ICallable<Qubit, Int64> QuantumCoreMeasureToInt
        {
            get
            {
                return this.Factory.Get<ICallable<Qubit, Int64>, Quantum.Core.MeasureToInt>();
            }
        }

        protected Release Release
        {
            get
            {
                return this.Factory.Get<Release, Microsoft.Quantum.Primitive.Release>();
            }
        }

        protected ICallable<(Result,Qubit), QVoid> QuantumCoreSet
        {
            get
            {
                return this.Factory.Get<ICallable<(Result,Qubit), QVoid>, Quantum.Core.Set>();
            }
        }

        public override Func<(Int64,Int64), (Int64,Int64)> Body
        {
            get => (_args) =>
            {
#line hidden
                this.Factory.StartOperation("Quantum.PublicGates.CUST_CNOT", OperationFunctor.Body, _args);
                var __result__ = default((Int64,Int64));
                try
                {
                    var (x,y) = _args;
#line 85 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                    var xResult = 0L;
#line 86 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                    var yResult = 0L;
#line 88 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                    var qubits = Allocate.Apply(2L);
#line 91 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                    if ((x != 2L))
                    {
#line 92 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                        if ((x == 0L))
                        {
#line 93 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                            QuantumCoreSet.Apply((Result.Zero, qubits[0L]));
                        }
                        else
                        {
#line 96 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                            QuantumCoreSet.Apply((Result.One, qubits[0L]));
                        }
                    }
                    else
                    {
#line 99 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                        MicrosoftQuantumPrimitiveH.Apply(qubits[0L]);
                    }

#line 102 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                    if ((y != 2L))
                    {
#line 103 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                        if ((y == 0L))
                        {
#line 104 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                            QuantumCoreSet.Apply((Result.Zero, qubits[0L]));
                        }
                        else
                        {
#line 107 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                            QuantumCoreSet.Apply((Result.One, qubits[0L]));
                        }
                    }
                    else
                    {
#line 110 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                        MicrosoftQuantumPrimitiveH.Apply(qubits[1L]);
                    }

#line 113 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                    MicrosoftQuantumPrimitiveCNOT.Apply((qubits[0L], qubits[1L]));
#line 115 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                    xResult = QuantumCoreMeasureToInt.Apply<Int64>(qubits[0L]);
#line 116 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                    yResult = QuantumCoreMeasureToInt.Apply<Int64>(qubits[1L]);
#line 118 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                    QuantumCoreSet.Apply((Result.Zero, qubits[0L]));
#line 119 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                    QuantumCoreSet.Apply((Result.Zero, qubits[1L]));
#line hidden
                    Release.Apply(qubits);
#line hidden
                    __result__ = (xResult, yResult);
#line 122 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                    return __result__;
                }
                finally
                {
#line hidden
                    this.Factory.EndOperation("Quantum.PublicGates.CUST_CNOT", OperationFunctor.Body, __result__);
                }
            }

            ;
        }

        public static System.Threading.Tasks.Task<(Int64,Int64)> Run(IOperationFactory __m__, Int64 x, Int64 y)
        {
            return __m__.Run<CUST_CNOT, (Int64,Int64), (Int64,Int64)>((x, y));
        }
    }
}