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
      Assert.AreEqual(0, testBreadQuantity.BreadDeal(99));
    }
    [TestMethod]
    public void BreadDeal_IsModuloDivisibleByThree_False()
    {
      Bread testBreadQuantity = new Bread();
      Assert.AreNotEqual(0, testBreadQuantity.BreadDeal(103));
    }
  }
}