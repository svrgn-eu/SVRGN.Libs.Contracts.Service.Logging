using SVRGN.Libs.Contracts.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace SVRGN.Libs.Contracts.Service.Logging
{
    public interface ILogStrategy : IBaseObject
    {
        #region Properties

        #endregion Properties

        #region Methods
        void Output(string Severity, string SenderClassName, string SenderMethodName, string Entry, bool ShallIncludeTimeStamps, Exception Exception);

        #endregion Methods
    }
}
