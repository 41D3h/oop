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
    }
    else
    {
      Console.WriteLine("Число четное");
    }
    Console.WriteLine("\nНажмите любую клавишу для продолжения...");
  }
}
