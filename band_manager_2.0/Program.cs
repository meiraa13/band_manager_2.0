Album QueenAlbum = new Album();
QueenAlbum.Name = "A night at the opera";

Music music1 = new Music();
music1.Name = "Love of my life";
music1.Duration = 213;

Music music2 = new Music();
music2.Name = "Bohemian Rhapsody";
music2.Duration = 420;

QueenAlbum.AddMusic(music1);
QueenAlbum.AddMusic(music2);

QueenAlbum.ShowAlbumMusic();