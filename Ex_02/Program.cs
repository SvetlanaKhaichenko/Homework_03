int[] isk(string a, int[] x)
{
    a = a.Replace(" ", "");
    string[] mas1 = a.Split(",");
    int[] mas = new int[mas1.Length];
    for (int i = 0; i < mas1.Length; i++)
    {
        mas[i] = Convert.ToInt32(mas1[i]);
    }
    return mas;
}

Console.WriteLine("Введите координаты первой точки через запятую");
int[] Mas1 = new int[3];
Mas1 = isk (Console.ReadLine(), Mas1);


Console.WriteLine("Введите координаты второй точки через запятую");
int[] Mas2 = new int[3];
Mas2 = isk(Console.ReadLine(), Mas2);
double result = Math.Sqrt(Math.Pow((Mas1[0] - Mas2[0]), 2) + Math.Pow((Mas1[1] - Mas2[1]), 2) + Math.Pow((Mas1[2] - Mas2[2]), 2));
System.Console.WriteLine(result);