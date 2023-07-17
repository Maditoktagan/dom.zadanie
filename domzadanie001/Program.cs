void Task19()
{
    Console.WriteLine("Введите пятизначное число");
    int number = Convert.ToInt32(Console.ReadLine());

    if (number / 10000 == number % 10 && number / 1000 % 10 == number / 10 % 10)
    {
        Console.WriteLine("Число является палиндромом");
    }
    else
    {
        Console.WriteLine("Число  не является палиндромом");
    }

}

void Task20()
{
    int x1 = 2;
    int y1 = 6;
    int z1 = 1;

    int x2 = 8;
    int y2 = 1;
    int z2 = 6;


    double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    result = Math.Round(result, 3);
    Console.WriteLine(result);
}


void Task23()
{
    int number = 10;
    for (int i = 4; i <= number; i++)
    {
        Console.WriteLine($"{i}* {i} *{i} ={Math.Pow(i, 3)}");
    }
}
Console.Clear();
Task23();