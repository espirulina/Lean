using System;
using QuantConnect;
using QuantConnect.Algorithm;
using System.Threading;
using System.Reflection;
using System.Collections.Generic;
using QuantConnect.Logging;
using QuantConnect.Optimizer.Optimizers;
using QuantConnect.Packets;
using QuantConnect.Algorithm.CSharp;

namespace QuantConnect.Optimizer
{
    //An executable project taking an IAlgorithm object and launching backtests.
    public class Program
    {

        public static void Main(string[] args)
        {
            try
            {
                Log.Trace(traceText: "QuantConnect.Optimizer() --------------------------------------");

                //TODO Load Algo by name and not by object
                var algo = new ParameterizedAlgorithm();

                var rndOptimizer = new RandomOptimizer(algo);

                algo.SetOptimizer(rndOptimizer);

                Log.Trace("QuantConnect.Optimizer(): " + " Random Optimizer set in Algo: " + algo.Name);

                var optimizedParameters = algo.Optimizer.Optimize();

                Log.Trace("QuantConnect.Optimizer(): " + "Optimized Parameters:");
                foreach (var param in optimizedParameters.Keys)
                {
                    Log.Trace("QuantConnect.Optimizer(): " + param + ": " + optimizedParameters[param]);
                }
            }
            catch (Exception ex)
            {
                  Log.Error("QuantConnect.Optimizer(): " + ex.Message);
                Log.Error("QuantConnect.Optimizer(): " + ex.StackTrace);
            }

            Console.ReadLine();

        }
     
    }
}
