using System;

public class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Position { get; set; }
    // Дополнительные свойства резюме

    public static EmployeeBuilder CreateBuilder()
    {
        return new EmployeeBuilder();
    }
}

public class EmployeeBuilder
{
    private Employee employee;

    public EmployeeBuilder()
    {
        employee = new Employee();
    }

    public EmployeeBuilder WithName(string name)
    {
        employee.Name = name;
        return this;
    }

    public EmployeeBuilder WithAge(int age)
    {
        employee.Age = age;
        return this;
    }

    public EmployeeBuilder WithPosition(string position)
    {
        employee.Position = position;
        return this;
    }

    // Дополнительные методы для установки других свойств резюме

    public static implicit operator Employee(EmployeeBuilder builder)
    {
        return builder.employee;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        EmployeeBuilder builder = Employee.CreateBuilder();
        Employee employee = builder
            .WithName("John Doe")
            .WithAge(30)
            .WithPosition("Software Engineer")
            // Вызов дополнительных методов для установки других свойств резюме
            ;

        // Можно использовать объект employee без явного вызова метода Build()
        Console.WriteLine($"Name: {employee.Name}, Age: {employee.Age}, Position: {employee.Position}");
    }
}

