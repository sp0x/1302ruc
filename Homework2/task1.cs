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
       
          public static void main(string[] args)
          {
            int sum = 0;
            Console.Write("digit: ");
            int inumber = int.Parse(Console.ReadLine());
            char[] chrNums = inumber.ToString().ToCharArray();

            Console.WriteLine("reversed: {0}", strReverse( chrNums )); // task1.a
            
            foreach(char chr in chrNums)            // 
            { sum += int.Parse(New String(chr)); }  // task1.b
            Console.WriteLine("sum: {0}", sum );    // 
            
            Console.WriteLine("divided: {0}", inumber / sum); // task1.c
            

            Console.WriteLine("2nd and 3rd num: {0},{1}", chrNums[1], chrNums[2]); // task1.d
            char tmp = chrNums[1];
            chrNums[1] = chrNums[2];
            chrNums[2] = tmp;
            Console.WriteLine("switched: {0}", new String(chrNums));
          }
          
          public static string chrReverse(char[] s)
          {
              Array.Reverse(s);
              return new String(s);
          }
    }
}
