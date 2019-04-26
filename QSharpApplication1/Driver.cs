using System;

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace Quantum.QSharpApplication1
{
    class Driver
    {
        static void Main(string[] args)
        {
            using (var qsim = new QuantumSimulator())
            {
                Double eigenphase;
                Double est;

                var rand = new Random(1);

                eigenphase = rand.NextDouble() * 3 * 2;
                est = PhaseEstimationSample.Run(qsim, eigenphase).Result;
                Console.WriteLine($"Expected {eigenphase}, estimated {est}.");

                eigenphase = rand.NextDouble() * 3 * 2;
                est = PhaseEstimationSample.Run(qsim, eigenphase).Result;
                Console.WriteLine($"Expected {eigenphase}, estimated {est}.");

                eigenphase = rand.NextDouble() * 3 * 2;
                est = PhaseEstimationSample.Run(qsim, eigenphase).Result;
                Console.WriteLine($"Expected {eigenphase}, estimated {est}.");
            }

            Console.ReadLine();
        }
    }
}