using System;

namespace Homework
{
    /// <summary>
    /// 6.	 �� �� ������ ��������, ����� ���� ���� ����� �� ��������� � ������� �Positive� ��� � ����������� � �Negative� ��� � �����������. ��� �� � �������� ������� ����� �� �� ������ ���������� �� ������
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
