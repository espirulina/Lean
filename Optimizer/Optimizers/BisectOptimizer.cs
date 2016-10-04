using System.Collections.Generic;
using QuantConnect.Packets;

namespace QuantConnect.Optimizer.Optimizers
{
    /// <summary>
    ///  Bisect optimizer could bisect and skip large empty parts
    /// </summary>
    public class BisectOptimizer : GenericOptimizer
    {
        public BisectOptimizer() : base()
        {
            
        }
        public override Dictionary<string, string> Optimize()
        {
            var parameters = new Dictionary<string, string>();

            //TODO => Logic of optimization

            return parameters;
        }
        public override Dictionary<string, string> Optimize(BacktestResult result)
        {
            var parameters = new Dictionary<string, string>();

            //TODO => Logic of optimization

            return parameters;
        }
    }
}
