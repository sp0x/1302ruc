using System;

namespace Homework
{
    /// <summary>
    /// 9.	Да се напише програма, която изписва с думи въведена цифра. Да се използва операторът switch. 
    /// </summary>
    public class task9
    {
        public static void main(string[] args)
        {
            Console.Write("number from 1 to 5: ");
            int num = int.Parse(Console.ReadLine());
            switch(num)
            {
                case 1:
                    Console.WriteLine("Number is 1");
                    break;
                case 2:
                    Console.WriteLine("Number is 2");
                    break;
                case 3:
                    Console.WriteLine("Number is 3");
                    break;
                case 4:
                    Console.WriteLine("Number is 4");
                    break;
                case 5:
                    Console.WriteLine("Number is 5");
                    break;
                default:
                    Console.WriteLine("Invalid number..");
                    break;
            }
        }
    }
}