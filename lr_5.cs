class Program
{
    static void Main(string[] args)
    {
        Task_1.run(); 
        Task_2.run(); 
        Task_3.run(); 
        Task_4.run(); 
        Task_5.run(); 
        Task_6.run();
    }
}

class Task_1
{
    public static void run()
    {
        Console.WriteLine("\nЗадание 1");
        int[] nums = new int[10];
        Random rnd = new Random();
        Console.Write("Исходный массив: ");
        for (int i = 0; i < 10; i++)
        {
            nums[i] = rnd.Next(0, 10);
            Console.Write($"{nums[i]} ");
        }
       
        int min = nums[0], max = nums[0];
        foreach (var num in nums)
        {
            if (num < min) min = num;
            if (num > max) max = num;
        }
        Console.WriteLine($"\nСумма минимального и максимального числа: {min + max}");
    }
}

class Task_2
{
    public static void run()
    {
        Console.WriteLine("\nЗадание 2");
        int[] nums = new int[15];
        Random rnd = new Random();
        Console.Write("Исходный массив: ");
        for (int i = 0; i < 15; i++)
        {
            nums[i] = rnd.Next(0, 20);
            Console.Write($"{nums[i]} ");
        }
        Console.Write("\nЧетные числа в массиве: ");
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] % 2 == 0 && nums[i] != 0) Console.Write($"{nums[i]} ");
        }
    }
}

class Task_3
{
    public static void run()
    {
        Console.WriteLine("\nЗадание 3");
        int[] nums = new int[20];
        Random rnd = new Random();
        Console.Write("Исходный массив: ");
        for (int i = 0; i < 20; i++)
        {
            nums[i] = rnd.Next(-5, 5);
            Console.Write($"{nums[i]} ");
        }
        int ind = 0;
        Console.Write("\nЭлементы в массиве с четными индексами: ");
        foreach (var num in nums)
        {
            if (ind % 2 == 0 && ind != 0) Console.Write($"{num} ");
            ind++;
        }
    }
}

class Task_4
{
    public static void run()
    {
        Console.WriteLine("\nЗадание 4");
        int[] nums = new int[10];
        Random rnd = new Random();
        Console.Write("Исходный массив: ");
        for (int i = 0; i < 10; i++)
        {
            nums[i] = rnd.Next(-20, 10);
            Console.Write($"{nums[i]} ");
        }
        int neg = 0;     
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] < 0) neg++;
        }
        Console.Write($"\nКоличество отрицательных элементов: {neg}");
    }
}

class Task_5
{
    public static void run()
    {
        Console.WriteLine("\nЗадание 5");
        int[] nums = new int[18];
        Random rnd = new Random();
        Console.Write("Исходный массив: ");
        for (int i = 0; i < 18; i++)
        {
            nums[i] = rnd.Next(-30, 30);
            Console.Write($"{nums[i]} ");
        }
        int negmax = -31;

        foreach (var num in nums)
        {
            if (negmax < num && num < 0) negmax = num;
        }
        Console.WriteLine((negmax != -31) ? $"\nМаксимальный отрицательный элемент: {negmax}": "\nОтрицательных чисел нет");
    }
}

class Task_6
{
    public static void run()
    {
        Console.WriteLine("\nЗадание 6");
        int[] nums = new int[12];
        Random rnd = new Random();
        Console.Write("Исходный массив: ");
        for (int i = 0; i < 12; i++)
        {
            nums[i] = rnd.Next(-20, 10);
            Console.Write($"{nums[i]} ");
        }

        Console.Write("\nИндексы отрицательных элементов: ");
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] < 0) Console.Write($"[{i}] ");
        }
    }
}