using System;
using System.Linq.Expressions;
using System.Linq;

namespace Homework
{
    /// <summary>
    /// 1.	�� �� ������ ��������, ����� ���� ���������� ����� abcde:
    ///     a.	������� ������� �������� - edcba.
    ///     b.	����� ����� �� �������� �� �����.
    ///     c.	������� �������� �� ���������� ����� ��������� �� ����� �� ������� ��.
    ///     d.	������� ������� �� � ������� ����� � �� ����������.
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