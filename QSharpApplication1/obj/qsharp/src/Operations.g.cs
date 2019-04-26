#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QSharpApplication1\",\"Name\":\"QFTImpl\"},\"SourceFile\":\"C:/Demo/QSharpApplication1/QSharpApplication1/Operations.qs\",\"Position\":{\"Item1\":6,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":18}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":20},\"Item2\":{\"Line\":1,\"Column\":22}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.QSharpApplication1\",\"Name\":\"QFTImpl\"},\"SourceFile\":\"C:/Demo/QSharpApplication1/QSharpApplication1/Operations.qs\",\"Position\":{\"Item1\":8,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Quantum.QSharpApplication1\",\"Name\":\"QFTImpl\"},\"SourceFile\":\"C:/Demo/QSharpApplication1/QSharpApplication1/Operations.qs\",\"Position\":{\"Item1\":24,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"Parent\":{\"Namespace\":\"Quantum.QSharpApplication1\",\"Name\":\"QFTImpl\"},\"SourceFile\":\"C:/Demo/QSharpApplication1/QSharpApplication1/Operations.qs\",\"Position\":{\"Item1\":25,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"Parent\":{\"Namespace\":\"Quantum.QSharpApplication1\",\"Name\":\"QFTImpl\"},\"SourceFile\":\"C:/Demo/QSharpApplication1/QSharpApplication1/Operations.qs\",\"Position\":{\"Item1\":26,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QSharpApplication1\",\"Name\":\"QuantumPhaseEstimationImpl\"},\"SourceFile\":\"C:/Demo/QSharpApplication1/QSharpApplication1/Operations.qs\",\"Position\":{\"Item1\":29,\"Item2\":1},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":37}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"oracle\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":39},\"Item2\":{\"Line\":1,\"Column\":45}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"targetState\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":89},\"Item2\":{\"Line\":1,\"Column\":100}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"controlRegister\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":112},\"Item2\":{\"Line\":1,\"Column\":127}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.QSharpApplication1\",\"Name\":\"QuantumPhaseEstimationImpl\"},\"SourceFile\":\"C:/Demo/QSharpApplication1/QSharpApplication1/Operations.qs\",\"Position\":{\"Item1\":31,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Quantum.QSharpApplication1\",\"Name\":\"QuantumPhaseEstimationImpl\"},\"SourceFile\":\"C:/Demo/QSharpApplication1/QSharpApplication1/Operations.qs\",\"Position\":{\"Item1\":53,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"Parent\":{\"Namespace\":\"Quantum.QSharpApplication1\",\"Name\":\"QuantumPhaseEstimationImpl\"},\"SourceFile\":\"C:/Demo/QSharpApplication1/QSharpApplication1/Operations.qs\",\"Position\":{\"Item1\":54,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"Parent\":{\"Namespace\":\"Quantum.QSharpApplication1\",\"Name\":\"QuantumPhaseEstimationImpl\"},\"SourceFile\":\"C:/Demo/QSharpApplication1/QSharpApplication1/Operations.qs\",\"Position\":{\"Item1\":55,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QSharpApplication1\",\"Name\":\"ExpOracle\"},\"SourceFile\":\"C:/Demo/QSharpApplication1/QSharpApplication1/Operations.qs\",\"Position\":{\"Item1\":59,\"Item2\":1},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":20}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"eigenphase\"]},\"Type\":{\"Case\":\"Double\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":22},\"Item2\":{\"Line\":1,\"Column\":32}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"register\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":43},\"Item2\":{\"Line\":1,\"Column\":51}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Double\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]},\"Documentation\":[\" This is bloackbox oracle !\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.QSharpApplication1\",\"Name\":\"ExpOracle\"},\"SourceFile\":\"C:/Demo/QSharpApplication1/QSharpApplication1/Operations.qs\",\"Position\":{\"Item1\":61,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Quantum.QSharpApplication1\",\"Name\":\"ExpOracle\"},\"SourceFile\":\"C:/Demo/QSharpApplication1/QSharpApplication1/Operations.qs\",\"Position\":{\"Item1\":65,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"Parent\":{\"Namespace\":\"Quantum.QSharpApplication1\",\"Name\":\"ExpOracle\"},\"SourceFile\":\"C:/Demo/QSharpApplication1/QSharpApplication1/Operations.qs\",\"Position\":{\"Item1\":66,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"Parent\":{\"Namespace\":\"Quantum.QSharpApplication1\",\"Name\":\"ExpOracle\"},\"SourceFile\":\"C:/Demo/QSharpApplication1/QSharpApplication1/Operations.qs\",\"Position\":{\"Item1\":67,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QSharpApplication1\",\"Name\":\"PowerOracle\"},\"SourceFile\":\"C:/Demo/QSharpApplication1/QSharpApplication1/Operations.qs\",\"Position\":{\"Item1\":70,\"Item2\":1},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"oracle\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":24},\"Item2\":{\"Line\":1,\"Column\":30}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"targetState\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":74},\"Item2\":{\"Line\":1,\"Column\":85}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"power\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":97},\"Item2\":{\"Line\":1,\"Column\":102}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.QSharpApplication1\",\"Name\":\"PowerOracle\"},\"SourceFile\":\"C:/Demo/QSharpApplication1/QSharpApplication1/Operations.qs\",\"Position\":{\"Item1\":72,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Quantum.QSharpApplication1\",\"Name\":\"PowerOracle\"},\"SourceFile\":\"C:/Demo/QSharpApplication1/QSharpApplication1/Operations.qs\",\"Position\":{\"Item1\":79,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"Parent\":{\"Namespace\":\"Quantum.QSharpApplication1\",\"Name\":\"PowerOracle\"},\"SourceFile\":\"C:/Demo/QSharpApplication1/QSharpApplication1/Operations.qs\",\"Position\":{\"Item1\":80,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"Parent\":{\"Namespace\":\"Quantum.QSharpApplication1\",\"Name\":\"PowerOracle\"},\"SourceFile\":\"C:/Demo/QSharpApplication1/QSharpApplication1/Operations.qs\",\"Position\":{\"Item1\":81,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QSharpApplication1\",\"Name\":\"PhaseEstimationSample\"},\"SourceFile\":\"C:/Demo/QSharpApplication1/QSharpApplication1/Operations.qs\",\"Position\":{\"Item1\":84,\"Item2\":1},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":32}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"eigenphase\"]},\"Type\":{\"Case\":\"Double\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":34},\"Item2\":{\"Line\":1,\"Column\":44}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Double\"},\"ReturnType\":{\"Case\":\"Double\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.QSharpApplication1\",\"Name\":\"PhaseEstimationSample\"},\"SourceFile\":\"C:/Demo/QSharpApplication1/QSharpApplication1/Operations.qs\",\"Position\":{\"Item1\":84,\"Item2\":1},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":32}},\"Documentation\":[]}")]
#line hidden
namespace Quantum.QSharpApplication1
{
    public class QFTImpl : Unitary<QArray<Qubit>>, ICallable
    {
        public QFTImpl(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "QFTImpl";
        String ICallable.FullName => "Quantum.QSharpApplication1.QFTImpl";
        protected IUnitary<QArray<Qubit>> MicrosoftQuantumCanonSwapReverseRegister
        {
            get;
            set;
        }

        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<Range, Range> RangeReverse
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveH
        {
            get;
            set;
        }

        protected IUnitary<(Int64,Int64,Qubit)> MicrosoftQuantumPrimitiveR1Frac
        {
            get;
            set;
        }

        public override Func<QArray<Qubit>, QVoid> Body => (__in__) =>
        {
            var qs = __in__;
#line 11 "C:\\Demo\\QSharpApplication1\\QSharpApplication1\\Operations.qs"
            var nQubits = qs.Length;
#line 13 "C:\\Demo\\QSharpApplication1\\QSharpApplication1\\Operations.qs"
            foreach (var i in new Range(0L, (nQubits - 1L)))
#line hidden
            {
#line 15 "C:\\Demo\\QSharpApplication1\\QSharpApplication1\\Operations.qs"
                MicrosoftQuantumPrimitiveH.Apply(qs[i]);
#line 16 "C:\\Demo\\QSharpApplication1\\QSharpApplication1\\Operations.qs"
                foreach (var j in new Range((i + 1L), (nQubits - 1L)))
#line hidden
                {
#line 18 "C:\\Demo\\QSharpApplication1\\QSharpApplication1\\Operations.qs"
                    MicrosoftQuantumPrimitiveR1Frac.Controlled.Apply((new QArray<Qubit>()
                    {qs[j]}, (1L, (j - i), qs[i])));
                }
            }

#line 22 "C:\\Demo\\QSharpApplication1\\QSharpApplication1\\Operations.qs"
            MicrosoftQuantumCanonSwapReverseRegister.Apply(qs?.Copy());
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<QArray<Qubit>, QVoid> AdjointBody => (__in__) =>
        {
            var qs = __in__;
#line hidden
            var nQubits = qs.Length;
#line hidden
            MicrosoftQuantumCanonSwapReverseRegister.Adjoint.Apply(qs?.Copy());
#line hidden
            foreach (var i in RangeReverse.Apply(new Range(0L, (nQubits - 1L))))
#line hidden
            {
#line hidden
                foreach (var j in RangeReverse.Apply(new Range((i + 1L), (nQubits - 1L))))
#line hidden
                {
#line hidden
                    MicrosoftQuantumPrimitiveR1Frac.Controlled.Adjoint.Apply((new QArray<Qubit>()
                    {qs[j]}, (1L, (j - i), qs[i])));
                }

#line hidden
                MicrosoftQuantumPrimitiveH.Adjoint.Apply(qs[i]);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,QArray<Qubit>), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,qs) = __in__;
#line hidden
            var nQubits = qs.Length;
#line hidden
            foreach (var i in new Range(0L, (nQubits - 1L)))
#line hidden
            {
#line hidden
                MicrosoftQuantumPrimitiveH.Controlled.Apply((__controlQubits__?.Copy(), qs[i]));
#line hidden
                foreach (var j in new Range((i + 1L), (nQubits - 1L)))
#line hidden
                {
#line hidden
                    MicrosoftQuantumPrimitiveR1Frac.Controlled.Controlled.Apply((__controlQubits__?.Copy(), (new QArray<Qubit>()
                    {qs[j]}, (1L, (j - i), qs[i]))));
                }
            }

#line hidden
            MicrosoftQuantumCanonSwapReverseRegister.Controlled.Apply((__controlQubits__?.Copy(), qs?.Copy()));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,QArray<Qubit>), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,qs) = __in__;
#line hidden
            var nQubits = qs.Length;
#line hidden
            MicrosoftQuantumCanonSwapReverseRegister.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), qs?.Copy()));
