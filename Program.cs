// Screen Sound
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
// List<string> listaDasBandas = new List<string> { "U2", "The Beatles", "Calypso" };
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Linking Park", new List<int> { 10, 8, 6 });
bandasRegistradas.Add("The Beatles", new List<int>());

void ExibirLogo()
{
  Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
  Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu()
{
  ExibirLogo();
  Console.WriteLine("\nDigite 1 para registrar uma banda");
  Console.WriteLine("Digite 2 para mostrar todas as bandas");
  Console.WriteLine("Digite 3 para avaliar uma banda");
  Console.WriteLine("Digite 4 para exibir a média de uma banda");
  Console.WriteLine("Digite 0 para sair");
  Console.Write("\nDigite sua opção: ");
  int opcaoEscolhida = int.Parse(Console.ReadLine()!);

  switch (opcaoEscolhida)
  {
    case 1:
      Console.WriteLine("Você digitou a opção" + opcaoEscolhida);
      RegistrarBanda();
      break;
    case 2:
      Console.WriteLine("Você digitou a opção" + opcaoEscolhida);
      MostrarBandasRegistradas();
      break;
    case 3:
      Console.WriteLine("Você digitou a opção" + opcaoEscolhida);
      AvaliarUmaBanda();
      break;
    case 4:
      Console.WriteLine("Você digitou a opção" + opcaoEscolhida);
      ExibirMediaDasNotasDaBanda();
      break;
    case 0:
      Console.WriteLine("Saindo do programa...");
      break;
    default:
      Console.WriteLine("Opção inválida...");
      break;
  }
}

void RegistrarBanda()
{
  Console.Clear();
  ExibindoTituloDaOpcao("Registro de bandas");
  Console.Write("Digite o nome da banda que deseja registrar: ");
  string nomeDaBanda = Console.ReadLine()!;
  bandasRegistradas.Add(nomeDaBanda, new List<int>());
  Console.WriteLine($"\nA banda {nomeDaBanda} foi registrada com sucesso!");
  Thread.Sleep(2000);
  Console.Clear();
  ExibirOpcoesDoMenu();
}

void MostrarBandasRegistradas()
{
  Console.Clear();
  ExibindoTituloDaOpcao("Exibindo todas as bandas registradas");

  Console.WriteLine("Lista de bandas:\n");
  foreach (var banda in bandasRegistradas.Keys)
  {
    Console.WriteLine($"- {banda}");
  }

  Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
  Console.ReadKey();
  Console.Clear();
  ExibirOpcoesDoMenu();
}

void ExibindoTituloDaOpcao(string titulo)
{
  int quantidadeDeLetras = titulo.Length;
  string asteriscos = string.Empty.PadLeft(quantidadeDeLetras);
  Console.WriteLine(asteriscos);
  Console.WriteLine(titulo);
  Console.WriteLine(asteriscos + "\n");
}

void AvaliarUmaBanda()
{
  Console.Clear();
  ExibindoTituloDaOpcao("Avaliar banda");
  Console.WriteLine("Lista de bandas:\n");
  foreach (var banda in bandasRegistradas.Keys)
  {
    Console.WriteLine($"- {banda}");
  }
  Console.Write("\nDigite o nome da banda que deseja avaliar: ");
  string nomeDaBanda = Console.ReadLine()!;
  if (bandasRegistradas.ContainsKey(nomeDaBanda))
  {
    Console.Write($"Qual nota que a banda {nomeDaBanda} Merece: ");
    int nota = int.Parse(Console.ReadLine()!);
    bandasRegistradas[nomeDaBanda].Add(nota);
    Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}");
    Thread.Sleep(4000);
    Console.Clear();
    ExibirOpcoesDoMenu();
  }
  else
  {
    Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
    Console.WriteLine("\nDigite qualquer tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
  }

}

void ExibirMediaDasNotasDaBanda()
{
  Console.Clear();
  ExibindoTituloDaOpcao("Avaliar banda");

  Console.Write("\nDigite o nome da banda que deseja avaliar: ");
  string nomeDaBanda = Console.ReadLine()!;
  if (bandasRegistradas.ContainsKey(nomeDaBanda))
  {
    List<int> notasDaBanda = bandasRegistradas[nomeDaBanda];

    Console.WriteLine($"\nA média da banda {nomeDaBanda} é {notasDaBanda.Average()}.");
    Console.WriteLine("\nDigite qualquer tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
  }
  else
  {
    Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
    Console.WriteLine("\nDigite qualquer tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
  }
}

// ExibirOpcoesDoMenu();

Banda queen = new Banda("Queen");

Album albumDoQueen = new Album("A night at the opera");

Musica musica1 = new Musica(queen, "Love of my life")
{
  Duracao = 213,
  Disponivel = true
};

Musica musica2 = new Musica(queen, "Bohemian Rhapsody")
{
  Duracao = 354,
  Disponivel = false
};

albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);
queen.AdicionarAlbum(albumDoQueen);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
albumDoQueen.ExibirMusicasDoAlbum();
queen.ExibirDiscografia();

Console.WriteLine("\n\n----------- PODCAST -----------\n\n");


Episodio episodio1 = new Episodio(2, "Técnicas de facilitação", 45);
episodio1.AdicionarConvidados("Maria");
episodio1.AdicionarConvidados("Marcelo");

Episodio episodio2 = new Episodio(1, "Técnicas de aprendizado", 67);
episodio2.AdicionarConvidados("Fernando");
episodio2.AdicionarConvidados("Marcos");
episodio2.AdicionarConvidados("Flávia");

Podcast podcast1 = new Podcast("Podcast especial", "Jefferson");
podcast1.AdicionarEpisodios(episodio1);
podcast1.AdicionarEpisodios(episodio2);
podcast1.ExibirDetalhes();