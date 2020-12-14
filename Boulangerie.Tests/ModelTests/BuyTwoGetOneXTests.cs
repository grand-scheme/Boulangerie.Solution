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
      Assert.AreEqual(5, testPrices.SetPrice("BREAD"));
    }
    [TestMethod]
    public void SetDiscount_CanSetDiscountBasedOnInput_True()
    {
      BuyOneGetTwoX testDiscount = new BuyOneGetTwoX();
      Assert.AreEqual(0, testDiscount.SetDiscount("BREAD"));
    }
    [TestMethod]
    public void TheEquation_DoesThisCalculateOut_True()
    {
    BuyOneGetTwoX testCart = new BuyOneGetTwoX();
    Assert.AreEqual(35, testCart.TheEquation(10, "BREAD"));
    }
    [TestMethod]
    public void TheEquation_CheckValuesForPastries_True()
    {
    BuyOneGetTwoX testCart = new BuyOneGetTwoX();
    Assert.AreEqual(17, testCart.TheEquation(10, "PASTRY"));
    }
  }
}