public class Scripture
{
    private List<string> _words = new List<string>();
    private string _text = "If any of you lack wisdom, let him ask of God, that giveth to all men liberally, and upbraideth not; and it shall be given him.";
    private Reference _reference = new Reference();

    public Scripture()
    {
        _reference = new Reference();
        _reference.CompleteReference();
        string[] splitText = _text.Split(' ');
        foreach (string split in splitText)
        {
            _words.Add(split);
        }
    }

    public string ReturnString()
    {
        return $"{string.Join(" ", _words)}";
    }

    public string ReturnScripture()
    {
        return $"{_reference.CompleteReference()} {string.Join(" ", _words)}";
    }

    
}