int n;
Console.WriteLine("Напишите кол-во чисел: ");
n = Convert.ToInt32(Console.ReadLine());
int[] M = new int[n];
Console.WriteLine("Напишите числа: ");
for (int i = 0; i < M.Length; i++)
{
    M[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Выбран  массив" + "[" + string.Join(", ", M) + "]");
int count = 0;
for (int i = 0; i < M.Length; i++)
{
    if (M[i] > 0)
    {
        count++;    
    }
}
Console.WriteLine($"Количество чисел больше нуля равно {count}"); 