using System;

namespace EmployeeHR
{
    public class Employee
    {
        public string Name { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Street { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;

        public void Read()
        {
            Console.Write("Enter name: ");
            Name = Console.ReadLine();
            Console.Write("Enter last name: ");
            LastName = Console.ReadLine();
            Console.Write("Enter street: ");
            Street = Console.ReadLine();
            Console.Write("Enter city: ");
            City = Console.ReadLine();
        }

        public void Show()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Last Name: {LastName}");
            Console.WriteLine($"Street: {Street}");
            Console.WriteLine($"City: {City}");
        }
    }

    public class HR : Employee
    {
        public string Education { get; set; } = string.Empty;
        public string BusinessRole { get; set; } = string.Empty;

        public void Read1()
        {
            base.Read();
            Console.Write("Enter education: ");
            Education = Console.ReadLine();
            Console.Write("Enter business role: ");
            BusinessRole = Console.ReadLine();
        }

        public void Show1()
        {
            base.Show();
            Console.WriteLine($"Education: {Education}");
            Console.WriteLine($"Business Role: {BusinessRole}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            HR hr = new HR();
            hr.Read1();
            hr.Show1();
            Console.ReadLine();
        }
    }
}