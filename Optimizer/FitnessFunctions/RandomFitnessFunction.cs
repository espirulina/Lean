using System;
using System.Collections.Generic;
using QuantConnect.Optimizer.Interfaces;
using QuantConnect.Packets;

namespace QuantConnect.Optimizer.FitnessFunctions
{
    public class RandomFitnessFunction : IFitnessFunction
    {
        // Constructor
        public RandomFitnessFunction()
        {
            
        }        
            
        /// <summary>
        /// Evaluate backtest result - calculates its fitness value
        /// </summary>
        public double Evaluate(Dictionary<string, string> statistics)
        {
            var ratio = Convert.ToDouble(statistics["Sharpe Ratio"]);
            return ratio;
        }
        
    }
}
