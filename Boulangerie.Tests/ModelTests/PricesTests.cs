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
    public void GetSoldAtDiscount_ReturnsInt_SystemInt()
    {
      int test19 = this.testB2G1.GetSoldAtDiscount(3);
      Assert.AreEqual(typeof(int), test19.GetType());
    }

    [TestMethod]
    public void GetSoldAtDiscount_ReturnsQuantityOfProductSoldAtDiscountPrice_Int()
    {
      int test20 = this.testB2G1.GetSoldAtDiscount(3);
      int expectedQuantity = 1;
      Assert.AreEqual(expectedQuantity, test20);
    }

    [TestMethod]
    public void GetSoldAtDiscount_ReturnsQuantityWhenInBulk_Int()
    {
      int test21 = this.testB2G1.GetSoldAtDiscount(32);
      int expectedQuantity = 10;
      Assert.AreEqual(expectedQuantity, test21);
    }

    [TestMethod]
    public void SoldAtFullPrice_ReturnsInt_SystemInt()
    {
      int test22 = this.testB2G1.GetSoldAtFullPrice(3);
      Assert.AreEqual(typeof(int), test22.GetType());
    }
  }
}