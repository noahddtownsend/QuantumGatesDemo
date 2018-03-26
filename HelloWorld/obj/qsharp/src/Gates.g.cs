#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Quantum.SuperdenseCoding", "Hadamard () : Int", new string[] { }, "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\HelloWorld\\Gates.qs", 155L, 9L, 5L)]
#line hidden
namespace Quantum.SuperdenseCoding
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
                this.Factory.StartOperation("Quantum.SuperdenseCoding.Hadamard", OperationFunctor.Body, _args);
                var __result__ = default(Int64);
                try
                {
#line 12 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\HelloWorld\\Gates.qs"
                    var result = 0L;
#line 14 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\HelloWorld\\Gates.qs"
                    var qubits = Allocate.Apply(1L);
#line 16 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\HelloWorld\\Gates.qs"
                    QuantumCoreSet.Apply((Result.Zero, qubits[0L]));
#line 18 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\HelloWorld\\Gates.qs"
                    MicrosoftQuantumPrimitiveH.Apply(qubits[0L]);
#line 19 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\HelloWorld\\Gates.qs"
                    MicrosoftQuantumPrimitiveH.Apply(qubits[0L]);
#line 20 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\HelloWorld\\Gates.qs"
                    MicrosoftQuantumPrimitiveH.Apply(qubits[0L]);
#line 21 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\HelloWorld\\Gates.qs"
                    MicrosoftQuantumPrimitiveH.Apply(qubits[0L]);
#line 22 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\HelloWorld\\Gates.qs"
                    MicrosoftQuantumPrimitiveH.Apply(qubits[0L]);
#line 23 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\HelloWorld\\Gates.qs"
                    MicrosoftQuantumPrimitiveH.Apply(qubits[0L]);
#line 24 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\HelloWorld\\Gates.qs"
                    MicrosoftQuantumPrimitiveH.Apply(qubits[0L]);
#line 25 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\HelloWorld\\Gates.qs"
                    MicrosoftQuantumPrimitiveH.Apply(qubits[0L]);
#line 26 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\HelloWorld\\Gates.qs"
                    MicrosoftQuantumPrimitiveH.Apply(qubits[0L]);
#line 27 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\HelloWorld\\Gates.qs"
                    MicrosoftQuantumPrimitiveH.Apply(qubits[0L]);
#line 28 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\HelloWorld\\Gates.qs"
                    MicrosoftQuantumPrimitiveH.Apply(qubits[0L]);
#line 30 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\HelloWorld\\Gates.qs"
                    result = QuantumCoreMeasureToInt.Apply<Int64>(qubits[0L]);
#line 32 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\HelloWorld\\Gates.qs"
                    QuantumCoreSet.Apply((Result.Zero, qubits[0L]));
#line hidden
                    Release.Apply(qubits);
#line hidden
                    __result__ = result;
#line 35 "C:\\Users\\gen6n\\source\\repos\\00 - Quantum Gates Example\\QuantumGatesDemo\\HelloWorld\\Gates.qs"
                    return __result__;
                }
                finally
                {
#line hidden
                    this.Factory.EndOperation("Quantum.SuperdenseCoding.Hadamard", OperationFunctor.Body, __result__);
                }
            }

            ;
        }

        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__)
        {
            return __m__.Run<Hadamard, QVoid, Int64>(QVoid.Instance);
        }
    }
}