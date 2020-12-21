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
      int testQuantity = test2.BreadQuantity();
      Assert.AreEqual(4, testQuantity);
    }
  }
}