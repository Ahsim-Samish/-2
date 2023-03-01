using System;
using static System.Console;

namespace практикум_2
{
    internal class Program
    {
          /// <summary>
          /// 
          /// </summary>
          /// <param name="args"></param>
          static void Writing()
        { }
        static void Main(string[] args)
        {
            /*{//задача 1
                int[] massiv = { 1, 2, 3, 4, 5 };
                int[] random = new int[6];
                Random ran = new Random()
                for (int i = 0; i < random.Length; i++)
                {

                    random[i] = ran.Next(-10, 10);
                    if (random[i] == massiv[1])
                    {
                        Console.WriteLine($"Номер элемента -{i}");
                    }
                }
            }*/
            /*{
                //задача 2
                int[] random = new int[6];
                Random ran = new Random();
                for (int i = 0; i < random.Length; i++)
                {
                    random[i] = ran.Next(-150, 150);
                    Console.WriteLine($"ran{i}={random[i]}");
                    if (random[i] <= 100)
                    {
                        Console.WriteLine($"  {random[i]}- не превышает 100");
                    }
                    if (random[i] >= 0)
                    {
                        Console.WriteLine($"  {random[i]}- неотрицательное");
                    }
                    if (random[i]%2 == 0)
                    {
                        Console.WriteLine($"  {random[i]}- чётное");
                    }
                }

            }*/
            /*{
                //задача 3
                int[] massiv = { 5, -3, 4, -8, -9, 1, 9, 6, -3, 4, 8, 2 };
                int a = 0;
                for (int i = 0; i < massiv.Length; i++)
                {
                    if (massiv[i] < 0)
                        a++;
                }
                Console.WriteLine($"Количество отрицательных элементов - {a}");
            }*/
            /*{
                //задача 4
                int[] massiv = { 5, -3, 4, -8, -9, 1, 9, 6, -3, 4, 8, 2 };
                int a = 0;
                for (int i = 0; i < massiv.Length; i++)
                {
                    if (massiv[i] %2==1)
                        a+= massiv[i];
                }
                a = a / massiv.Length;
                Console.WriteLine($"Среднее арифметическое элементов с нечетными номерами - {a}");
            }*/
            /*{
                //задача 5
                int[] massiv = { 5, -3, 4, -8, -9, 1, 9, 6, -3, 4, 8, 2 };
                for (int i = 0; i < massiv.Length; i++)
                {
                        massiv[i] = massiv[i]*5;
                    Console.WriteLine(massiv[i]);
                }
            }*/
        }
    }
}
