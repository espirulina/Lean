using System;
using System.Collections.Generic;
using QuantConnect.Algorithm;
using QuantConnect.Lean.Engine.Results;
using QuantConnect.Packets;

namespace QuantConnect.Optimizer.Optimizers
{
  public class RandomOptimizer : GenericOptimizer
    {
        public RandomOptimizer()
        {

        }

        public RandomOptimizer(QCAlgorithm algo) : base(algo)
        {
            
        }

        public new Dictionary<string, string> Optimize()
        {
            // Create 5 Random parameter sets
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                Dictionary<string, string> set = new Dictionary<string, string>();
                foreach (var key in parametersKeys)
                {
                    string param = Convert.ToDecimal(rnd.NextDouble()).ToString();
                    set.Add(key, param);
                }
                parameterSets.Add(set);
            }

            // Foreach set run a simulation backtest
            List<Dictionary<string, string>> statistics = new List<Dictionary<string, string>>();

            foreach (Dictionary<string, string> paramSet in parameterSets)
            {
                _algo.SetParameters(paramSet);

                LaunchEngine();
                BacktestingResultHandler resultshandler = (BacktestingResultHandler) _resultshandler;

                statistics.Add(resultshandler.FinalStatistics);
            }

            //Check best ratio
            //TODO Change to LINQ string best = statistics.Max(s => s["ratio"]);

            int bestBacktestIndex = -1;
            decimal maxRatio = 0;
            for (int i = 0; i < parameterSets.Count; i++)
            {
                decimal ratio = Convert.ToDecimal(statistics[i]["ratio"]);
                if (ratio > maxRatio)
                {
                    maxRatio = ratio;
                    bestBacktestIndex = i;
                }
            }

            bestParameters = parameterSets[bestBacktestIndex];

            return bestParameters;
        }

        public Dictionary<string, string> Optimize(BacktestResult result)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            //TODO => Logic of optimization

            return parameters;
        }
    }
}
