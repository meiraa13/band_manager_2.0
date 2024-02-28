Episode ep1 = new(1, "teste", 20);
ep1.AddGuest("alcione, keila");


Episode ep2 = new(1, "teste2", 20);
ep2.AddGuest("marcelo");

Podcast podcast1 = new("Primeiro podcast", "Eduardo");
podcast1.AddEpisode(ep1);
podcast1.AddEpisode(ep2);
podcast1.ShowDetail();