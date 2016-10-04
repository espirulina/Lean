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
                Log.Trace("QuantConnect.Optimizer() --------------------------------------");

                //TODO Load Algo by name and not by object
                ParameterizedAlgorithm algo = new ParameterizedAlgorithm();

                algo.SetOptimizer(new RandomOptimizer(algo));

                Log.Trace("QuantConnect.Optimizer(): " + " Random Optimizer set in Algo: " + algo.Name);

                Dictionary<string, string> optimizedParameters = algo.Optimizer.Optimize();

                Log.Trace("QuantConnect.Optimizer(): " + "Optimized Parameters:");
                foreach (var param in optimizedParameters.Keys)
                {
                    Log.Trace("QuantConnect.Optimizer(): " + param + ": " + optimizedParameters[param]);
                }
            }
            catch (Exception ex)
            {
                  Log.Trace("QuantConnect.Optimizer(): " + ex.Message);
            }

            Console.ReadLine();

        }
     
    }
}
