using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Boulangerie.Tests
{
  [TestClass]
  public class PastryTests 
  {
    [TestMethod]
    public void ExcessQuantity_IsDivisibleByThree_True()
    {
      Pastry testPastryQuantity = new Pastry();
      Assert.AreEqual(0, testPastryQuantity.ExcessQuantity(99));
    }
    [TestMethod]
    public void ExcessQuantity_SavesWhatIsNotDivisibleByThree_Yes()
    {
      Pastry testPastryQuantity = new Pastry();
      Assert.AreNotEqual(0, testPastryQuantity.ExcessQuantity(91));
    }
    [TestMethod]
    public void AtDiscountQuantity_IsOneThirdOfTotalQuantityMinusRemainder_Yes()
    {
      Pastry onePastryAtPrice = new Pastry();
      Assert.AreEqual(1, onePastryAtPrice.AtDiscountQuantity(3));
    }
    [TestMethod]
    public void AtDiscountQuantity_IsNotSimplyOne_Yes()
    {
      Pastry onePastryAtPrice = new Pastry();
      Assert.AreEqual(2, onePastryAtPrice.AtDiscountQuantity(6));
    }
    [TestMethod]
    public void FullPriceQuantity_Include2For1AndModuloRemainder_Yes()
    {
      Pastry allFullPrice = new Pastry();
      Assert.AreEqual(4, allFullPrice.FullPriceQuantity(5));
    }
    [TestMethod]
    public void PastryFinalCost_CalculatesCorrectTotal_Yes()
    {
      Pastry cartTotal = new Pastry();
      Assert.AreEqual
      (9, cartTotal.PastryFinalCost(5));
    }
  }
}