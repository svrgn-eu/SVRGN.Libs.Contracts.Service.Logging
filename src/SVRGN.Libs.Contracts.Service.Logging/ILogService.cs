using SVRGN.Libs.Contracts.Service.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace SVRGN.Libs.Contracts.Service.Logging
{
    /// <summary>
    /// this service is responsible for logging and escalating Errors and Fatals to the ErrorService
    /// </summary>
    public interface ILogService : IService
    {
        #region Properties

        int FatalCount { get; }
        int ErrorCount { get; }
        int WarningCount { get; }
        int InfoCount { get; }
        int DebugCount { get; }
        int TotalCount { get; }

        #endregion Properties

        #region Methods

        void Fatal(string SenderClassName, string SenderMethodName, string Entry, Exception exception = null);
        void Error(string SenderClassName, string SenderMethodName, string Entry, Exception exception = null);
        void Warning(string SenderClassName, string SenderMethodName, string Entry, Exception exception = null);
        void Info(string SenderClassName, string SenderMethodName, string Entry, Exception exception = null);
        void Debug(string SenderClassName, string SenderMethodName, string Entry, Exception exception = null);
        void SetMinimumLogLevel(string LogLevel);

        #endregion Methods
    }
}
