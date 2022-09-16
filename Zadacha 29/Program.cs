// Задача 29: Пользователь вводит 8 чисел.
// Поместите их в массив и распечатайте.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int InputNumberLenghtMassiv()
{
    while(true)
    {
        try
        {
            Console.Write("Введите длину массива: ");
            int NumberLenghtMassiv = Convert.ToInt16(Console.ReadLine());
            return NumberLenghtMassiv;
            break;
        }
        catch(System.FormatException)
        {
            Console.WriteLine("Ошибка!");
        }
    }
}

static extern double[] InputStringNumber_OutListNumber(int len);
{
    int lenght = len;
    double[] numberStringList = new double[lenght];
    for (int i = 0; i < lenght; i++)
    {
        while(true)
        {
            try
            {
                Console.Write($"Nomer {i+1}. Введите число: ");
                numberStringList[i] = Convert.ToDouble(Console.ReadLine());
                break;
            }
            catch(System.FormatException)
            {
                Console.WriteLine($"Nomer {i+1}. Ошибка!");
            }
        }
    }
    return numberStringList;
}

double[] InputArrayListNumber(double[] numberArray)
{
    double[] numList = new double[numberArray.Length];
    
    
    for (int i = 0; i < numberArray.Length; i++)
    {
        bool true1 = true;
        while(true1)
        {
            try
            {
                numList[i] = numberArray[i];
                true1 = false;
            }
            catch(System.FormatException)
            {
                bool true2 = true;
                while(true2)
                {
                    try
                    {
                        Console.WriteLine($"Nomer {i+1}. Ошибка!");
                        Console.Write($"Nomer {i+1}. Введите число: ");
                        numList[i] = Convert.ToDouble(Console.ReadLine());
                        true2 = false;
                    }
                    catch(System.FormatException)
                    {
                    }
                }
                
            }
        }
    }
    return numList;
}




int lenghtList = InputNumberLenghtMassiv();

// double[] NumStringList = InputStringNumber_OutListNumber(lenghtList);

// double[] resultNumberList = InputArrayListNumber(NumStringList);

double[] resultNumberList = InputStringNumber_OutListNumber(lenghtList);

Console.WriteLine(string.Join(", ", resultNumberList));