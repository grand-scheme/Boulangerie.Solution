using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Boulangerie.Models.Tests
{
  [TestClass]
  public class PricesTests
  {
    Buy2Get1 testB2G1;
    
    [TestInitialize()]
    public void InitializeTests()
    {
      this.testB2G1 = new Buy2Get1();
    }

    [TestMethod]
    public void FinalCost_ReturnsCorrectPriceForInputBread_Int()
    {
      int quantity = 1;
      string productType = "BREAD";
      int testPrice = this.testB2G1.FinalCost(quantity, productType);
      int expectedPrice = 5;
      Assert.AreEqual(expectedPrice, testPrice);
    }
    [TestMethod]
    public void FinalCost_ReturnsCorrectPriceForInputPastry_Int()
    {
      int quantity = 1;
      string productType = "PASTRY";
      int testPrice = this.testB2G1.FinalCost(quantity, productType);
      int expectedPrice = 2;
      Assert.AreEqual(expectedPrice, testPrice);
    }
  }
}