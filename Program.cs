﻿// Задайте одномерный массив, заполненный случайными
// числами. Определите количество простых чисел в этом
// массиве.
// Примеры
// [1 3 4 19 3] => 2
// [4 3 4 1 9 5 21 13] => 3

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

int CountPrime(int[] array) // объявление функции подсчета количества целых простых чисел 
{
    int count = 0; // переменная для подсчёта количества целых простых чисел
    for (int i = 0; i < array.Length; i++) // проход по всем элементам массива
    {
        if (IsPrime(array[i])) count++; // условие: является ли элемент массива(число) простым, записываем в переменную "count", если да 
    }
    return count; // возврат результата
}

bool IsPrime(int num) // объявление функции для проверки на простоту числа
{
    for (int i = 2; i <= Math.Sqrt(num); i++) // цикл перебора всех чисел от 2 до квадрата от "num". Если "num" делится на любое из этих чисел без остатка, то "num" не является простым числом.
    {
        if (num % i == 0) return false; // условное выражение внутри цикла. Если "num" делится на "i" без остатка (то есть num % i равно 0), то "num" не является простым числом, и функция возвращает false
    }
    return true; // если цикл завершается без возврата "false", это означает, что "num" не делится на любое число от 2 до квадратного корня из "num" без остатка. Следовательно, "num" является простым числом, и функция возвращает "true"
}

int[] arr = CreateArrayRndInt(10, 1, 1000); // новая переменная, вызывающая первую функцию для возвращенных значений с параметрами:size=10, min=1, max=1000
PrintArray(arr); // вызов функции для вывода этой переменной

int result = CountPrime(arr); // переменная для вывода

Console.WriteLine(result); // вывод результата