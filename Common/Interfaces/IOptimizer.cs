using System.Collections.Generic;
using QuantConnect.Packets;

namespace QuantConnect.Interfaces
{
    /// <summary>
    /// Allow users to set the optimization technique to use. Set the IOptimizer which will generate the parameter sets to backtest.
    /// </summary>
    public interface IOptimizer
    {
        Dictionary<string, string> Optimize();

        /// <summary>
        /// IOptimizer would take in the last set of results; and return a new parameter set to backtest over.
        /// </summary>
        /// <param name="result"> Last set of results
        /// <returns> New parameter set to backtest over.</returns>
        Dictionary<string, string> Optimize(BacktestResult result);
        
    }
}
