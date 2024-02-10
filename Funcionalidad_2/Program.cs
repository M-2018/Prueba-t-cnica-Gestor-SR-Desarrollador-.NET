using System;

public class Escalera
{
    public static string GetStaircaseA(int n)
    {
        if (n <= 0 || n >= 100)
        {
            throw new ArgumentException("El tamaño de la escalera debe estar en el rango 0 < n < 100.");
        }

        string staircase = "";
        for (int i = 1; i <= n; i++)
        {
            string spaces = new string(' ', n - i);
            string symbols = new string('#', i);
            staircase += spaces + symbols + "\n";
        }

        return staircase;
    }

    public static string GetStaircaseB(int n)
    {
        if (n <= 0 || n >= 100)
        {
            throw new ArgumentException("El tamaño de la escalera debe estar en el rango 0 < n < 100.");
        }

        string staircase = "";
        for (int i = n; i >= 1; i--)
        {
            string spaces = new string(' ', n - i);
            string symbols = new string('#', i);
            staircase += spaces + symbols + "\n";
        }

        return staircase;
    }

    public static string GetStaircaseC(int n)
    {
        if (n <= 0 || n >= 100)
        {
            throw new ArgumentException("El tamaño de la escalera debe estar en el rango 0 < n < 100.");
        }

        string staircase = "";
        for (int i = 1; i <= n; i++)
        {
            string spaces = new string(' ', n - i);
            string symbols = new string('#', 2 * i - 1);
            staircase += spaces + symbols + "\n";
        }

        for (int i = n - 1; i >= 1; i--)
        {
            string spaces = new string(' ', n - i);
            string symbols = new string('#', 2 * i - 1);
            staircase += spaces + symbols + "\n";
        }

        return staircase;
    }

    public static void Main()
    {
        Console.WriteLine("Escalera A:\n" + GetStaircaseA(4));
        Console.WriteLine("Escalera B:\n" + GetStaircaseB(4));
        Console.WriteLine("Escalera C:\n" + GetStaircaseC(4));
    }
}
