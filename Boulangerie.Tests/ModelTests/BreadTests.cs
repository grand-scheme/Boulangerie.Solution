using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Boulangerie.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void ExcessQuantity_IsNumberDivisibleByThree_True()
    {
      Bread testBreadQuantity = new Bread();
      Assert.AreEqual(0, testBreadQuantity.ExcessQuantity(99));
    }
    [TestMethod]
    public void ExcessQuantity_IsModuloDivisibleByThree_False()
    {
      Bread testBreadQuantity = new Bread();
      Assert.AreNotEqual(0, testBreadQuantity.ExcessQuantity(103));
    }
    [TestMethod]
    public void FullPriceQuantity_ExcludesDiscountQuality_Yes()
    {
      Bread testBreadAtFullPriceQuantity = new Bread();
      Assert.AreEqual(10, testBreadAtFullPriceQuantity.FullPriceQuantity(15));
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