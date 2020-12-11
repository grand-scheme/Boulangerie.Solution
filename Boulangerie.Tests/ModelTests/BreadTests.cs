using Microsoft.VisualStudio.TestTools.UnitTesting;
using Boulangerie;

namespace Boulangerie.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadDeal_IsNumberDivisibleByThree_True()
    {
      Bread testBreadQuantity = new Bread();
      Assert.AreEqual(true, testBreadQuantity.BreadDeal(99));
    }
  }
}