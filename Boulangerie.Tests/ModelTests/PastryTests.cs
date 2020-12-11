using Microsoft.VisualStudio.TestTools.UnitTesting;
using Boulangerie;

namespace Boulangerie.Tests
{
  [TestClass]
  public class PastryTests 
  {
    [TestMethod]
    public void PastryDeal_IsDivisibleByThree_True()
    {
      Pastry testPastryQuantity = new Pastry();
      Assert.AreEqual(0, testPastryQuantity.PastryDeal(99));
    }
  }
}