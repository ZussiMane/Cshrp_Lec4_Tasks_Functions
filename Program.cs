﻿// Задайте одномерный массив, заполненный случайными
// числами. Определите количество простых чисел в этом
// массиве.
// Примеры
// [1 3 4 19 3] => 2
// [4 3 4 1 9 5 21 13] => 3

// int[] CreateArrayRndInt(int size, int min, int max) // объявление функции заполнения массива случайными числами и возращением значений типа int
// {
//     int[] array = new int[size]; // объявление массива с размером "size"
//     Random rnd = new Random(); // объект для генерации чисел

//     for (int i = 0; i < array.Length; i++) // цикл для заполнения массива
//     {
//         array[i] = rnd.Next(min, max); // вызов метода для генерации случайных чисел с параметрами(отрезок)- от и до(невключительно)
//     }
//     return array;
// }

// void PrintArray(int[] array)  // функция вывода результата в консоль (не возвращающая значения-тип метода "void")
// {
//     Console.Write("["); // команда для вывода массива в квадратных скобках (открывающая скобка)
//     for (int i = 0; i < array.Length; i++) // цикл для вывода всех элементов массива по порядку (от 0-го элемента)
//     {
//         if (i < array.Length - 1) // условие проверяет, является ли текущий элемент не последним в массиве.
//         {
//             Console.Write($"{array[i]}, "); // если текущий элемент не последний, он выводится на консоль с запятой и пробелом после него
//         }
//         else
//         {
//             Console.Write($"{array[i]}"); // если текущий элемент является последним в массиве, он выводится на консоль без запятой после него
//         }
//     }
//     Console.WriteLine("]"); // закрывающая скобка (должна быть после цикла, а не внутри него) и добавление новой строки
// }

// int CountPrime(int[] array) // объявление функции подсчета количества целых простых чисел 
// {
//     int count = 0; // переменная для подсчёта количества целых простых чисел
//     for (int i = 0; i < array.Length; i++) // проход по всем элементам массива
//     {
//         if (IsPrime(array[i])) count++; // условие: является ли элемент массива(число) простым, записываем в переменную "count", если да 
//     }
//     return count; // возврат результата
// }

// bool IsPrime(int num) // объявление функции для проверки на простоту числа
// {
//     for (int i = 2; i <= Math.Sqrt(num); i++) // цикл перебора всех чисел от 2 до квадрата от "num". Если "num" делится на любое из этих чисел без остатка, то "num" не является простым числом.
//     {
//         if (num % i == 0) return false; // условное выражение внутри цикла. Если "num" делится на "i" без остатка (то есть num % i равно 0), то "num" не является простым числом, и функция возвращает false
//     }
//     return true; // если цикл завершается без возврата "false", это означает, что "num" не делится на любое число от 2 до квадратного корня из "num" без остатка. Следовательно, "num" является простым числом, и функция возвращает "true"
// }

// int[] arr = CreateArrayRndInt(10, 1, 1000); // новая переменная, вызывающая первую функцию для возвращенных значений с параметрами:size=10, min=1, max=1000
// PrintArray(arr); // вызов функции для вывода этой переменной

// int result = CountPrime(arr); // переменная для вывода

// Console.WriteLine(result); // вывод результата
//--------------------------------------------------------//
// Задайте массив из N случайных целых чисел (N вводится с
// клавиатуры).
// Найдите количество чисел, которые оканчиваются на 1 и
// делятся нацело на 7.
// Пример
// [1 5 11 (21) 81 4 0 (91) 2 3]
// => 2

//беру 2 готовые функции из предыдущей задачи "CreateArrayRndInt"-для заполнения массива случайными числами, 
//"PrintArray"-для вывода этого массива
// int[] CreateArrayRndInt(int size, int min, int max) // объявление функции заполнения массива случайными числами и возращением значений типа int
// {
//     int[] array = new int[size]; // объявление массива с размером "size"
//     Random rnd = new Random(); // объект для генерации чисел