#line hidden
            foreach (var i in RangeReverse.Apply(new Range(0L, (nQubits - 1L))))
#line hidden
            {
#line hidden
                foreach (var j in RangeReverse.Apply(new Range((i + 1L), (nQubits - 1L))))
#line hidden
                {
#line hidden
                    MicrosoftQuantumPrimitiveR1Frac.Controlled.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (new QArray<Qubit>()
                    {qs[j]}, (1L, (j - i), qs[i]))));
                }

#line hidden
                MicrosoftQuantumPrimitiveH.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), qs[i]));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonSwapReverseRegister = this.Factory.Get<IUnitary<QArray<Qubit>>>(typeof(Microsoft.Quantum.Canon.SwapReverseRegister));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.MicrosoftQuantumPrimitiveR1Frac = this.Factory.Get<IUnitary<(Int64,Int64,Qubit)>>(typeof(Microsoft.Quantum.Primitive.R1Frac));
        }

        public override IApplyData __dataIn(QArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> qs)
        {
            return __m__.Run<QFTImpl, QArray<Qubit>, QVoid>(qs);
        }
    }

    public class QuantumPhaseEstimationImpl : Unitary<(IUnitary,QArray<Qubit>,QArray<Qubit>)>, ICallable
    {
        public QuantumPhaseEstimationImpl(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IUnitary,QArray<Qubit>,QArray<Qubit>)>, IApplyData
        {
            public In((IUnitary,QArray<Qubit>,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "QuantumPhaseEstimationImpl";
        String ICallable.FullName => "Quantum.QSharpApplication1.QuantumPhaseEstimationImpl";
        protected IUnitary MicrosoftQuantumCanonApplyToEachCA
        {
            get;
            set;
        }

        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<Range, Range> RangeReverse
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveH
        {
            get;
            set;
        }

        protected IUnitary<(IUnitary,QArray<Qubit>,Int64)> PowerOracle
        {
            get;
            set;
        }

        protected IUnitary<QArray<Qubit>> QFTImpl
        {
            get;
            set;
        }

        public override Func<(IUnitary,QArray<Qubit>,QArray<Qubit>), QVoid> Body => (__in__) =>
        {
            var (oracle,targetState,controlRegister) = __in__;
#line 34 "C:\\Demo\\QSharpApplication1\\QSharpApplication1\\Operations.qs"
            var nQubits = controlRegister.Length;
#line 35 "C:\\Demo\\QSharpApplication1\\QSharpApplication1\\Operations.qs"
            MicrosoftQuantumCanonApplyToEachCA.Apply((MicrosoftQuantumPrimitiveH, controlRegister?.Copy()));
#line 37 "C:\\Demo\\QSharpApplication1\\QSharpApplication1\\Operations.qs"
            foreach (var idxControlQubit in new Range(0L, (nQubits - 1L)))
#line hidden
            {
#line 39 "C:\\Demo\\QSharpApplication1\\QSharpApplication1\\Operations.qs"
                var control = controlRegister[((nQubits - 1L) - idxControlQubit)];
#line 40 "C:\\Demo\\QSharpApplication1\\QSharpApplication1\\Operations.qs"
                var power = 2L.Pow(idxControlQubit);
#line 41 "C:\\Demo\\QSharpApplication1\\QSharpApplication1\\Operations.qs"
                PowerOracle.Controlled.Apply((new QArray<Qubit>()
                {control}, (oracle, targetState?.Copy(), power)));
            }

#line 51 "C:\\Demo\\QSharpApplication1\\QSharpApplication1\\Operations.qs"
            QFTImpl.Adjoint.Apply(controlRegister?.Copy());
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IUnitary,QArray<Qubit>,QArray<Qubit>), QVoid> AdjointBody => (__in__) =>
        {
            var (oracle,targetState,controlRegister) = __in__;
#line hidden
            var nQubits = controlRegister.Length;
#line hidden
            QFTImpl.Adjoint.Adjoint.Apply(controlRegister?.Copy());
#line hidden
            foreach (var idxControlQubit in RangeReverse.Apply(new Range(0L, (nQubits - 1L))))
#line hidden
            {
#line hidden
                var control = controlRegister[((nQubits - 1L) - idxControlQubit)];
#line hidden
                var power = 2L.Pow(idxControlQubit);
#line hidden
                PowerOracle.Controlled.Adjoint.Apply((new QArray<Qubit>()
                {control}, (oracle, targetState?.Copy(), power)));
            }

#line hidden
            MicrosoftQuantumCanonApplyToEachCA.Adjoint.Apply((MicrosoftQuantumPrimitiveH, controlRegister?.Copy()));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(IUnitary,QArray<Qubit>,QArray<Qubit>)), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,(oracle,targetState,controlRegister)) = __in__;
#line hidden
            var nQubits = controlRegister.Length;
#line hidden
            MicrosoftQuantumCanonApplyToEachCA.Controlled.Apply((__controlQubits__?.Copy(), (MicrosoftQuantumPrimitiveH, controlRegister?.Copy())));
#line hidden
            foreach (var idxControlQubit in new Range(0L, (nQubits - 1L)))
#line hidden
            {
#line hidden
                var control = controlRegister[((nQubits - 1L) - idxControlQubit)];
#line hidden
                var power = 2L.Pow(idxControlQubit);
#line hidden
                PowerOracle.Controlled.Controlled.Apply((__controlQubits__?.Copy(), (new QArray<Qubit>()
                {control}, (oracle, targetState?.Copy(), power))));
            }

#line hidden
            QFTImpl.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), controlRegister?.Copy()));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(IUnitary,QArray<Qubit>,QArray<Qubit>)), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,(oracle,targetState,controlRegister)) = __in__;
