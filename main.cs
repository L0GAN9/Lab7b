using System;

class Program {
  public static int IntegerPower(int x, int y)
  {
    
    var num = x*x;

    for (int i = 2; i < y; i++)
    {
      num = num * x;
    }
    return num;
  }
  public static void Main (string[] args) 
  {
    Console.WriteLine ("Enter Base Value");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter Power Value");
    int y = Convert.ToInt32(Console.ReadLine());
    int num = IntegerPower(x,y);
    Console.WriteLine(num);
  }
}