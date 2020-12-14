using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Boulangerie.Tests
{
  [TestClass]
  public class BuyOneGetTwoXTests
  {
    [TestMethod]
    public void NoticeProduct_CanTellIfSelectingBreadOrPastry_True()
    {
      BuyOneGetTwoX testProductInput = new BuyOneGetTwoX();
      Assert.AreEqual("bread", testProductInput.NoticeProduct("bread"));
    }
    [TestMethod]
    public void SetPrice_CanSetPricesBasedOnInput_True()
    {
      BuyOneGetTwoX testPrices = new BuyOneGetTwoX();
      Assert.AreEqual(5, testPrices.SetPrice("bread"));
    }
  }
}