#line hidden
            var nQubits = controlRegister.Length;
#line hidden
            QFTImpl.Adjoint.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), controlRegister?.Copy()));
#line hidden
            foreach (var idxControlQubit in RangeReverse.Apply(new Range(0L, (nQubits - 1L))))
#line hidden
            {
#line hidden
                var control = controlRegister[((nQubits - 1L) - idxControlQubit)];
#line hidden
                var power = 2L.Pow(idxControlQubit);
#line hidden
                PowerOracle.Controlled.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (new QArray<Qubit>()
                {control}, (oracle, targetState?.Copy(), power))));
            }

#line hidden
            MicrosoftQuantumCanonApplyToEachCA.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (MicrosoftQuantumPrimitiveH, controlRegister?.Copy())));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyToEachCA = this.Factory.Get<IUnitary>(typeof(Microsoft.Quantum.Canon.ApplyToEachCA<>));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.PowerOracle = this.Factory.Get<IUnitary<(IUnitary,QArray<Qubit>,Int64)>>(typeof(PowerOracle));
            this.QFTImpl = this.Factory.Get<IUnitary<QArray<Qubit>>>(typeof(QFTImpl));
        }

        public override IApplyData __dataIn((IUnitary,QArray<Qubit>,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IUnitary oracle, QArray<Qubit> targetState, QArray<Qubit> controlRegister)
        {
            return __m__.Run<QuantumPhaseEstimationImpl, (IUnitary,QArray<Qubit>,QArray<Qubit>), QVoid>((oracle, targetState, controlRegister));
        }
    }

    public class ExpOracle : Unitary<(Double,QArray<Qubit>)>, ICallable
    {
        public ExpOracle(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Double,QArray<Qubit>)>, IApplyData
        {
            public In((Double,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item2)?.Qubits;
        }

        String ICallable.Name => "ExpOracle";
        String ICallable.FullName => "Quantum.QSharpApplication1.ExpOracle";
        protected IUnitary<(Double,Qubit)> MicrosoftQuantumPrimitiveRz
        {
            get;
            set;
        }

        public override Func<(Double,QArray<Qubit>), QVoid> Body => (__in__) =>
        {
            var (eigenphase,register) = __in__;
#line 63 "C:\\Demo\\QSharpApplication1\\QSharpApplication1\\Operations.qs"
            MicrosoftQuantumPrimitiveRz.Apply(((2D * eigenphase), register[0L]));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Double,QArray<Qubit>), QVoid> AdjointBody => (__in__) =>
        {
            var (eigenphase,register) = __in__;
#line hidden
            MicrosoftQuantumPrimitiveRz.Adjoint.Apply(((2D * eigenphase), register[0L]));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Double,QArray<Qubit>)), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,(eigenphase,register)) = __in__;
