class Program
{
    static void Main(string[] args)
    {
        Task_1.run();
        Task_2.run();
        Task_3.run();
        Task_4.run();
        Task_5.run();
    }
}

class Task_1
{
    public static void run()
    {
        Console.WriteLine("Задание 1");
        int a = readInt("a");
        int b = readInt("b");
        int c = readInt("c");
        double d = Math.Pow(b, 2) - 4 * a * c;
        
        if(d < 0)
        {
            Console.WriteLine("Корней нет");
        } else if(d > 0)
        {
            Console.WriteLine("2 корня");
        } else
        {
            Console.WriteLine("1 корень");
        }
    }

    public static int readInt(string arg)
    {
        Console.Write($"Введи число {arg}: ");
        return Convert.ToInt32(Console.ReadLine());    
    }
}

class Task_2
{
    public static void run()
    {
        Console.WriteLine("\nЗадание 2");
        int a = Task_1.readInt("a");
        int b = Task_1.readInt("b");
        int c = Task_1.readInt("c");

        if (c >= a && c <= b)
        {
            Console.WriteLine("Принадлежит");
        }
        else
        {
            Console.WriteLine("Не принадлежит");
        }
    }
}

class Task_3
{
    public static void run()
    {
        Console.WriteLine("\nЗадание 3");
        int a = Task_1.readInt("a");
        int b = Task_1.readInt("b");
        int c = Task_1.readInt("c");
        int count = 0;
        if (a < 0)
        {
            count++;
        }
        if (b < 0)
        {
            count++;
        }
        if (c < 0)
        {
            count++;
        }
        Console.WriteLine($"Количество отрицательных чисел: {count}");
    }
}

class Task_4
{
    public static void run()
    {
        Console.WriteLine("\nЗадание 4");
        double a = readDouble("a");
        double b = readDouble("b");
        if (b == 0)
        {
            Console.WriteLine("Деление невозможно");
        } else
        {
            Console.WriteLine($"Частное = {a / b}");
        }
        
    }
    public static double readDouble(string arg)
    {
        Console.Write($"Введи число {arg}: ");
        return Convert.ToDouble(Console.ReadLine());
    }
}

class Task_5
{
    public static void run()
    {
        Console.WriteLine("\nЗадание 5");
        double a = Task_4.readDouble("a");
        double b = Task_4.readDouble("b");

        Console.WriteLine($"Ответ = {(a == b ? a + b : a - b)}");
    }
}