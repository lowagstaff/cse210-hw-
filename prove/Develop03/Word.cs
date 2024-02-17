using System.Formats.Asn1;

public class Word
{
    private List<char> _letters = new List<char>(); 

    private bool _cleared = false;


    public Word()
    {
        Scripture s = new Scripture();
        string text = s.ReturnString();
        char[] characters = text.ToCharArray();
        foreach (char character in characters)
        {
            _letters.Add(character);
        }
    }
    

    public string RemoveChars()
    {
        
        Random random = new Random();
        int random1 = random.Next(0, _letters.Count);
        int random2 = random.Next(0, _letters.Count);
        int random3 = random.Next(0, _letters.Count);
        int random4 = random.Next(0, _letters.Count);
        int random5 = random.Next(0, _letters.Count);
        int random6 = random.Next(0, _letters.Count);
        int random7 = random.Next(0, _letters.Count);
        int random8 = random.Next(0, _letters.Count);
        int random9 = random.Next(0, _letters.Count);
        int random10 = random.Next(0, _letters.Count);

        _letters[random1] = '_';
        _letters[random2] = '_';
        _letters[random3] = '_';
        _letters[random4] = '_';
        _letters[random5] = '_';
        _letters[random6] = '_';
        _letters[random7] = '_';
        _letters[random8] = '_';
        _letters[random9] = '_';
        _letters[random10] = '_';

        switch (_letters[random1])
        {
            case '_':
                _letters[random1++] = '_';
                break;
            default:
                if (_letters[random2] == '_')
                {
                    _letters[random2++] = '_';
                    _letters[random2--] = '_';
                }
                else if (_letters[random3] == '_')
                {
                    _letters[random3++] = '_';
                    _letters[random2--] = '_';
                }
                else if (_letters[random4] == '_')
                {
                    _letters[random4++] = '_';
                    _letters[random2--] = '_';
                }
                else if (_letters[random5] == '_')
                {
                    _letters[random5++] = '_';
                    _letters[random2--] = '_';
                }

                break;

        }

        var mystring = new string(_letters.ToArray());

        if (mystring == "_______________________________________________________________________________________________________________________________")
        {
            _cleared = true;
            Environment.Exit(0);
        }

        return mystring;
    }

}