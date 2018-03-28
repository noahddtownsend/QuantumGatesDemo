#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Quantum.PublicGates", "Hadamard () : Int", new string[] { }, "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs", 150L, 9L, 5L)]
[assembly: OperationDeclaration("Quantum.PublicGates", "NOT (i : Int) : Int", new string[] { }, "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs", 699L, 40L, 5L)]
[assembly: OperationDeclaration("Quantum.PublicGates", "CUST_CNOT (x : Int, y : Int) : (Int, Int)", new string[] { }, "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs", 1249L, 75L, 5L)]
#line hidden
namespace Quantum.PublicGates
{
    public class Hadamard : Operation<QVoid, Int64>
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

        public override Func<QVoid, Int64> Body
        {
            get => (_args) =>
            {
#line hidden
                this.Factory.StartOperation("Quantum.PublicGates.Hadamard", OperationFunctor.Body, _args);
                var __result__ = default(Int64);
                try
                {
#line 12 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                    var result = 0L;
#line 14 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                    var qubits = Allocate.Apply(1L);
#line 16 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                    QuantumCoreSet.Apply((Result.Zero, qubits[0L]));
#line 18 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                    MicrosoftQuantumPrimitiveH.Apply(qubits[0L]);
#line 19 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                    MicrosoftQuantumPrimitiveH.Apply(qubits[0L]);
#line 20 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                    MicrosoftQuantumPrimitiveH.Apply(qubits[0L]);
#line 21 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                    MicrosoftQuantumPrimitiveH.Apply(qubits[0L]);
#line 22 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                    MicrosoftQuantumPrimitiveH.Apply(qubits[0L]);
#line 23 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                    MicrosoftQuantumPrimitiveH.Apply(qubits[0L]);
#line 24 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                    MicrosoftQuantumPrimitiveH.Apply(qubits[0L]);
#line 25 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                    MicrosoftQuantumPrimitiveH.Apply(qubits[0L]);
#line 26 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                    MicrosoftQuantumPrimitiveH.Apply(qubits[0L]);
#line 27 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                    MicrosoftQuantumPrimitiveH.Apply(qubits[0L]);
#line 28 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                    MicrosoftQuantumPrimitiveH.Apply(qubits[0L]);
#line 30 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                    result = QuantumCoreMeasureToInt.Apply<Int64>(qubits[0L]);
#line 32 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                    QuantumCoreSet.Apply((Result.Zero, qubits[0L]));
#line hidden
                    Release.Apply(qubits);
#line hidden
                    __result__ = result;
#line 35 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
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

        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__)
        {
            return __m__.Run<Hadamard, QVoid, Int64>(QVoid.Instance);
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
#line 43 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                    var result = 0L;
#line 45 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                    var qubits = Allocate.Apply(1L);
#line 48 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                    if ((i != 2L))
                    {
#line 50 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                        var valueToSet = Result.Zero;
#line 52 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                        if ((i == 1L))
                        {
#line 53 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                            valueToSet = Result.One;
                        }

#line 56 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                        QuantumCoreSet.Apply((valueToSet, qubits[0L]));
                    }
                    else
                    {
#line 60 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                        MicrosoftQuantumPrimitiveH.Apply(qubits[0L]);
                    }

#line 63 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                    MicrosoftQuantumPrimitiveX.Apply(qubits[0L]);
#line 65 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                    result = QuantumCoreMeasureToInt.Apply<Int64>(qubits[0L]);
#line 67 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                    QuantumCoreSet.Apply((Result.Zero, qubits[0L]));
#line hidden
                    Release.Apply(qubits);
#line hidden
                    __result__ = result;
#line 70 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
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
#line 78 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                    var xResult = 0L;
#line 79 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                    var yResult = 0L;
#line 81 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                    var qubits = Allocate.Apply(2L);
#line 84 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                    if ((x != 2L))
                    {
#line 85 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                        var valueToSet = Result.Zero;
#line 87 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                        if ((x == 1L))
                        {
#line 88 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                            valueToSet = Result.One;
                        }

#line 91 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                        QuantumCoreSet.Apply((valueToSet, qubits[0L]));
                    }
                    else
                    {
#line 93 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                        MicrosoftQuantumPrimitiveH.Apply(qubits[0L]);
                    }

#line 96 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                    if ((y != 2L))
                    {
#line 97 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                        var valueToSet = Result.Zero;
#line 99 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                        if ((y == 1L))
                        {
#line 100 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                            valueToSet = Result.One;
                        }

#line 103 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                        QuantumCoreSet.Apply((valueToSet, qubits[1L]));
                    }
                    else
                    {
#line 105 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                        MicrosoftQuantumPrimitiveH.Apply(qubits[1L]);
                    }

#line 108 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                    MicrosoftQuantumPrimitiveCNOT.Apply((qubits[0L], qubits[1L]));
#line 110 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                    xResult = QuantumCoreMeasureToInt.Apply<Int64>(qubits[0L]);
#line 111 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                    yResult = QuantumCoreMeasureToInt.Apply<Int64>(qubits[1L]);
#line 113 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                    QuantumCoreSet.Apply((Result.Zero, qubits[0L]));
#line 114 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
                    QuantumCoreSet.Apply((Result.Zero, qubits[1L]));
#line hidden
                    Release.Apply(qubits);
#line hidden
                    __result__ = (xResult, yResult);
#line 117 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\Quantum Gates Example - Visual Studio Project\\HelloWorld\\Gates.qs"
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