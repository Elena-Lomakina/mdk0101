using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Из шести целых чисел найти наибольшее и наименьшее число, а так же среднее арифметическое этих введенных чисел.
namespace pr11
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;
            int e = 0;
            int f = 0;
            int max = 0;
            int min = 0;

            int Number2 = 0;

            while (Number2 == 0)
            {
                try
                {
                    Console.WriteLine("Введите первое число ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Number2++;
                }
                catch
                {
                    Console.WriteLine("\nОшибка!!!");
                }
            }

            Number2 = 0;

            while (Number2 == 0)
            {
                try
                {
                    Console.WriteLine("Введите второе число ");
                    b = Convert.ToInt32(Console.ReadLine());
                    Number2++;
                }
                catch
                {
                    Console.WriteLine("\nОшибка!!!");
                }
            }

            Number2 = 0;

            while (Number2 == 0)
            {
                try
                {
                    Console.WriteLine("Введите третье число ");
                    c = Convert.ToInt32(Console.ReadLine());
                    Number2++;
                }
                catch
                {
                    Console.WriteLine("\nОшибка!!!");
                }
            }

            Number2 = 0;

            while (Number2 == 0)
            {
                try
                {
                    Console.WriteLine("Введите четвертое число ");
                    d = Convert.ToInt32(Console.ReadLine());
                    Number2++;
                }
                catch
                {
                    Console.WriteLine("\nОшибка!!!");

                }
            }

            Number2 = 0;

            while (Number2 == 0)
            {
                try
                {
                    Console.WriteLine("Введите пятое число ");
                    e = Convert.ToInt32(Console.ReadLine());
                    Number2++;
                }
                catch
                {
                    Console.WriteLine("\nОшибка!!!");
                }
            }

            Number2 = 0;

            while (Number2 == 0)
            {
                try
                {

                    Console.WriteLine("Введите шестое число ");
                    f = Convert.ToInt32(Console.ReadLine());
                    Number2++;
                }
                catch
                {
                    Console.WriteLine("\nОшибка!!!");

                } 
            }

            if (a > b)
            {
                if (a > c)
                {
                    if (a > d)
                    {
                        if (a > e)
                        {
                            if (a > f)
                            {
                                max = a;
                            }
                        }
                    }
                }
            }
            if (b > a)
            {
                if (b > c)
                {
                    if (b > d)
                    {
                        if (b > e)
                        {
                            if (b > f)
                            {
                                max = b;
                            }
                        }
                    }
                }
            }
            if (c > a)
            {
                if (c > b)
                {
                    if (c > d)
                    {
                        if (c > e)
                        {
                            if (c > f)
                            {
                                max = c;
                            }
                        }
                    }
                }
            }
            if (d > a)
            {
                if (d > b)
                {
                    if (d > c)
                    {
                        if (d > e)
                        {
                            if (d > f)
                            {
                                max = d;
                            }
                        }
                    }
                }
            }
            if (e > a)
            {
                if (e > b)
                {
                    if (e > c)
                    {
                        if (e > d)
                        {
                            if (e > f)
                            {
                                max = e;
                            }
                        }
                    }
                }
            }
            if (f > a)
            {
                if (f > b)
                {
                    if (f > c)
                    {
                        if (f > d)
                        {
                            if (f > e)
                            {
                                max = f;
                            }
                        }
                    }
                }
            }
            if (a < b)
            {
                if (a < c)
                {
                    if (a < d)
                    {
                        if (a < e)
                        {
                            if (a < f)
                            {
                                min = a;
                            }
                        }
                    }
                }
            }
            if (b < a)
            {
                if (b < c)
                {
                    if (b < d)
                    {
                        if (b < e)
                        {
                            if (b < f)
                            {
                                min = b;
                            }
                        }
                    }
                }
            }
            if (c < a)
            {
                if (c < b)
                {
                    if (c < d)
                    {
                        if (c < e)
                        {
                            if (c < f)
                            {
                                min = c;
                            }
                        }
                    }
                }
            }
            if (d < a)
            {
                if (d < b)
                {
                    if (d < c)
                    {
                        if (d < e)
                        {
                            if (d < f)
                            {
                                min = d;
                            }
                        }
                    }
                }
            }
            if (e < a)
            {
                if (e < b)
                {
                    if (e < c)
                    {
                        if (e < d)
                        {
                            if (e < f)
                            {
                                min = e;
                            }
                        }
                    }
                }
            }
            if (f < a)
            {
                if (f < b)
                {
                    if (f < c)
                    {
                        if (f < d)
                        {
                            if (f < e)
                            {
                                min = f;
                            }
                        }
                    }
                }
            }
            Console.WriteLine("min: {0} \nmax: {1} \n", min, max);
            int sz = (a + b + c + d + e + f) / 2;
            Console.WriteLine("Среднее арифметическое:{0} \n", sz);

            //Проверить истинность высказывания: "Цифры данного целого 
            //положительного трехзначного числа, введенного с клавиатуры, образуют убывающую последовательность".

             int numb = 0;

             int Number1 = 0;

             while (Number1 == 0)
             {
                 try
                 {
                     Console.WriteLine("Введите трехзначное число ");
                     numb = Convert.ToInt32(Console.ReadLine());
                     Number1++;
                 }
                 catch
                 {
                     Console.WriteLine("\nОшибка!!!");
                 }
                 if (numb < 100 || numb > 1000)
                 {
                     Number1 = 0;
                 }
             }
 
                if (numb / 100 < numb / 10 % 10 && numb / 10 % 10 < numb % 10)
                    Console.WriteLine("Нет");
                else if (numb / 100 > numb / 10 % 10 && numb / 10 % 10 > numb % 10)
                    Console.WriteLine("Да");
                else
                {
                    Console.WriteLine("Возможен набор одинаковых цифр или некорректный ввод (большее-меньшее-большее)");
                }
             

            //Даны два целых положительных числа: D (день, от 1 до 31) и M (месяц, от 1 до 12), 
            //определяющие правильную дату не високосного года. Вывести значения D и M для даты, 
            //предшествующей указанной.

             int D = 0;
             int M = 0;
             int Number = 0;

             while (Number == 0)
             {
                 try
                 {
                     Console.WriteLine("Введите день, от 1 до 31 ");
                     D = Convert.ToInt32(Console.ReadLine());
                     Number++;
                 }
                 catch
                 {
                     Console.WriteLine("\nОшибка!!!");
                 }
                 if (D < 0 || D > 31 || D == 0)
                 {
                     Number = 0;
                 }
             }

             Number = 0;

             while (Number == 0)
             {
                 try
                 {
                     Console.WriteLine("Введите месяц, от 1 до 12 ");
                     M = Convert.ToInt32(Console.ReadLine());
                     Number++;
                 }
                 catch
                 {
                     Console.WriteLine("\nОшибка!!!");
      
                 }
                 if (M < 0 || M > 12 || M == 0)
                 {
                     Number = 0;
                 }
             }

             if (D <= 31 && D > 1)
             {
                D--;
                if (M == 1)
                {
                    M = 12;
                }
             }
             if (D == 1)
             {
                D = 31;
                if (M <= 12 && M > 1)
                {
                    M--;
                }
                if (M == 1)
                {
                    M = 12;
                }
             }
             Console.WriteLine("День: {0} \nМесяц: {1} \n", D, M);

             Console.ReadKey();
        }
    }
}
