using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Boulangerie.Models.Tests
{
  [TestClass]
  public class Bread2Tests
  {
    Bread2 testBread;
    
    [TestInitialize()]
    public void InitializeTests()
    {
      this.testBread = new Bread2();
    }
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
      Bread2 test7 = this.testBread;
      Assert.AreEqual(typeof(Bread2), test7.GetType());
    }
    // end 20
    [TestMethod] // test 21
    public void Bread2_ReturnsProductString_String()
    {
      string expectedString = "bread";
      string testString = this.testBread.Product;
      Assert.AreEqual(expectedString, testString);
    }
    // end 21
    [TestMethod] // test 22
    public void Bread2_ReturnsPluralString_String()
    {
      string expectedString = "bread";
      string testString = this.testBread.Plural;
      Assert.AreEqual(expectedString, testString);
    }
    // end 22
    [TestMethod] // test 23
    public void Bread2_ReturnsSingularString_String()
    {
      string expectedString = "breads";
      string testString = this.testBread.Singular;
      Assert.AreEqual(expectedString, testString);
    }
    // end 23
    [TestMethod] // test 24
    public void Bread2_ReturnsDealMinusOneString_String()
    {
      string expectedString = "breads";
      string testString = this.testBread.DealMinusOne;
      Assert.AreEqual(expectedString, testString);
    }
    // end 24
  }
}