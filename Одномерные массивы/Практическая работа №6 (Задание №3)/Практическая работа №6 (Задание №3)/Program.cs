int n;
Console.WriteLine("Введите число элементов массива");
n = Convert.ToInt16(Console.ReadLine());
double[] a = new double[n];
int i = 0;
while (i < n)
{
    Console.WriteLine("Введите элемент массива");
    a[i] = double.Parse(Console.ReadLine());
    Console.WriteLine();
    i++;
}
double min = 0;
double max = 0;
for (i = 0; i < n; i++)
{
    if (min > a[i])
    {
        min = i;
    }
    if (max < a[i])
    {
        max = i;
    }
}
if (max < min)
{
    max += min;
    min = max - min;
    max = max - min;
}
for (i = min + 1; i < min + (max - min); ++i)
{
    a[i] = 0;
}
for (i=0; i < n; i = i + 1)
{
    Console.WriteLine("Элемент[" + i + "]:" + a[i]);
}