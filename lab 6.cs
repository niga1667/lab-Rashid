using System;

class Student
{
    public string Name;
    public int Age;
    public string Group;

    public void Print()
    {
        Console.WriteLine($"Имя: {Name}, Возраст: {Age}, Группа: {Group}");
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student();
        s.Name = "Рашид";
        s.Age = 18;
        s.Group = "ИСИТ-о-24/4";
        s.Print();
    }
}
