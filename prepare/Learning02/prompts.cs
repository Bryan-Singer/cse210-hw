using System;
using System.Formats.Asn1;
using System.IO;
using System.Threading.Tasks.Dataflow;
using System.Collections.Generic;
using System.Security.Cryptography;

public class Prompts
{

    static string[] questions = new string[]
    {
        """  
        Who was the most interesting person I interacted with today?,
        What was the best part of my day?,
        How did I see the hand of the Lord in my life today?,
        What was the strongest emotion I felt today?,
        If I had one thing I could do over today, what would it be?
        """
    }

    static Random numbergenerator = new Random();
    int number = numbergenerator.Next(questions.Length);

    public void newquestion()
    {


        Console.WriteLine(questions[number]);
        string written_entry = Console.ReadLine();
    }
}