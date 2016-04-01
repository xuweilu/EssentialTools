﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using EssentialTools.Models;
using System.Linq;

namespace EssentialTools.Tests
{
    [TestClass]
    public class UnitTest2
    {
        private Product[] products = {
            new Product { Name = "Kayak",Category = "Watersports",Price = 275M},
            new Product { Name = "Lifejacket",Category = "Watersports",Price = 48.95M},
            new Product { Name = "Soccer ball",Category = "Soccer",Price = 19.50m},
            new Product { Name = "Corner flag",Category = "Soccer",Price = 34.95M}
        };
        [TestMethod]
        public void Sum_Products_Correctly()
        {
            //arrange
            Mock<IDiscountHelper> mock = new Mock<IDiscountHelper>();
            mock.Setup(m => m.ApplyDispcount(It.IsAny<decimal>()))
                .Returns<decimal>(total => total);
            var target = new LinqValueCalculator(mock.Object);

            //action
            var result = target.ValueProducts(products);

            //assert
            Assert.AreEqual(products.Sum(e => e.Price), result);
        }
    }
}
