using System;
using PierresBakery.Models;
using System.Collections.Generic;

namespace PierresBakery
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("How many loaves of bread would you like?");
      int loaves = int.Parse(Console.ReadLine());
      Console.WriteLine(loaves);
    }
  }
}