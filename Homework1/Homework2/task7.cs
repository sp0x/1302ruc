using System;

namespace Homework
{
    /// <summary>
    /// 7.	�� �� ������ ��������, ����� ���� ��� ���� ����� �� ���������. �� �� ������ ���������� ���� ����� �� ��������� ����������. ��� ����� �� ��������� ���������� �� �� ���� ���� � ������������, ����������� ��� ������������.
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