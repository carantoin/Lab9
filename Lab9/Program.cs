using Lab9;

Console.Write("Введите цену товара:");
double c = double.Parse(Console.ReadLine());
Console.Write("Введите количество единиц товара:");
double a = double.Parse(Console.ReadLine());
Price price = new Price(c, a);
price.Print();