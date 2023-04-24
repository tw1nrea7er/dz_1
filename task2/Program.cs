// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
    Console.Write("Введите первое число: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе число: ");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите третье число: ");
    int c = Convert.ToInt32(Console.ReadLine());
    int max = 0;
    if ((a >= b) && (a >= c))
    {
        max = a;
        Console.WriteLine($"максимальное число из двух: {max}");
    }
    else if ((b >= a) && (b >= c))
    {
        max = b;
        Console.WriteLine($"максимальное число из двух: {max}");
    }
    else if ((c >= a) && (c >= b)) 
    {
        max = c;
        Console.WriteLine($"максимальное число из двух: {max}");
    }
