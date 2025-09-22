using System;
public class Randomm
{
    public void Calculate()
    {
        Random r = new Random();
        System.Console.WriteLine("Enter a number beteen 1 to 100");
        int b = Convert.ToInt16(Console.ReadLine());
        int a = r.Next(1, 101);
        System.Console.WriteLine(a);
        int attempt =1;
        while (a != b & b!=0)
        {
            if (a == b)
            {
                System.Console.WriteLine($"congratulation on finding the real number in {attempt} attempt");
                break;
            }
            else if (a-b<=5& a-b>=0)
            {
                System.Console.WriteLine("little bigger");
            }
            else if (b-a<=5 & b-a >0)
            {
                System.Console.WriteLine("little smaller");
            }
            
            System.Console.WriteLine("Enter a number beteen 1 to 100 again to guess   or    enter 0 to exit");
            b = Convert.ToInt16(Console.ReadLine());
            attempt++;
        }
    }

}