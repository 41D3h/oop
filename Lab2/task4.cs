using System;

public class Program
{
  public static void Main() {
    for(;;)
    {
      try
      {
        Console.Write("Введите номер месяца ");
        var month = Convert.ToInt(Console.ReadLine());
      }
      catch (Exception e)
      {
        Console.WriteLine("Введеное значение не является целым числом");
        Console.ReadKey(true);
        Console.Clear();
        continue;
      }
      
      if (month > 12 || month < 1)
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

    switch (month)
    {
      case 1, 2, 12: Console.WriteLine("Winter");
        break;
      case 3 .. 5: Console.WriteLine("Spring");
        break;
      case 6 .. 8: Console.WriteLine("Summer");
        break;
      case 9 .. 11: Console.WriteLine("Autumn");
    }
  }
}
