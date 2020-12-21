using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Boulangerie.Models.Tests
{
  [TestClass]
  public class Bread2Tests
  {
    [TestMethod] // test 13
    public void Bread2_CanInstantiateNewBread2_GetType()
    {
      Bread2 test1 = new Bread2(5);
      Assert.AreEqual(typeof(Bread2), test1.GetType());
    }
    // end of test 13

    [TestMethod] // test 14
    public void Bread2_CanGetAndSetQuantity_True()
    {
      Bread2 test2 = new Bread2(5);
      // test2.SetQuantity(5);
      int testQuantity = test2.BreadQuantity;
      Assert.AreEqual(5, testQuantity);
    }
    // end of test 14
    [TestMethod] // test 15
    public void BreadTotalCost_ReturnsNumber_Int()
    {
      Bread2 test3 = new Bread2(5);
      // test3.SetQuantity(1);
      int test3Quantity = test3.BreadQuantity;
      Assert.AreEqual(typeof(int), test3Quantity.GetType());
    }
    // end of test 15
    [TestMethod] // test 16
    public void BreadTotalCost_ReturnsCorrectPrice_Int()
    {
      Bread2 test4 = new Bread2(5);
      // test4.SetQuantity(1);
      int test4Price = test4.BreadTotalCost();
      int expectedPrice = 5;
      Assert.AreEqual(expectedPrice, test4Price);
    }
    // end of test 16
    [TestMethod] // test 17
    public void BreadTotalCost_ReturnsCorrectPriceFor3_Int()
    {
      Bread2 test5 = new Bread2(5);
      // test5.SetQuantity(3);
      int test5Price = test5.BreadTotalCost();
      int expectedPrice = 10;
      Assert.AreEqual(expectedPrice, test5Price);
    }
    // end test 17
    [TestMethod] // test 18
    public void BreadTotalCost_ReturnsCorrectPriceFor10_Int()
    {
      Bread2 test6 = new Bread2(5);
      // test6.SetQuantity(10);
      int test6Price = test6.BreadTotalCost();
      // 10 loaves should = 
      // (3 loaves @ $10) * 3 = 9 loaves @ $30
      // + 1 loaf @ $5 = $35
      int expectedPrice = 35;
      Assert.AreEqual(expectedPrice, test6Price);
    }
    // end test 18
  }
}