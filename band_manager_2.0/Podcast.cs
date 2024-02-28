class Podcast
{
    public List<Episode> Episodes = [];
    public string Name { get; }
    public string Host { get; }
    public int TotalEpisodes => Episodes.Count;

    public Podcast(string name, string host)
    {
        this.Name = name;
        this.Host = host;
    }

    public void AddEpisode(Episode episode)
    {   
        Episodes.Add(episode);
    }

    public void ShowDetail()
    {
        Console.WriteLine($"Podcast {Name} - Apresentado por {Host}\n");
        foreach(var episode in Episodes.OrderBy(ep=> ep.EpisodeNumber))
        {
            Console.WriteLine($"{episode.Overview}");
        }
        Console.WriteLine($"Total de episódios {TotalEpisodes}");

    }

}