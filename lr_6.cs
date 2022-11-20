using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        Task_1.run(); 
        Task_2.run();
        Task_3.run(); 
        Task_4.run();
    }
}

class Task_1
{
    public static void run()
    {
        Console.WriteLine("\nЗадание 1");
        Console.WriteLine("Введите количество строк и столбцов: ");
        int row = Convert.ToInt32(Console.ReadLine());
        int column = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите диапазон случайных чисел: ");
        int rndmin = Convert.ToInt32(Console.ReadLine());
        int rndmax = Convert.ToInt32(Console.ReadLine());
        int[,] nums = new int[row, column];
        Random rnd = new Random();
        
        Console.WriteLine("Исходный массив: ");
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                nums[i, j] = rnd.Next(rndmin, rndmax);
                Console.Write($"{nums[i, j]} ");
            }
            Console.Write("\n");  
        }

        int mult, summ = 0;
        double avg = 0;
        for (int i = 0; i < row; i++)
        {
            mult = 1;
            for (int j = 0; j < column; j++)
            {
                avg += nums[i, j];
                mult *= nums[i, j];
            }
            summ += mult;
        }
        double res = avg / (row * column);
        Console.WriteLine($"Сумма произведений строк и столбцов: {summ}");
        Console.WriteLine($"Среднее арифметическое: {res}");
    }
}

class Task_2
{
    public static void run()
    {
        Console.WriteLine("\nЗадание 2");
        Console.WriteLine("Введите количество строк и столбцов: ");
        int row = Convert.ToInt32(Console.ReadLine());
        int column = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите диапазон случайных чисел: ");
        int rndmin = Convert.ToInt32(Console.ReadLine());
        int rndmax = Convert.ToInt32(Console.ReadLine());
        int[,] nums = new int[row, column];
        Random rnd = new Random();

        Console.WriteLine("Исходный массив: ");
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                nums[i, j] = rnd.Next(rndmin, rndmax);
                Console.Write($"{nums[i, j]} ");
            }
            Console.Write("\n");
        }

        int[] result = new int[column];
        int mult;
        Console.WriteLine($"Итоговый массив: ");
        for (int i = 0; i < row; i++)
        {
            mult = 1;
            for (int j = 0; j < column; j++)
            {
                mult *= nums[i, j];
            }
            result[i] = mult;
            Console.Write($"{result[i]} ");
        }
    }
}

class Task_3
{
    public static void run()
    {
        Console.WriteLine("\n\nЗадание 3");
        Console.WriteLine("Введите количество строк и столбцов: ");
        int row = Convert.ToInt32(Console.ReadLine());
        int column = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите диапазон случайных чисел: ");
        int rndmin = Convert.ToInt32(Console.ReadLine());
        int rndmax = Convert.ToInt32(Console.ReadLine());
        int[,] nums = new int[row, column];
        Random rnd = new Random();

        Console.WriteLine("Исходный массив: ");
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                nums[i, j] = rnd.Next(rndmin, rndmax);
                Console.Write($"{nums[i, j]} ");
            }
            Console.Write("\n");
        }

        int summ = 0;
        int[,] result = new int[row, column];
        Console.WriteLine("Итоговый массив:");
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                summ += nums[i, j];
                if (i == j)
                {
                    result[i, j] = nums[i, j];
                } else
                {
                    result[i, j] = 1;
                }
                Console.Write($"{result[i, j]} ");
            }
            Console.Write("\n");
        }
        Console.WriteLine($"Сумма элементов массива: {summ}");
    }
}

class Task_4
{
    public static void run()
    {
        Console.WriteLine("\nЗадание 4");
        Console.WriteLine("Введите количество строк и столбцов: ");
        int row = Convert.ToInt32(Console.ReadLine());
        int column = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите диапазон случайных чисел: ");
        int rndmin = Convert.ToInt32(Console.ReadLine());
        int rndmax = Convert.ToInt32(Console.ReadLine());
        int[,] nums = new int[row, column];
        Random rnd = new Random();

        Console.WriteLine("Исходный массив: ");
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                nums[i, j] = rnd.Next(rndmin, rndmax);
                Console.Write($"{nums[i, j]} ");
            }
            Console.Write("\n");
        }

        int summ = 0, change = 0;
        int[,] result = new int[row, column];
        Console.WriteLine("Итоговый массив:");
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                summ += nums[i, j];
                if (nums[i, j] < 0)
                {
                    result[i, j] = 1;
                    change++;
                }
                else
                {
                    result[i, j] = nums[i, j];
                }
                Console.Write($"{result[i, j]} ");
            }
            Console.Write("\n");
        }
        Console.WriteLine($"Сумма элементов массива: {summ}");
        Console.WriteLine($"Количество изменений: {change}");
    }
}