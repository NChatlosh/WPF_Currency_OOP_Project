using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WPFCurrencyLibrary.ViewModels;
using CurrencyLibrary;
using CurrencyLibrary.USCurrency;
using System.Collections.Generic;
using System.ComponentModel;

namespace WPFCurrencyTests
{
    [TestClass]
    public class MakeChangeUCVMTests
    {
        MakeChangeUCViewModel mvm;
        USCurrencyRepo repo;
        public MakeChangeUCVMTests()
        {
            repo = new USCurrencyRepo();
            repo.AddCoin(new Penny());
            mvm = new MakeChangeUCViewModel(repo);
        }

        [TestMethod]
        public void MakeChangeUCMakeChangeCommandTest()
        {
            //Arrange
            int countBefore = mvm.Repo.GetCoinCount();
            mvm.Amount = "1.23";
            List<string> receivedEvents = new List<string>();
            double total = 1.24;

            mvm.PropertyChanged += delegate (object sender, PropertyChangedEventArgs e)
            {
                receivedEvents.Add(e.PropertyName);
            };
            //Act
            mvm.MakeChangeCommand.Execute(null);
            //Assert
            Assert.AreEqual("$ " + total.ToString(), mvm.Total);
            Assert.AreEqual(receivedEvents[0], "Coins_CollectionChanged");
            Assert.AreEqual(string.Empty, mvm.Amount);
            Assert.AreNotEqual(countBefore, mvm.Repo.GetCoinCount());
        }

        [TestMethod]
        public void MakeChangeUCCanMakeChangeCommandBadInputTest()
        {
            //Arrange
            int countBefore = mvm.Repo.GetCoinCount();
            mvm.Amount = "Test";
            List<string> receivedEvents = new List<string>();
            double total = 0.02;

            mvm.PropertyChanged += delegate (object sender, PropertyChangedEventArgs e)
            {
                receivedEvents.Add(e.PropertyName);
            };
            //Act
            mvm.MakeChangeCommand.Execute(null);
            //Assert
            Assert.AreEqual(1, receivedEvents.Count);
            Assert.AreEqual(countBefore, mvm.Repo.GetCoinCount());
            mvm.Repo.AddCoin(new Penny());
            Assert.AreEqual("$ " + total.ToString(), mvm.Total);
        }
    }
}
