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
  }
}