using System.Text;
using System.Threading;
namespace p16
{
    class Class
    {
        static void Main()
        {

            double[][] a = new double[3][];
            a[0] = new double[8];
            a[1] = new double[6];
            a[2] = new double[4];

            int q = 1;
            do
            {
                Console.Clear();
                Console.Write($" Программа имеет пользовательское меню, в которой пользователь с помощью" +
                    $"\n меню можно заполнить два одномерных массива значениями, первый массив содержит 8 вещественных чисел," +
                    $"\n второй - 6; в третьем массиве содержится: среднее арифметическое элементов первого массива," +
                    $"\n среднее арифметическое элементов второго массива, разность\n максимального и минимального элементов первого и второго массивов." +
                    $"\n\n 1 - Заполнить 1 массив.\n 2 - Заролнить 2 массив.\n 3 - Вывести 3 массив.\n 0 - Чтобы выйти.\n\n Введите номер пункта меню = ");
                int qqq = (int)Convert.ToDouble(Console.ReadLine());

                switch (qqq)
                {
                    default:
                        Console.Clear();
                        Console.Write($"\n\n Нет этого варианта");
                        Thread.Sleep(2000);
                        break;

                    case 0:
                        Console.Clear();
                        Console.Write($"\n 0 - Чтобы выйти.\n\n 0 пункт меню.\n\n Выход\n");
                        return;

                    case 1:
                        {
                            Console.Clear();
                            Console.Write($"\n\n 1 - Заполнить 1 массив.\n\n");
                            for (int i = 0; i < 8; i++)
                            {
                                Console.Write($" Введите значение {i + 1} элемента 1 массива = ");
                                a[0][i] = Convert.ToDouble(Console.ReadLine());
                            }
                            Console.Write("\n 1 массив: ");
                            for (int i = 0; i < 8; i++)
                            {
                                Console.Write($" {a[0][i]:N2}");
                            }
                            Console.Write($"\n\n Нажмите Enter для выхода в меню");
                            Console.ReadLine();
                        }

                        break;

                    case 2:
                        {
                            Console.Clear();
                            Console.Write($"\n\n 2 - Заполнить 2 массив.\n\n");
                            for (int i = 0; i < 6; i++)
                            {
                                Console.Write($" Введите значение {i + 1} элемента 2 массива = ");
                                a[1][i] = Convert.ToDouble(Console.ReadLine());
                            }
                            Console.Write("\n 2 массив: ");
                            for (int i = 0; i < 6; i++)
                            {
                                Console.Write($" {a[1][i]:N2}");
                            }
                            Console.Write($"\n\n Нажмите Enter для выхода в меню");
                            Console.ReadLine();
                        }
                        break;

                    case 3:
                        {
                            Console.Clear();
                            Console.Write($"\n\n 3 - Вывести 3 массив.\n");
                            double[] a1 = new double[8];                           
                            double sum1 = 0;
                            for (int i = 0; i < 8; i++)
                            {
                                a1[i] = a[0][i];
                                sum1 += a[0][i];
                            }
                            double sum11 = sum1 / 8;
                            a[2][0] = sum11;
                            
                            double[] a2 = new double[6];
                            double sum2 = 0;
                            for (int i = 0; i < 6; i++)
                            {
                                a2[i] = a[1][i];
                                sum2 += a[1][i];
                            } 
                            double sum22 = sum2 / 6;
                            a[2][1] = sum22;

                            Array.Sort(a1);
                            a[2][2] = a1[7] - a1[0];

                            Array.Sort(a2);
                            a[2][3] = a2[5] - a2[0];
                            int sl = 0;

                            for (int i = 0; i < a.Length; i++)
                            {
                                sl++;
                                Console.Write($"\n Массив {sl}: ");
                                for (int j = 0; j < a[i].GetLength(0); j++){Console.Write($" {a[i][j]:N2} ");}
                            }
                            Console.Write($"\n\n Cреднее арифметическое элементов 1 массива = {sum11:N2}\n Cреднее арифметическое элементов 2 массива = {sum22:N2}\n Разность максимального и минимального элементов 1 массива = {a1[7]:N2} - {a1[0]:N2} = {a[2][2]:N2}\n Разность максимального и минимального элементов 2 массива = {a2[5]:N2} - {a2[0]:N2} = {a[2][3]:N2}\n\n Нажмите Enter для выхода в меню");
                            Console.ReadLine();
                        }
                        break;
                }
            } while (q != 0);
        }
    }
}