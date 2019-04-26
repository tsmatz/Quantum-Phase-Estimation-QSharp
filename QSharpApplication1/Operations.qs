namespace Quantum.QSharpApplication1
{
	open Microsoft.Quantum.Extensions.Convert;
    open Microsoft.Quantum.Primitive;
	open Microsoft.Quantum.Extensions.Math;
    
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

	operation QuantumPhaseEstimationImpl (oracle : (Qubit[] => Unit : Adjoint, Controlled), targetState : Qubit[], controlRegister : Qubit[]) : Unit
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
				//	Controlled oracle([control], targetState);
				//}
            }
            
            Adjoint QFTImpl(controlRegister);
        }
        
        adjoint invert;
        controlled distribute;
        controlled adjoint distribute;
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

	operation PowerOracle (oracle : (Qubit[] => Unit : Adjoint, Controlled), targetState : Qubit[], power : Int) : Unit {

        body (...) {
			for (idxPower in 0 .. power - 1)
			{
				oracle(targetState);
			}
		}

        adjoint invert;
        controlled distribute;
        controlled adjoint distribute;
	}

	operation PhaseEstimationSample (eigenphase : Double) : Double {
		let oracle = ExpOracle(eigenphase, _); // Generate (Qubit[] => Unit) with eigenphase 
		let n = 10;

        mutable estPhase = 0.0;
        
        using ((eigenstate, phaseRegister) = (Qubit[1], Qubit[n])) {
            X(eigenstate[0]);
            QuantumPhaseEstimationImpl(oracle, eigenstate, phaseRegister);
			let estReg = Microsoft.Quantum.Canon.MeasureIntegerBE(Microsoft.Quantum.Canon.BigEndian(phaseRegister));
			set estPhase = 2.0 * PI() * ToDouble(estReg) / ToDouble(2 ^ n);
            Reset(eigenstate[0]);
        }
        
        return estPhase;
	}

}
