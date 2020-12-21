using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Boulangerie.Models.Tests
{
  [TestClass]
  public class PricesTests
  {
    [TestMethod] // test 19
    public void GetSoldAtDiscount_ReturnsInt_SystemInt()
    {
      Buy2Get1 dummy = new Buy2Get1();
      int test19 = dummy.GetSoldAtDiscount(3);
      Assert.AreEqual(typeof(int), test19.GetType());
    }
    // end of test 19
    [TestMethod] // test 20
    public void GetSoldAtDiscount_ReturnsQuantityOfProductSoldAtDiscountPrice_Int()
    {
      Buy2Get1 dummy = new Buy2Get1();
      int test20 = dummy.GetSoldAtDiscount(3);
      int expectedQuantity = 3;
      Assert.AreEqual(expectedQuantity, test20);
    }
    // end of test 20
  }
}