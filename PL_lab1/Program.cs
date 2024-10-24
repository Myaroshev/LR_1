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
                            Console.WriteLine("Введите '0' для выхода в меню(x)");
                            Console.Write("x(0 для выхода/любое значение для продолжения): ");
                            string input = Console.ReadLine();

                            if (input == "0")
                            {
                                Console.Clear();
                                break;
                            }

                            int[] array = { 1, 2, 3, 4, 5 };

                            try
                            {
                                Class1 summclass = new Class1(array);

                                summclass.reverse(array, array.Length);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }

                            Console.WriteLine();
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
