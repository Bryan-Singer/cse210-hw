using System;

class Program
{
    static void Main(string[] args)
    {

        /*Personal Solution*/
        int grade = 71;

        if (grade < 90)
        {
            if (grade < 80)
            {
                if (grade < 70)
                {
                    if (grade < 60) 
                    {
                        Console.WriteLine("Your grade is an F");
                    }
                    else
                    {
                        if ((grade % 10) < 7)
                        {
                            if ((grade % 10) < 3)
                            {
                                Console.WriteLine("Your grade is an D-");
                            }
                            else
                            {
                                Console.WriteLine("Your grade is an D");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Your grade is an D+");
                        }
                    }
                }
                else
                {
                    if ((grade % 10) < 7)
                        {
                            if ((grade % 10) < 3)
                            {
                                Console.WriteLine("Your grade is an C-");
                            }
                            else
                            {
                                Console.WriteLine("Your grade is an C");
                            }
                        }
                    else
                    {
                        Console.WriteLine("Your grade is an C+");
                    }
                }
            }
            else
            {
                if ((grade % 10) < 7)
                    {
                        if ((grade % 10) < 3)
                        {
                            Console.WriteLine("Your grade is an B-");
                        }
                        else
                        {
                            Console.WriteLine("Your grade is an B");
                        }
                    }
                else
                {
                    Console.WriteLine("Your grade is an B+");
                }
            }
        }
        else
        {
            if ((grade % 10) < 3)
                {
                    Console.WriteLine("Your grade is an A-");
                }
            else
            {
                Console.WriteLine("Your grade is an A");
            }
        }

        /*Sample Solution*/

        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");
        
        if (percent >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}