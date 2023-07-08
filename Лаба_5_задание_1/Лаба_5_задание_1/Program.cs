using System;
using System.IO;
namespace Лаба_5_задание_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"E:\текст3.txt";

            //a-количество символов в тексте
            int a = 0;
            try
            {
                //Считает количество символов в тексте.
                Console.WriteLine("******Считываем построчно********");
                using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        a = a + line.Length;
                    }
                }
                Console.WriteLine(a);
                Console.WriteLine("******Считываем посимвольно********");
                using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
                {
                    char[] array = new char[a];

                    sr.Read(array, 0, a);
                    Console.WriteLine(array); //Вывод начального текста
                    int count = 0;
                    int povtor = -1;
                    int l = 0;

                    Console.WriteLine();
                    Console.WriteLine("******Цитаты********"); //Определение цитаты в тексте и её вывод
                    for (int i = 0 + count; i < a; i++)
                    {
                        if (array[i] == '(' && i != povtor)
                        {
                            //for (int j = i+1; j < a; j++)
                            //{
                            //    if (array[j] == ')')
                            //    {
                            //        povtor = j;
                            //        //for (int k = i; k <= j; k++)
                            //        //{ Console.Write(array[k]); }
                            //        //Console.WriteLine();
                            //        //break;
                            //        l++;
                            //        Console.WriteLine(l);
                            //    }
                            //}
                            count = count + i;
                            l++;
                            Console.WriteLine(l);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message); //В случае возникновения ошибок, вывод их в консоль
            }
            Console.ReadKey();
        }
    }
}
