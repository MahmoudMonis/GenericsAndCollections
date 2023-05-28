using System;
using System.Collections.Generic;
using Readings;

class Program
{
    private const string Name = "Mahmoud Taha";

    static void Main(string[] args)
    {
        List<int> intList = new List<int>();
        List<string> stringList = new List<string>();
        List<Employee> employeeList = new List<Employee>();

        // Add items
        intList.Add(10);
        intList.Add(20);

        stringList.Add("Mahmoud");
        stringList.Add("cristiano");

        employeeList.Add(new Employee(1, "Mahmoud Taha"));
        employeeList.Add(new Employee(2, "cristiano ronaldo"));

        // Get items
        Console.WriteLine("Int List:");
        foreach (int number in intList)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("\nString List:");
        foreach (string name in stringList)
        {
            Console.WriteLine(name);
        }

        Console.WriteLine("\nEmployee List:");
        foreach (Employee employee in employeeList)
        {
            Console.WriteLine($"ID: {employee.Id}, Name: {employee.Name}");
        }

        // Delete items
        intList.Remove(20);
        stringList.Remove("Mahmoud");
        employeeList.RemoveAll(e => e.Id == 2);

        Console.WriteLine("\nAfter deletion:");

        Console.WriteLine("Int List:");
        foreach (int number in intList)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("\nString List:");
        foreach (string name in stringList)
        {
            Console.WriteLine(name);
        }

        Console.WriteLine("\nEmployee List:");
        foreach (Employee employee in employeeList)
        {
            Console.WriteLine($"ID: {employee.Id}, Name: {employee.Name}");
        }

        // Clear all items
        intList.Clear();
        stringList.Clear();
        employeeList.Clear();

        Console.WriteLine("\nAfter clearing all items:");

        Console.WriteLine("Int List:");
        foreach (int number in intList)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("\nString List:");
        foreach (string name in stringList)
        {
            Console.WriteLine(name);
        }

        Console.WriteLine("\nEmployee List:");
        foreach (Employee employee in employeeList)
        {
            Console.WriteLine($"ID: {employee.Id}, Name: {employee.Name}");
        }
    }
}
