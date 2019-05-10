#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QSharpApplication1\",\"Name\":\"QFTImpl\"},\"SourceFile\":\"C:/Demo/Quantum-Phase-Estimation-QSharp/QSharpApplication1/Operations.qs\",\"Position\":{\"Item1\":6,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":18}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":20},\"Item2\":{\"Line\":1,\"Column\":22}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpApplication1\",\"Name\":\"QFTImpl\"},\"SourceFile\":\"C:/Demo/Quantum-Phase-Estimation-QSharp/QSharpApplication1/Operations.qs\",\"Position\":{\"Item1\":8,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpApplication1\",\"Name\":\"QFTImpl\"},\"SourceFile\":\"C:/Demo/Quantum-Phase-Estimation-QSharp/QSharpApplication1/Operations.qs\",\"Position\":{\"Item1\":24,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpApplication1\",\"Name\":\"QFTImpl\"},\"SourceFile\":\"C:/Demo/Quantum-Phase-Estimation-QSharp/QSharpApplication1/Operations.qs\",\"Position\":{\"Item1\":25,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpApplication1\",\"Name\":\"QFTImpl\"},\"SourceFile\":\"C:/Demo/Quantum-Phase-Estimation-QSharp/QSharpApplication1/Operations.qs\",\"Position\":{\"Item1\":26,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QSharpApplication1\",\"Name\":\"QuantumPhaseEstimationImpl\"},\"SourceFile\":\"C:/Demo/Quantum-Phase-Estimation-QSharp/QSharpApplication1/Operations.qs\",\"Position\":{\"Item1\":29,\"Item2\":1},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":37}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"oracle\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":39},\"Item2\":{\"Line\":1,\"Column\":45}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"targetState\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":80},\"Item2\":{\"Line\":1,\"Column\":91}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"controlRegister\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":103},\"Item2\":{\"Line\":1,\"Column\":118}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpApplication1\",\"Name\":\"QuantumPhaseEstimationImpl\"},\"SourceFile\":\"C:/Demo/Quantum-Phase-Estimation-QSharp/QSharpApplication1/Operations.qs\",\"Position\":{\"Item1\":31,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpApplication1\",\"Name\":\"QuantumPhaseEstimationImpl\"},\"SourceFile\":\"C:/Demo/Quantum-Phase-Estimation-QSharp/QSharpApplication1/Operations.qs\",\"Position\":{\"Item1\":29,\"Item2\":1},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":140},\"Item2\":{\"Line\":1,\"Column\":149}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Quantum.QSharpApplication1.QuantumPhaseEstimationImpl\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpApplication1\",\"Name\":\"QuantumPhaseEstimationImpl\"},\"SourceFile\":\"C:/Demo/Quantum-Phase-Estimation-QSharp/QSharpApplication1/Operations.qs\",\"Position\":{\"Item1\":29,\"Item2\":1},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":140},\"Item2\":{\"Line\":1,\"Column\":149}},\"Documentation\":[\"automatically generated QsControlled specialization for Quantum.QSharpApplication1.QuantumPhaseEstimationImpl\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpApplication1\",\"Name\":\"QuantumPhaseEstimationImpl\"},\"SourceFile\":\"C:/Demo/Quantum-Phase-Estimation-QSharp/QSharpApplication1/Operations.qs\",\"Position\":{\"Item1\":29,\"Item2\":1},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":140},\"Item2\":{\"Line\":1,\"Column\":149}},\"Documentation\":[\"automatically generated QsControlledAdjoint specialization for Quantum.QSharpApplication1.QuantumPhaseEstimationImpl\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QSharpApplication1\",\"Name\":\"ExpOracle\"},\"SourceFile\":\"C:/Demo/Quantum-Phase-Estimation-QSharp/QSharpApplication1/Operations.qs\",\"Position\":{\"Item1\":55,\"Item2\":1},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":20}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"eigenphase\"]},\"Type\":{\"Case\":\"Double\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":22},\"Item2\":{\"Line\":1,\"Column\":32}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"register\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":43},\"Item2\":{\"Line\":1,\"Column\":51}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Double\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[\" This is bloackbox oracle !\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpApplication1\",\"Name\":\"ExpOracle\"},\"SourceFile\":\"C:/Demo/Quantum-Phase-Estimation-QSharp/QSharpApplication1/Operations.qs\",\"Position\":{\"Item1\":57,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpApplication1\",\"Name\":\"ExpOracle\"},\"SourceFile\":\"C:/Demo/Quantum-Phase-Estimation-QSharp/QSharpApplication1/Operations.qs\",\"Position\":{\"Item1\":61,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpApplication1\",\"Name\":\"ExpOracle\"},\"SourceFile\":\"C:/Demo/Quantum-Phase-Estimation-QSharp/QSharpApplication1/Operations.qs\",\"Position\":{\"Item1\":62,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpApplication1\",\"Name\":\"ExpOracle\"},\"SourceFile\":\"C:/Demo/Quantum-Phase-Estimation-QSharp/QSharpApplication1/Operations.qs\",\"Position\":{\"Item1\":63,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QSharpApplication1\",\"Name\":\"PowerOracle\"},\"SourceFile\":\"C:/Demo/Quantum-Phase-Estimation-QSharp/QSharpApplication1/Operations.qs\",\"Position\":{\"Item1\":66,\"Item2\":1},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"oracle\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":24},\"Item2\":{\"Line\":1,\"Column\":30}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"targetState\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":65},\"Item2\":{\"Line\":1,\"Column\":76}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"power\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":88},\"Item2\":{\"Line\":1,\"Column\":93}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpApplication1\",\"Name\":\"PowerOracle\"},\"SourceFile\":\"C:/Demo/Quantum-Phase-Estimation-QSharp/QSharpApplication1/Operations.qs\",\"Position\":{\"Item1\":68,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpApplication1\",\"Name\":\"PowerOracle\"},\"SourceFile\":\"C:/Demo/Quantum-Phase-Estimation-QSharp/QSharpApplication1/Operations.qs\",\"Position\":{\"Item1\":66,\"Item2\":1},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":111},\"Item2\":{\"Line\":1,\"Column\":120}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Quantum.QSharpApplication1.PowerOracle\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpApplication1\",\"Name\":\"PowerOracle\"},\"SourceFile\":\"C:/Demo/Quantum-Phase-Estimation-QSharp/QSharpApplication1/Operations.qs\",\"Position\":{\"Item1\":66,\"Item2\":1},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":111},\"Item2\":{\"Line\":1,\"Column\":120}},\"Documentation\":[\"automatically generated QsControlled specialization for Quantum.QSharpApplication1.PowerOracle\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpApplication1\",\"Name\":\"PowerOracle\"},\"SourceFile\":\"C:/Demo/Quantum-Phase-Estimation-QSharp/QSharpApplication1/Operations.qs\",\"Position\":{\"Item1\":66,\"Item2\":1},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":111},\"Item2\":{\"Line\":1,\"Column\":120}},\"Documentation\":[\"automatically generated QsControlledAdjoint specialization for Quantum.QSharpApplication1.PowerOracle\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QSharpApplication1\",\"Name\":\"PhaseEstimationSample\"},\"SourceFile\":\"C:/Demo/Quantum-Phase-Estimation-QSharp/QSharpApplication1/Operations.qs\",\"Position\":{\"Item1\":76,\"Item2\":1},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":32}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"eigenphase\"]},\"Type\":{\"Case\":\"Double\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":34},\"Item2\":{\"Line\":1,\"Column\":44}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Double\"},\"ReturnType\":{\"Case\":\"Double\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpApplication1\",\"Name\":\"PhaseEstimationSample\"},\"SourceFile\":\"C:/Demo/Quantum-Phase-Estimation-QSharp/QSharpApplication1/Operations.qs\",\"Position\":{\"Item1\":76,\"Item2\":1},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":32}},\"Documentation\":[]}")]
#line hidden
namespace Quantum.QSharpApplication1
{
    public class QFTImpl : Unitary<IQArray<Qubit>>, ICallable
    {
        public QFTImpl(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "QFTImpl";
        String ICallable.FullName => "Quantum.QSharpApplication1.QFTImpl";
        protected IUnitary<IQArray<Qubit>> MicrosoftQuantumCanonSwapReverseRegister
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

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicH
        {
            get;
            set;
        }

        protected IUnitary<(Int64,Int64,Qubit)> MicrosoftQuantumIntrinsicR1Frac
        {
            get;
            set;
        }

        public override Func<IQArray<Qubit>, QVoid> Body => (__in__) =>
        {
            var qs = __in__;
#line 11 "C:\\Demo\\Quantum-Phase-Estimation-QSharp\\QSharpApplication1\\Operations.qs"
            var nQubits = qs.Length;
#line 13 "C:\\Demo\\Quantum-Phase-Estimation-QSharp\\QSharpApplication1\\Operations.qs"
            foreach (var i in new Range(0L, (nQubits - 1L)))
#line hidden
            {
#line 15 "C:\\Demo\\Quantum-Phase-Estimation-QSharp\\QSharpApplication1\\Operations.qs"
                MicrosoftQuantumIntrinsicH.Apply(qs[i]);
#line 16 "C:\\Demo\\Quantum-Phase-Estimation-QSharp\\QSharpApplication1\\Operations.qs"
                foreach (var j in new Range((i + 1L), (nQubits - 1L)))
#line hidden
                {
#line 18 "C:\\Demo\\Quantum-Phase-Estimation-QSharp\\QSharpApplication1\\Operations.qs"
                    MicrosoftQuantumIntrinsicR1Frac.Controlled.Apply((new QArray<Qubit>(qs[j]), (1L, (j - i), qs[i])));
                }
            }

#line 22 "C:\\Demo\\Quantum-Phase-Estimation-QSharp\\QSharpApplication1\\Operations.qs"
            MicrosoftQuantumCanonSwapReverseRegister.Apply(qs);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<IQArray<Qubit>, QVoid> AdjointBody => (__in__) =>
        {
            var qs = __in__;
#line hidden
            var nQubits = qs.Length;
#line hidden
            MicrosoftQuantumCanonSwapReverseRegister.Adjoint.Apply(qs);
#line hidden
            foreach (var i in RangeReverse.Apply(new Range(0L, (nQubits - 1L))))
#line hidden
            {
#line hidden
                foreach (var j in RangeReverse.Apply(new Range((i + 1L), (nQubits - 1L))))
#line hidden
                {
#line hidden
                    MicrosoftQuantumIntrinsicR1Frac.Controlled.Adjoint.Apply((new QArray<Qubit>(qs[j]), (1L, (j - i), qs[i])));
                }

#line hidden
                MicrosoftQuantumIntrinsicH.Adjoint.Apply(qs[i]);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,IQArray<Qubit>), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,qs) = __in__;
#line hidden
            var nQubits = qs.Length;
#line hidden
            foreach (var i in new Range(0L, (nQubits - 1L)))
#line hidden
            {
#line hidden
                MicrosoftQuantumIntrinsicH.Controlled.Apply((__controlQubits__, qs[i]));
#line hidden
                foreach (var j in new Range((i + 1L), (nQubits - 1L)))
#line hidden
                {
#line hidden
                    MicrosoftQuantumIntrinsicR1Frac.Controlled.Controlled.Apply((__controlQubits__, (new QArray<Qubit>(qs[j]), (1L, (j - i), qs[i]))));
                }
            }

#line hidden
            MicrosoftQuantumCanonSwapReverseRegister.Controlled.Apply((__controlQubits__, qs));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,IQArray<Qubit>), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,qs) = __in__;
#line hidden
            var nQubits = qs.Length;
#line hidden
            MicrosoftQuantumCanonSwapReverseRegister.Adjoint.Controlled.Apply((__controlQubits__, qs));
#line hidden
            foreach (var i in RangeReverse.Apply(new Range(0L, (nQubits - 1L))))
#line hidden
            {
#line hidden
                foreach (var j in RangeReverse.Apply(new Range((i + 1L), (nQubits - 1L))))
#line hidden
                {
#line hidden
                    MicrosoftQuantumIntrinsicR1Frac.Controlled.Adjoint.Controlled.Apply((__controlQubits__, (new QArray<Qubit>(qs[j]), (1L, (j - i), qs[i]))));
                }

#line hidden
                MicrosoftQuantumIntrinsicH.Adjoint.Controlled.Apply((__controlQubits__, qs[i]));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonSwapReverseRegister = this.Factory.Get<IUnitary<IQArray<Qubit>>>(typeof(Microsoft.Quantum.Canon.SwapReverseRegister));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
            this.MicrosoftQuantumIntrinsicR1Frac = this.Factory.Get<IUnitary<(Int64,Int64,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.R1Frac));
        }

