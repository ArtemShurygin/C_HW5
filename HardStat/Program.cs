//Задача HARD STAT необязательная: Задайте массив случайных целых чисел.
//Найдите максимальный элемент и его индекс, минимальный элемент и его индекс, среднее арифметическое всех элементов.
//Сохранить эту инфу в отдельный массив и вывести на экран с пояснениями. 
//Найти медианное значение первоначалального массива, возможно придется кое-что для этого дополнительно выполнить.


double [] array = new double [6];
FillArray(array);
PrintArray(array);

double [] rez = Stat(array);
Console.WriteLine();
Console.WriteLine("Индекс максимального элемента: " + rez[0]); //Индекс первого в массиве максимального элемента
Console.WriteLine("Значение максимального элемента: " + rez[1]);
Console.WriteLine("Индекс минимального элемента: " + rez[2]); //Индекс первого в массиве минимального элемента
Console.WriteLine("Значение минимального элемента: " + rez[3]);
Console.WriteLine("Среднее арифметическое всех элементов " + rez[4]);
 
Median(array);

void FillArray(double [] array)
    {
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(0, 9);
    }

void PrintArray(double [] array)
    {
    foreach(int el in array)
        Console.Write($"{el} ");
    Console.WriteLine();
    }

double[] Stat(double [] array)
    {
    double max = array[0];
    double min = array[0];
    int imin = 0;
    int imax = 0;
    double sum = 0;
    for (int i = 0; i < array.Length; i++)
        {
        if (array[i] > max)
            {
            max = array[i];
            imax = i;
            }
        if (array[i] < min)
            {
            min = array[i];
            imin = i;
            }
        sum += array[i];
        }
    double average = sum/array.Length;
    double [] results = {imax, max, imin, min, average};
    return results;
    }

void Median(double [] array)
    {
    int n = 1;
    while (n > 0)   //Упорядочивание элементов массива по возрастанию
        {
        n = 0;
        for (int i = 0; i < array.Length-1; i++)
            {
            if (array[i+1] < array[i])
                {
                double k = array[i+1];
                array[i+1] = array[i];
                array[i] = k;
                n++;
                //Console.WriteLine("No ");
                //PrintArray(array);
                }
            }
        }
    Console.WriteLine();
    Console.WriteLine("Упорядоченный по возрастанию чисел массив:");
    PrintArray(array);
    double median = 0;
    int l = array.Length;
    int l2 = l / 2;
    if (l%2 == 0)
        {
        median = (array[l2] + array[l2-1]) / 2;
        }
    else    
         median = array[l2];
    Console.WriteLine("Медианное значение: " + median);
    }


/*
void ImaxIminAverage(int [] array)
    {
    int max = array[0];
    int min = array[0];
    int imin = 0;
    int imax = 0;
    double sum = 0;
    for (int i = 0; i < array.Length; i++)
        {
        if (array[i] > max)
            {
            max = array[i];
            imax = i;
            }
        if (array[i] < min)
            {
            min = array[i];
            imin = i;
            }
        sum += array[i];
        }
        double average = sum/array.Length;
        
        Console.WriteLine("imax: " + imax);
        Console.WriteLine("max: " + max);
        Console.WriteLine("imin: " + imin);
        Console.WriteLine("min: " + min);
        Console.WriteLine("sum: " + sum);
        Console.WriteLine("average " + average);
        
    }
*/