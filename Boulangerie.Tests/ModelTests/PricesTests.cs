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
      int expectedQuantity = 1;
      Assert.AreEqual(expectedQuantity, test20);
    }
    // end of test 20
    [TestMethod] // test 21
    public void GetSoldAtDiscount_ReturnsQuantityWhenInBulk_Int()
    {
      Buy2Get1 dummy = new Buy2Get1();
      int test21 = dummy.GetSoldAtDiscount(32);
      int expectedQuantity = 10;
      Assert.AreEqual(expectedQuantity, test21);
    }
    // end of test 21
    [TestMethod] // test 22
    public void SoldAtFullPrice_ReturnsInt_SystemInt()
    {
    Buy2Get1 dummy = new Buy2Get1();
      int test22 = dummy.GetSoldAtFullPrice(3);
      Assert.AreEqual(typeof(int), test22.GetType());
    }
    // end of test 22
  }
}