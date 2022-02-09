using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class task2
{
  static void Main(string[] args)
  {
    Console.Write("Input x = ");
    double x = Convert.ToDouble(Console.ReadLine());
	
    double y = 5 / 3 - Math.Atan(Math.Sqrt(2 - Math.Cos(2 * x))) - Math.Pow(Math.E, -x / 5); 
    Console.WriteLine(" x = {0} \n y = {1}", x, y);
  }
}
