using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Boulangerie.Models.Tests
{
  [TestClass]
  public class Bread2Tests
  {
    [TestMethod] // test 13
    public void Bread2_CanInstantiateNewBread2_GetType()
    {
      Bread2 test1 = new Bread2();
      Assert.AreEqual(typeof(Bread2), test1.GetType());
    }
    // end of test 13

    [TestMethod] // test 14
    public void Bread2_CanSetQuantity_True()
    {
      Bread2 test2 = new Bread2();
      test2.SetQuantity(5);
      int testQuantity = test2.GetBreadQuantity();
      Assert.AreEqual(5, testQuantity);
    }
    // end of test 14
    [TestMethod] // test 15
    public void Bread2_BreadTotalCostReturnsNumber_Int()
    {
      Bread2 test3 = new Bread2();
      test3.SetQuantity(1);
      int test3Quantity = test3.GetBreadQuantity();
      Assert.AreEqual(typeof(bool), test3Quantity.GetType());
    }
  }
}