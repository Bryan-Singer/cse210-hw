using System;

public class Refrence
{
    public int _chapter;
    public int _verseStart;
    public string _book;
    public int _verseEnd;
    public Refrence (string book, int chapter, int verseStart, int verseEnd)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verseStart;
        _verseEnd = verseEnd;
    }
    public Refrence(string book, int chapter, int verseStart)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verseStart;
    }
    public void displayInfo()
    {

    }
}