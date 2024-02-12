using System;
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
            Console.WriteLine("Przekątna prostokąta o długości "+a+" i szerokości "+b+" wyniesie: "+diagonal);
        }
    }
}