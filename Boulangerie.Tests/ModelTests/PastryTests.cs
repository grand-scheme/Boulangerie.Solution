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
    [TestMethod]
    public void PastryDeal_SavesWhatIsNotDivisibleByThree_Yes()
    {
      Pastry testPastryQuantity = new Pastry();
      Assert.AreNotEqual(0, testPastryQuantity.PastryDeal(91));
    }
    [TestMethod]
    public void PastryTwoAtFullPrice_IsTwoThirdsOfPastryQuantityMinusExtra_Yes()
    {
      Pastry twoPastriesAtPrice = new Pastry();
      Assert.AreEqual(2, twoPastriesAtPrice.PastryTwoAtFullPrice(4));
    }
  }
}