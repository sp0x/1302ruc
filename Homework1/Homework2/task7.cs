using System;

namespace Homework
{
    /// <summary>
    /// 7.	Да се напише програма, която чете три цели числа от конзолата. Да се изведе информация дали могат да образуват триъгълник. Ако могат да образуват триъгълник да се каже дали е разностранен, равнобедрен или равностранен.
    /// </summary>
    public class task7
    {
        public static void main(string[] args)
        {
            Console.Write("a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c: ");
            int c = int.Parse(Console.ReadLine());
            bool ravnob = a == b || b==c || a==c;
            bool ravnostr = a == b && b == c && a == c;
            Console.WriteLine("type: {0}", ravnob ? "ravnobedren" : ravnostr ? "ravnostranen" : "raznostranen");
        }
    }
}