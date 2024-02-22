class Music
{
    public string Name {  get; set; }
    public string Artist {  get; set; }
    public int Duration {  get; set; }
    public bool Available { get; set; }
    // lambda ou "arrow function" servindo como getter
    public string BandDescription => $"A música {Name} pertence à banda {Artist}";


    public void ShowInfo()
    {
        Console.WriteLine($"Nome: {this.Name}");
        Console.WriteLine($"Artista: {this.Artist}");
        Console.WriteLine($"Duração: {this.Duration}");
        if (Available)
        {
            Console.WriteLine("Disponível no plano");
        }else
        {
            Console.WriteLine("Adquira o plano plus");
        }

    }

}