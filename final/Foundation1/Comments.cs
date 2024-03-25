public class Comments
{
    public string[] _comments = new string[]
    {
        "I really enjoyed the video.",
        "I LOVED this!!!",
        "How did they do that!?!?",
        "What a great video!",
        "I can't wait for the next episode.",
        "I would love to do this!!!",
        "This is my favorite video.",
    };

    public string[] _names = new string[]
    {
        "Wesley",
        "Samantha",
        "Tegan",
        "Alyssa",
        "Natalie",
        "Megan",
        "Melissa",
    };

    public string GetRandomComment()
    {
        Random randomGenerator = new Random();
        int randomIndex = randomGenerator.Next(0, _comments.Length);
        string randomComment = _comments[randomIndex];
        return randomComment;
    }

    public string GetRandomUser()
    {
        Random randomgenerator = new Random();
        int randomIndex = randomgenerator.Next(0, _names.Length);
        string randomName = _names[randomIndex];
        return randomName;
    }

    public string GetComment()
    {
        return GetRandomComment() + " - " + GetRandomUser();
    }
}