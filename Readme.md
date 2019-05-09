# Q# Sample for Quantum Phase Estimation

Q# provides [Microsoft.Quantum.Canon.QuantumPhaseEstimation()](https://docs.microsoft.com/en-us/qsharp/api/canon/microsoft.quantum.canon.quantumphaseestimation?view=qsharp-preview) and you don't need to implement this algorithms by yourself.    
This source code is only for the purpose of your learning.

See my post "[Programming Quantum Phase Estimation (with Quantum Fourier Transform)](https://tsmatz.wordpress.com/2019/04/26/quantum-computing-qsharp-quantum-fourier-transform-and-phase-estimation/)" for the background about Quantum Phase Estimation and this sample code.

Almost all lines of code are written by primitive Q# operators, but the only following is written by using high-level (or user-defined) operators in Microsoft.Quantum.Canon (for simplifying this example).

- *Microsoft.Quantum.Canon.SwapReverseRegister()*    
  For the reverse of all n qubits, such as ![math expression](https://chart.googleapis.com/chart?cht=tx&chl=%5cleft%7c+a_0+%5cright%3e+%5cleft%7c+a_1+%5cright%3e+%5cldots+%5cleft%7c+a_%7bn-1%7d+%5cright%3e+%5crightarrow+%5cleft%7c+a_%7bn-1%7d+%5cright%3e+%5cleft%7c+a_%7bn-2%7d+%5cright%3e+%5cldots+%5cleft%7c+a_0+%5cright%3e).    
  You can implement the same operation with SWAP operator using 3 CNOT and 2 / n combinations of SWAP.
- *Microsoft.Quantum.Canon.ApplyToEachCA()*    
  For applying H() to all qubits in the single line of code. (You can implement the same operation by loop execution.)
- *Microsoft.Quantum.Canon.BigEndian() and Microsoft.Quantum.Canon.MeasureIntegerBE()*    
  For measuring qubits' integer by big endian order.    
  You can implement the same operation by measuring each register qubits and sum.

*Tsuyoshi Matsuzaki @ Microsoft*
