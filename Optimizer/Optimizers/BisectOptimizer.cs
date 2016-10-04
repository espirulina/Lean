using System.Collections.Generic;
using QuantConnect.Packets;

namespace QuantConnect.Optimizer.Optimizers
{
    /// <summary>
    ///  Bisect optimizer could bisect and skip large empty parts
    /// </summary>
    public class BisectOptimizer : GenericOptimizer
    {
        public BisectOptimizer()
        {
            
        }
        public Dictionary<string, decimal> Optimize()
        {
            Dictionary<string, decimal> parameters = new Dictionary<string, decimal>();

            //TODO => Logic of optimization

            return parameters;
        }
        public Dictionary<string, decimal> Optimize(BacktestResult result)
        {
            Dictionary<string, decimal> parameters = new Dictionary<string, decimal>();

            //TODO => Logic of optimization

            return parameters;
        }
    }
}
