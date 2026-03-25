using System;

class Program
{
    static long ExtendedGcd(long a, long b, out long x, out long y)
    {
        if (b == 0)
        {
            x = 1;
            y = 0;
            return a;
        }

        long gcd = ExtendedGcd(b, a % b, out long x1, out long y1);

        x = y1;
        y = x1 - (a / b) * y1;

        return gcd;
    }

    static void Main()
    {

         Console.WriteLine("Иванова Ирина Геннадьевна");
        Console.WriteLine("Группа: 09.03.04-РПИб-о25");
        Console.WriteLine("1 курс");
        Console.WriteLine();

        // Для ручного тестирования - с подсказками
        // Для сдачи в систему - закомментируйте DEBUG или удалите подсказки
#if DEBUG
        Console.Write("Введите a и n через пробел: ");
#endif

        string[] input = Console.ReadLine().Split();
        long a = long.Parse(input[0]);
        long n = long.Parse(input[1]);

        long x, y;
        long gcd = ExtendedGcd(a, n, out x, out y);

        if (gcd != 1)
        {
#if DEBUG
            Console.Write("Обратного элемента нет (ответ: ");
            Console.Write(0);
            Console.WriteLine(")");
#else
            Console.WriteLine(0);
#endif
        }
        else
        {
            long result = x % n;
            if (result < 0) result += n;

#if DEBUG
            Console.Write("Обратный элемент: ");
            Console.WriteLine(result);
#else
            Console.WriteLine(result);
#endif
        }

#if DEBUG
        Console.WriteLine("Нажмите любую клавишу для выхода...");
        Console.ReadKey();
#endif
    }
}
