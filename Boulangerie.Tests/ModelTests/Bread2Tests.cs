using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Boulangerie.Models.Tests
{
  [TestClass]
  public class Bread2Tests
  {
    [TestMethod] // test 13
    public void Bread2_CanInstantiateNewBread2_True()
    {
      Bread2 test1 = new Bread2();
      Assert.AreEqual(typeof(Bread), test1.GetType());
    }
    // end of test 13
  }
}