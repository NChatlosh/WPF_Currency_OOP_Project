using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CurrencyLibrary.USCurrency;
using CurrencyLibrary;

namespace UnitTestCurrency
{
    /// <summary>
    /// Summary description for PennyTest
    /// </summary>
    [TestClass]
    public class USCoinTest
    {
        Penny p;

        [TestMethod]
        public void USPennyConstructor()
        {
            //Arrange
            p = new Penny();
            //Act 

            //Assert
            Assert.AreEqual(CurrencyLibrary.USCurrency.USCoinMintMark.P, p.MintMark);
            Assert.AreEqual(System.DateTime.Now.Year, p.Year); //Current year is default year
        }

        [TestMethod]
        public void USPennyMonetaryValue()
        {
            //Arrange
            //Act
            p = new Penny();
            //Assert
            Assert.AreEqual(0.01, p.MonetaryValue);
        }

        [TestMethod]
        public void USCoinPennyAbout()
        {
            //Arrange
            p = new Penny();
            //Act 

            //Assert
            Assert.AreEqual("US Penny is from 2018. It is worth $0.01. It was made in Philadelphia.", p.About());
        }

        [TestMethod]
        public void USCoinMintMark()
        {

            //Arrange
            string mintNameDenver, mintNamePhili, mintNameSanFran, mintNameWestPoint, mintNameNewOrleans;
            USCoinMintMark D, P, S, W, O;

            //Act 
            mintNameDenver = "Denver";
            mintNamePhili = "Philadelphia";
            mintNameSanFran = "San Francisco";
            mintNameWestPoint = "West Point";
            mintNameNewOrleans = "New Orleans";
            D = CurrencyLibrary.USCurrency.USCoinMintMark.D;
            P = CurrencyLibrary.USCurrency.USCoinMintMark.P;
            S = CurrencyLibrary.USCurrency.USCoinMintMark.S;
            W = CurrencyLibrary.USCurrency.USCoinMintMark.W;
            O = CurrencyLibrary.USCurrency.USCoinMintMark.O;

            //Assert
            Assert.AreEqual(USCoin.GetMintNameFromMark(D), mintNameDenver);
            Assert.AreEqual(USCoin.GetMintNameFromMark(P), mintNamePhili);
            Assert.AreEqual(USCoin.GetMintNameFromMark(S), mintNameSanFran);
            Assert.AreEqual(USCoin.GetMintNameFromMark(W), mintNameWestPoint);
            Assert.AreEqual(USCoin.GetMintNameFromMark(O), mintNameNewOrleans);
        }


    }
}
