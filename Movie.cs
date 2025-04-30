public class Movie
{
    public string title { get; set; }
    public string director { get; set; }
    public List<string> Starts { get; set; }
    public string description { get; set; }

    public Movie(string title, string director, List<string> starts, string description)
    {
        this.title = title;
        this.director = director;
        this.Starts = starts;
        this.description = description;
    }
}