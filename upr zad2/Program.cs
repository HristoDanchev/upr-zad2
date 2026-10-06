using upr_zad2;

Console.WriteLine("Hello, World!");
Console.WriteLine("=== ДЕМОНСТРАЦИЯ НА ПРАВОЪГЪЛНИК ===");

Rectangle r1 = new Rectangle();
Console.WriteLine($"Правоъгълник 1 (по подразбиране): Лице = {r1.GetArea()}");

Rectangle r2 = new Rectangle(5.5, 4);
Console.WriteLine($"Правоъгълник 2 (5.5 x 4): Лице = {r2.GetArea()}");

Rectangle r3 = new Rectangle(-3, 0);
Console.WriteLine($"Правоъгълник 3 (невалиден -3 x 0): Лице = {r3.GetArea()}");


Console.WriteLine("\n=== ДЕМОНСТРАЦИЯ НА КРЪГ ===");

Circle c1 = new Circle();
Console.WriteLine($"Кръг 1 (по подразбиране): Лице = {c1.GetArea():F2}");

Circle c2 = new Circle(3);
Console.WriteLine($"Кръг 2 (r = 3): Лице = {c2.GetArea():F2}");

Circle c3 = new Circle(-5);
Console.WriteLine($"Кръг 3 (невалиден r = -5): Лице = {c3.GetArea():F2}");
        