using System;
/// <summary>
/// 4.	Да се напише програма, която чете цяло число от конзолата и го умножава по 8 без да използва операторът за умножение.
/// </summary>
public class task4
{
    public static void main(string[] args)
    {
        Console.Write("number: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("number * 8 = {0}", a << 3);

    }
}