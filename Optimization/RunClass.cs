﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using QuantConnect.Lean.Engine;
using QuantConnect.Lean.Engine.Results;
using QuantConnect.Packets;
using QuantConnect.Configuration;
using QuantConnect.Util;
using QuantConnect.Interfaces;
using QuantConnect.Queues;
using QuantConnect.Messaging;
using QuantConnect.Api;
using QuantConnect.Logging;
using QuantConnect.Lean.Engine.DataFeeds;
using QuantConnect.Lean.Engine.Setup;
using QuantConnect.Lean.Engine.RealTime;
using QuantConnect.Lean.Engine.TransactionHandlers;
using QuantConnect.Lean.Engine.HistoricalData;

namespace QuantConnect.Optimization
{
    public class RunClass : MarshalByRefObject
    {
        private Api.Api _api;
        private Messaging.Messaging _notify;
        private JobQueue _jobQueue;
        private IResultHandler _resultshandler;

        private FileSystemDataFeed _dataFeed;
        private ConsoleSetupHandler _setup;
        private BacktestingRealTimeHandler _realTime;
        private ITransactionHandler _transactions;
        private IHistoryProvider _historyProvider;

        private readonly Engine _engine;

        public RunClass()
        {

        }
        public string[] Run(string algorithmName)
        {
            LaunchLean(algorithmName);
            BacktestingResultHandler resultshandler = (BacktestingResultHandler)_resultshandler;

            var ratio = resultshandler.FinalStatistics["Sharpe Ratio"];

            string[] results = new[] {ratio};

            return results;
        }
        private void LaunchLean(string algorithmName)
        {
            Config.Set("environment", "backtesting");
            Config.Set("job-user-id", "12594");
            Config.Set("environment", "backtesting");
            Config.Set("api-access-token", "72fc81e35e4d33eb6a0e46355409769a");
            Config.Set("data - folder", "../../../Data/");
            
            Config.Set("algorithm-type-name", algorithmName);
            Config.Set("algorithm-language", "CSharp");

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

            //			var algorithmHandlers = new LeanEngineAlgorithmHandlers (_resultshandler, _setup, _dataFeed, _transactions, _realTime, _historyProvider);
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

    }

}
