using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RepositoryWithMVC_LastTime.Data.BLL;
using RepositoryWithMVC_LastTime.Data.DAL;
using RepositoryWithMVC_LastTime.Models;
using System;

namespace UnitTest
{
    [TestClass]
    public class AccountUnitTest
    {
        Mock<IRepository<Account>> repoMock;
        AccountBusinessLogic accountBl;
        double initialBalance = 123.25;

        [TestInitialize]
        public void InitalizeTests()
        {
            repoMock = new Mock<IRepository<Account>>();

            accountBl = new AccountBusinessLogic(repoMock.Object);

            repoMock.Setup(x => x.Get(It.Is<int>(i => i == 1))).Returns(new Account
            {
                Id = 1,
                Balance = initialBalance,
                IsActive = true,
                Name = "testAccount"
            });
        }

        [TestMethod]
        public void GetBalance()
        {
            Assert.AreEqual(initialBalance, accountBl.GetBalance(1));
        }

        [TestMethod]
        public void GetBalanceWithNullReferenceIdReturnsExcption()
        {
            Assert.ThrowsException<Exception>(() => accountBl.GetBalance(2));
        }
    }
}