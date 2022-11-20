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
        int n = Program.readInt("N");
        int m = Program.readInt("M");
        int quantity = 0, temp = n;
        do
        {
            if (n % 10 == m) quantity++;
            n = n / 10;
        } while (n != 0);
        Console.WriteLine($"Цифра {m} встречается в числе {temp} {quantity} раз.");
    }
}

class Task_2
{
    public static void run()
    {
        Console.WriteLine("\nЗадание 2");
        int n = Program.readInt("N");
        int temp = n, min = n % 10;
        do
        {
            if (min > temp % 10) min = temp % 10;
            temp = temp / 10;
        } while (temp != 0);
        Console.WriteLine($"Минимальная цифра в числе {n}: {min}");
    }
}

class Task_3
{
    public static void run()
    {
        Console.WriteLine("\nЗадание 3");
        int a = Program.readInt("A");
        int b = Program.readInt("B");
        int rez = 0, mult = a;
        do
        {
            rez += b;
            mult--;
        } while (mult > 0);
        Console.WriteLine($"{a} X {b} = {rez}");
    }
}

class Task_4
{
    public static void run()
    {
        Console.WriteLine("\nЗадание 4");
        int n = Program.readInt("N");
        int f1 = 1, f2 = 1, temp, i = 0;
        do
        {
            temp = f1 + f2;
            f1 = f2;
            f2 = temp;
            i++;
        } while (i < n - 2);
        if (n == 0) f2 = 0;
        if (n == 1 || n == 2) f2--;
        Console.WriteLine($"{n}-й число фибоначчи: {f2}");
    }
}