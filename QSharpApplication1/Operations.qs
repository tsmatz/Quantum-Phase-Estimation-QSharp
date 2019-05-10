namespace Quantum.QSharpApplication1
{
    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Convert;
    open Microsoft.Quantum.Math;
    
    operation QFTImpl (qs : Qubit[]) : Unit
    {
        body (...)
        {
            let nQubits = Length(qs);
            
            for (i in 0 .. nQubits - 1)
            {
                H(qs[i]);
                for (j in i + 1 .. nQubits - 1)
                {
                    Controlled R1Frac([qs[j]], (1, j - i, qs[i]));
                }
            }
            
            Microsoft.Quantum.Canon.SwapReverseRegister(qs);
        }
        
        adjoint invert;
        controlled distribute;
        controlled adjoint distribute;
    }

    operation QuantumPhaseEstimationImpl (oracle : (Qubit[] => Unit is Adj + Ctl), targetState : Qubit[], controlRegister : Qubit[]) : Unit is Adj + Ctl
    {
        body (...)
        {
            let nQubits = Length(controlRegister);
            Microsoft.Quantum.Canon.ApplyToEachCA(H, controlRegister);
            
            for (idxControlQubit in 0 .. nQubits - 1)
            {
                let control = (controlRegister)[nQubits - 1 - idxControlQubit];
                let power = 2 ^ idxControlQubit;
                Controlled PowerOracle([control], (oracle, targetState, power));

                //// You can also write as follows,
                //// Or use Microsoft.Quantum.Canon.DiscreteOracle instead
                //for (idxPower in 0 .. power - 1)
                //{
                //  Controlled oracle([control], targetState);
                //}
            }
            
            Adjoint QFTImpl(controlRegister);
        }        
    }

    /// This is bloackbox oracle !
    operation ExpOracle (eigenphase : Double, register : Qubit[]) : Unit {
        
        body (...) {
            Rz(2.0 * eigenphase, register[0]);
        }
        
        adjoint invert;
        controlled distribute;
        controlled adjoint distribute;
    }

    operation PowerOracle (oracle : (Qubit[] => Unit is Adj + Ctl), targetState : Qubit[], power : Int) : Unit is Adj + Ctl {

        body (...) {
            for (idxPower in 0 .. power - 1)
            {
                oracle(targetState);
            }
        }
    }

    operation PhaseEstimationSample (eigenphase : Double) : Double {
        let oracle = ExpOracle(eigenphase, _); // Generate (Qubit[] => Unit) with eigenphase 
        let n = 10;

        mutable estPhase = 0.0;
        
        using ((eigenstate, phaseRegister) = (Qubit[1], Qubit[n])) {
            X(eigenstate[0]);
            QuantumPhaseEstimationImpl(oracle, eigenstate, phaseRegister);
            let estReg = Microsoft.Quantum.Arithmetic.MeasureInteger(
                Microsoft.Quantum.Arithmetic.BigEndianAsLittleEndian(Microsoft.Quantum.Arithmetic.BigEndian(phaseRegister)));
            set estPhase = 2.0 * PI() * IntAsDouble(estReg) / IntAsDouble(2 ^ n);
            Reset(eigenstate[0]);
        }
        
        return estPhase;
    }

}
