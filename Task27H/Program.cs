//Задача 27. - HARD необязательная Напишите программу,
//которая принимает на вход целое или дробное число и выдаёт количество цифр в числе.

//452 -> 3
//82 -> 2
//9,012 ->4


Console.WriteLine("Введите число:");
double num = Convert.ToDouble( Console.ReadLine());
num_length(num);

void num_length(double num)
{
    int i = 0;
    int k = 0;
    int i_num = Convert.ToInt32(num);
    if (i_num > num) // Убрали округление в большую сторону
        i_num--;
    while (i_num > 0) // Подсчет целых чисел
        {
        i_num/=10;
        k++;
        }
    // Console.WriteLine("Количество целых цифр: " + k);
    i_num = Convert.ToInt32(num);
    double n_num = num;
    while (i_num  - n_num > 0  | i_num  - n_num < 0) // Подсчет цифр после запятой, нули на конце не считаются
        {
        i++;
        k++;
        n_num = num * Math.Pow(10,i);;
        i_num = Convert.ToInt32(n_num);   
        }
    // Console.WriteLine("Количество цифр после запятой: " + i);
    Console.WriteLine("Количество цифр в числе: " + k);
}