using ReflectionDemo;

var reflection = typeof(Person);
var constructors = reflection.GetConstructors();
foreach (var c in constructors)
{
    Console.Write($"{c.Name} : ");
    foreach (var p in c.GetParameters())
    {
        Console.WriteLine($"\t{p.Position} - {p.Name}");
    }
    Console.WriteLine();
}