using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Boulangerie.Models.Tests
{
  [TestClass]
  public class PricesTests
  {
    [TestMethod] // test 19
    public void SoldAtDiscount_ReturnsInt_Int()
    {
      SoldAtDiscount test19 = new SoldAtDiscount(3);
      Assert.AreEqual(typeof(int), test19.GetType());
    }
    // end of test 19
  }
}