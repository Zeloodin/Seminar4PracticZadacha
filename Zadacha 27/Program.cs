// Задача 27: Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Expanding_numbers_into_a_sum(int numbers)
{
    int value_numbers = numbers;
    int sum = 0;
    while(true)
    {
        if (value_numbers <= 0)
        {
            break;
        }
        else
        {
            sum += (value_numbers % 10);
            value_numbers /= 10;
        }
    }
    return sum;
}

// error C S8112: Локальная функция "InputNumber()" должна объявить тело,
// так как она не помечена как "static extern".


// string InputNumber();
// {
//     int number;
//     while(true)
//     {
//         try
//         {
//             Console.Write("Введите число: ");
//             number = Convert.ToInt32(Console.ReadLine());
//             break;
//         }
//         catch(System.FormatException)
//         {
//             Console.WriteLine("Ошибка!");
//         }
//         catch(System.OverflowException)
//         {
//             Console.WriteLine("Ошибка!");
//         }
//     }
//     return number;
// }

int number;
while(true)
{
    try
    {
        Console.Write("Введите число: ");
        number = Convert.ToInt32(Console.ReadLine());
        break;
    }
    catch(System.FormatException)
    {
        Console.WriteLine("Ошибка!");
    }
    catch(System.OverflowException)
    {
        Console.WriteLine("Ошибка!");
    }
}

Console.WriteLine(Expanding_numbers_into_a_sum(number));
