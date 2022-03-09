public class Program
{
  private static Random rnd = new Random();
  public static void Main() {
    Console.Clear();
    
    //task1
    int[] arrayK = new int[]
    {
      25, -47, 96, 143, -538, 
      -72, 963, 271, -1, 321, 
      0, 531, -135, 246, 642,
      38, -419, 344, -821, 739,
      701, -109, 375, 285, -629
    };//15 positives, 9 negatives, 1 zero
    
    Console.WriteLine("Количество неотрицательных элементов массива K(25) = {0}\n", Positives(arrayK));
    
    //task2
    int[] arrayP = new int[30];
    Console.WriteLine("Элементы массива P(30)");
    ArrayGenerator(arrayP, 0, 256);
    
    int max = MaxIndex(arrayP);
    Console.WriteLine("Максимальное значение в массиве = {0}, его индекс {1}\n", arrayP[max], max + 1);
    
    //task3
    int[] arrayF = new int[30];
    Console.WriteLine("Элементы массива F(30)");
    ArrayGenerator(arrayF, -512, 511);
    
    Console.WriteLine("Первый положительный элемент = {0}\n", FirstPositive(arrayF));
    
    //task4
    int[] arrayT = new int[20];
    Console.WriteLine("Элементы массива T(20)");
    ArrayGenerator(arrayT, -512, 511);
    
    ReverseBubbleSort(arrayT);
    Console.WriteLine("Элементы массива T(20)");
    DisplayArray(arrayT);
    
    //task5
    int[,] arrayL = new int[10,15];
    Console.WriteLine("Элементы массива L(10,15)");
    for (int i = 0; i < arrayL.GetLength(0); i++)
    {
      for (int j = 0; j < arrayL.GetLength(1); j++)
      {
        arrayL[i, j] = rnd.Next(-512, 511);
        Console.Write("{0}\t", arrayL[i, j]);
      }
      Console.WriteLine();
    }

    RowsSwapper(arrayL);
    for (int i = 0; i < arrayL.GetLength(0); i++)
    {
      for (int j = 0; j < arrayL.GetLength(1); j++)
      {
        Console.Write("{0}\t", arrayL[i, j]);
      }
      Console.WriteLine();
    }

  }

  //task1
  private static int Positives(int[] numbers) {
    int count = 0;
    foreach (var number in numbers)
    {
      if (number >= 0) count++;
    }

    return count;
  }

  //task2
  private static int MaxIndex(int[] numbers) {
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
  private static int FirstPositive(int[] numbers) {
    foreach (var number in numbers)
    {
      if (number > 0) return number;
    }

    return -1;
  }
  
  //task4
  private static void ReverseBubbleSort(int[] numbers) {
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
  private static void RowsSwapper(int[,] numbers) {
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
      
    for (int j = 0; j < numbers.GetLength(0); j++)
    {
      int temp = numbers[k, j];
      numbers[k, j] = numbers[n, j];
      numbers[n, j] = temp;
    }
  }

  private static void ArrayGenerator(int[] array, int min, int max) {
    for (int i = 0; i < array.Length; i++)
    {
      array[i] = rnd.Next(min,max);
    }

    DisplayArray(array);
  }

  private static void DisplayArray(int[] array) {
    foreach (var elem in array)
    {
      Console.Write("{0}\t", elem);
    }
    Console.WriteLine();
    Console.WriteLine();
  }
}