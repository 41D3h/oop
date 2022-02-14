using System;

public class Program
{
  public static void Main()
  {
    Console.Write("Введите целое положительное число: ");
    var n = Convert.ToInt32(Console.ReadLine());
    if (n % 2 == 1)
    {
      Console.WriteLine("Число нечетное");
      if (Math.Sign(n) == 1)
      {
        Console.WriteLine("Число положительное");
      }
      else
      {
        Console.WriteLine("Число отрицательное");
      }
    }
    else
    {
      Console.WriteLine("Число четное");
    }
    Console.WriteLine("\nНажмите любую клавишу для продолжения...");
  }
}
