using System;
/// <summary>
/// 2.	Да се напише програма, която пресмята лицето на трапец по дадени две основи и височина.
/// </summary>
public class task2
{
    public static void main(string[] args)
    {
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("h = ");
        int h = int.Parse(Console.ReadLine());
        Console.WriteLine("S = {0}", ((a+b)/2)*h);
    }
}