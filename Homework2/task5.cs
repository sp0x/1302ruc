using System;
/// <summary>
/// 5.	Да се напише програма, която чете име, егн и телефон от конзолата и извежда следния поздрав: „Hello „ИМЕ“ your ID is: „ЕГН“ and your phone number is „ТЕЛ“ “, без  външните кавички. Забранява се използването на оператора +.
/// </summary>
public class task5
{
    public static void main(string[] args)
    {
        Console.Write("name: ");
        int name = int.Parse(Console.ReadLine());
        Console.Write("id: ");
        int id = int.Parse(Console.ReadLine());
        Console.Write("phone: ");
        int phone = int.Parse(Console.ReadLine());

        Console.WriteLine("Hello „{0}“ your ID is: „{1}“ and your phone number is „{2}“",
            name,id,phone);
    }
}