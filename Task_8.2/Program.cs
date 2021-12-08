using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_8._2
{
    class Program   /* Программно создайте текстовый файл и запишите в него 10 случайных чисел. 
                      Затем программно откройте созданный файл, рассчитайте сумму чисел в нем, 
                           ответ выведите на консоль.*/
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\ander\Desktop\ИТМО\1.Module\Task_8\Task_8\Task_8.2\bin\result.txt";
                        
            int Sum = 0;
            using (StreamWriter sw = new StreamWriter(path, false))  //запись в файл
            {
                int[] array = new int[10];
                Random random = new Random();
                for (int i = 0; i < 10; i++)
                {
                    array[i] = random.Next(0, 10);
                    sw.Write("{0} ", array[i]);

                    
                }
            }

            using (StreamReader sr = new StreamReader(path))   //чтение
            {
                string[] string_array = sr.ReadToEnd().Split(' ');
                foreach (string sa in string_array)
                {
                    string s = sa.Trim();
                    if (s == "")
                    {
                        break;
                    }
                    int n = Convert.ToInt32(s);
                    Sum += n;
                }
                
                Console.WriteLine();
                Console.WriteLine("Сумма чисел в текстовом документе равна {0}", Sum);
            }
            Console.ReadKey();



        }
    }
}
