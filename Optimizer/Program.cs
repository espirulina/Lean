using System;
using QuantConnect;
using QuantConnect.Algorithm.CSharp;
using QuantConnect.Algorithm;
using QuantConnect.Optimizers;
using System.Threading;
using System.Reflection;
using System.Collections.Generic;
using QuantConnect.Logging;
using QuantConnect.Packets;

namespace QuantConnect.Optimizer
{
    //An executable project taking an IAlgorithm object and launching backtests.
    class Program
    {
        private static AppDomainSetup _ads;
        private static string _callingDomainName;
        private static string _exeAssembly;

        public static void Main(string[] args)
        {
            //TODO Load Algo by name and not by object
            ParameterizedAlgorithm algo = new ParameterizedAlgorithm();

            BacktestResult result;

            algo.SetOptimizer(new GenericOptimizer());

            Dictionary<string,string> optimizedParameters = algo.Optimizer.Optimize();


        }
     
    }
}
