using System

class Program
{
    static void Main(string[] args)
    {
        /*Simple loop*/
        string response = "yes";

        while (response == "yes")
        {
            Console.Write("Do you want to continue? ");
            response = Console.ReadLine();
        }


        /*This loop works the same as a while loop, with the exception that the
        body of the loop runs once first, before the check is made for the 
        first time. This means that the body of the loop is guaranteed to run 
        at least once.*/

        string response;

        do
        {
            Console.Write("Do you want to continue? ");
            response = Console.ReadLine();
        } while (response == "yes");


        /*The standard for loop in C# is more like a "for x in range" loop in
        Python. The condition has three parts, separated by semi-colons. The 
        first initializes the value, the second is the condition to check, and
        the third is an increment step that is run at the end of each loop.
        
        The following code shows the syntax of a for loop that counts from 0 to
        9.*/
        for (int i = 0; i < 10; i++) /*"++" increments the value by 1*/
        {
            Console.WriteLine(i);
        }


        /*Another C# loop much like a "for i in list" loop in Python*/
        foreach (string color in colors)
        {
            Console.WriteLine(color);
        }


        /*Random number generator*/
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);


        /* Guessing Game (1) */
        Console.Write("What is the magicc number? ");
        string magic_number = Console.ReadLine();
        string number_guess = null;
        while (number_guess != magic_number)
        {
            console.Write("What is your guess: ")
            number_guess = console.ReadLine();
            if (number_guess > magic_number)
            {
                console.WriteLine("Lower")
            }
            else if (number_guess < magic_number)
            {
                console.WriteLine("Higher")
            }
            else
            {
                console.WriteLine("You guessed it!")
            }
        }
    }
}