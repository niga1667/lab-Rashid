using System;

class Student
{
    public string Name;
    public int Age;

    public Student() 
    {
        Name = "Неизвестно";
        Age = 0;
    }

    public Student(string name, int age) 
    {
        Name = name;
        Age = age;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Имя: {Name}, Возраст: {Age}");
    }

    public void ShowInfo(string prefix)
    {
        Console.WriteLine($"{prefix}: {Name}, {Age} лет");
    }
}

class Program
{
    static void Main()
    {
        Student s1 = new Student();
        Student s2 = new Student("Рашид", 18);

        s1.ShowInfo();
        s2.ShowInfo("Информация о студенте");
    }
}
