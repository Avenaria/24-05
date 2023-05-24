using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _24_05
{
    internal class Program

    {  
        static void IntArray(int[] arr)
        {
            //Random r = new Random();
            //for (int i = 0; i < arr.Length; i++)
            //{
                  
            //    arr[i] = r.Next(10);
            //}
        }
        static void Main(string[] args)
        {
            // bool flag = true;

            // int []arr1 = new int[10];
            // int []arr2 = new int[6];
            // IntArray(arr1);
            // IntArray(arr2);
            // int j=0;
            //int []arr3 = new int[10];
            // foreach(int i in (arr1.Length > arr2.Length) ? arr1 : arr2)
            // {
            //     arr3[j++] = i;
            // }
            //int [,] arr = new int[2, 2] { {9,3 },{6,8 } };
            //int max=0;
            //int max1=0;
            //int max2=0;
            //foreach(int i in arr)
            //{
            //    Console.WriteLine(i);
            //}
            //for(int i = 0; i < arr.Length; i++)
            // {   if(arr[i,0] > max1)
            //     {
            //         max1 = arr[i,0];

            //     }
            //     for (int j = 0; j < arr[0, j]; j++)
            //     { if (arr[0, j] > max2)
            //         {
            //             max2 = arr[0, j];

            //             if (max1 > max2)
            //             {
            //                 max = max1;
            //             }
            //             else (max2 > max1) max = max2;

            //         }
            //         Console.WriteLine(max);

            //    }

            //}

            // определение количества слов в строке введеной пользвотелем 
            //Console.WriteLine(Console.ReadLine().Split(' ').Length);


            string str1 = " jrehgehrg jehgdf rer";
            char[] charArr = str1.ToCharArray();
            string str2 = new string(charArr);
            string str3 = new string(charArr, 1, 3);// индекс символа и количество символов после него которые нужно вывеси на экран
            string str4 = new string('w', 8);
            WriteLine(str1);
            WriteLine(str2);
            WriteLine(str3);
            WriteLine(str4);
            WriteLine(charArr);
            string str = @"c:\\Temp\\ Files-\fil\";// для того что бы не экранировать элементв @
            //str.CopyTo(0, str,6)// копировать одну строку в другую 0 дополнительный параметр с ккакой позиции нужно начать копировать,куда нужно копировать и количество символов которые нужно скопировать
            //Equals - сравненеи двух строк привязан к обьекту//
            //Compare()- произвоидит сравнение переданных строк в качестве параметров возвращаетинт значение 
            //StartsWith() проверяет начинается с этого или нет, то что передается в качестве параметра 
            string s = "Простая строка";
            string s2 = "Строка ";
            string s3 = "строка ";

            WriteLine(s.Equals(s2));
            WriteLine(s2.CompareTo(s3));
            WriteLine(s2.CompareTo(s3));
            //IndexOf i LastIndex Of- возвращаяют индекс перевое  или последнее вхождение символа в строку 
            //Substring  возвращает строку из текущей подстроки 
            string t = "Инкапсюляция Наследование Полимарфизм ";
            string r = "абвгдеё ";
            WriteLine(t.IndexOf('Н'));
            WriteLine(t.LastIndexOf('и'));
            WriteLine(t.LastIndexOfAny(r.ToCharArray()));
            WriteLine(t.Substring(12,12));
            WriteLine();
            WriteLine();
            WriteLine();




        }
    }
}
