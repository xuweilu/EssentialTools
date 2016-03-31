using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EssentialTools.Models;

namespace EssentialTools.Tests
{
    [TestClass]
    public class UnitTest1
    {
        private IDiscountHelper getTestObject() {
            return new MinimumDiscountHelper();
        }
        [TestMethod]
        public void Discount_Above_100()
        {
            //arrange
            IDiscountHelper target = getTestObject();
            decimal total = 200;

            //action
            var discountedTotal = target.ApplyDispcount(total);

            //assert
            Assert.AreEqual(total * 0.9m, discountedTotal);
        }
    }
}
