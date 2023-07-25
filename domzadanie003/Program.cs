class Program
{
    static void Main()
    {
        Random random = new Random();
        int arraySize = 10;
        int[] array = new int[arraySize];
        for (int i = 0; i < arraySize; i++)
        {
            array[i] = random.Next(100, 1000);
        }

        Console.WriteLine("Сгенерированный массив:");
        foreach (int number in array)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
        int countEvenNumbers = 0;
        foreach (int number in array)
        {
            if (number % 2 == 0)
            {
                countEvenNumbers++;
            }
        }
        Console.WriteLine("Количество четных чисел в массиве: " + countEvenNumbers);

        void Task36()
        {
            Random random = new Random();
            int arraySize = 10;
            int[] array = new int[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                array[i] = random.Next(1, 100);
            }
            Console.WriteLine("Сгенерированный массив:");
            foreach (int number in array)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            int sum = 0;
            for (int i = 1; i < arraySize; i += 2)
            {
                sum += array[i];
            }
            Console.WriteLine("Сумма элементов с нечетными индексами: " + sum);
        }

        void Task39()
        { 
        double[] array = { 3.21, 7.04, 22.93, -2.71, 78.24};

        Console.WriteLine("Массив:");
        foreach (double number in array)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();

        double max = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }

        double min = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
        }

        double dif = max - min;

        Console.WriteLine("Разница между максимальным и минимальным: " + dif);

        }

        Console.Clear();
        Task39();
        
        

     


            

    }

}
