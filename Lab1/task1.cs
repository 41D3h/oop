using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class task1
{
  static void Main(string[] args)
  {
    OperatingSystem os = System.Environment.OSVersion;
    Console.WriteLine("Platform: {0}", os.Platform);
    System.Console.WriteLine("The current date and time is " + System.DateTime.Now);
    System.Console.ReadLine();
  }
}
