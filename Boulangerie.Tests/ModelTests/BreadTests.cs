using Microsoft.VisualStudio.TestTools.UnitTesting;
using Boulangerie;

namespace Boulangerie.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadDeal_IsNumberDivisibleByThree_True()
    {
      Bread testBreadQuantity = new Bread();
      Assert.AreEqual(0, testBreadQuantity.BreadDeal(99));
    }
    [TestMethod]
    public void BreadDeal_IsModuloDivisibleByThree_False()
    {
      Bread testBreadQuantity = new Bread();
      Assert.AreNotEqual(0, testBreadQuantity.BreadDeal(103));
    }
    [TestMethod]
    public void BreadFullPrice_IsQuantityTwoThirdsOfBreadQuantityQuotient_Yes()
    {
      Bread testBreadFullPriceQuantity = new Bread();
      Assert.AreEqual(6, testBreadFullPriceQuantity.BreadFullPrice(10));
    }
    [TestMethod]
    public void BreadFinalCost_IsCheckoutPriceAccuratePerDiscount_Yes()
    {
      Bread testCheckoutPrice = new Bread();
      Assert.AreEqual(100, testCheckoutPrice.BreadFinalCost(30));
    } 
  }
}