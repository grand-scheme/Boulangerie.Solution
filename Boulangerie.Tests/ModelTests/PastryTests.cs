using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Boulangerie.Models.Tests
{
  [TestClass]
  public class PastryTests
  {
    Pastry testPastry;
    
    [TestInitialize()]
    public void InitializeTests()
    {
      this.testPastry = new Pastry();
    }

    [TestMethod]
    public void Pastry_CanInstantiateNewPastry_GetTypePastry()
    {
      Pastry test1 = new Pastry(5);
      Assert.AreEqual(typeof(Pastry), test1.GetType());
    }

    [TestMethod]
    public void Pastry_CanGetAndSetQuantity_Int()
    {
      Pastry test2 = new Pastry(10);
      int testQuantity = test2.Quantity;
      Assert.AreEqual(10, testQuantity);
    }

    [TestMethod]
    public void PastryTotalCost_ReturnsNumber_GetTypeInt()
    {
      Pastry test3 = new Pastry(5);
      int test3Quantity = test3.Quantity;
      Assert.AreEqual(typeof(int), test3Quantity.GetType());
    }

    [TestMethod]
    public void PastryTotalCost_ReturnsCorrectPrice_Int()
    {
      Pastry test4 = new Pastry(1);
      int test4Price = test4.PastryTotalCost();
      int expectedPrice = 2;
      Assert.AreEqual(expectedPrice, test4Price);
    }

    [TestMethod]
    public void PastryTotalCost_ReturnsCorrectPriceFor3_Int()
    {
      Pastry test5 = new Pastry(3);
      int test5Price = test5.PastryTotalCost();
      int expectedPrice = 5;
      Assert.AreEqual(expectedPrice, test5Price);
    }

    [TestMethod]
    public void PastryTotalCost_ReturnsCorrectPriceFor10_Int()
    {
      Pastry test6 = new Pastry(10);
      int test6Price = test6.PastryTotalCost();
      int expectedPrice = ((2+2+1) + (2+2+1) + (2+2+1) + (2));
      Assert.AreEqual(expectedPrice, test6Price);
    }

        [TestMethod]
    public void Pastry_AbleToSetWithoutPassingInt_GetTypePastry()
    {
      Pastry test7 = this.testPastry;
      Assert.AreEqual(typeof(Pastry), test7.GetType());
    }
    
    [TestMethod]
    public void Pastry_ReturnsProductString_String()
    {
      string expectedString = "pastry";
      string testString = this.testPastry.Product;
      Assert.AreEqual(expectedString, testString);
    }
    
    [TestMethod]
    public void Pastry_ReturnsPluralString_String()
    {
      string expectedString = "pastries";
      string testString = this.testPastry.Plural;
      Assert.AreEqual(expectedString, testString);
    }
    
    [TestMethod]
    public void Pastry_ReturnsSingularString_String()
    {
      string expectedString = "pastry";
      string testString = this.testPastry.Singular;
      Assert.AreEqual(expectedString, testString);
    }
    
    [TestMethod]
    public void Pastry_ReturnsDealMinusOneString_String()
    {
      string expectedString = "It's 'Buy three for $5' for our pastries. It's only a dollar to add one more to your bag. Do you want to add one more?";
      string testString = this.testPastry.DealMinusOne;
      Assert.AreEqual(expectedString, testString);
    }
  }
}