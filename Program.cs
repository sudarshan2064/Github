
using System;

class Program
{
    public static void Main()
    {
        int num1, num2;
        Console.WriteLine("enter two number");
        num1 = int.Parse(Console.ReadLine());
        num2 = int.Parse(Console.ReadLine());
        int sum = Arithmetic.Add(num1, num2);
        Console.WriteLine("summ is  "+sum);
    }
}
