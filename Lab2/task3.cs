using System;

public class Program
{
  public static void Main()
  {
    Console.Write("A = ");
    var a = Convert.ToDouble(Console.ReadLine());
    
    Console.Write("X = ");
    var x = Convert.ToDouble(Console.ReadLine());
    
    if (a > 0)
    {
      var y = 2 * a * x + Math.Abs(a - x);
      Console.WriteLine("При a = {0}, x = {1}\nЗначение функции = {2}", a, x, y);
    }
    else
    {
      var y = Math.Pow(Math.E, x) / Math.Sqrt(1 + a * a) - 1
      Console.WriteLine("При a = {0}, x = {1}\nЗначение функции = {2}", a, x, y);
    }
  }
}
