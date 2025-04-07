using System;
using System.IO;
using System.Linq;
using System.Text;
namespace p22
{
    class Program
    {
        static void Main()
        {
              StreamWriter fstr_out1 = null; StreamWriter fstr_out = null;
            string str;
            int Ob = 1;
            do
            {
                Console.Clear();
                Console.Write($" Программа имеет пользовательское меню, в которой которм можно:" +
                    "\n - текст, вводимый пользователем с клавиатуры, преобразовать в массив строк и записать в байтовый файл; " +
                    "\n - считать текст из байтового файла и заменить пробелы в тексте на символ подчеркивания, " +
                    "\n   определить длины строк, и результаты вывести в текстовый файл;" +
                    "\n - считать данные из результирующего текстового файла и вывести их на экран;" +
                    "\n - выйти из программы." +
                    "\n\n\n 1 - Tекст, вводимый пользователем с клавиатуры, преобразовать в массив строк и записать в байтовый файл." +
                    "\n\n 2 - Cчитать текст из байтового файла и заменить пробелы в тексте на символ подчеркивания, \n     определить длины строк, и результаты вывести в текстовый файл." +
                    "\n\n 3 - Cчитать данные из результирующего текстового файла и вывести их на экран." +
                    "\n\n 0 - Bыйти из программы." +
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
                        Console.WriteLine(" 1 - Tекст, вводимый пользователем с клавиатуры, преобразовать в массив строк и записать в байтовый файл.\n\n Введите текст, для окончания введите в последней строке — '!'");
                        try
                        {           
                            fstr_out = new StreamWriter("c#.txt");
                            do
                            {
                                Console.Write(" ");
                                str = Console.ReadLine();
                                if (str != "!")
                                {
                                    str = str + "\r\n"; 
                                    fstr_out.Write(str);
                                }
                            } while (str != "!");
                        }
                        finally
                        {
                            if (fstr_out != null) fstr_out.Close();
                        }
                        Console.Write($"\n Текст записан в файл 'c#.txt'\n\n Нажмите Enter для выхода в меню");
                        Console.ReadLine();
                        break;

                    case 2:
                        Console.Clear();
                        Console.Write("2 - Cчитать текст из байтового файла и заменить пробелы в тексте на символ подчеркивания, \n    определить длины строк, и результаты вывести в текстовый файл.\n\n");
                        StreamReader fstr_n = new StreamReader("c#.txt"); FileStream fin = null; FileStream fout = null; fstr_out = new StreamWriter("c#1.txt");
                        int ii; int nChar; int zm = 0; int strdl = 1; string s;
                        try
                        {
                            nChar = fstr_n.Read();
                            while (nChar != -1)
                            {
                                if (nChar == 32)
                                {
                                    Console.Write("_");
                                    fstr_out.Write("_");
                                    nChar = fstr_n.Read();
                                    zm++;
                                }
                                else
                                {
                                    Console.Write(Convert.ToChar(nChar));
                                    fstr_out.Write(Convert.ToChar(nChar));
                                    nChar = fstr_n.Read();
                                }
                            }
                        }
                        finally { fstr_n.Close(); }
                        try { } finally { fstr_out.Close(); }
                        Console.Write("\n");
                        using (StreamReader fstr_n1 = new StreamReader("c#.txt", System.Text.Encoding.Default))
                        {
                            while ((s = fstr_n1.ReadLine()) != null)
                            {
                                int dl = s.Length;
                                Console.WriteLine($" Длина {strdl} строки = {dl}"); strdl++;
                            }
                        }
                        try
                        {
                            fin = new FileStream("c#1.txt", FileMode.Open);
                            fout = new FileStream("c#.txt", FileMode.Create);
                            do
                            {
                                ii = fin.ReadByte();
                                if (ii != -1) fout.WriteByte((byte)ii);
                            } while (ii != -1);
                        }
                        finally
                        {
                            if (fin != null) fin.Close();
                            if (fout != null) fout.Close();
                        }
                        Console.Write($" Количество замен {zm}\n\n Изиенен файл c#.txt\n\n Нажмите Enter для выхода в меню");
                        Console.ReadLine();
                        break;

                    case 3:
                        Console.Clear();
                        Console.Write(" 3 - Cчитать данные из результирующего текстового файла и вывести их на экран.\n\n");
                        using (StreamReader fstr_in = new StreamReader("c#.txt"))
                        {
                            Console.WriteLine(fstr_in.ReadToEnd());
                        }
                        Console.Write($" Нажмите Enter для выхода в меню");
                        Console.ReadLine();
                        break;
                }
            } while (Ob != 0);
        }
    }
}