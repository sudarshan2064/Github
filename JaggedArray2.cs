//2d array as jagged array
using System;
using System.ComponentModel;
public class JaggedArray2
{
    public void Calculate()
    {
        System.Console.WriteLine("Enter a row of jagged array");
        int row = Convert.ToInt32(Console.ReadLine());
        int[][,] jagged = new int[row][,];
        for (int i = 0; i < row; i++)
        {
            System.Console.WriteLine("Enter row of 2d array inside jagged array");
            int num = Convert.ToInt16(Console.ReadLine());

            for (int a = 0; a < num; a++)
            {
                System.Console.WriteLine("enter column of 2d array");
                int column = Convert.ToInt16(Console.ReadLine());
                System.Console.WriteLine("Enter array elements");
                for (int b = 0; b < column; b++)
                {
                    jagged[i][a, b] = Convert.ToInt16(Console.ReadLine());
                }

            }

        }
        for (int i = 0; i < row; i++)
        {
            

            for (int a = 0; a < row; a++)
            {
               
                for (int b = 0; b < jagged[i].GetLength[b]; b++)
                {
                   System.Console.WriteLine( jagged[i][a, b] );
                }
                
            }

        }
    }
}