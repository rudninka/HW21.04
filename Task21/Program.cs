// Найти расстояние между точками в 3D пространстве
Console.WriteLine("Введите координаты первой точки: ");
int X1 = int.Parse(Console.ReadLine());
int Y1 = int.Parse(Console.ReadLine());
int Z1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки: ");
int X2 = int.Parse(Console.ReadLine());
int Y2 = int.Parse(Console.ReadLine());
int Z2 = int.Parse(Console.ReadLine());
int length = (int) Math.Pow(X2-X1,2) + (int) Math.Pow(Y2-Y1,2) + (int) Math.Pow(Z1-Z2,2);
double result = Math.Round(Math.Sqrt(length), 2);
Console.WriteLine($" Расстояние между двумя точками равно {result}");