int Input(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}


void Task10()
{
    int number = Input("Введите число: ");
    Console.WriteLine($"Второя цифра:  {number / 10 % 10}");
}


void Task13()
{
    int number = Input("Введите число: ");
    number = Math.Abs(number);
    if (number > 99)
    {
        while (number > 999)
        {
            number /= 10;
        }
        Console.WriteLine($"Третья цифра:  {number % 10}");
    }
    else
    {
        Console.WriteLine("Третии цифры нет");
    }
}

void Task15()
{
    int day = Input("Введите номер дня");
    if (day >= 1 && day <= 5) 
    {
        Console.WriteLine("Это Будни");
    }
    else if (day == 6 || day == 7)
    {
        Console.WriteLine("Выходные");
    }
    else
    {
        Console.WriteLine("Что-то пошло не так:");
    }
}
Console.Clear();
Task15();