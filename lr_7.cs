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
        void PowerA3(double a, out double b)
        {
            b = a * a * a;
        }

        Console.WriteLine("\nЗадание 1");
        double b, a;
        Random rnd = new Random();
        for (int i = 0; i < 5; i++) {
            a = rnd.Next(10);
            PowerA3(a, out b);
            Console.WriteLine($"{a} в 3 степени: {b}");
        }
    }
}

class Task_2
{
    public static void run()
    {
        void PowerA234(double a, out double b, out double c, out double d)
        {
            b = a * a;
            c = b * a;
            d = c * a;
        }

        Console.WriteLine("\nЗадание 1");
        double a, b, c, d;
        Random rnd = new Random();
        for (int i = 0; i < 5; i++)
        {
            a = rnd.Next(1, 10);
            PowerA234(a, out b, out c, out d);
            Console.WriteLine($"{a} в 2 степени: {b}\n \tв 3 степени: {c}\n \tв 4 степени {d}");
        }
    }
}

class Task_3
{
    public static void run()
    {
        void Mean(double x, double y)
        {
            double AMean = (x + y) / 2;
            double GMean = Math.Sqrt(x*y);
            Console.WriteLine($"\nСр. арифм. {x} и {y}: {AMean}");
            Console.WriteLine($"Ср. геом. {x} и {y}: {GMean}");
        }

        Console.WriteLine("\nЗадание 3");
        Random rnd = new Random();
        double temp, a = rnd.Next(1, 10);
        for (int i = 0; i < 3; i++)
        {    
            temp = rnd.Next(1, 10);
            Mean(a, temp);
        }
    }
}

class Task_4
{
    public static void run()
    {
        void TrianglePS(double a)
        {
            double P, S;
            P = a * 3;
            S = (a * a * Math.Sqrt(3)) / 4;
            Console.WriteLine($"\na = {a}\nP = {P}\nS = {S}");
        }

        Console.WriteLine("\nЗадание 4");
        double a;
        Random rnd = new Random();
        for (int i = 0; i < 3; i++)
        {
            a = rnd.Next(1, 10);
            TrianglePS(a);
        }
    }
}