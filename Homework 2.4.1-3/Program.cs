using System;
using System.Diagnostics;
namespace DanePracownika
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name = "Filip";
            string Surname = "Kazimierczak";
            int Age = 42;
            char Sex = 'm';
            uint PersonalIdentificationNumber = 123456789;
            string EmployeeId = "2509324094";

            Console.WriteLine("Imię: " + Name);
            Console.WriteLine("Nazwisko: " + Surname);
            Console.WriteLine("Wiek: " + Age);
            Console.WriteLine("Płeć: " + Sex);
            Console.WriteLine("Pesel: " + PersonalIdentificationNumber);
            Console.WriteLine("Numer Pracownika: " + EmployeeId);
            Console.ReadLine();

            char first = 'A';
            char second = 'B';
            char third = 'C';
            Console.WriteLine(third);
            Console.WriteLine(second);
            Console.WriteLine(first);
            Console.ReadLine();

            double a = 5;
            double b = 6;
            double diagonal = Math.Sqrt((Math.Pow(a, 2) + Math.Pow(b, 2)));
            Console.WriteLine("Przekątna prostokąta o długości " + a + " i szerokości " + b + " wyniesie: " + diagonal);
            Console.ReadLine();

            int g;
            string h;
            double l;

            Console.WriteLine(g = 10);
            Console.WriteLine(h = "Szkoła Dotneta");
            Console.WriteLine(l = 12.5);
            Console.ReadLine();

            Console.WriteLine("Welcome in our Population Survey! ");
            Console.WriteLine("Let me ask you couple of questions, please make sure you answer all of them");
            Console.WriteLine("Your answers will let us analyze demographic characteristics of the population");
            Console.WriteLine("PLease enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine($"Dear {name} please enter your surname now: ");
            string surname = Console.ReadLine();
            Console.WriteLine($"Dear {name} {surname} please enter your email address:");
            string email = Console.ReadLine();
            Console.WriteLine($"Dear {name} {surname} please enter your phone number:");
            string phone = Console.ReadLine();
            Console.WriteLine($"Dear {name} {surname} please enter your height in cms:");
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine($"Dear {name} {surname} please enter your weight in kgs:");
            double weight = double.Parse(Console.ReadLine());
            Console.WriteLine($"--------------------------------------------------------");
            Console.WriteLine($"Dear {name} {surname} thank you for your contribution!");













        }
    }
}