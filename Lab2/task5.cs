using System;

public class Program
{
  public static void Main() {
    for(;;)
    {
      Console.Write("Нижняя граница =  ");
      var a = Convert.ToDouble(Console.ReadLine());
      
      Console.Write("Верхняя граница = ");
      var b = Convert.ToDouble(Console.ReadLine());
      
      Console.Write("Шаг = ");
      var h = Convert.ToDouble(Console.ReadLine());
      
      if (Math.Abs(a - b) < h)
      {
        Console.WriteLine("Неверный ввод");
        Console.ReadKey(true);
        Console.Clear();
        continue;
      }
      else
      {
        break;
      }
    }

    if (a > b)
    {
      var c = a;
      a = b;
      b = c;
    }

    Console.WriteLine("Табуляция циклом for");
    for (double i = a; i < b; i += h)
    {
      Console.WriteLine("f({0}) = {1}", i, Math.Sin(i));
    }
    
    Console.WriteLine("Табуляция циклом while");
    var current = a;
    while (current <= b)
    {
      Console.WriteLine("f({0}) = {1}", current, Math.Sin(current));
      current += h;
    }
    
    Console.WriteLine("Табуляция циклом do .. while");
    var current = a;
    do
    {
      Console.WriteLine("f({0}) = {1}", current, Math.Sin(current));
      current += h;
    } while (current < b + h);
  }
}
