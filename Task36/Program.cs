//Задача 36: Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int [] array = new int [5];
FillArray(array);
PrintArray(array);
SumUneven(array);

void FillArray(int [] array)
    {
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-100, 100);
    }

void PrintArray(int [] array)
    {
    foreach(int el in array)
        Console.Write($"{el} ");
    Console.WriteLine();
    }

void SumUneven(int [] array)
    {
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
        if (i % 2 > 0)
            sum += array[i];
    Console.WriteLine("Cумма элементов, стоящих на нечётных позициях в массиве: " + sum);
    }