## Консольные программки на C#

### Array of pointers.cs 
Программа реализует пользовательское меню для работы с массивом указателей на элементы вещественного типа.

Инициализация: Программа создает массив из 8 элементов типа double и массив указателей на эти элементы.

Меню: Пользователь может выбрать один из нескольких пунктов меню:
- Заполнить массив: Пользователь вводит значения для каждого элемента массива.
- Вывести адрес элемента: Пользователь вводит индекс, и программа выводит адрес элемента, индекс которого меньше на 2, чем введенный.
- Вывести значение элемента: Пользователь вводит индекс, и программа выводит значение элемента, индекс которого больше на 5, чем введенный.

Цикл: Программа работает в цикле, позволяя пользователю выполнять действия до тех пор, пока он не решит выйти, выбрав соответствующий пункт меню.

Безопасность: Используется небезопасный код (unsafe), что позволяет работать с указателями, но требует осторожности при управлении памятью.

### Stepwise multidimensional arrays.cs
Программа реализует пользовательское меню для работы с тремя одномерными массивами.

Инициализация массивов: Программа создает три массива:
- Первый массив содержит 8 вещественных чисел.
- Второй массив содержит 6 вещественных чисел.
- Третий массив будет использоваться для хранения результатов вычислений.

Меню: Пользователь может выбрать один из следующих пунктов меню:
- Заполнить 1 массив: Пользователь вводит значения для первого массива.
- Заполнить 2 массив: Пользователь вводит значения для второго массива.
- Вывести 3 массив: Программа вычисляет и выводит:
- Среднее арифметическое элементов первого массива.
- Среднее арифметическое элементов второго массива.
- Разность между максимальным и минимальным элементами первого массива.
- Разность между максимальным и минимальным элементами второго массива.

Цикл: Программа работает в цикле, позволяя пользователю выполнять действия до тех пор, пока он не решит выйти, выбрав соответствующий пункт меню.

Вывод результатов: При выводе результатов программа форматирует числа с двумя знаками после запятой и предоставляет пользователю возможность увидеть все массивы и результаты вычислений.

### Strings and byte files.cs
Программа предоставляет пользователю меню для работы с текстовыми файлами. 

Инициализация: Программа создает пользовательское меню с несколькими опциями для работы с текстом и файлами.

Меню: Пользователь может выбрать один из следующих пунктов:
- Преобразовать текст в массив строк и записать в байтовый файл: Пользователь вводит текст, который записывается в файл `c#.txt`. Ввод завершается, когда пользователь вводит символ `!`.
- Считать текст из байтового файла: Программа считывает текст из `c#.txt`, заменяет пробелы на символы подчеркивания, определяет длины строк и записывает результаты в файл `c#1.txt`. Также выводит количество замен пробелов.
- Считать данные из результирующего текстового файла: Программа считывает и выводит содержимое файла `c#.txt` на экран.

Обработка ошибок: Программа использует блоки `try-finally` для безопасного закрытия файловых потоков, что предотвращает утечки ресурсов.

Вывод результатов: Программа выводит длины строк и количество замен пробелов, а также позволяет пользователю видеть содержимое файлов.

### Strings.cs
Программа предоставляет пользователю меню для работы со строками, позволяя заменять символы с нечетным кодом.

Инициализация: Программа создает бесконечный цикл, в котором пользователь может взаимодействовать с меню.

Меню: Пользователь может выбрать один из следующих пунктов:
- Вывод строки: Пользователь вводит строку, которая сохраняется для дальнейшей обработки.
- Замена символов: Программа заменяет все символы в строке, имеющие нечетный код ASCII, на символ, введенный пользователем. Также программа выводит количество произведенных замен.
- Выход: Пользователь может выйти из программы.

Обработка строк:
- При выборе пункта 1 программа запрашивает ввод строки и сохраняет её.
- При выборе пункта 2 программа выводит коды ASCII каждого символа строки, затем заменяет символы с нечетным кодом на указанный символ и подсчитывает количество замен.

Вывод результатов: Программа выводит изменённую строку и количество замен, произведённых в процессе.

Обработка ошибок: Программа обрабатывает ввод пользователя и выводит сообщение, если выбран неверный пункт меню.

