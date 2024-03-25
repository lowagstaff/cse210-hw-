using System;

class Program
{
    static void Main(string[] args)
    {
        Video v = new Video();
        v.ReturnVideos();

        foreach (string vidoe in v._videos)
        {
            Console.WriteLine(vidoe);
            v.ReturnVideo2();
            Console.WriteLine();
        }
    }
}