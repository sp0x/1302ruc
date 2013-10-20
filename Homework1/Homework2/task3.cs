using System;
/// <summary>
/// 3.	Да се напише програма, която по три зададени страни смята лицето на триъгълник. Използвайте Херонова формула.
/// </summary>
public class task3
{
    public static void main(string[] args)
    {
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("c = ");
        int c = int.Parse(Console.ReadLine());
        float p=(a+b+c)/2;
        Console.WriteLine("S = {0}",
            Math.Sqrt(p*(p-a)*(p-b)*(p-c)));
    }
}