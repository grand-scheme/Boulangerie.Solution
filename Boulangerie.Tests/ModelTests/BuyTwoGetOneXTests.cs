using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Boulangerie.Tests
{
  [TestClass]
  public class BuyOneGetTwoXTests
  {
    [TestMethod]
    public void SetPrice_CanSetPricesBasedOnInput_True()
    {
      BuyOneGetTwoX testPrices = new BuyOneGetTwoX();
      Assert.AreEqual(5, testPrices.SetPrice("bread"));
    }
    [TestMethod]
    public void SetDiscount_CanSetDiscountBasedOnInput_True()
    {
      BuyOneGetTwoX testDiscount = new BuyOneGetTwoX();
      Assert.AreEqual(0, testDiscount.SetDiscount("bread"));
    }
  }
}