using System;
using System.Formats.Asn1;
using System.IO;
using System.Threading.Tasks.Dataflow;
using System.Reflection.Metadata;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

public class Prompts
{

    static string[] questions = new string[]
    {
        "Who was the most interesting person I interacted with today? ",
        "What was the best part of my day? ",
        "How did I see the hand of the Lord in my life today? ",
        "What was the strongest emotion I felt today? ",
        "If I had one thing I could do over today, what would it be? "
        
    };

    static Random numbergenerator = new Random();
    int number = numbergenerator.Next(questions.Length);

    public void newquestion()
    {
        DateTime current_time = DateTime.Now;

        string date_text = current_time.ToShortDateString();


        Console.WriteLine(questions[number]);
        string written_entry = Console.ReadLine();

        string journal_entry = $"{date_text} {questions[number]} {written_entry}--";

        List<string> list_entry = new List<string>();
        list_entry.Add(journal_entry);

        string saving_file = "records.txt";
        using (StreamWriter new_text = File.AppendText(saving_file))
        {
            new_text.Write($"{list_entry[0]}\n");
        } 
    }
}