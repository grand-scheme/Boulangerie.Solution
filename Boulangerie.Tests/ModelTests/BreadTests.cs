using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Boulangerie.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadOutsideDiscount_IsNumberDivisibleByThree_True()
    {
      Bread testBreadQuantity = new Bread();
      Assert.AreEqual(0, testBreadQuantity.BreadOutsideDiscount(99));
    }
    [TestMethod]
    public void BreadOutsideDiscount_IsModuloDivisibleByThree_False()
    {
      Bread testBreadQuantity = new Bread();
      Assert.AreNotEqual(0, testBreadQuantity.BreadOutsideDiscount(103));
    }
    [TestMethod]
    public void BreadAtFullPrice_IsQuantityTwoThirdsOfBreadQuantityQuotient_Yes()
    {
      Bread testBreadAtFullPriceQuantity = new Bread();
      Assert.AreEqual(6, testBreadAtFullPriceQuantity.BreadAtFullPrice(10));
    }
    [TestMethod]
    public void BreadFinalCost_IsAccuratePerDiscount_Yes()
    {
      Bread testCheckoutPrice = new Bread();
      Assert.AreEqual(100, testCheckoutPrice.BreadFinalCost(30));
    } 
    [TestMethod]
    public void BreadFinalCost_IncludesValuesLessThanThree_Yes()
    {
      Bread testCheckoutPrice = new Bread();
      Assert.AreEqual(10, testCheckoutPrice.BreadFinalCost(2));
    } 
    [TestMethod]
    public void BreadFinalCost_IncludesValuesNotDivisibleByThree_Yes()
    {
      Bread testCheckoutPrice = new Bread();
      Assert.AreEqual(25, testCheckoutPrice.BreadFinalCost(7));
    } 
  }
}