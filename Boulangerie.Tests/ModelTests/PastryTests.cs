using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Boulangerie.Models.Tests
{
  [TestClass]
  public class Pastry2Tests
  {

    [TestMethod]
    public void Pastry2_CanInstantiateNewPastry2_GetType()
    {
      Pastry2 test1 = new Pastry2(5);
      Assert.AreEqual(typeof(Pastry2), test1.GetType());
    }

    [TestMethod]
    public void Pastry2_CanGetAndSetQuantity_True()
    {
      Pastry2 test2 = new Pastry2(10);
      int testQuantity = test2.PastryQuantity;
      Assert.AreEqual(10, testQuantity);
    }

    [TestMethod]
    public void PastryTotalCost_ReturnsNumber_Int()
    {
      Pastry2 test3 = new Pastry2(5);
      int test3Quantity = test3.PastryQuantity;
      Assert.AreEqual(typeof(int), test3Quantity.GetType());
    }

    [TestMethod]
    public void PastryTotalCost_ReturnsCorrectPrice_Int()
    {
      Pastry2 test4 = new Pastry2(1);
      int test4Price = test4.PastryTotalCost();
      int expectedPrice = 2;
      Assert.AreEqual(expectedPrice, test4Price);
    }

    [TestMethod]
    public void PastryTotalCost_ReturnsCorrectPriceFor3_Int()
    {
      Pastry2 test5 = new Pastry2(3);
      int test5Price = test5.PastryTotalCost();
      int expectedPrice = 5;
      Assert.AreEqual(expectedPrice, test5Price);
    }

    [TestMethod]
    public void PastryTotalCost_ReturnsCorrectPriceFor10_Int()
    {
      Pastry2 test6 = new Pastry2(10);
      int test6Price = test6.PastryTotalCost();
      int expectedPrice = ((2+2+1) + (2+2+1) + (2+2+1) + (2));
      Assert.AreEqual(expectedPrice, test6Price);
    }
  }
}