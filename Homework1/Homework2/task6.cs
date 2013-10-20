using System;

namespace Homework
{
    /// <summary>
    /// 6.	 Да се напише програма, която чете цяло число от конзолата и извежда “Positive” ако е положително и “Negative” ако е отрицателно. Ако не е въведено валидно число да се изведе информация за грешка
    /// </summary>
    public class task5
    {
        public static void main(string[] args)
        {
            Console.Write("number: ");
            Console.WriteLine(int.Parse(Console.ReadLine()) < 0 ? "Negative" : "Positive");
        }
    }
}
