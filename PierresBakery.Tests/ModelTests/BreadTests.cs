using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class Breadtests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread bread = new Bread(6);
      Assert.AreEqual(typeof(Bread), bread.GetType());
    }

       [TestMethod]
    public void GetCost_ReturnsCostOfAllLoaves_Int()
    {
      Bread bread = new Bread(1);
      Assert.AreEqual(bread.BreadPrice(1), 5);
    }
  }
}