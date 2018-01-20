using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monopoly_Game;

namespace MonopolyTest
{
    [TestClass]
    public class BankTest
    {
        [TestMethod]
        public void TestWithdrow()
        {
            Bank bank = new Bank();
            Assert.AreEqual(15140, bank.GetBalance());
            bank.Withdraw(15000);
            Assert.AreEqual(140, bank.GetBalance());
     

        }


        [TestMethod]
        public void TestDeposit()
        {
            Bank bank = new Bank();
            bank.Deposit(200);
            Assert.AreEqual(15340, bank.GetBalance());

            bank.Deposit(-100);
            Assert.AreEqual(15340, bank.GetBalance());

            bank.Deposit(100);
            Assert.AreEqual(15440, bank.GetBalance());


        }


    }

}
