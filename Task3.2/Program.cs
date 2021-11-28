using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        /*На числовой оси расположены три точки: A, B, C. Определить, какая из двух последних точек(B или C) расположена ближе к A, 
         * и вывести эту точку и ее расстояние от точки A.Если пользователь введёт координаты B и C так, что они будут равноотстоящими от А, 
         * * совпадать с А или между собой -выдать соответствующее сообщение.*/
        static void Main(string[] args)
        {
            Console.Write("Введите числовое значение точки A: ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите числовое значение точки B: ");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите числовое значение точки C: ");
            int C = Convert.ToInt32(Console.ReadLine());
            int lengthAB = Math.Abs(A - B);
            int lengthAC = Math.Abs(A - C);

            if (lengthAB > lengthAC)
            {
                Console.WriteLine("C ближе к А на расстояние = {0}", lengthAC);
                if (A == C)
                {
                    Console.WriteLine("Точки A и C совпадают");
                }
            }
            else if (lengthAB < lengthAC)
            {
                Console.WriteLine("B ближе к А на расстояние = {0}", lengthAB);
                if (A == B)
                {
                    Console.WriteLine("Точки A и B совпадают");
                }
            }
            else
            {
                if (A == B && B == C && A == C)
                {
                    Console.WriteLine("Точки A, B и C совпадают");
                }
                else
                {
                    if (A > B && A < C)
                    {
                        int norm2 = Math.Abs(B) - 2 * Math.Abs(A);
                        if (norm2 == Math.Abs(C))
                        {
                            Console.WriteLine("Точки B и C равноудалены от точки A на расстояние {0}", ((Math.Abs(C) + Math.Abs(B)) / 2));
                        }
                    }
                    else if (B > A && C < A)
                    {
                        int norm2 = Math.Abs(C) - 2 * Math.Abs(A);
                        if (norm2 == Math.Abs(B))
                        {
                            Console.WriteLine("Точки B и C равноудалены от точки A на расстояние {0}", ((Math.Abs(B) + Math.Abs(C)) / 2));
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
