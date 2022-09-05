double[] cubes(int a)
{
    double[] x = new double[a];
    for (int i = 0; i < a; i++)
    {
        x[i] = Math.Pow(i + 1, 3);
    }
    return x;
}

string output(double[] a)
{

    return string.Join(", ", a);
}

System.Console.WriteLine("Введите число: ");
int polz = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(output(cubes(polz)));