//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

int [] array = new int [5];
FillArray(array);
PrintArray(array);
EvenNum(array);

void FillArray(int [] array)
    {
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 999);
    }

void PrintArray(int [] array)
    {
    foreach(int el in array)
        Console.Write($"{el} ");
    Console.WriteLine();
    }

void EvenNum(int [] array)
    {
    int even = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0)
            even++;
    Console.WriteLine("Количество четных чисел в массиве: " + even);
    }