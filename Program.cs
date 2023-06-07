using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp43
{


    class Program
    {
        static void Main()
        {
            int[] array1 = new int[10];
            int[] array2 = new int[17];

            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                array1[i] = rnd.Next(0, 20);
            }
            for (int i = 0; i < 17; i++)
            {
                array2[i] = rnd.Next(0, 20);
            }
            Array.Sort(array1);
            Array.Sort(array2);
            Array.Reverse(array2);
            Console.WriteLine("первый массив");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(array1[i] + "  ");
            }
            Console.WriteLine();
            Console.WriteLine("второй массив");
            for (int i = 0; i < 17; i++)
            {
                Console.Write(array2[i] + "  ");
            }
            //////////////////////////////////////////
            int k = 0;
            int amount = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i != j && array1[i] == array1[j])
                    {
                        k++;
                    }
                }
                if (k == 0)
                {
                    amount++;

                }
                k = 0;
            }
            k = 0;
            for (int i = 0; i < 17; i++)
            {
                for (int j = 0; j < 17; j++)
                {
                    if (i != j && array2[i] == array2[j])
                    {
                        k++;
                    }
                }
                if (k == 0)
                {
                    amount++;

                }
                k = 0;
            }
            int a = 0;
            int[] array3 = new int[amount];
            if (array1[0] != array1[1])
            {
                array3[a] = array1[0];
                a++;
            }
            if (array2[0] != array2[1])
            {
                array3[a] = array2[0];
                a++;
            }
            if (array1[8] != array1[9])
            {
                array3[a] = array1[9];
                a++;
            }
            if (array2[15] != array2[16])
            {
                array3[a] = array2[16];
                a++;
            }
            for (int i = 1; i < 9; i++)
            {
                if (array1[i] != array1[i - 1] && array1[i] != array1[i + 1])
                {
                    array3[a] = array1[i];
                    a++;
                }
            }
            for (int i = 1; i < 16; i++)
            {
                if (array2[i] != array2[i - 1] && array2[i] != array2[i + 1])
                {
                    array3[a] = array2[i];
                    a++;
                }
            }
            Array.Sort(array3);
            Console.WriteLine();
            Console.WriteLine("новый массив ");
            for (int i = 0; i < amount; i++)
            {
                Console.Write(array3[i] + "   ");
            }
            Console.WriteLine();
            void p()
            {
                Console.WriteLine("повторить ввод если да то 1 нет то 0");
                string y = Convert.ToString(Console.ReadLine());
                if (y == "1")
                    Main();
                else
                    return;
            }
            p();
            return;
        }
    }
}

