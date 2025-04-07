using System;
using System.Text;

namespace pr_18
{
class Program
{
static void Main(string[] args)
{


int count = 0;
int Ob = 0;
string s = "";
char ss;
for(; ; )
{
do
{
Console.Write($"Программа имеет пользовательское меню, которое позволяет пользователю ввести строку.\n Заменяет в строке символы, имеющие нечетный код, на символ, введенный пользователем.\n Определяет количество замен.\n\n 1 - Вывод строки. \n 2 - Заменить символы, имеющие нечетный код, на символ, введенный пользователем и определить количество замен. \n 0 - Чтобы выйти. \n Введите номер пункта меню = ");
int men = (int)Convert.ToDouble(Console.ReadLine());
switch (men)
{
case 0:
Console.Clear();
Console.Write($"\n 0 - Чтобы выйти.\n\n Выход\n");
return;
case 1:
{
Console.Clear();
Console.WriteLine("\nВведите фразу: ");
s = Console.ReadLine();
StringBuilder str = new StringBuilder(s);

Console.Write($"\n\n Нажмите Enter для выхода в меню");
Console.ReadLine();
}
break;
case 2:
{
Console.Clear();
Console.Write($"\n 2 - Заменить символы, имеющие нечетный код, на символ, введенный пользователем и определить количество замен.\n");
Console.WriteLine("\nВведите символ: ");
ss = Convert.ToChar(Console.ReadLine());
Console.WriteLine("\nВы ввели фразу: ");
char[] a = s.ToCharArray();
foreach (object x in a) Console.Write(x);
Console.WriteLine("\n");
for (int i = 0; i < a.Length; i++)
{
Console.WriteLine("Код каждого символа: " + (int)(a[i]) + "\t| символ: " + s[i]);
}
for (int i = 0; i < s.Length; i++)
{
if ((int)a[i] % 2 == 1)
{
a[i] = ss;
count++;
}
Console.Write(a[i]);
}
Console.WriteLine($"\nКоличество замен = {count}");
Console.Write($"\n Нажмите Enter для выхода в меню");
Console.ReadLine();

}
break;

default:
Console.Clear();
Console.Write($"\n Нет этого варианта\n");
Thread.Sleep(2000);
break;
}
}
while (Ob != 0);
}
}
}
}