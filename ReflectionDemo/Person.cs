namespace ReflectionDemo;

public class Person
{
    public string Name { get; set; }
    public int age;

    public Person()
    {
    }

    public Person(int age, string name)
    {
        this.age = age;
        Name = name;
    }
}