//     for (int i = 0; i < array.Length; i++) // цикл для заполнения массива
//     {
//         array[i] = rnd.Next(min, max); // вызов метода для генерации случайных чисел с параметрами(отрезок)- от и до(невключительно)
//     }
//     return array;
// }
// void PrintArray(int[] array)  // функция вывода результата в консоль (не возвращающая значения-тип метода "void")
// {
//     Console.Write("["); // команда для вывода массива в квадратных скобках (открывающая скобка)
//     for (int i = 0; i < array.Length; i++) // цикл для вывода всех элементов массива по порядку (от 0-го элемента)
//     {
//         if (i < array.Length - 1) // условие проверяет, является ли текущий элемент не последним в массиве.
//         {
//             Console.Write($"{array[i]}, "); // если текущий элемент не последний, он выводится на консоль с запятой и пробелом после него
//         }
//         else
//         {
//             Console.Write($"{array[i]}"); // если текущий элемент является последним в массиве, он выводится на консоль без запятой после него
//         }
//     }
//     Console.WriteLine("]"); // закрывающая скобка (должна быть после цикла, а не внутри него) и добавление новой строки
// }
// // объявление новой функции проверки числа (окончание на 1 и деления на 7)
// int NumberCountCheck(int[] arr, int lastDigit, int multiple) // функция c параметрами из условия задачи
// // тело метода
// {
//     int count = 0; // переменная-счетчик(до цикла, чтобы "count" не всегда был равен 0)
//     for (int i = 0; i < arr.Length; i++) // стандартный цикл прохода по всему массиву
//     {
//         if (arr[i] % 10 == lastDigit && arr[i] % multiple == 0) count++; // условие (проверка элемента массива-окончание на 1 и деления на 7), увеличение счетчика
//     }
//     return count; // возвращение значений
// }

// Console.WriteLine("Введите чисто N: "); // ввод числа N c клавиатуры
// int N = Convert.ToInt32(Console.ReadLine()); // конвертация в  char в 32

// int[] newArray = CreateArrayRndInt(N, 1, 100); // новый массив, ссылающийся на функцию "CreateArrayRndInt"
// PrintArray(newArray); // вывод массива через функцию "PrintArray"

// Console.WriteLine(NumberCountCheck(newArray, 1, 7)); // вывод c с передаваемыми параметрами "1", "7"
//---------------------------------------------------------//
// Заполните массив на N (вводится с консоли, не более 8)
// случайных целых чисел от 0 до 9.
// Сформируйте целое число, которое будет состоять из цифр из
// массива. Старший разряд числа находится на 0-м индексе,
// младший – на последнем.
// Пример
// [1 3 2 4 2 3] => 132423
// [2 3 1] => 231

// беру 2 готовые функции из предыдущей задачи "CreateArrayRndInt"-для заполнения массива случайными числами, 
// "PrintArray"-для вывода этого массива
int[] CreateArrayRndInt(int size, int min, int max) // объявление функции заполнения массива случайными числами и возращением значений типа int
{
    int[] array = new int[size]; // объявление массива с размером "size"
    Random rnd = new Random(); // объект для генерации чисел

    for (int i = 0; i < array.Length; i++) // цикл для заполнения массива
    {
        array[i] = rnd.Next(min, max); // вызов метода для генерации случайных чисел с параметрами(отрезок)- от и до(невключительно)
    }
    return array;
}
void PrintArray(int[] array)  // функция вывода результата в консоль (не возвращающая значения-тип метода "void")
{
    Console.Write("["); // команда для вывода массива в квадратных скобках (открывающая скобка)
    for (int i = 0; i < array.Length; i++) // цикл для вывода всех элементов массива по порядку (от 0-го элемента)
    {
        if (i < array.Length - 1) // условие проверяет, является ли текущий элемент не последним в массиве.
        {
            Console.Write($"{array[i]}, "); // если текущий элемент не последний, он выводится на консоль с запятой и пробелом после него
        }
        else
        {
            Console.Write($"{array[i]}"); // если текущий элемент является последним в массиве, он выводится на консоль без запятой после него
        }
    }
    Console.WriteLine("]"); // закрывающая скобка (должна быть после цикла, а не внутри него) и добавление новой строки
}

int ArrayToNumber(int[] newarray) // функция составления числа из элементов массива
{
    int num = 0;
    for (int i = 0; i < newarray.Length; i++)
    {
        num = 10 * num + newarray[i];
    }
    return num;
}
Console.WriteLine("Введите размер массива (не более 8)"); // ввод 
int N = Convert.ToInt32(Console.ReadLine()); // переменная кол-ва элементов массива, вводимая с клавиатуры
if (N < 1 || N > 8) //условие(по задаче)
{
    Console.WriteLine("Задан некорректный размер массива!"); // ошибка ввода
    return; // завершает главную функцию(всю программу) "main"-точку входа(т.к. вся программа написана в этой функции "main")
}
int[] arr = CreateArrayRndInt(N, 0, 10); // новый массив, ссылающийся на функцию "CreateArrayRndInt"
PrintArray(arr); // вывод этого массива
int arrayToNumber = ArrayToNumber(arr); // новая переменна (число из элементов массива)
Console.WriteLine(arrayToNumber); // вывод этого числа