        public override IApplyData __dataIn(IQArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> qs)
        {
            return __m__.Run<QFTImpl, IQArray<Qubit>, QVoid>(qs);
        }
    }

    public class QuantumPhaseEstimationImpl : Unitary<(IUnitary,IQArray<Qubit>,IQArray<Qubit>)>, ICallable
    {
        public QuantumPhaseEstimationImpl(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IUnitary,IQArray<Qubit>,IQArray<Qubit>)>, IApplyData
        {
            public In((IUnitary,IQArray<Qubit>,IQArray<Qubit>) data) : base(data)
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

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicH
        {
            get;
            set;
        }

        protected IUnitary<(IUnitary,IQArray<Qubit>,Int64)> PowerOracle
        {
            get;
            set;
        }

        protected IUnitary<IQArray<Qubit>> QFTImpl
        {
            get;
            set;
        }

        public override Func<(IUnitary,IQArray<Qubit>,IQArray<Qubit>), QVoid> Body => (__in__) =>
        {
            var (oracle,targetState,controlRegister) = __in__;
#line 34 "C:\\Demo\\Quantum-Phase-Estimation-QSharp\\QSharpApplication1\\Operations.qs"
            var nQubits = controlRegister.Length;
#line 35 "C:\\Demo\\Quantum-Phase-Estimation-QSharp\\QSharpApplication1\\Operations.qs"
            MicrosoftQuantumCanonApplyToEachCA.Apply((MicrosoftQuantumIntrinsicH, controlRegister));
#line 37 "C:\\Demo\\Quantum-Phase-Estimation-QSharp\\QSharpApplication1\\Operations.qs"
            foreach (var idxControlQubit in new Range(0L, (nQubits - 1L)))
#line hidden
            {
#line 39 "C:\\Demo\\Quantum-Phase-Estimation-QSharp\\QSharpApplication1\\Operations.qs"
                var control = controlRegister[((nQubits - 1L) - idxControlQubit)];
#line 40 "C:\\Demo\\Quantum-Phase-Estimation-QSharp\\QSharpApplication1\\Operations.qs"
                var power = 2L.Pow(idxControlQubit);
#line 41 "C:\\Demo\\Quantum-Phase-Estimation-QSharp\\QSharpApplication1\\Operations.qs"
                PowerOracle.Controlled.Apply((new QArray<Qubit>(control), (oracle, targetState, power)));
            }

#line 51 "C:\\Demo\\Quantum-Phase-Estimation-QSharp\\QSharpApplication1\\Operations.qs"
            QFTImpl.Adjoint.Apply(controlRegister);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IUnitary,IQArray<Qubit>,IQArray<Qubit>), QVoid> AdjointBody => (__in__) =>
        {
            var (oracle,targetState,controlRegister) = __in__;
#line hidden
            var nQubits = controlRegister.Length;
#line hidden
            QFTImpl.Adjoint.Adjoint.Apply(controlRegister);
#line hidden
            foreach (var idxControlQubit in RangeReverse.Apply(new Range(0L, (nQubits - 1L))))
#line hidden
            {
#line hidden
                var control = controlRegister[((nQubits - 1L) - idxControlQubit)];
#line hidden
                var power = 2L.Pow(idxControlQubit);
#line hidden
                PowerOracle.Controlled.Adjoint.Apply((new QArray<Qubit>(control), (oracle, targetState, power)));
            }

#line hidden
            MicrosoftQuantumCanonApplyToEachCA.Adjoint.Apply((MicrosoftQuantumIntrinsicH, controlRegister));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(IUnitary,IQArray<Qubit>,IQArray<Qubit>)), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,(oracle,targetState,controlRegister)) = __in__;
#line hidden
            var nQubits = controlRegister.Length;
#line hidden
            MicrosoftQuantumCanonApplyToEachCA.Controlled.Apply((__controlQubits__, (MicrosoftQuantumIntrinsicH, controlRegister)));
#line hidden
            foreach (var idxControlQubit in new Range(0L, (nQubits - 1L)))
#line hidden
            {
#line hidden
                var control = controlRegister[((nQubits - 1L) - idxControlQubit)];
#line hidden
                var power = 2L.Pow(idxControlQubit);
#line hidden
                PowerOracle.Controlled.Controlled.Apply((__controlQubits__, (new QArray<Qubit>(control), (oracle, targetState, power))));
            }

#line hidden
            QFTImpl.Adjoint.Controlled.Apply((__controlQubits__, controlRegister));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(IUnitary,IQArray<Qubit>,IQArray<Qubit>)), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,(oracle,targetState,controlRegister)) = __in__;
