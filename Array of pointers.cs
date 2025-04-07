using System;
namespace p17
{
    class Program
    {
        static void Main(string[] args)
        {
            unsafe
            {                
                double[] a = new double[8];
                double*[] pa = new double*[8];
                for (int i = 0; i < 8; i++)
                    fixed (double* p = a) pa[i] = p + i;
                int index = 0;
                ulong addr;
                int Ob = 1;
                do
                {
                    
                    Console.Clear();
                    Console.Write($" Программа имеет пользовательское меню, в которой пользователь с помощью меню можно:" +
                        "\n заполнить массив указателей на одномерный массив, содержащий 8 элементов вещественноготипа,  " +
                        "\n выводит на экран адрес элемента, индекс которого меньше на 2, чем значение индекса, введенное пользователем," +
                        "\n выводит на экран значение элемента, индекс которого больше индекса, введенного пользователем, на 5." +
                        "\n\n\n 1 - Заполнить массив." +
                        "\n\n 2 - Ввести индекс и вывести на экран адрес элемента, индекс которого меньше на 2,\n     чем значение индекса, введенное пользователем." +
                        "\n\n 3 - Ввести индекс и вывести на экран значение элемента, индекс которого больше индекса,\n     введенного пользователем, на 5." +
                        "\n\n 0 - Чтобы выйти." +
                        "\n\n Введите номер пункта меню = ");
                    int menu = Convert.ToInt32(Console.ReadLine());

                    switch (menu)
                    {
                        default:
                            Console.Clear();
                            Console.Write($"\n\n Нет этого варианта");
                            Thread.Sleep(2000);
                            break;

                        case 0:
                            Console.Clear();
                            Console.Write($"\n Выход\n");
                            return;

                        case 1:
                            Console.Clear();
                            Console.Write($"\n 1 - Заполнить массив.\n\n");
                            for (int i = 0; i < 8; i++)
                            {
                                Console.Write($" Введите {i + 1} элемент: ");
                                *pa[i] = Convert.ToDouble(Console.ReadLine());
                            }
                            Console.Write("\n Массив:");
                            for (int i = 0; i < 8; i++)
                            {
                                Console.Write($" {*pa[i]:###.00}");
                            }


                            Console.Write($"\n\n Нажмите Enter для выхода в меню");
                            Console.ReadLine();
                            break;

                        case 2:
                            {
                                Console.Clear();
                                Console.Write($"\n 2 - Ввести индекс и вывести на экран адрес элемента, индекс которого меньше на 2,\n чем значение индекса, введенное пользователем.\n\n"); 

                                for (int i = 0; i < 8; i++)
                                {
                                    addr = (ulong)pa[i];
                                    Console.Write($" Индекс: {i}   Значение: {*pa[i]:###.00}   Адрес: {addr}\n");
                                }
                                Console.Write("\n Введите индекс элемента: ");
                                index = Convert.ToInt32(Console.ReadLine());
                                Console.Write($"\n Индекс: {index} - 2 = {index - 2}\n Адрес: {(ulong)pa[index-2]}\n\n Нажмите Enter для выхода в меню");
                                Console.ReadLine();
                            }
                            break;

                        case 3:
                            {
                                Console.Clear();
                                Console.Write($"\n 3 - Ввести индекс и вывести на экран значение элемента,\n индекс которого больше индекса, введенного пользователем, на 5.\n\n");
                                for (int i = 0; i < 8; i++)
                                {
                                    addr = (ulong)pa[i];
                                    Console.Write($" Индекс: {i}   Значение: {*pa[i]:###.00}   Адрес: {addr}\n");
                                }
                                Console.Write("\n Введите индекс элемента: ");
                                index = Convert.ToInt32(Console.ReadLine());
                                Console.Write($"\n Индекс: {index} + 5 = {index + 5}\n Значение элемента: {*pa[index + 5]:###.00}\n\n Нажмите Enter для выхода в меню");
                                Console.ReadLine();
                            }
                            break;
                    }
                } while (Ob != 0);
            }
        }
    }
}
