using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1_PL
{
    internal class Class1
    {
        private char letter;
        private int x;
        private int y;
        private int z;
        private int[] arr;

        public Class1(char letter)
        {
            this.letter = letter;
        }
        public Class1(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public Class1(int x)
        {
            this.x = x;
        }
        public Class1(int[] arr)
        {
            this.arr = arr;
        }

        //1.1
        public bool isUpperCase()
        {
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            return alphabet.Contains(letter);
        }


        //1.2
        public bool sum3(int x, int y, int z)
        {
            int sum_xy = x + y;
            int sum_xz = x + z;
            int sum_yz = y + z;

            if (sum_xy == z)
            {
                return true;
            }
            else if (sum_xz == y)
            {
                return true;
            }
            else if (sum_yz == x)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        //1.3
        public bool equalNum(int x)
        {
            x = Math.Abs(x);

            int digit = x % 10;

            while (x > 0)
            {
                if (x % 10 != digit)
                {
                    return false;
                }

                x /= 10;
            }

            return true;
        }


        //1.4
        public void reverse(int[] arr, int n)
        {
            for (int i = 0; i < n / 2; i++)
            {
                int temp = arr[i];
                arr[i] = arr[n - 1 - i];
                arr[n - 1 - i] = temp;

            }

            Console.WriteLine();
            Console.Write($"Перевернутый массив: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{arr[i]}");
            }
            Console.WriteLine();
        }
    }
}
