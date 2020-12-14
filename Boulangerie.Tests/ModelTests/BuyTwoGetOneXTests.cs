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
    [TestMethod]
    public void CheckVariables_CanEachUnitBoughtBeSetToCorrectValue_True()
    {
      BuyOneGetTwoX testValues = new BuyOneGetTwoX();
      Assert.AreEqual(("bread 5 0 5 2 4 1"), testValues.CheckVariables(5, "bread"));
    }
  }
}