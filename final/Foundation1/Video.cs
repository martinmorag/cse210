public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public int _numberOfComments;

    public List<Video> _theList = new List<Video>();

    public void Insert(string title, string author, int length, int number)
    {
        Video video = new Video();
        video._title = title;
        video._author = author;
        video._length = length;
        video._numberOfComments = number;
        _theList.Add(video);
    }
    public void Display()
    {
        Console.WriteLine($"\n{_title} by {_author} has a lenght of {_length} seconds.");
        Console.WriteLine($"This video has {_numberOfComments} comments.\n");
    }
    public void DisplayIt()
    {
        foreach(Video video in _theList)
        {
            video.Display();
        }
    }
}