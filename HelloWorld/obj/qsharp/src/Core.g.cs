#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Quantum.Core", "Set (desired : Result, q1 : Qubit) : ()", new string[] { }, "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\HelloWorld\\Core.qs", 221L, 9L, 5L)]
[assembly: OperationDeclaration("Quantum.Core", "Bell (x : Qubit, y : Qubit) : ()", new string[] { }, "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\HelloWorld\\Core.qs", 537L, 25L, 2L)]
[assembly: OperationDeclaration("Quantum.Core", "InverseBell (x : Qubit, y : Qubit) : ()", new string[] { }, "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\HelloWorld\\Core.qs", 686L, 35L, 2L)]
[assembly: OperationDeclaration("Quantum.Core", "SD (qubit : Qubit, x : Int, y : Int) : ()", new string[] { }, "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\HelloWorld\\Core.qs", 798L, 44L, 2L)]
[assembly: OperationDeclaration("Quantum.Core", "MeasureToInt (qubit : Qubit) : Int", new string[] { }, "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\HelloWorld\\Core.qs", 1256L, 68L, 2L)]
#line hidden
namespace Quantum.Core
{
    public class Set : Operation<(Result,Qubit), QVoid>
    {
        public Set(IOperationFactory m) : base(m)
        {
            this.Dependencies = new Type[] { typeof(Microsoft.Quantum.Primitive.M), typeof(Microsoft.Quantum.Primitive.X) };
        }

        public override Type[] Dependencies
        {
            get;
        }

        protected ICallable<Qubit, Result> M
        {
            get
            {
                return this.Factory.Get<ICallable<Qubit, Result>, Microsoft.Quantum.Primitive.M>();
            }
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get
            {
                return this.Factory.Get<IUnitary<Qubit>, Microsoft.Quantum.Primitive.X>();
            }
        }

