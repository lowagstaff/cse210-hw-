using System.Security.Cryptography.X509Certificates;

public class Video
{

    public List<string> _videos = new List<string>();
    public string[] _title = new string[]
    {
        "Going Fishing for Salmon!!!",
        "Eating at a 10 Star Restaurant",
        "Can I Wrestle a Bear!?",
        "Hospital Visit After Wrestling a Bear",
    };
    public string[] _aurthor = new string[]
    {
        "Biggie Cheese",
        "Grande Guy",
        "Mr. Bear",
        "Fishing Meister",
    };

    public string[] _length = new string[]
    {
        "120 seconds",
        "200 seconds",
        "800 seconds",
        "60 seconds",
    };

    public void ReturnVideos()
    {
        string video1 = $"{_title[0]} by {_aurthor[0]} - {_length[0]}";
        _videos.Add(video1);
        string video2 = $"{_title[1]} by {_aurthor[1]} - {_length[1]}";
        _videos.Add(video2);
        string video3 = $"{_title[2]} by {_aurthor[2]} - {_length[2]}";
        _videos.Add(video3);
        string video4 = $"{_title[3]} by {_aurthor[3]} - {_length[3]}";
        _videos.Add(video4);


    }


    public void ReturnVideo()
    {

        List<string> comments = new List<string>();
        Comments c = new Comments();
        comments.Add(c.GetComment());
        comments.Add(c.GetComment());
        comments.Add(c.GetComment());
        comments.Add(c.GetComment());

            Console.WriteLine($"The number of comments is {comments.Count}");

            foreach (string comment in comments)
            {
                Console.Write("-");
                Console.WriteLine(comment);
            }            
    
    }
    public void ReturnVideo2()
    {

        List<string> comments = new List<string>();
        Comments c = new Comments();
        comments.Add(c.GetComment());
        comments.Add(c.GetComment());
        comments.Add(c.GetComment());
        comments.Add(c.GetComment());

        Console.WriteLine($"The number of comments is {comments.Count}");

        foreach (string comment in comments)
        {
            Console.Write("-");
            Console.WriteLine(comment);
        }        

    }
    public void ReturnVideo3()
    {

        List<string> comments = new List<string>();
        Comments c = new Comments();
        comments.Add(c.GetComment());
        comments.Add(c.GetComment());
        comments.Add(c.GetComment());
        comments.Add(c.GetComment());

        Console.WriteLine($"The number of comments is {comments.Count}");

        foreach (string comment in comments)
        {
            Console.Write("-");
            Console.WriteLine(comment);
        }        

        
    }
    public void ReturnVideo4()
    {


        List<string> comments = new List<string>();
        Comments c = new Comments();
        comments.Add(c.GetComment());
        comments.Add(c.GetComment());
        comments.Add(c.GetComment());
        comments.Add(c.GetComment());

        Console.WriteLine($"The number of comments is {comments.Count}");

        foreach (string comment in comments)
        {
            Console.Write("-");
            Console.WriteLine(comment);
        }        

    }   
}