using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Boulangerie.Models.Tests
{
  [TestClass]
  public class Bread2Tests
  {
    [TestMethod]
    public void Bread2_CanInstantiateNewBread2_GetType()
    {
      Bread2 test1 = new Bread2(5);
      Assert.AreEqual(typeof(Bread2), test1.GetType());
    }

    [TestMethod]
    public void Bread2_CanGetAndSetQuantity_True()
    {
      Bread2 test2 = new Bread2(10);
      int testQuantity = test2.Quantity;
      Assert.AreEqual(10, testQuantity);
    }

    [TestMethod]
    public void TotalCost_ReturnsNumber_Int()
    {
      Bread2 test3 = new Bread2(5);
      int test3Quantity = test3.Quantity;
      Assert.AreEqual(typeof(int), test3Quantity.GetType());
    }

    [TestMethod]
    public void BreadTotalCost_ReturnsCorrectPrice_Int()
    {
      Bread2 test4 = new Bread2(1);
      int test4Price = test4.BreadTotalCost();
      int expectedPrice = 5;
      Assert.AreEqual(expectedPrice, test4Price);
    }

    [TestMethod]
    public void BreadTotalCost_ReturnsCorrectPriceFor3_Int()
    {
      Bread2 test5 = new Bread2(3);
      int test5Price = test5.BreadTotalCost();
      int expectedPrice = 10;
      Assert.AreEqual(expectedPrice, test5Price);
    }

    [TestMethod]
    public void BreadTotalCost_ReturnsCorrectPriceFor10_Int()
    {
      Bread2 test6 = new Bread2(10);
      int test6Price = test6.BreadTotalCost();
      int expectedPrice = ((5+5+0) + (5+5+0) + (5+5+0) + (5));
      Assert.AreEqual(expectedPrice, test6Price);
    }
    [TestMethod] //test 20
    public void Bread2_AbleToSetWithoutInt_Bread2()
    {
      Bread2 test7 = new Bread2();
      Assert.AreNotEqual(typeof(Bread2), test7.GetType());
    }
  }
}