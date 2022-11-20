class Program
{
    static void Main(string[] args){
       Task_1.run();
       Task_2.run();
       Task_3.run();
    }
}

class Task_1
{
    public static void run()
    {
        Console.WriteLine("Задание 1");
        int n = 1, sum = 0;
        while (n != 0){
            Console.Write("Введиете число: ");
            n = Convert.ToInt32(Console.ReadLine());
            sum += n;
        }
        Console.WriteLine($"Сумма вводимых цифр: {sum}");
    }
}

class Task_2
{
    public static void run()
    {
        Console.WriteLine("\nЗадание 2");
        Console.Write("Введите n: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int f = 1, temp = n;
        while (n > 0){
            f *= n;
            n--;
        }
        Console.WriteLine($"Факториал числа {temp} равен {f}");
    }
}

class Task_3
{
    public static void run()
    {
        Console.WriteLine("\nЗадание 3");
        Console.WriteLine("Введите n: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int i = 0, num = 2;
        while (i != n)
        {
            Console.WriteLine($"Четное число:{num}");
            i++;
            num += 2;
        }
    }
}