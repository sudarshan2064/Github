using System;
public class JaggedArray1
{
    public void Calculate()
    {
        System.Console.WriteLine("enter rows of jagged array");
        int row = Convert.ToInt16(Console.ReadLine());
        int[][] jagged = new int[row][];

        for (int i = 0; i < row; i++)
        {

            System.Console.WriteLine("enter row of sub 1d array");
            int row2 = Convert.ToInt16(Console.ReadLine());
            jagged[i] = new int[row2];
            System.Console.WriteLine("Enter array elements");

            for (int j = 0; j < row2; j++)
                jagged[i][j] = Convert.ToInt16(Console.ReadLine());

        }
        for (int i = 0; i < row; i++)
        {

            for (int j = 0; j < jagged[i].Length; j++)

                System.Console.Write("  " + jagged[i][j] + " ");
            System.Console.WriteLine("");
        }
    }
}

// output: 
// enter rows of jagged array
// 2
// enter row of sub 1d array
// 2
// Enter array elements
// 1
// 2
// enter row of sub 1d array
// 2
// Enter array elements
// 2
// 3
//   1   2 
//   2   3