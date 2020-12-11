using Microsoft.VisualStudio.TestTools.UnitTesting;
using Boulangerie;

namespace Boulangerie.Tests
{
  [TestClass]
  public class BreadTests 
  {
    [TestMethod]
    public bool Bread_IsNumberDivisibleBy3_True()
    {
      Bread testBreadQuantity = new Bread();
      Assert.AreEqual(true, testBreadQuantity.BreadDeal(99));
      // Test method will go here
      // Assert.AreEqual(EXPECTED RESULT, CODE TO TEST);
    }
  }
}