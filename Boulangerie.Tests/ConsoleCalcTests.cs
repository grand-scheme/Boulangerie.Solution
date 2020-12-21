using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Boulangerie.Models.Tests
{
  [TestClass]
  public class ConsoleCalcTests
  {
    ConsoleCalcs testConsoleCalcs;
    
    [TestInitialize()]
    public void InitializeTests()
    {
      this.testConsoleCalcs = new ConsoleCalcs();
    }


    [TestMethod] // test 17
    public void ProductCart_CanInstantiateAndReturnNumber_Int()
    {
      int quantity = 1;
      string productType = "TYPE";
      int output = this.testConsoleCalcs.ProductCart(quantity, productType);

      Assert.AreEqual(typeof(int), output.GetType());
    }
    // END TEST 17
    [TestMethod] // test 18
    public void ProductCart_CanReturnFinalCostIfInputIsBread_Int()
    {
      int quantity = 1;
      string productType = "BREAD";
      int testedOutput = this.testConsoleCalcs.ProductCart(quantity, productType);
      int expectedOutput = 5;

      Assert.AreEqual(expectedOutput, testedOutput);
    }
  }
}