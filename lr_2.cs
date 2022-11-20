class Program
{
    static void Main(string[] args)
    {
        Task_1.run();
        Task_2.run();
        Task_3.run();
        Task_4.run();
    }
    public static int readInt(string arg)
    {
        Console.Write($"Введи число {arg}: ");
        return Convert.ToInt32(Console.ReadLine());
    }
}

class Task_1
{
    public static void run()
    {
        Console.WriteLine("Задание 1");
        int a = Program.readInt("a");
        int n = Program.readInt("n");
        int rezult = a;
        if (n == 0) {
            rezult = 1;
        } else
        {
            for (int i = 1; i < n; i++)
            {
                    rezult *= a;
            }
        }
        Console.WriteLine($"{a} в степени {n} = {rezult}");
    }
}

class Task_2
{
    public static void run() 
    {
        Console.WriteLine("\nЗадание 2");
        int rezult;
        for (int i = 10; i < 100; i++)
        {
            rezult = (i % 10) + (i / 10);
            if (rezult == 5) Console.WriteLine($"Сумма чисел равна 5 у {i}");
        }
    }
}

class Task_3
{
    public static void run()
    {
        Console.WriteLine("\nЗадание 3");
        int sum = 0, i = 1;
        for (; i <= 100; i+=2)
        {
            sum += i;
        }
        Console.WriteLine($"Сумма нечетных чисел: {sum}");
    }
}

class Task_4
{
    public static void run()
    {
        Console.WriteLine("\nЗадание 4");
        int n = Program.readInt("n");
        int rezult = 1, i = 1;
        for (;i <= n; i++)
        {
            rezult *= i;
        }
        Console.WriteLine($"Факториал числа {n}: {rezult}");
    }
}