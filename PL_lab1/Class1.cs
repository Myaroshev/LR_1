using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL_lab1
{
    public class Class1
    {
        public char letter;
        public int x;
        public int y;
        public int z;
        public int[] arr;
        string input;

        public Class1()
        {
        }
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
        public Class1(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public Class1(string input)
        {
            this.input = input;
        }

        //1.1
        public bool isUpperCase()
        {
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            return alphabet.Contains(letter);
        }
        public int sumLastNums(int x)
        {
            if (x < 10)
            {
                throw new ArgumentException("Число должно содержать не менее двух цифр");
            }

            int digit_last = x % 10;
            int sec_digit = (x / 10) % 10;

            return digit_last + sec_digit;
        }
        public bool isPositive(int x)
        {
            if (x > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool isDivisor(int a, int b)
        {
            if (a % b == 0)
            {
                return true;
            }
            else if (b % a == 0) { return true; }
            else { return false; }
        }
        public int lastNumSum(int a, int b)
        {
            return ((a+b)%10);
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
        public double safeDiv(int x, int y)
        {
            if (y == 0)
            {
                return 0; 
            }
            else
            {
                return x / y;
            }
        }
        public String makeDecision(int x, int y)
        {
            if (x > y)
            {
                return $"{x}>{y}".ToString();
            }
            else if (x < y)
            {
                return $"{y}>{x}".ToString();
            }
            else
            {
                return $"{x}=={y}".ToString();
            }
        }
        public String age(int x)
        {
            if (x % 10 == 1 && x != 11)
            {
                return $"{x} год";
            }
            else if ((x % 10 == 2 || x % 10 == 3 || x % 10 == 4) && (x != 12) && (x != 13) && (x != 14))
            {
                return $"{x} года";
            }
            else
            {
                return $"{x} лет";
            }
        }
        public void printDays(String x)
        {
            switch (x)
            {
                case "понедельник":
                    Console.WriteLine("вторник\nсреда\nчетверг\nпятница\nсуббота\nвоскресенье");
                    break;
                case "вторник":
                    Console.WriteLine("среда\nчетверг\nпятница\nсуббота\nвоскресенье");
                    break;
                case "среда":
                    Console.WriteLine("четверг\nпятница\nсуббота\nвоскресенье");
                    break;
                case "четверг":
                    Console.WriteLine("пятница\nсуббота\nвоскресенье");
                    break;
                case "пятница":
                    Console.WriteLine("суббота\nвоскресенье");
                    break;
                case "суббота":
                    Console.WriteLine("воскресенье");
                    break;
                case "воскресенье":
                    Console.WriteLine("");
                    break;
                default:
                    Console.WriteLine("Это не день недели");
                    break;
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
        public String reverseListNums(int x)
        {
            string str = "";
            while (x >= 0)
            {
                str += x.ToString() + " ";
                x--;
            }
            return str;
        }
        public int pow(int x, int y)
        {
            if (y < 0)
            {
                throw new ArgumentException("Степень должна быть >=0");
            }

            int result = 1;
            for (int i = 0; i < y; i++)
            {
                result *= x;
            }
            return result;
        }
        public void leftTriangle(int x)
        {
            for (int i = 1; i <= x; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public void guessGame()
        {
            int att = 0;
            int guess;
            Random random = new Random();
            int answer = random.Next(10);
            //Console.WriteLine(answer);

            do
            {
                Console.Write("Введите число от 0 до 9: ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out guess) || guess < 0 || guess > 9)
                {
                    Console.WriteLine("Введите число от 0 до 9");
                    continue;
                }

                att++;

                if (guess == answer)
                {
                    Console.WriteLine("Вы угадали!");
                    Console.WriteLine($"Вы отгадали число за {guess} попыток.");
                    break;
                }
                else
                {
                    Console.WriteLine("Вы не угадали. Введите число от 0 до 9");
                }
            }
            while (true);
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
        public int findLast(int[] arr, int x)
        {
            int index = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                {
                    index = i;
                }
            }

            return index;
        }
        public int[] add(int[] arr, int x, int pos)
        {
            int[] arr_2 = new int[arr.Length + 1];

            for (int i = 0; i < pos; i++)
            {
                arr_2[i] = arr[i];
            }

            arr_2[pos] = x;

            for (int i = pos; i < arr.Length; i++)
            {
                arr_2[i + 1] = arr[i];
            }

            return arr_2;
        }
        public int[] concat(int[] arr1, int[] arr2)
        {
            int[] result = new int[arr1.Length + arr2.Length];

            for (int i = 0; i < arr1.Length; i++)
            {
                result[i] = arr1[i];
            }

            for (int i = 0; i < arr2.Length; i++)
            {
                result[arr1.Length + i] = arr2[i];
            }

            return result;
        }
        public int[] deleteNegative(int[] arr) 
        {
            int n = arr.Length;

            for(int i  = 0; i < arr.Length; i++) 
            {
                if (arr[i] < 0)
                {
                    n--;
                }
            }

            int[] arr2 = new int[n];
            int j = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 0)
                {
                    arr2[j++] = arr[i];
                }
            }

            return arr2;
        }




    }
}
