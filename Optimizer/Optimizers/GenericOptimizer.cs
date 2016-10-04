using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using Newtonsoft.Json.Linq;
using QuantConnect.Algorithm;
using QuantConnect.Configuration;
using QuantConnect.Interfaces;
using QuantConnect.Lean.Engine;
using QuantConnect.Lean.Engine.DataFeeds;
using QuantConnect.Lean.Engine.HistoricalData;
using QuantConnect.Lean.Engine.RealTime;
using QuantConnect.Lean.Engine.Results;
using QuantConnect.Lean.Engine.Setup;
using QuantConnect.Lean.Engine.TransactionHandlers;
using QuantConnect.Logging;
using QuantConnect.Packets;
using QuantConnect.Queues;
using QuantConnect.Util;

namespace QuantConnect.Optimizer.Optimizers
{
    /// <summary>
    ///  A GenericOptimizer would remember breed its parameter sets as to get the best 
    /// results and generate new ones.
    /// </summary>
    public abstract class GenericOptimizer : IOptimizer
    {
        private Api.Api _api;
        private Messaging.Messaging _notify;
        private JobQueue _jobQueue;
        protected IResultHandler _resultshandler;

        private FileSystemDataFeed _dataFeed;
        private ConsoleSetupHandler _setup;
        private BacktestingRealTimeHandler _realTime;
        private ITransactionHandler _transactions;
        private IHistoryProvider _historyProvider;

        protected readonly Engine _engine;

        protected QCAlgorithm _algo;
        protected List<Dictionary<string, string>> parameterSets;
        protected Dictionary<string, string> bestParameters;
        protected List<string> parametersKeys;

        public GenericOptimizer()
        {
          
        }

        public GenericOptimizer(QCAlgorithm algo)
        {
            parametersKeys = new List<string>();
            JObject parameters = JObject.Parse(Config.Get(key: "parameters"));

            foreach (var param in parameters)
            {
                parametersKeys.Add(param.Key);
            }

            // Logic of optimization
            parameterSets = new List<Dictionary<string, string>>();

            bestParameters = new Dictionary<string, string>();
            _algo = algo;
        }
        
        protected void LaunchEngine()
        {
            _jobQueue = new JobQueue();
            _notify = new Messaging.Messaging();
            _api = new Api.Api();
            _resultshandler = new DesktopResultHandler();
            _dataFeed = new FileSystemDataFeed();
            _setup = new ConsoleSetupHandler();
            _realTime = new BacktestingRealTimeHandler();
            _historyProvider = new SubscriptionDataReaderHistoryProvider();
            _transactions = new BacktestingTransactionHandler();
            var systemHandlers = new LeanEngineSystemHandlers(_jobQueue, _api, _notify);
            systemHandlers.Initialize();

            Log.LogHandler = Composer.Instance.GetExportedValueByTypeName<ILogHandler>(Config.Get("log-handler", "CompositeLogHandler"));

            LeanEngineAlgorithmHandlers leanEngineAlgorithmHandlers;
            try
            {
                leanEngineAlgorithmHandlers = LeanEngineAlgorithmHandlers.FromConfiguration(Composer.Instance);
                _resultshandler = leanEngineAlgorithmHandlers.Results;
            }
            catch (CompositionException compositionException)
            {
                Log.Error("Engine.Main(): Failed to load library: " + compositionException);
                throw;
            }
            string algorithmPath;
            AlgorithmNodePacket job = systemHandlers.JobQueue.NextJob(out algorithmPath);
            try
            {
                var _engine = new Engine(systemHandlers, leanEngineAlgorithmHandlers, Config.GetBool("live-mode"));
                _engine.Run(job, algorithmPath);
            }
            finally
            {
                //Delete the message from the job queue:
                //systemHandlers.JobQueue.AcknowledgeJob(job);
                Log.Trace("Engine.Main(): Packet removed from queue: " + job.AlgorithmId);

                // clean up resources
                systemHandlers.Dispose();
                leanEngineAlgorithmHandlers.Dispose();
                Log.LogHandler.Dispose();
            }
        }


        public abstract Dictionary<string, string> Optimize(BacktestResult result);

        public abstract Dictionary<string, string> Optimize();

    }
}
