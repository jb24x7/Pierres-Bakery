using System;
using PierresBakery.Models;
using System.Collections.Generic;

namespace PierresBakery
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Bread is 5$ per loaf and on sale for buy 3 get 1 free. How many loaves of bread would you like?");
      int loaves = int.Parse(Console.ReadLine());
      Bread bread = new Bread(loaves);
      Console.WriteLine("Pastries are 2$ per pastry and on sale for buy 4 get 1 free. How many pastries would you like?");
      int pastriesNum = int.Parse(Console.ReadLine());
      Pastries pastries = new Pastries(pastriesNum);
      int costForAll = bread.BreadPrice() + pastries.PastriesPrice();
      Console.WriteLine($"Your total will be ${costForAll} ");
    }
  }
}