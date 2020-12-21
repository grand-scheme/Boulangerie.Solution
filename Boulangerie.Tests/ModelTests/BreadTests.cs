using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Boulangerie.Models.Tests
{
  [TestClass]
  public class BreadTests
  {
    Bread testBread;
    
    [TestInitialize()]
    public void InitializeTests()
    {
      this.testBread = new Bread();
    }

    [TestMethod]
    public void Bread_CanInstantiateNewBread_GetType()
    {
      Bread test1 = new Bread(5);
      Assert.AreEqual(typeof(Bread), test1.GetType());
    }

    [TestMethod]
    public void Bread_CanGetAndSetQuantity_True()
    {
      Bread test2 = new Bread(10);
      int testQuantity = test2.Quantity;
      Assert.AreEqual(10, testQuantity);
    }

    [TestMethod]
    public void TotalCost_ReturnsNumber_Int()
    {
      Bread test3 = new Bread(5);
      int test3Quantity = test3.Quantity;
      Assert.AreEqual(typeof(int), test3Quantity.GetType());
    }

    [TestMethod]
    public void BreadTotalCost_ReturnsCorrectPrice_Int()
    {
      Bread test4 = new Bread(1);
      int test4Price = test4.BreadTotalCost();
      int expectedPrice = 5;
      Assert.AreEqual(expectedPrice, test4Price);
    }

    [TestMethod]
    public void BreadTotalCost_ReturnsCorrectPriceFor3_Int()
    {
      Bread test5 = new Bread(3);
      int test5Price = test5.BreadTotalCost();
      int expectedPrice = 10;
      Assert.AreEqual(expectedPrice, test5Price);
    }

    [TestMethod]
    public void BreadTotalCost_ReturnsCorrectPriceFor10_Int()
    {
      Bread test6 = new Bread(10);
      int test6Price = test6.BreadTotalCost();
      int expectedPrice = ((5+5+0) + (5+5+0) + (5+5+0) + (5));
      Assert.AreEqual(expectedPrice, test6Price);
    }

    [TestMethod]
    public void Bread_AbleToSetWithoutInt_Bread()
    {
      Bread test7 = this.testBread;
      Assert.AreEqual(typeof(Bread), test7.GetType());
    }
    
    [TestMethod]
    public void Bread_ReturnsProductString_String()
    {
      string expectedString = "bread";
      string testString = this.testBread.Product;
      Assert.AreEqual(expectedString, testString);
    }
    
    [TestMethod]
    public void Bread_ReturnsPluralString_String()
    {
      string expectedString = "loaves of bread";
      string testString = this.testBread.Plural;
      Assert.AreEqual(expectedString, testString);
    }
    
    [TestMethod]
    public void Bread_ReturnsSingularString_String()
    {
      string expectedString = "loaf of bread";
      string testString = this.testBread.Singular;
      Assert.AreEqual(expectedString, testString);
    }
    
    [TestMethod]
    public void Bread_ReturnsDealMinusOneString_String()
    {
      string expectedString = "It's 'Buy two, get one free' for our bread. If you add one more, it's on the house. Why would you say no to free bread?";
      string testString = this.testBread.DealMinusOne;
      Assert.AreEqual(expectedString, testString);
    }
  }
}