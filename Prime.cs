// Program to display prime numbers upto where user want
using System;
public class Prime
{
    public int num, i, prime;
    public void Calculate()
    {
        i = 2;
        while (i < prime)
        {
            if (prime % i == 0)
            {
                break; //not prime
            }

            i++;
        }
        if (i == prime)
        {
            Console.Write($"  {prime}");
        }
        prime++;
    }


    public void Check()
    {

        Console.WriteLine("Enter a range  upto where prime numbers you want");
        num = Convert.ToInt32(Console.ReadLine());
        prime = 2;
        while (prime <= num)
        {
            Calculate();

        }
    }
}

// PS D:\All Folders\C#\Github\NewProject> dotnet run
// Enter a range  upto where prime numbers you want
// 100
//   2  3  5  7  11  13  17  19  23  29  31  37  41  43  47  53  59  61  67  71  73  79  83  89  97