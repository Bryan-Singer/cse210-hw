using System;
using System.IO;
using System.Collections.Generic;

public class Journal
{

    public void Write()
    {
        Prompts prompt = new Prompts();
        prompt.newquestion();
    }
    public void Display()
    {
        string file = "records.txt";
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split("--");

            Console.WriteLine($"{line}");
        }
    }
    public void load()
    {

    }









}