#line hidden
            MicrosoftQuantumPrimitiveRz.Controlled.Apply((__controlQubits__?.Copy(), ((2D * eigenphase), register[0L])));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Double,QArray<Qubit>)), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,(eigenphase,register)) = __in__;
#line hidden
            MicrosoftQuantumPrimitiveRz.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), ((2D * eigenphase), register[0L])));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveRz = this.Factory.Get<IUnitary<(Double,Qubit)>>(typeof(Microsoft.Quantum.Primitive.Rz));
        }

        public override IApplyData __dataIn((Double,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Double eigenphase, QArray<Qubit> register)
        {
            return __m__.Run<ExpOracle, (Double,QArray<Qubit>), QVoid>((eigenphase, register));
        }
    }

    public class PowerOracle : Unitary<(IUnitary,QArray<Qubit>,Int64)>, ICallable
    {
        public PowerOracle(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IUnitary,QArray<Qubit>,Int64)>, IApplyData
        {
            public In((IUnitary,QArray<Qubit>,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "PowerOracle";
        String ICallable.FullName => "Quantum.QSharpApplication1.PowerOracle";
        protected ICallable<Range, Range> RangeReverse
        {
            get;
            set;
        }

        public override Func<(IUnitary,QArray<Qubit>,Int64), QVoid> Body => (__in__) =>
        {
            var (oracle,targetState,power) = __in__;
#line 74 "C:\\Demo\\QSharpApplication1\\QSharpApplication1\\Operations.qs"
            foreach (var idxPower in new Range(0L, (power - 1L)))
#line hidden
            {
#line 76 "C:\\Demo\\QSharpApplication1\\QSharpApplication1\\Operations.qs"
                oracle.Apply(targetState?.Copy());
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IUnitary,QArray<Qubit>,Int64), QVoid> AdjointBody => (__in__) =>
        {
            var (oracle,targetState,power) = __in__;
#line hidden
            foreach (var idxPower in RangeReverse.Apply(new Range(0L, (power - 1L))))
#line hidden
            {
#line hidden
                oracle.Adjoint.Apply(targetState?.Copy());
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(IUnitary,QArray<Qubit>,Int64)), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,(oracle,targetState,power)) = __in__;
#line hidden
            foreach (var idxPower in new Range(0L, (power - 1L)))
#line hidden
            {
#line hidden
                oracle.Controlled.Apply((__controlQubits__?.Copy(), targetState?.Copy()));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(IUnitary,QArray<Qubit>,Int64)), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,(oracle,targetState,power)) = __in__;
#line hidden
            foreach (var idxPower in RangeReverse.Apply(new Range(0L, (power - 1L))))
#line hidden
            {
#line hidden
                oracle.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), targetState?.Copy()));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
        }

        public override IApplyData __dataIn((IUnitary,QArray<Qubit>,Int64) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IUnitary oracle, QArray<Qubit> targetState, Int64 power)
        {
            return __m__.Run<PowerOracle, (IUnitary,QArray<Qubit>,Int64), QVoid>((oracle, targetState, power));
        }
    }

    public class PhaseEstimationSample : Operation<Double, Double>, ICallable
    {
        public PhaseEstimationSample(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "PhaseEstimationSample";
        String ICallable.FullName => "Quantum.QSharpApplication1.PhaseEstimationSample";
        protected ICallable<Microsoft.Quantum.Canon.BigEndian, Int64> MicrosoftQuantumCanonMeasureIntegerBE
        {
            get;
            set;
        }

        protected ICallable<Int64, Double> MicrosoftQuantumExtensionsConvertToDouble
        {
            get;
            set;
        }

        protected ICallable<QVoid, Double> MicrosoftQuantumExtensionsMathPI
        {
            get;
            set;
        }

        protected Allocate Allocate
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected ICallable<Qubit, QVoid> Reset
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        protected IUnitary<(Double,QArray<Qubit>)> ExpOracle
        {
            get;
            set;
        }

        protected IUnitary<(IUnitary,QArray<Qubit>,QArray<Qubit>)> QuantumPhaseEstimationImpl
        {
            get;
            set;
        }

        public override Func<Double, Double> Body => (__in__) =>
        {
            var eigenphase = __in__;
#line 86 "C:\\Demo\\QSharpApplication1\\QSharpApplication1\\Operations.qs"
            var oracle = ExpOracle.Partial(new Func<QArray<Qubit>, (Double,QArray<Qubit>)>((__arg1__) => (eigenphase, __arg1__)));
#line 87 "C:\\Demo\\QSharpApplication1\\QSharpApplication1\\Operations.qs"
            var n = 10L;
#line 89 "C:\\Demo\\QSharpApplication1\\QSharpApplication1\\Operations.qs"
            var estPhase = 0D;
#line hidden
            {
#line 91 "C:\\Demo\\QSharpApplication1\\QSharpApplication1\\Operations.qs"
                var (eigenstate,phaseRegister) = (Allocate.Apply(1L), Allocate.Apply(n));
#line 92 "C:\\Demo\\QSharpApplication1\\QSharpApplication1\\Operations.qs"
                MicrosoftQuantumPrimitiveX.Apply(eigenstate[0L]);
#line 93 "C:\\Demo\\QSharpApplication1\\QSharpApplication1\\Operations.qs"
                QuantumPhaseEstimationImpl.Apply((oracle, eigenstate?.Copy(), phaseRegister?.Copy()));
#line 94 "C:\\Demo\\QSharpApplication1\\QSharpApplication1\\Operations.qs"
                var estReg = MicrosoftQuantumCanonMeasureIntegerBE.Apply(new Microsoft.Quantum.Canon.BigEndian(phaseRegister?.Copy()));
#line 95 "C:\\Demo\\QSharpApplication1\\QSharpApplication1\\Operations.qs"
                estPhase = (((2D * MicrosoftQuantumExtensionsMathPI.Apply(QVoid.Instance)) * MicrosoftQuantumExtensionsConvertToDouble.Apply(estReg)) / MicrosoftQuantumExtensionsConvertToDouble.Apply(2L.Pow(n)));
#line 96 "C:\\Demo\\QSharpApplication1\\QSharpApplication1\\Operations.qs"
                Reset.Apply(eigenstate[0L]);
#line hidden
                Release.Apply(eigenstate);
#line hidden
                Release.Apply(phaseRegister);
            }

#line 99 "C:\\Demo\\QSharpApplication1\\QSharpApplication1\\Operations.qs"
            return estPhase;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonMeasureIntegerBE = this.Factory.Get<ICallable<Microsoft.Quantum.Canon.BigEndian, Int64>>(typeof(Microsoft.Quantum.Canon.MeasureIntegerBE));
            this.MicrosoftQuantumExtensionsConvertToDouble = this.Factory.Get<ICallable<Int64, Double>>(typeof(Microsoft.Quantum.Extensions.Convert.ToDouble));
            this.MicrosoftQuantumExtensionsMathPI = this.Factory.Get<ICallable<QVoid, Double>>(typeof(Microsoft.Quantum.Extensions.Math.PI));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.Reset = this.Factory.Get<ICallable<Qubit, QVoid>>(typeof(Microsoft.Quantum.Primitive.Reset));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
            this.ExpOracle = this.Factory.Get<IUnitary<(Double,QArray<Qubit>)>>(typeof(ExpOracle));
            this.QuantumPhaseEstimationImpl = this.Factory.Get<IUnitary<(IUnitary,QArray<Qubit>,QArray<Qubit>)>>(typeof(QuantumPhaseEstimationImpl));
        }

        public override IApplyData __dataIn(Double data) => new QTuple<Double>(data);
        public override IApplyData __dataOut(Double data) => new QTuple<Double>(data);
        public static System.Threading.Tasks.Task<Double> Run(IOperationFactory __m__, Double eigenphase)
        {
            return __m__.Run<PhaseEstimationSample, Double, Double>(eigenphase);
        }
    }
}