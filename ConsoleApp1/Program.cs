// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World 1!");
Console.WriteLine("Hello, World 2!");
Console.WriteLine("Hello, World 3!");

static double getAvarage(double[] tab)
{
    double avarage = 0, sum = 0;
    for (int i = 0; i < tab.Length - 1; i++)
    {
        sum += tab[i];

    }
    avarage = sum / tab.Length;
    return avarage;
}