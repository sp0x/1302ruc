using System;
using System.Linq.Expressions;
using System.Linq;

namespace Homework
{
    /// <summary>
    /// 1.	Да се напише програма, която чете петцифрено число abcde:
    ///     a.	Извежда числото обърнато - edcba.
    ///     b.	Смята сбора от всичките му цифри.
    ///     c.	Извежда частното на въведеното число разделено на сбора от цифрите му.
    ///     d.	Разменя втората му и третата цифра и го разпечатва.
    /// </summary>
    public class task1
    {
        public delegate int sumit();
          public static void main(string[] args)
          {
            int sum = 0;
            Console.Write("digit: ");
            int inumber = int.Parse(Console.ReadLine());
            char[] chrNums = inumber.ToString().ToCharArray();

            Console.WriteLine("reversed: {0}", strReverse(inumber.ToString()));
            Console.WriteLine("sum: {0}",  ((sumit)(delegate {
                foreach (char c in chrNums) { sum += int.Parse(c.ToString()); }
                return sum;
            }))());
            Console.WriteLine("divided: {0}", inumber / sum);
            

            Console.WriteLine("2nd and 3rd num: {0},{1}", chrNums[1], chrNums[2]);
            char tmp = chrNums[1];
            chrNums[1] = chrNums[2];
            chrNums[2] = tmp;
            Console.WriteLine("switched: {0}", new string(chrNums));
          }
          public static string strReverse(string s)
          {
              char[] arr = s.ToCharArray();
              Array.Reverse(arr);
              return new string(arr);
          }
    }
}