using System.Collections.Concurrent;
using System.Data;

public class Reference
{
    private string _book;
    private string _chapter;
    private string _verse;
    private string _endVerse;

    public Reference()
    {
        _book = "James";
        _chapter = "1";
        _verse = "5";
    }

    public Reference(string v2)
    {
        _book = "James";
        _chapter = "1";
        _verse = "5";
        _endVerse = $"-{v2}";
    }

    public string GetBook()
    {
        return _book;
    }

    public void SetBook(string book)
    {
        _book = book;
    }

    public string GetChapter()
    {
        return _chapter;
    }

    public void SetChapter(string chapter)
    {
        _chapter = chapter;
    }

    public string GetVerse()
    {
        return _verse;
    }

    public void SetVerse(string verse)
    {
        _verse = verse;
    }

    public string GetEndVerse()
    {
        return _endVerse;
    }

    public void SetEndVerse(string endVerse)
    {
        _endVerse = endVerse;
    }



    public string CompleteReference()
    {
        return $"{_book} {_chapter}:{_verse}{_endVerse}";
    }



}