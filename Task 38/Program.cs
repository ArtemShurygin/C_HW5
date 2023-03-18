//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементами массива.

//[3 7 22 2 78] -> 76

double [] array = new double [5];
FillArray(array);
PrintArray(array);
DifMaxMin(array);

void FillArray(double [] array)
    {
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
        {
        array[i] = random.NextDouble()*(200) - 100 ;
        //Console.Write($"{array[i].ToString("F2")} ");
        }
    }


void PrintArray(double [] array)
    {
    foreach(double el in array)
        Console.Write($"{el.ToString("F2")} ");
    Console.WriteLine();
    }


void DifMaxMin(double [] array)
    {
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
        {
        if (array[i] > max)
            max = array[i];
        if (array[i] < min)
            min = array[i];
        }
    //Console.WriteLine("max: " + max);
    //Console.WriteLine("min: " + min);
    Console.WriteLine("Разница между максимальным и минимальным элементами массива: " + (max - min).ToString("F5"));
    //У каждого элемента массива столько цифр после запятой, сколько позволяет их хранить тип double,
    //поэтому, если считать разницу вручную, то погрешность последней цифры из-за округления может составить 1
    }