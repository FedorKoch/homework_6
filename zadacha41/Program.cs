Console.Clear();
int k = 0;
int n = int.Parse(Console.ReadLine());
int [] mas = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
for (int i = 0; i < mas.Length; i++)
{ 
    if (mas[i] > 0)
    k = k + 1;
}
Console.WriteLine();
Console.WriteLine("положительных чисел");
Console.WriteLine(k);