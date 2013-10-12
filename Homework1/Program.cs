using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;


class Program
{
    private static String strInvalidTask = "Невалиден номер на задачата!";
    private static String strWrongData = "Wrong data input";
    //Entry point..
    public static void Main()
    {
        while (true)
        {        // Loop the homework for all tests to be done
            try
            {
                Console.Write("Задача от домашното (1-7): ");
                uint taskNum = uint.Parse(Console.ReadLine());
                if (taskNum > 7)
                { Console.WriteLine(strInvalidTask); continue; }
                Console.WriteLine();
                executeTask(taskNum);
            }
            catch (Exception ex)
            {
                Console.WriteLine(strInvalidTask);
            }
        }
    }
    public static void executeTask(uint taskNum)
    {
        switch (taskNum)
        {
            case 1:
                task1(); break;
            case 2:
                task2(); break;
            case 3:
                task3(); break;
            case 4:
                task4A(); break;
            case 5:
                task4B(); break;
            case 6:
                task5(); break;
            case 7:
                task6(); break;
        }
    }


    #region Tasks
    public static void task1()
    {
        // 1.   Да се напише програма, която приема три имена и извежда поздрав.
        Console.Write("Твойте 3 имена: ");
        string strNames = Console.ReadLine();
        try
        {
            Console.WriteLine("Здравей " + strNames + "!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Моля опитайте отново с валидни 3 имена!");
        }
    }

    public static int task2()
    {
        // 2.	Да се въведат три цели числа и да се изведе техният сбор.
        Console.Write("Моля въведете 3 числа, разделени с , : ");
        String[] strNums = Console.ReadLine().Trim().Split(',');
        try
        {
            int ret = int.Parse(strNums[0]) + int.Parse(strNums[1]) + int.Parse(strNums[2]);
            Console.WriteLine("{0} + {1} + {2} = {3}", strNums[0], strNums[1], strNums[2], ret );
        }
        catch (Exception ex)
        {
            Console.WriteLine("Моля опитайте отново!");
        }
        return 0;
    }

    public static void task3()
    {
        // 3.	Декларирайте няколко променливи, като изберете за всяка една най-подходящия от типовете
        // sbyte, byte, short, ushort, int, uint, long и ulong
        // за да им присвоите следните стойности: 52130
        //  -115, 4825932, 97, -10000, 20000; 224; 970700000; 112; -44; -1000000; 1990; 123456789123456789.
        sbyte sbVar1 = -115;
        int intVar2 = 4825932;
        byte bVar3 = 97;
        short shVar4 = -10000;
        short shVar5 = 20000;
        byte bVar6 = 224;
        ulong ulVar7 = 970700000;
        byte bVar8 = 112;
        sbyte sbVar9 = -44;
        int sbVar10 = -1000000;
        ushort usVar11 = 1990;
        ulong ulVar12 = 123456789123456789;
    }
    #region Task4 A and B
    public static void task4A()
    {
        //4.	Да се напише програма, която чете две числа от конзолата и разменя стойностите им.
        // 		*Да се направи по два различни начина.
        Console.Write("Въведете 2 числа: ");
        string[] strNums = Console.ReadLine().Trim().Replace(",","").Split(' ');
        System.Array.Reverse(strNums);
        Console.WriteLine();
        Console.WriteLine("Разменения резултат e: " + String.Join(" ", strNums));
    }
    public static void task4B()
    {
        //4.    Да се напише програма, която чете две числа от конзолата и разменя стойностите им.
        //      *Да се направи по два различни начина.
        Console.Write("Първо число: ");
        int intA = int.Parse(Console.ReadLine());
        Console.Write("Второ число: ");
        int intB = int.Parse(Console.ReadLine());
        int tmpBuff = intA;
        intA = intB;
        intB = tmpBuff;
        Console.WriteLine("Разменения резултат е: " + intA.ToString() + intB.ToString());
    }
    #endregion

    public static void task5()
    {
        //	5.	Да се напише програма, която чете име от конзолата и извежда следния поздрав: „Hello „<name>“ hello“,
        //	без  външните кавички и <name> да е въведеното от конзолата име.
        string strName = Console.ReadLine();
        Console.WriteLine("Hello \"{0}\"", strName);
    }
    public static void task6()
    {
    //	6.	Да се напише програма, която приема символен низ, булева променлива и цяло число от конзолата и ги извежда.
    //	Ако някоя от въведените стойности не отговаря на типа си да се изведе съобщение „Wrong data input“.
    START:
        try
        {
            Console.Write("Your String: ");
            String boolVar = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Your value is: " + boolVar);
        }
        catch (Exception ex) { Console.WriteLine(strWrongData); goto START; }
    BOOL:
        try
        {
            Console.Write("Your boolean: ");
            Boolean boolVar = Console.ReadLine().Trim().ToLower() == "true";
            Console.WriteLine();
            Console.WriteLine("Your value is: " + boolVar);
        }
        catch (Exception ex) { Console.WriteLine(strWrongData); goto BOOL; }
    WHOLE:
        try
        {
            Console.Write("Your whole num: ");
            float boolVar = float.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Your value is: " + boolVar);
        }
        catch (Exception ex) { Console.WriteLine(strWrongData); goto WHOLE; }
    }
    #endregion

}