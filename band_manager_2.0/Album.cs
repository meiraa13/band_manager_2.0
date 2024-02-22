class Album
{
    private List<Music> musics = [];
    public string Name { get; set; }
    public int TotalTime => musics.Sum(music => music.Duration);
    public void AddMusic(Music music)
    {
        musics.Add(music);
    }

    public void ShowAlbumMusic()
    {
        Console.WriteLine($"Lista de músicas do album {this.Name}\n");
        foreach(var music in musics)
        {
            Console.WriteLine($"Música: {music.Name}");
        }
        Console.WriteLine($"\nTempo de duração do album: {TotalTime}");
    }
}