#line hidden
            var nQubits = controlRegister.Length;
#line hidden
            QFTImpl.Adjoint.Adjoint.Controlled.Apply((__controlQubits__, controlRegister));
#line hidden
            foreach (var idxControlQubit in RangeReverse.Apply(new Range(0L, (nQubits - 1L))))
#line hidden
            {
#line hidden
                var control = controlRegister[((nQubits - 1L) - idxControlQubit)];
#line hidden
                var power = 2L.Pow(idxControlQubit);
#line hidden
                PowerOracle.Controlled.Adjoint.Controlled.Apply((__controlQubits__, (new QArray<Qubit>(control), (oracle, targetState, power))));
            }

#line hidden
            MicrosoftQuantumCanonApplyToEachCA.Adjoint.Controlled.Apply((__controlQubits__, (MicrosoftQuantumIntrinsicH, controlRegister)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyToEachCA = this.Factory.Get<IUnitary>(typeof(Microsoft.Quantum.Canon.ApplyToEachCA<>));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
            this.PowerOracle = this.Factory.Get<IUnitary<(IUnitary,IQArray<Qubit>,Int64)>>(typeof(PowerOracle));
            this.QFTImpl = this.Factory.Get<IUnitary<IQArray<Qubit>>>(typeof(QFTImpl));
        }

        public override IApplyData __dataIn((IUnitary,IQArray<Qubit>,IQArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IUnitary oracle, IQArray<Qubit> targetState, IQArray<Qubit> controlRegister)
        {
            return __m__.Run<QuantumPhaseEstimationImpl, (IUnitary,IQArray<Qubit>,IQArray<Qubit>), QVoid>((oracle, targetState, controlRegister));
        }
    }

    public class ExpOracle : Unitary<(Double,IQArray<Qubit>)>, ICallable
    {
        public ExpOracle(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Double,IQArray<Qubit>)>, IApplyData
        {
            public In((Double,IQArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item2)?.Qubits;
        }

        String ICallable.Name => "ExpOracle";
        String ICallable.FullName => "Quantum.QSharpApplication1.ExpOracle";
        protected IUnitary<(Double,Qubit)> MicrosoftQuantumIntrinsicRz
        {
            get;
            set;
        }

        public override Func<(Double,IQArray<Qubit>), QVoid> Body => (__in__) =>
        {
            var (eigenphase,register) = __in__;
#line 59 "C:\\Demo\\Quantum-Phase-Estimation-QSharp\\QSharpApplication1\\Operations.qs"
            MicrosoftQuantumIntrinsicRz.Apply(((2D * eigenphase), register[0L]));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Double,IQArray<Qubit>), QVoid> AdjointBody => (__in__) =>
        {
            var (eigenphase,register) = __in__;
#line hidden
            MicrosoftQuantumIntrinsicRz.Adjoint.Apply(((2D * eigenphase), register[0L]));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(Double,IQArray<Qubit>)), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,(eigenphase,register)) = __in__;
#line hidden
            MicrosoftQuantumIntrinsicRz.Controlled.Apply((__controlQubits__, ((2D * eigenphase), register[0L])));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(Double,IQArray<Qubit>)), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,(eigenphase,register)) = __in__;
