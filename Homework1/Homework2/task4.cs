using System;
/// <summary>
/// 4.	�� �� ������ ��������, ����� ���� ���� ����� �� ��������� � �� �������� �� 8 ��� �� �������� ���������� �� ���������.
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