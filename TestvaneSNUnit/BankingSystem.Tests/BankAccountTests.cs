using System;
using System.Collections.Generic;
using System.Text;
using BankingSystem;
using NUnit.Framework;

namespace BankingSystem.Tests
{
    [TestFixture]
    public class BankAccountTests
    {
       [Test]
        public void AccountInitializeWithPositiveValue()
        {
            BankAccount account = new BankAccount(2000m);
            Assert.AreEqual(2000m, account.Balance);
        }
        [Test]
        public void DepositShouldAddMoney()
        {
            BankAccount account = new BankAccount();
            account.Deposit(50);
            Assert.IsTrue(account.Balance == 50);
        }
        [Test]
        public void CreditShouldAddMoney()
        {
            BankAccount account = new BankAccount();
            account.Credit(50);
            Assert.IsTrue(account.Balance == 50);
        }
        [Test]   
        public void IncreaseShouldAddMoneyWithPercent()
            {
                BankAccount account = new BankAccount(1000);
                account.Increase(20);
                Assert.IsTrue(account.Balance == 1200);
            }
        [Test]
        public void CheckIfBonusWorks1()
        {
            BankAccount account = new BankAccount(4000);
            account.Bonus();
            Assert.IsTrue(account.Balance == 4300);
        }
        [Test]
        public void CheckIfBonusWorks2()
        {
            BankAccount account = new BankAccount(2500);
            account.Bonus();
            Assert.IsTrue(account.Balance == 2700);
        }
        [Test]
        public void CheckIfBonusWorks3()
        {
            BankAccount account = new BankAccount(1500);
            account.Bonus();
            Assert.IsTrue(account.Balance == 1600);
        }
        [Test]
        public void CheckIfBonusWorks4()
        {
            BankAccount account = new BankAccount(900);
            account.Bonus();
            Assert.IsTrue(account.Balance == 900);
        }
    }
}
