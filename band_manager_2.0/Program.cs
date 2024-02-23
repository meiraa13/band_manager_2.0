Album QueenAlbum = new("A night at the opera");

Band queen = new("Queen");

Music music1 = new(queen, "Love of my life")
{
    Duration = 213,
    Available = true,
};

Music music2 = new(queen, "Bohemian Rhapsody")
{
    Duration = 315,
    Available = false,
};

music1.ShowInfo();
queen.AddAlbum(QueenAlbum);
queen.ShowDiscography();

QueenAlbum.AddMusic(music1);
QueenAlbum.AddMusic(music2);
QueenAlbum.ShowAlbumMusic();

