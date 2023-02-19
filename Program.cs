using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 1
            //Random random = new Random();
            //int[] mass = new int[6];
            //int i;
            //for(i=0;i<6;i++)
            //{
            //    mass[i] = random.Next(1,10);
            //    Console.WriteLine($"mass[{i}]={mass[i]}");
            //}
            //for (i=0; i < 6; i++)
            //{
            //    if (mass[i] % mass[0] == 0)
            //    {
            //        int index = i;
            //        Console.WriteLine($"index={index}");
            //    }
            //}

            //Задача 2
            //int[] mass = new int[10];
            //Random rnd= new Random();
            //int i;
            //for (i = 0; i <10; i++)
            //{
            //    mass[i] = rnd.Next(-10,26);
            //    Console.WriteLine($"mass[{i}]={mass[i]}");
            //}
            //Console.WriteLine();
            //for (i=0;i<10;i++) 
            //{
            //    if (mass[i]>=0)
            //    {
            //        int a = mass[i];
            //        Console.WriteLine($"a={a}");
            //    }
            //}
            //Console.WriteLine();
            //for(i=0;i<10;i++)
            //{
            //    if(mass[i]<100)
            //    {
            //        int b=mass[i];
            //        Console.WriteLine($"b={b}");
            //    }
            //}
            //Console.WriteLine();
            //for(i=0;i<10;i++)
            //{
            //    if (mass[i]%2==0)
            //{
            //    int c = mass[i];
            //    Console.WriteLine($"c={c}");
            //}
            //}

            //Задача 3
            //int[] mass = new int[12] { 5, -3, 4, -8, -9, 1, 9, 6, -3, 4, 8, 2 };
            //int a = 0;
            //for (int i=0;i<12;i++)
            //{
            //    if(mass[i]<0)
            //    {
            //        a++;
            //    }
            //}
            //Console.Write($"a={a}");

            //Задача 4
            //int[] mass = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //double sr_ar = 0;
            //int a = 0;
            //for(int i=0;i<10; i++)
            //{
            //    if (mass[i]%2==1)
            //    {
            //        sr_ar=sr_ar+mass[i];
            //        a++;
            //    }
            //}
            //Console.WriteLine($"Среднее арифметическое={sr_ar/a}");

            //Задача 5
            //int[] mass=new int[10] {1,2,3,4,5,6,7,8,9,10};
            //for(int i=0;i<10;i++)
            //{
            //    Console.WriteLine($"mass[{i}]={mass[i] + mass[0]}");
            //}
            Console.ReadKey();
        }
    }
}
