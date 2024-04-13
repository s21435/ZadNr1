// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World 1!");
Console.WriteLine("Hello, World 2!");
Console.WriteLine("Hello, World 3!");

static double getAvarage(int[] tab)
{
    double avarage = 0, sum = 0;
    for (int i = 0; i < tab.Length - 1; i++)
    {
        sum += tab[i];

    }
    avarage = sum / tab.Length;
    return avarage;
}
int[] tab = [1,2,3,4,5,6,7,8,9,9];
Console.WriteLine(getAvarage(tab));

static int getMax(int[] tab)
{
    int max = tab[0];
    for (int i = 0; i < tab.Length - 1; i++)
    {
        int a = 0;
        if (tab[i] > max)
            max = tab[i];
    }
    return max;
}
