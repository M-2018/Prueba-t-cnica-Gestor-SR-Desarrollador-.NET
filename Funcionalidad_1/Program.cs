using System;
using System.Collections.Generic;
using System.Linq;

public interface IMediaAgent
{
    double GetMedia(List<double> data);
}

public class AritmeticaAgent : IMediaAgent
{
    public double GetMedia(List<double> data)
    {
        double media = data.Sum() / data.Count;
        Console.WriteLine($"Media Aritmética: {media}");
        return media;
    }
}

public class HarmonicaAgent : IMediaAgent
{
    public double GetMedia(List<double> data)
    {
        double media = 0;
        foreach (var number in data)
        {
            media += 1 / number;
        }
        media = data.Count / media;
        Console.WriteLine($"Media Harmonica: {media}");
        return media;
    }
}

public class MedianaAgent : IMediaAgent
{
    public double GetMedia(List<double> data)
    {
        data.Sort();
        int n = data.Count;

        double mediana;
        if (n % 2 == 0)
        {
            mediana = (data[n / 2 - 1] + data[n / 2]) / 2.0;
        }
        else
        {
            mediana = data[n / 2];
        }

        Console.WriteLine($"Mediana: {mediana}");
        return mediana;
    }
}

class Program
{
    static void Main()
    {
        List<double> data = new List<double> { 4, 2, 8, 6, 7, 3, 1, 5 };

        AritmeticaAgent aritmeticaAgent = new AritmeticaAgent();
        HarmonicaAgent harmonicaAgent = new HarmonicaAgent();
        MedianaAgent medianaAgent = new MedianaAgent();

        double aritmeticmedia = aritmeticaAgent.GetMedia(data);
        double harmonicmedia = harmonicaAgent.GetMedia(data);
        double median = medianaAgent.GetMedia(data);

        Console.ReadLine();
    }
}
