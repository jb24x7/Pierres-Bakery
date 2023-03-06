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
    public void GetCost_ReturnsCostOfAllLoaves1_Int()
    {
      Bread bread = new Bread(6);
      Assert.AreEqual(bread.BreadPrice(), 20);
    }

           [TestMethod]
    public void GetCost_ReturnsCostOfAllLoaves2_Int()
    {
      Bread bread = new Bread(8);
      Assert.AreEqual(bread.BreadPrice(), 30);
    }
  }
}