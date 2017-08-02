using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace GigCommunity.IntegrationTests
{
    public class Isolated : Attribute, ITestAction
    {
        private TransactionScope _transactionScope;

        public ActionTargets Targets
        {
            get { return ActionTargets.Test; }
        }

        public TransactionScope TransactionScope { get => _transactionScope; set => _transactionScope = value; }

        public void AfterTest(TestDetails testDetails)
        {
            _transactionScope.Dispose();
        }

        public void BeforeTest(TestDetails testDetails)
        {
            _transactionScope = new TransactionScope();
        }
    }
}
