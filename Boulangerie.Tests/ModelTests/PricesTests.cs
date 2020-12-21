using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Boulangerie.Models.Tests
{
  [TestClass]
  public class PricesTests
  {
    [TestMethod] // test 19
    public void GetSoldAtDiscount_ReturnsInt_Int()
    {
      Buy2Get1 dummy = new Buy2Get1();
      int test19 = dummy.GetSoldAtDiscount(3);
      Assert.AreEqual(typeof(bool), test19.GetType());
    }
    // end of test 19
  }
}