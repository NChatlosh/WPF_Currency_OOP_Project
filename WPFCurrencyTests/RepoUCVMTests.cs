using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CurrencyLibrary.USCurrency;
using WPFCurrencyLibrary.ViewModels;
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using CurrencyLibrary;

namespace WPFCurrencyTests
{
    [TestClass]
    public class RepoUCVMTests
    {
        RepoUCViewModel rvm;
        USCurrencyRepo repo;
        public RepoUCVMTests()
        {
            repo = new USCurrencyRepo();
            repo.AddCoin(new Penny());
            rvm = new RepoUCViewModel(repo);
        }

        [TestMethod]
        public void RepoUCAddCommandTest()
        {
            //Arrange
            int countBefore = rvm.Repo.GetCoinCount();
            rvm.Quantity = "3";
            List<string> receivedEvents = new List<string>();
            double total = 0.04;

            rvm.PropertyChanged += delegate (object sender, PropertyChangedEventArgs e)
            {
                receivedEvents.Add(e.PropertyName);
            };
            //Act
            rvm.AddCommand.Execute(new Penny());
            //Assert
            Assert.AreEqual(receivedEvents[0], "Coins_CollectionChanged");
            Assert.AreEqual((countBefore + 3), rvm.Repo.GetCoinCount());
            Assert.AreEqual("$ " + total.ToString(), rvm.Total);
        }

        [TestMethod]
        public void RepoUCNewCommandTest()
        {
            //Arrange
            int countAfter = 1;
            List<string> receivedEvents = new List<string>();
            double total = 0.01;

            rvm.PropertyChanged += delegate (object sender, PropertyChangedEventArgs e)
            {
                receivedEvents.Add(e.PropertyName);
            };
            //Act
            rvm.NewCommand.Execute(null);
            //Assert
            Assert.AreEqual(receivedEvents[0], "Coins_CollectionChanged");
            Assert.AreEqual(countAfter, rvm.Repo.GetCoinCount());
            Assert.AreEqual("$ " + total.ToString(), rvm.Total);
        }

        [TestMethod]
        public void VMBaseRepoUCSaveLoadCommandTest()
        {
            //Arrange
            ObservableCollection<ICoin> testCoins = rvm.Repo.Coins;
            List<string> receivedEvents = new List<string>();
            rvm.PropertyChanged += delegate (object sender, PropertyChangedEventArgs e)
            {
                receivedEvents.Add(e.PropertyName);
            };
            //Act
            rvm.SaveCommand.Execute(null);
            rvm.LoadCommand.Execute(null);
            //Assert
            Assert.AreEqual(receivedEvents[0], "Coins_CollectionChanged");
            Assert.AreEqual(testCoins.Count, rvm.Repo.Coins.Count);
            CollectionAssert.AreEqual(testCoins, rvm.Repo.Coins);
        }

        [TestMethod]
        public void VMBaseRepoUCCanSaveCommandEmptyCollectionTest()
        {
            //Arrange
            rvm.Repo.Coins.Clear();
            List<string> receivedEvents = new List<string>();
            rvm.PropertyChanged += delegate (object sender, PropertyChangedEventArgs e)
            {
                receivedEvents.Add(e.PropertyName);
            };
            //Act
            rvm.SaveCommand.Execute(null);
            //Assert
            Assert.AreEqual(0, receivedEvents.Count);
            Assert.AreEqual(0, rvm.Repo.Coins.Count);
        }
    }
}
