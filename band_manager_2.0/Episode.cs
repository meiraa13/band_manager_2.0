class Episode
{
    private List<string> Guests = [];
    public int EpisodeNumber { get;  }
    public string Title {  get;  }
    public int Duration {  get; }
    public string Overview => $"Episódio número:{EpisodeNumber} - {Title}({Duration})" +
        $"Convidados:{string.Join(",", Guests)}";
    public Episode(int episodeNumber, string title, int duration)
    {
        EpisodeNumber = episodeNumber;
        Title = title;
        Duration = duration;
    }



    public void AddGuest(string guest)
    {
        Guests.Add(guest);
    }
}