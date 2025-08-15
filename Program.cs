
using System;

    class Program
    {
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, world!");
        Console.WriteLine("Welcome to your first C# project.");

        Calculator cal = new Calculator();
        cal.Run();

        Vote v = new Vote();
        v.Check();

        Factorial fa = new Factorial();
        fa.Calculate();

        Table tr = new Table();
        tr.Calculate();

        Table tar = new Table();
        tar.Calculate();

        Banking br = new Banking();
        br.Action();

        Armstrong ar = new Armstrong();
        ar.Calculate();

        Hcf hcf = new Hcf();
        hcf.Calculate();
        Lcm l = new Lcm();
        l.Calculate();


    }
}
