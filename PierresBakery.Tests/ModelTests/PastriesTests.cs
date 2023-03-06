using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
 [TestClass]
  public class Pastriestests
  {
    [TestMethod]
    public void PastriesConstructor_CreatesInstanceOfBread_Bread()
    {
      Pastries pastries = new Pastries(6);
      Assert.AreEqual(typeof(Pastries), pastries.GetType());
    }

       [TestMethod]
    public void GetCost_ReturnsCostOfAllLoaves_Int()
    {
      Pastries pastries = new Pastries(6);
      Assert.AreEqual(pastries.PastriesPrice(), 10);
    }
  }
}