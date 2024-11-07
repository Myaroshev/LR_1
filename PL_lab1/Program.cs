using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL_lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Задание №1");
                Console.WriteLine("2. Задание №2");
                Console.WriteLine("3. Задание №3");
                Console.WriteLine("4. Задание №4");
                Console.WriteLine("5. Задание №1(2)");
                Console.WriteLine("6. Задание №1(4)");
                Console.WriteLine("7. Задание №1(8)");
                Console.WriteLine("8. Задание №1(10)");
                Console.WriteLine("9. Задание №2(2)");
                Console.WriteLine("10. Задание №2(4)");
                Console.WriteLine("11. Задание №2(8)");
                Console.WriteLine("12. Задание №2(10)");
                Console.WriteLine("13. Задание №3(2)");
                Console.WriteLine("14. Задание №3(4)");
                Console.WriteLine("15. Задание №3(8)");
                Console.WriteLine("16. Задание №3(10)");
                Console.WriteLine("17. Задание №4(2)");
                Console.WriteLine("18. Задание №4(4)");
                Console.WriteLine("19. Задание №4(8)");
                Console.WriteLine("20. Задание №4(10)");
                Console.Write("\nВыберите действие: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    //1.1
                    case 1:
                        Console.Clear();

                        while (true)
                        {
                            Console.WriteLine("Введите '0' для выхода в меню\n\tили");
                            Console.Write("Введите букву (английский алфавит): ");
                            string input = Console.ReadLine();

                            if (input == "0")
                            {
                                Console.Clear();
                                break;
                            }

                            if (input.Length != 1 || !char.IsLetter(input[0]))
                            {
                                Console.WriteLine("Введите только 1 букву! Или, введите букву, а не число\n");
                                continue;
                            }

                            try
                            {
                                char letter = char.Parse(input);
                                Class1 charClass = new Class1(letter);

                                Console.WriteLine($"{charClass.isUpperCase()}");
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }

                            Console.WriteLine();
                        }
                        break;



                    //1.2
                    case 2:
                        Console.Clear();

                        while (true)
                        {
                            Console.WriteLine("Введите '0' для выхода в меню(x)\n\tили");
                            Console.WriteLine("Введите 3 числа: ");

                            Console.Write("x: ");
                            string input_x = Console.ReadLine();


                            if (input_x == "0")
                            {
                                Console.Clear();
                                break;
                            }


                            int x;
                            if (!int.TryParse(input_x, out x))
                            {
                                Console.WriteLine("Введите число!\n");
                                continue;
                            }

 
                            Console.Write("y: ");
                            string input_y = Console.ReadLine();
                            int y;
                            if (!int.TryParse(input_y, out y))
                            {
                                Console.WriteLine("Введите число!\n");
                                continue;
                            }


                            Console.Write("z: ");
                            string inputZ = Console.ReadLine();
                            int z;
                            if (!int.TryParse(inputZ, out z))
                            {
                                Console.WriteLine("Введите число!\n");
                                continue;
                            }


                            try
                            {
                                Class1 summclass = new Class1(x, y, z);
                                Console.WriteLine($"{summclass.sum3(x,y,z)}");
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }

                            Console.WriteLine();
                        }
                        break;



                    //1.3
                    case 3:
                        Console.Clear();

                        while (true)
                        {
                            Console.WriteLine("Введите '0' для выхода в меню(x)\n\tили");
                            Console.WriteLine("Введите число: ");

                            Console.Write("x: ");
                            string input = Console.ReadLine();

                            if (input == "0")
                            {
                                Console.Clear();
                                break;
                            }

                            int x;
                            if (!int.TryParse(input, out x))
                            {
                                Console.WriteLine("Введите число!\n");
                                continue;
                            }

                            try
                            {
                                Class1 summclass = new Class1(x);

                                Console.WriteLine($"{summclass.equalNum(x)}");
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }

                            Console.WriteLine();
                        }
                        break;



                    //1.4
                    case 4:
                        Console.Clear();

                        while (true)
                        {
                            Console.WriteLine("Введите '0' для выхода в меню(x)\n\tили");
                            Console.WriteLine("Введите число: ");
                            string input = Console.ReadLine();

                            if (input == "0")
                            {
                                Console.Clear();
                                break;
                            }

                            int[] arrayy = { 1, 2, 3, 4, 5 };

                            try
                            {
                                Class1 summclass = new Class1(arrayy);

                                summclass.reverse(arrayy, arrayy.Length);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }

                            Console.WriteLine();
                        }
                        break;


                    //1.1(2)
                    case 5:
                        Console.Clear();

                        while (true)
                        {
                            Console.WriteLine("Введите '0' для выхода в меню(x)\n\tили");
                            Console.WriteLine("Введите число: ");

                            Console.Write("x: ");
                            string input = Console.ReadLine();

                            if (input == "0")
                            {
                                Console.Clear();
                                break;
                            }

                            int x;
                            if (!int.TryParse(input, out x))
                            {
                                Console.WriteLine("Введите число!\n");
                                continue;
                            }

                            try
                            {
                                Class1 summclass = new Class1(x);

                                Console.WriteLine($"{summclass.sumLastNums(x)}");
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }

                            Console.WriteLine();
                        }
                        break;
                    //1.1(4)
                    case 6:
                        Console.Clear();

                        while (true)
                        {
                            Console.WriteLine("Введите '0' для выхода в меню(x)\n\tили");
                            Console.WriteLine("Введите число: ");

                            Console.Write("x: ");
                            string input = Console.ReadLine();

                            if (input == "0")
                            {
                                Console.Clear();
                                break;
                            }

                            int x;
                            if (!int.TryParse(input, out x))
                            {
                                Console.WriteLine("Введите число!\n");
                                continue;
                            }

                            try
                            {
                                Class1 summclass = new Class1(x);

                                Console.WriteLine($"{summclass.isPositive(x)}");
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }

                            Console.WriteLine();
                        }
                        break;
                    //1.1(8)
                    case 7:
                        Console.Clear();

                        while (true)
                        {
                            Console.WriteLine("Введите '0' для выхода в меню(x)\n\tили");
                            Console.WriteLine("Введите число: ");

                            Console.Write("a: ");
                            string input = Console.ReadLine();

                            if (input == "0")
                            {
                                Console.Clear();
                                break;
                            }

                            Console.Write("b: ");
                            string input2 = Console.ReadLine();


                            int a;
                            if (!int.TryParse(input, out a))
                            {
                                Console.WriteLine("Введите число!\n");
                                continue;
                            }
                            int b;
                            if (!int.TryParse(input2, out b))
                            {
                                Console.WriteLine("Введите число!\n");
                                continue;
                            }

                            try
                            {
                                Class1 summclass = new Class1(a, b);

                                Console.WriteLine($"{summclass.isDivisor(a, b)}");
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }

                            Console.WriteLine();
                        }
                        break;
                    //1.1(10)
                    case 8:
                        Console.Clear();

                        while (true)
                        {
                            Console.WriteLine("Введите '0' для выхода в меню(x)\n\tили");
                            Console.WriteLine("Введите любое число: ");

                            Console.Write("a: ");
                            string input = Console.ReadLine();

                            if (input == "0")
                            {
                                Console.Clear();
                                break;
                            }
                            int a;
                            if (!int.TryParse(input, out a))
                            {
                                Console.WriteLine("Введите число!\n");
                                continue;
                            }


                            try
                            {
                                Class1 summclass = new Class1(a);

                                //int sum = 5;
                                //sum = summclass.lastNumSum(sum, 11);
                                //sum = summclass.lastNumSum(sum, 123);
                                //sum = summclass.lastNumSum(sum, 14);
                                //sum = summclass.lastNumSum(sum, 1);

                                int sum = 10;
                                sum = summclass.lastNumSum(sum, 12);
                                sum = summclass.lastNumSum(sum, 111);
                                sum = summclass.lastNumSum(sum, 182);
                                sum = summclass.lastNumSum(sum, 292);

                                Console.WriteLine($"Итого: {sum % 10}");
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }

                            Console.WriteLine();
                        }
                        break;


                    //1.2(2)
                    case 9:
                        Console.Clear();

                        while (true)
                        {
                            Console.WriteLine("Введите '0' для выхода в меню(x)\n\tили");
                            Console.WriteLine("Введите число: ");

                            Console.Write("x: ");
                            string input = Console.ReadLine();

                            if (input == "0")
                            {
                                Console.Clear();
                                break;
                            }

                            Console.Write("y: ");
                            string input2 = Console.ReadLine();


                            int a;
                            if (!int.TryParse(input, out a))
                            {
                                Console.WriteLine("Введите число!\n");
                                continue;
                            }
                            int b;
                            if (!int.TryParse(input2, out b))
                            {
                                Console.WriteLine("Введите число!\n");
                                continue;
                            }

                            try
                            {
                                Class1 summclass = new Class1(a, b);

                                Console.WriteLine($"{summclass.safeDiv(a, b)}");
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }

                            Console.WriteLine();
                        }
                        break;


                    //1.2(4)
                    case 10:
                        Console.Clear();

                        while (true)
                        {
                            Console.WriteLine("Введите '0' для выхода в меню(x)\n\tили");
                            Console.WriteLine("Введите число: ");

                            Console.Write("x: ");
                            string input = Console.ReadLine();

                            if (input == "0")
                            {
                                Console.Clear();
                                break;
                            }

                            Console.Write("y: ");
                            string input2 = Console.ReadLine();


                            int a;
                            if (!int.TryParse(input, out a))
                            {
                                Console.WriteLine("Введите число!\n");
                                continue;
                            }
                            int b;
                            if (!int.TryParse(input2, out b))
                            {
                                Console.WriteLine("Введите число!\n");
                                continue;
                            }

                            try
                            {
                                Class1 summclass = new Class1(a, b);

                                Console.WriteLine($"{summclass.makeDecision(a, b)}");
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }

                            Console.WriteLine();
                        }
                        break;

                    //1.2(8)
                    case 11:
                        Console.Clear();

                        while (true)
                        {
                            Console.WriteLine("Введите '0' для выхода в меню(x)\n\tили");
                            Console.WriteLine("Введите число: ");

                            Console.Write("x: ");
                            string input = Console.ReadLine();

                            if (input == "0")
                            {
                                Console.Clear();
                                break;
                            }

                            int x;
                            if (!int.TryParse(input, out x))
                            {
                                Console.WriteLine("Введите число!\n");
                                continue;
                            }

                            try
                            {
                                Class1 summclass = new Class1(x);

                                Console.WriteLine($"{summclass.age(x)}");
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }

                            Console.WriteLine();
                        }
                        break;

                    //1.2(10)
                    case 12:
                        Console.Clear();

                        while (true)
                        {
                            Console.WriteLine("Введите '0' для выхода в меню\n\tили");
                            Console.WriteLine("Введите день недели: ");
                            string input = Console.ReadLine();

                            if (input == "0")
                            {
                                Console.Clear();
                                break;
                            }


                            try
                            {
                                Class1 charClass = new Class1(input);

                                charClass.printDays(input);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }

                            Console.WriteLine();
                        }
                        break;

                    //1.3(2)
                    case 13:
                        Console.Clear();

                        while (true)
                        {
                            Console.WriteLine("Введите '0' для выхода в меню(x)\n\tили");
                            Console.WriteLine("Введите число: ");

                            Console.Write("x: ");
                            string input = Console.ReadLine();

                            if (input == "0")
                            {
                                Console.Clear();
                                break;
                            }


                            int a;
                            if (!int.TryParse(input, out a))
                            {
                                Console.WriteLine("Введите число!\n");
                                continue;
                            }


                            try
                            {
                                Class1 summclass = new Class1(a);

                                Console.WriteLine($"{summclass.reverseListNums(a)}");
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }

                            Console.WriteLine();
                        }
                        break;

                    //1.3(4)
                    case 14:
                        Console.Clear();

                        while (true)
                        {
                            Console.WriteLine("Введите '0' для выхода в меню(x)\n\tили");
                            Console.WriteLine("Введите число: ");

                            Console.Write("x(число): ");
                            string input = Console.ReadLine();

                            if (input == "0")
                            {
                                Console.Clear();
                                break;
                            }

                            Console.Write("y(степень): ");
                            string input2 = Console.ReadLine();


                            int a;
                            if (!int.TryParse(input, out a))
                            {
                                Console.WriteLine("Введите число!\n");
                                continue;
                            }
                            int b;
                            if (!int.TryParse(input2, out b))
                            {
                                Console.WriteLine("Введите число!\n");
                                continue;
                            }

                            try
                            {
                                Class1 summclass = new Class1(a, b);

                                Console.WriteLine($"{summclass.pow(a, b)}");
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }

                            Console.WriteLine();
                        }
                        break;

                    //1.3(8)
                    case 15:
                        Console.Clear();

                        while (true)
                        {
                            Console.WriteLine("Введите '0' для выхода в меню(x)\n\tили");
                            Console.WriteLine("Введите число: ");

                            Console.Write("x(число): ");
                            string input = Console.ReadLine();

                            if (input == "0")
                            {
                                Console.Clear();
                                break;
                            }



                            int a;
                            if (!int.TryParse(input, out a))
                            {
                                Console.WriteLine("Введите число!\n");
                                continue;
                            }

                            try
                            {
                                Class1 summclass = new Class1(a);

                                summclass.leftTriangle(a);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }

                            Console.WriteLine();
                        }
                        break;

                    //1.3(10)
                    case 16:
                        Console.Clear();

                        while (true)
                        {
                            try
                            {
                                Class1 summclass = new Class1();
                                summclass.guessGame();

                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }

                            Console.WriteLine();
                        }
                        break;

                    //1.4(2)
                    case 17:
                        Console.Clear();

                        while (true)
                        {
                            Console.WriteLine("Введите '0' для выхода в меню(x)\n\tили");
                            int[] arrayy = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 12, 19 };

                            for (int i = 0; i < 12; i++)
                            {
                                Console.Write($"{arrayy[i]} ");
                            }

                            Console.Write("\nВведите число: ");
                            string input = Console.ReadLine();

                            if (input == "0")
                            {
                                Console.Clear();
                                break;
                            }

                            int a;
                            if (!int.TryParse(input, out a))
                            {
                                Console.WriteLine("Введите число!\n");
                                continue;
                            }

                            try
                            {
                                Class1 summclass = new Class1(arrayy);

                                Console.WriteLine($"индекс = {summclass.findLast(arrayy, a)}");
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }

                            Console.WriteLine();
                        }
                        break;

                    //1.4(4)
                    case 18:
                        Console.Clear();

                        while (true)
                        {
                            int[] array = { 1, 2, 3, 4, 5, 6, 7 };
                            Class1 massiv = new Class1();

                            Console.WriteLine("Введите '0' для выхода в меню\n\tили");
                            Console.WriteLine("Введите число и позицию для вставки:");
                            Console.WriteLine($"{string.Join(", ", array)}");

                            Console.Write("\nx(число): ");
                            string input = Console.ReadLine();

                            if (input == "0")
                            {
                                Console.Clear();
                                break;
                            }

                            Console.Write("y(позиция в массиве): ");
                            string input2 = Console.ReadLine();

                            int a;
                            if (!int.TryParse(input, out a))
                            {
                                Console.WriteLine("Некорректный ввод числа!\n");
                                continue;
                            }

                            int b;
                            if (!int.TryParse(input2, out b))
                            {
                                Console.WriteLine("Некорректный ввод позиции!\n");
                                continue;
                            }

                            try
                            {
                                int[] result = massiv.add(array, a, b);
                                Console.WriteLine($"Результат: [{string.Join(", ", result)}]");
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"Ошибка: {ex.Message}");
                            }

                            Console.WriteLine();
                        }
                        break;

                    //1.4(8)
                    case 19:
                        Console.Clear();

                        while (true)
                        {
                            Class1 concat = new Class1();
                            int[] arr1 = { 1 };
                            int[] arr2 = { 2, 3 };

                            Console.WriteLine($"Первый массив: [{string.Join(", ", arr1)}]");
                            Console.WriteLine($"Второй массив: [{string.Join(", ", arr2)}]");

                            try
                            {
                                int[] result = concat.concat(arr1, arr2);
                                Console.WriteLine($"Результат: [{string.Join(", ", result)}]");



                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"Ошибка: {ex.Message}");
                            }

                            Console.WriteLine();
                            break;
                        }

                        break;

                    //1.4(10)
                    case 20:
                        Console.Clear();

                        while (true)
                        {
                            Class1 concat = new Class1();
                            int[] arr1 = { 1,2,3,-4,-5,6,-9 };

                            Console.WriteLine($"Исходный массив: [{string.Join(", ", arr1)}]");

                            try
                            {
                                int[] result = concat.deleteNegative(arr1);
                                Console.WriteLine($"Результат: [{string.Join(", ", result)}]");



                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"Ошибка: {ex.Message}");
                            }

                            Console.WriteLine();
                            break;
                        }

                        break;

                    default:
                        Console.WriteLine("err");
                        break;
                }
            }
        }
    }
}
