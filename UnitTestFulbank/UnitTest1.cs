using Fulbank.classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestFulbank
{
    [TestClass]
    public class BankTest
    {
        [TestMethod]
        public void DebitTest()
        {
            User aUser = new User(1, "DE LOS RIOS", "Nathan", "nathan.delosrios28@gmail.com", "0628745324", "0215458965", "3 rue de la pie, 28000, Chartres");
            aUser.Add_Account(1, 1, 500.00, -100);

            aUser.GetAccounts()[0].OperationDebit(100);

            Assert.AreEqual(400.00, aUser.GetAccounts()[0].Get_Balance());
        }

        [TestMethod]
        public void CreditTest()
        {
            User aUser = new User(1, "DE LOS RIOS", "Nathan", "nathan.delosrios28@gmail.com", "0628745324", "0215458965", "3 rue de la pie, 28000, Chartres");
            aUser.Add_Account(1, 1, 500.00, -100);

            aUser.GetAccounts()[0].OperationDeposit(100);

            Assert.AreEqual(600.00, aUser.GetAccounts()[0].Get_Balance());
        }
    }
}
