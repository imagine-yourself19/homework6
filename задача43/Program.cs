double b1, k1, b2, k2, x, y;
Console.WriteLine("Введите число b1");
b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число k1");
k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число b2");
b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число k2");
k2 = Convert.ToDouble(Console.ReadLine());
// Приравниваем правые части уравнений друг к другу чтобы получить  x: 
// k1 * x + b1 = k2 * x + b2;
x = (b2 - b1) / (k1 - k2);
// Подставляем х в любое из уравнений, чтобы получить y:
y = k1 * (b2 - b1) / (k1 - k2) + b1;
Console.WriteLine($"Координаты точки пересечения двух прямых равна {(x, y)}");