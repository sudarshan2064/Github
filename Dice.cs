using System;
class Dice
{
    public void Calculate()
    {
        int playerRadom, enemyRandom;
        Random random = new Random();
        int playerPoint = 0;
        int enemyPoint = 0;
        System.Console.WriteLine("Enter the number of round you wanna play the dice game ");
        int n = Convert.ToInt16(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            playerRadom = random.Next(1, 7);
            enemyRandom = random.Next(1, 7);
            Console.ReadKey();                    //it stops the iteration for user apporoval
            System.Console.WriteLine($"Your rolled {playerRadom}");
            System.Console.WriteLine("....");
            System.Threading.Thread.Sleep(1000);        //this method delay by 1 sec before compiling next line of code
            System.Console.WriteLine($"Your enemy AI rolled  {enemyRandom}");
            int pointgap = (playerRadom > enemyRandom) ? playerRadom - enemyRandom : enemyRandom - playerRadom;

            if (playerRadom > enemyRandom)
            {
                playerPoint++;
                System.Console.WriteLine("you won this round");
            }
            else if (playerRadom < enemyRandom)
            {
                enemyPoint++;
                System.Console.WriteLine("you loss this round");
            }
            else
            {
                System.Console.WriteLine("draw");
            }
            System.Console.WriteLine($"your point: {playerPoint} | Enemy point: {enemyPoint} | won by: {pointgap} points");
            System.Console.WriteLine($"press any key to play round {i + 1} ");
            Console.ReadKey();

        }
    }
}