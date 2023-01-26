
# Описание работы программы
>## Задача:
Создать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
>## Решение:
 1. Создаем функцию *"[InputArray](#inputarray)"* для ввода массива с клавиатуры
 2. Создаем функцию *"[PrintArray](#printarray)"* для вывода массива на экран
 3. Создаем переменную *"newLength"*, с помощью цикла *"for"* находим и присваиваем ей сумму строк, соответсвующих условию.
 4. Создаем новый массив *"newArray"* с длиной *"newLength"*
 5. С помощью новой переменной *"count"* и цикла *"for"* заполняем массив *"newArray"*
 6. С помощью функции *"PrintArray"* выводим новый массив *"newArray"*

---
>## Используемые функции:
 ### InputArray:
 ```
 string[] InputArray()
{
    Console.WriteLine("Уточните общее количество элементов будущего массива");
    int size = Convert.ToInt32(Console.ReadLine());
    string[] myArray = new string[size];
    for (int i = 0; i < myArray.Length; i++)
    {
        Console.Write($"Введите элемент массива под индексом {i}: ");
        myArray[i] = Console.ReadLine()!;
    }
    return myArray;
}
 ```
### PrintArray:
```
 void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}
```
>## Блок-схема:


