using System;

namespace Homework
{
    /// <summary>
    /// 8.	ƒа се напише програма, ко€то чете три числа a,b,c и намира реалните корени на квадратното уравнение ax^2+bx+c=0.
    /// </summary>
    public class task8
    {
        public static void main(string[] args)
        {
            Console.Write("a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c: ");
            int c = int.Parse(Console.ReadLine());
            double[] solutions = quadraticSolve(a, b, c);
            Console.WriteLine(solutions.Length == 0 ? "nqma realni koreni!" : 
                solutions.Length == 2 ? String.Format("x1={0} x2={1}", solutions[0] , solutions[1]) :
                                       String.Format("x={0}", solutions[0]));
        }
        public static double[] quadraticSolve(int a, int b, int c)
        {
            double determinanta = (b * b) - (4 * a * c);
            double x, x1, x2, img;
            if (determinanta > 0)
            {
                x1 = (-b + Math.Sqrt(determinanta)) / (2 * a);
                x2 = (-b - Math.Sqrt(determinanta)) / (2 * a);
                return new double[] { x1, x2 };
            }
            else { return new double[] { }; }
        }
    }
}