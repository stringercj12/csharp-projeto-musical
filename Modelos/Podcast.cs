class Podcast
{

    public Podcast(string nome, string host)
    {
        Nome = nome;
        Host = host;
    }
    public string Nome { get; }
    public string Host { get; }

    public int TotalEpisodios => episodios.Count;
    List<Episodio> episodios = new List<Episodio>();

    public void AdicionarEpisodios(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Podcast {Nome} apresentado por {Host}\n");

        Console.WriteLine("Episódios: \n");

        foreach (var episodio in episodios.OrderBy(e => e.Ordem))
        {
            Console.WriteLine(episodio.Resumo);
        }

        Console.WriteLine($"\n\nEste podcast possui: {TotalEpisodios} episódios.");

    }
}