        public override Func<(Result,Qubit), QVoid> Body
        {
            get => (_args) =>
            {
#line hidden
                this.Factory.StartOperation("Quantum.Core.Set", OperationFunctor.Body, _args);
                var __result__ = default(QVoid);
                try
                {
                    var (desired,q1) = _args;
                    // M measures the current state of the qubit
#line 13 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\HelloWorld\\Core.qs"
                    var current = M.Apply<Result>(q1);
#line 15 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\HelloWorld\\Core.qs"
                    if ((desired != current))
                    {
                        // flips the qubit about the x-axis (i.e. |0> -> |1>)
#line 18 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\HelloWorld\\Core.qs"
                        MicrosoftQuantumPrimitiveX.Apply(q1);
                    }

#line hidden
                    return __result__;
                }
                finally
                {
#line hidden
                    this.Factory.EndOperation("Quantum.Core.Set", OperationFunctor.Body, __result__);
                }
            }

            ;
        }

        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Result desired, Qubit q1)
        {
            return __m__.Run<Set, (Result,Qubit), QVoid>((desired, q1));
        }
    }

    public class Bell : Operation<(Qubit,Qubit), QVoid>
    {
        public Bell(IOperationFactory m) : base(m)
        {
            this.Dependencies = new Type[] { typeof(Microsoft.Quantum.Primitive.CNOT), typeof(Microsoft.Quantum.Primitive.H) };
        }

        public override Type[] Dependencies
        {
            get;
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

        public override Func<(Qubit,Qubit), QVoid> Body
        {
            get => (_args) =>
            {
#line hidden
                this.Factory.StartOperation("Quantum.Core.Bell", OperationFunctor.Body, _args);
                var __result__ = default(QVoid);
                try
                {
                    var (x,y) = _args;
#line 28 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\HelloWorld\\Core.qs"
                    MicrosoftQuantumPrimitiveH.Apply(x);
#line 29 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\HelloWorld\\Core.qs"
                    MicrosoftQuantumPrimitiveCNOT.Apply((x, y));
#line hidden
                    return __result__;
                }
                finally
                {
#line hidden
                    this.Factory.EndOperation("Quantum.Core.Bell", OperationFunctor.Body, __result__);
                }
            }

            ;
        }

        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit x, Qubit y)
        {
            return __m__.Run<Bell, (Qubit,Qubit), QVoid>((x, y));
        }
    }

    public class InverseBell : Operation<(Qubit,Qubit), QVoid>
    {
        public InverseBell(IOperationFactory m) : base(m)
        {
            this.Dependencies = new Type[] { typeof(Microsoft.Quantum.Primitive.CNOT), typeof(Microsoft.Quantum.Primitive.H) };
        }

        public override Type[] Dependencies
        {
            get;
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

        public override Func<(Qubit,Qubit), QVoid> Body
        {
            get => (_args) =>
            {
#line hidden
                this.Factory.StartOperation("Quantum.Core.InverseBell", OperationFunctor.Body, _args);
                var __result__ = default(QVoid);
                try
                {
                    var (x,y) = _args;
#line 38 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\HelloWorld\\Core.qs"
                    MicrosoftQuantumPrimitiveCNOT.Apply((x, y));
#line 39 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\HelloWorld\\Core.qs"
                    MicrosoftQuantumPrimitiveH.Apply(x);
#line hidden
                    return __result__;
                }
                finally
                {
#line hidden
                    this.Factory.EndOperation("Quantum.Core.InverseBell", OperationFunctor.Body, __result__);
                }
            }

            ;
        }

        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit x, Qubit y)
        {
            return __m__.Run<InverseBell, (Qubit,Qubit), QVoid>((x, y));
        }
    }

    public class SD : Operation<(Qubit,Int64,Int64), QVoid>
    {
        public SD(IOperationFactory m) : base(m)
        {
            this.Dependencies = new Type[] { typeof(Microsoft.Quantum.Primitive.X), typeof(Microsoft.Quantum.Primitive.Y), typeof(Microsoft.Quantum.Primitive.Z) };
        }

        public override Type[] Dependencies
        {
            get;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get
            {
                return this.Factory.Get<IUnitary<Qubit>, Microsoft.Quantum.Primitive.X>();
            }
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveY
        {
            get
            {
                return this.Factory.Get<IUnitary<Qubit>, Microsoft.Quantum.Primitive.Y>();
            }
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveZ
        {
            get
            {
                return this.Factory.Get<IUnitary<Qubit>, Microsoft.Quantum.Primitive.Z>();
            }
        }

        public override Func<(Qubit,Int64,Int64), QVoid> Body
        {
            get => (_args) =>
            {
#line hidden
                this.Factory.StartOperation("Quantum.Core.SD", OperationFunctor.Body, _args);
                var __result__ = default(QVoid);
                try
                {
                    var (qubit,x,y) = _args;
#line 47 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\HelloWorld\\Core.qs"
                    if ((x == 0L))
                    {
#line 49 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\HelloWorld\\Core.qs"
                        if ((y == 1L))
                        {
#line 51 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\HelloWorld\\Core.qs"
                            MicrosoftQuantumPrimitiveX.Apply(qubit);
                        }
                    }
                    else
                    {
#line 55 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\HelloWorld\\Core.qs"
                        if ((y == 0L))
                        {
#line 56 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\HelloWorld\\Core.qs"
                            MicrosoftQuantumPrimitiveZ.Apply(qubit);
                        }
                        else
                        {
#line 59 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\HelloWorld\\Core.qs"
                            MicrosoftQuantumPrimitiveY.Apply(qubit);
                        }
                    }

#line hidden
                    return __result__;
                }
                finally
                {
#line hidden
                    this.Factory.EndOperation("Quantum.Core.SD", OperationFunctor.Body, __result__);
                }
            }

            ;
        }

        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit qubit, Int64 x, Int64 y)
        {
            return __m__.Run<SD, (Qubit,Int64,Int64), QVoid>((qubit, x, y));
        }
    }

    public class MeasureToInt : Operation<Qubit, Int64>
    {
        public MeasureToInt(IOperationFactory m) : base(m)
        {
            this.Dependencies = new Type[] { typeof(Microsoft.Quantum.Primitive.M) };
        }

        public override Type[] Dependencies
        {
            get;
        }

        protected ICallable<Qubit, Result> M
        {
            get
            {
                return this.Factory.Get<ICallable<Qubit, Result>, Microsoft.Quantum.Primitive.M>();
            }
        }

        public override Func<Qubit, Int64> Body
        {
            get => (qubit) =>
            {
#line hidden
                this.Factory.StartOperation("Quantum.Core.MeasureToInt", OperationFunctor.Body, qubit);
                var __result__ = default(Int64);
                try
                {
#line 71 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\HelloWorld\\Core.qs"
                    var toReturn = 0L;
#line 73 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\HelloWorld\\Core.qs"
                    if ((M.Apply<Result>(qubit) == Result.One))
                    {
#line 75 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\HelloWorld\\Core.qs"
                        toReturn = 1L;
                    }

#line hidden
                    __result__ = toReturn;
#line 78 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\HelloWorld\\Core.qs"
                    return __result__;
                }
                finally
                {
#line hidden
                    this.Factory.EndOperation("Quantum.Core.MeasureToInt", OperationFunctor.Body, __result__);
                }
            }

            ;
        }

        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, Qubit qubit)
        {
            return __m__.Run<MeasureToInt, Qubit, Int64>(qubit);
        }
    }
}