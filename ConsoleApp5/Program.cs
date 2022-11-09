using System;
class test
{
    static void Main()
    {
        Console.WriteLine("enter x:");
        string x = Console.ReadLine();
        Console.WriteLine("enter y:");
        string y = Console.ReadLine();
        int a = Convert.ToInt32(x);
        int b = Convert.ToInt32(y);
        double c = Math.Sqrt(Math.Pow(Math.Abs(a - b), Math.Abs(b)));
        Console.WriteLine(c);
    }
}