#line hidden
            MicrosoftQuantumIntrinsicRz.Adjoint.Controlled.Apply((__controlQubits__, ((2D * eigenphase), register[0L])));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumIntrinsicRz = this.Factory.Get<IUnitary<(Double,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.Rz));
        }

        public override IApplyData __dataIn((Double,IQArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Double eigenphase, IQArray<Qubit> register)
        {
            return __m__.Run<ExpOracle, (Double,IQArray<Qubit>), QVoid>((eigenphase, register));
        }
    }

    public class PowerOracle : Unitary<(IUnitary,IQArray<Qubit>,Int64)>, ICallable
    {
        public PowerOracle(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IUnitary,IQArray<Qubit>,Int64)>, IApplyData
        {
            public In((IUnitary,IQArray<Qubit>,Int64) data) : base(data)
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

        public override Func<(IUnitary,IQArray<Qubit>,Int64), QVoid> Body => (__in__) =>
        {
            var (oracle,targetState,power) = __in__;
#line 70 "C:\\Demo\\Quantum-Phase-Estimation-QSharp\\QSharpApplication1\\Operations.qs"
            foreach (var idxPower in new Range(0L, (power - 1L)))
#line hidden
            {
#line 72 "C:\\Demo\\Quantum-Phase-Estimation-QSharp\\QSharpApplication1\\Operations.qs"
                oracle.Apply(targetState);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IUnitary,IQArray<Qubit>,Int64), QVoid> AdjointBody => (__in__) =>
        {
            var (oracle,targetState,power) = __in__;
#line hidden
            foreach (var idxPower in RangeReverse.Apply(new Range(0L, (power - 1L))))
#line hidden
            {
#line hidden
                oracle.Adjoint.Apply(targetState);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(IUnitary,IQArray<Qubit>,Int64)), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,(oracle,targetState,power)) = __in__;
#line hidden
            foreach (var idxPower in new Range(0L, (power - 1L)))
#line hidden
            {
#line hidden
                oracle.Controlled.Apply((__controlQubits__, targetState));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(IUnitary,IQArray<Qubit>,Int64)), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,(oracle,targetState,power)) = __in__;
#line hidden
            foreach (var idxPower in RangeReverse.Apply(new Range(0L, (power - 1L))))
#line hidden
            {
#line hidden
                oracle.Adjoint.Controlled.Apply((__controlQubits__, targetState));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
        }

        public override IApplyData __dataIn((IUnitary,IQArray<Qubit>,Int64) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IUnitary oracle, IQArray<Qubit> targetState, Int64 power)
        {
            return __m__.Run<PowerOracle, (IUnitary,IQArray<Qubit>,Int64), QVoid>((oracle, targetState, power));
        }
    }

    public class PhaseEstimationSample : Operation<Double, Double>, ICallable
    {
        public PhaseEstimationSample(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "PhaseEstimationSample";
        String ICallable.FullName => "Quantum.QSharpApplication1.PhaseEstimationSample";
        protected ICallable<Microsoft.Quantum.Arithmetic.BigEndian, Microsoft.Quantum.Arithmetic.LittleEndian> MicrosoftQuantumArithmeticBigEndianAsLittleEndian
        {
            get;
            set;
        }

        protected ICallable<Microsoft.Quantum.Arithmetic.LittleEndian, Int64> MicrosoftQuantumArithmeticMeasureInteger
        {
            get;
            set;
        }

        protected ICallable<Int64, Double> MicrosoftQuantumConvertIntAsDouble
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

        protected ICallable<Qubit, QVoid> MicrosoftQuantumIntrinsicReset
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        protected ICallable<QVoid, Double> MicrosoftQuantumMathPI
        {
            get;
            set;
        }

        protected IUnitary<(Double,IQArray<Qubit>)> ExpOracle
        {
            get;
            set;
        }

        protected IUnitary<(IUnitary,IQArray<Qubit>,IQArray<Qubit>)> QuantumPhaseEstimationImpl
        {
            get;
            set;
        }

        public override Func<Double, Double> Body => (__in__) =>
        {
            var eigenphase = __in__;
#line 78 "C:\\Demo\\Quantum-Phase-Estimation-QSharp\\QSharpApplication1\\Operations.qs"
            var oracle = ExpOracle.Partial(new Func<IQArray<Qubit>, (Double,IQArray<Qubit>)>((__arg1__) => (eigenphase, __arg1__)));
#line 79 "C:\\Demo\\Quantum-Phase-Estimation-QSharp\\QSharpApplication1\\Operations.qs"
            var n = 10L;
#line 81 "C:\\Demo\\Quantum-Phase-Estimation-QSharp\\QSharpApplication1\\Operations.qs"
            var estPhase = 0D;
#line hidden
            {
#line 83 "C:\\Demo\\Quantum-Phase-Estimation-QSharp\\QSharpApplication1\\Operations.qs"
                var (eigenstate,phaseRegister) = (Allocate.Apply(1L), Allocate.Apply(n));
#line hidden
                Exception __arg2__ = null;
                try
                {
#line 84 "C:\\Demo\\Quantum-Phase-Estimation-QSharp\\QSharpApplication1\\Operations.qs"
                    MicrosoftQuantumIntrinsicX.Apply(eigenstate[0L]);
#line 85 "C:\\Demo\\Quantum-Phase-Estimation-QSharp\\QSharpApplication1\\Operations.qs"
                    QuantumPhaseEstimationImpl.Apply((oracle, eigenstate, phaseRegister));
#line 86 "C:\\Demo\\Quantum-Phase-Estimation-QSharp\\QSharpApplication1\\Operations.qs"
                    var estReg = MicrosoftQuantumArithmeticMeasureInteger.Apply(MicrosoftQuantumArithmeticBigEndianAsLittleEndian.Apply(new Microsoft.Quantum.Arithmetic.BigEndian(phaseRegister)));
#line 88 "C:\\Demo\\Quantum-Phase-Estimation-QSharp\\QSharpApplication1\\Operations.qs"
                    estPhase = (((2D * MicrosoftQuantumMathPI.Apply(QVoid.Instance)) * MicrosoftQuantumConvertIntAsDouble.Apply(estReg)) / MicrosoftQuantumConvertIntAsDouble.Apply(2L.Pow(n)));
#line 89 "C:\\Demo\\Quantum-Phase-Estimation-QSharp\\QSharpApplication1\\Operations.qs"
                    MicrosoftQuantumIntrinsicReset.Apply(eigenstate[0L]);
                }
#line hidden
                catch (Exception __arg3__)
                {
                    __arg2__ = __arg3__;
                    throw __arg2__;
                }
#line hidden
                finally
                {
                    if (__arg2__ != null)
                    {
                        throw __arg2__;
                    }

#line hidden
                    Release.Apply(eigenstate);
#line hidden
                    Release.Apply(phaseRegister);
                }
            }

#line 92 "C:\\Demo\\Quantum-Phase-Estimation-QSharp\\QSharpApplication1\\Operations.qs"
            return estPhase;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumArithmeticBigEndianAsLittleEndian = this.Factory.Get<ICallable<Microsoft.Quantum.Arithmetic.BigEndian, Microsoft.Quantum.Arithmetic.LittleEndian>>(typeof(Microsoft.Quantum.Arithmetic.BigEndianAsLittleEndian));
            this.MicrosoftQuantumArithmeticMeasureInteger = this.Factory.Get<ICallable<Microsoft.Quantum.Arithmetic.LittleEndian, Int64>>(typeof(Microsoft.Quantum.Arithmetic.MeasureInteger));
            this.MicrosoftQuantumConvertIntAsDouble = this.Factory.Get<ICallable<Int64, Double>>(typeof(Microsoft.Quantum.Convert.IntAsDouble));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicReset = this.Factory.Get<ICallable<Qubit, QVoid>>(typeof(Microsoft.Quantum.Intrinsic.Reset));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
            this.MicrosoftQuantumMathPI = this.Factory.Get<ICallable<QVoid, Double>>(typeof(Microsoft.Quantum.Math.PI));
            this.ExpOracle = this.Factory.Get<IUnitary<(Double,IQArray<Qubit>)>>(typeof(ExpOracle));
            this.QuantumPhaseEstimationImpl = this.Factory.Get<IUnitary<(IUnitary,IQArray<Qubit>,IQArray<Qubit>)>>(typeof(QuantumPhaseEstimationImpl));
        }

        public override IApplyData __dataIn(Double data) => new QTuple<Double>(data);
        public override IApplyData __dataOut(Double data) => new QTuple<Double>(data);
        public static System.Threading.Tasks.Task<Double> Run(IOperationFactory __m__, Double eigenphase)
        {
            return __m__.Run<PhaseEstimationSample, Double, Double>(eigenphase);
        }
    }
}