using System;

public class Program
{
  public static Random rnd = new Random();
  public static void Main() {
    
    
    //task1
    int[] array_K = new int[25]
    {
      25, -47, 96, 143, -538, 
      -72, 963, 271, -1, 321, 
      0, 531, -135, 246, 642,
      38, -419, 344, -821, 739,
      701, -109, 375, 285, -629
    };//15 positives, 9 negatives, 1 zero
    
    Console.WriteLine("Количество неотрицательных элементов массива K(25) = {0}\n", Positives(array_K));

    //task2
    int[] array_P = new int[30];
    Console.WriteLine("Элементы массива P(30)");
    ArrayGenerator(array_P, 0, 256);

    int max = MaxIndex(array_P);
    Console.WriteLine("Максимальное значение в массиве = {0}, его индекс {1}\n", array_P[max], max + 1);

    //task3
    int[] array_F = new int[30];
    Console.WriteLine("Элементы массива F(30)");
    ArrayGenerator(array_F, -512, 511);

    Console.WriteLine("Первый положительный элемент = {0}\n", FirstPositive(array_F));
    
    //task4
    int[] array_T = new int[20];
    Console.WriteLine("Элементы массива T(20)");
    ArrayGenerator(array_T, -512, 511);

    ReverseBubbleSort(array_T);
    Console.WriteLine("Элементы массива T(20)");
    DisplayArray(array_T);
    
    //task5
    int[][] array_L = new int[10][];
    Console.WriteLine("Элементы массива L(10,15)");
    for (int i = 0; i < array_L.Length; i++)
    {
      array_L[i] = new int[15];
      for (int j = 0; j < array_L[i].Length; j++)
      {
        array_L[i][j] = rnd.Next(-512, 511);
        Console.Write("{0}\t", array_L[i][j]);
      }
      Console.WriteLine();
    }

    RowsSwapper(array_L);
    for (int i = 0; i < array_L.Length; i++)
    {
      for (int j = 0; j < array_L[i].Length; j++)
      {
        Console.Write("{0}\t", array_L[i][j]);
      }
      Console.WriteLine();
    }

  }

  //task1
  public static int Positives(int[] numbers) {
    int count = 0;
    foreach (var number in numbers)
    {
      if (number >= 0) count++;
    }

    return count;
  }

  //task2
  public static int MaxIndex(int[] numbers) {
    int max = numbers[0], index = 0;
    for (int i = 1; i < numbers.Length; i++)
    {
      if (max < numbers[i])
      {
        max = numbers[i];
        index = i;
      } 
    }

    return index;
  }

  //task3
  public static int FirstPositive(int[] numbers) {
    for (int i = 0; i < numbers.Length; i++)
    {
      if (numbers[i] > 0) return numbers[i];
    }

    return -1;
  }
  
  //task4
  public static void ReverseBubbleSort(int[] numbers) {
    for (int i = 1; i < numbers.Length; i++)
    {
      for (int j = 1; j < numbers.Length; j++)
      {
        if (numbers[j - 1] > numbers[j])
        {
          int temp = numbers[j - 1];
          numbers[j - 1] = numbers[j];
          numbers[j] = temp;
        }
      }
    }
  }

  //task5
  public static void RowsSwapper(int[][] numbers) {
    int k, n;
    
    do
    {
      try
      {
        Console.WriteLine("Введите номера строк, которые необходимо поменять");
        k = Convert.ToInt32(Console.ReadLine()) - 1;
        n = Convert.ToInt32(Console.ReadLine()) - 1;
        
        if (k < 10 && n < 10 && k >= 0 && n >= 0) break;
      }
      catch (Exception e)
      {
        Console.WriteLine(e);
      }

      Console.WriteLine("Что-то пошло не так. Попробуйте еще раз");
    } while (true);

    Console.WriteLine();
      
    for (int j = 0; j < numbers[0].Length; j++)
    {
      int temp = numbers[k][j];
      numbers[k][j] = numbers[n][j];
      numbers[n][j] = temp;
    }
  }
  
  public static void ArrayGenerator(int[] array, int min, int max) {
    for (int i = 0; i < array.Length; i++)
    {
      array[i] = rnd.Next(min,max);
    }

    DisplayArray(array);
  }

  public static void DisplayArray(int[] array) {
    foreach (var elem in array)
    {
      Console.Write("{0}\t", elem);
    }
    Console.WriteLine();
    Console.WriteLine();
  }
}
