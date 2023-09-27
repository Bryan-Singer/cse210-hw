using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        int x;
        x = 6;
        Console.WriteLine(x);

        int y = 5;
        Console.WriteLine(y);

        Console.Write("What is your favorite color? ");
        string color = Console.ReadLine();
        Console.WriteLine($"{color}");

        if (x > y)
        {
            Console.WriteLine("Greater");
        }

        string school = "BYU-Idaho";
        Console.WriteLine($"I am studying at {school}.");

        Console.Write("What is your first name? ");
        string first_name = Console.ReadLine();
        Console.Write("What is your last name? ");
        string last_name = Console.ReadLine();
        Console.WriteLine($"Your name is {last_name}, {first_name} {last_name}.");

        string valueInText = "42";
        int number = int.Parse(valueInText);
        Console.WriteLine(number);


        Console.WriteLine("Hello Develop02 World!");
    }
}