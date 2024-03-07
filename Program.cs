using ScreenSound.Modelos;

Banda ira = new Banda("Ira!");
ira.AdicionarNota(10);
ira.AdicionarNota(8);
ira.AdicionarNota(6);
Banda beatles = new("The Beatles");

Dictionary<string, Banda> bandasRegistradas = new();
bandasRegistradas.Add(ira.Nome, ira);
bandasRegistradas.Add(beatles.Nome, beatles);

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
    Console.WriteLine("Boas vindas ao Screen Sound 2.0!");
}

void ExibirOpcoesDoMenu()
{
  ExibirLogo();
  Console.WriteLine("\nDigite 1 para registrar uma banda");
  Console.WriteLine("Digite 2 para registrar o álbum de uma banda");
  Console.WriteLine("Digite 3 para mostrar todas as bandas");
  Console.WriteLine("Digite 4 para avaliar uma banda");
  Console.WriteLine("Digite 5 para exibir os detalhes de uma banda");
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

void RegistrarAlbum()
{
  Console.Clear();
  ExibirTituloDaOpcao("Registro de álbuns");
  Console.Write("Digite a banda cujo álbum deseja registrar: ");
  string nomeDaBanda = Console.ReadLine()!;
  if (bandasRegistradas.ContainsKey(nomeDaBanda))
  {
    Console.Write("Agora digite o título do álbum: ");
    string tituloAlbum = Console.ReadLine()!;
    Banda banda = bandasRegistradas[nomeDaBanda];
    banda.AdicionarAlbum(new Album(tituloAlbum));
    Console.WriteLine($"O álbum {tituloAlbum} de {nomeDaBanda} foi registrado com sucesso!");
    Thread.Sleep(4000);
    Console.Clear();
  }
  else
  {
    Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
    Console.WriteLine("Digite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
  }
  ExibirOpcoesDoMenu();
}

void RegistrarBanda()
{
  Console.Clear();
  ExibirTituloDaOpcao("Registro de bandas");
  Console.Write("Digite o nome da banda que deseja registrar: ");
  string nomeDaBanda = Console.ReadLine()!;
  Banda banda = new Banda(nomeDaBanda);
  bandasRegistradas.Add(nomeDaBanda, banda);
  Console.WriteLine($"\nA banda {nomeDaBanda} foi registrada com sucesso!");
  Thread.Sleep(2000);
  Console.Clear();
  ExibirOpcoesDoMenu();
}

void MostrarBandasRegistradas()
{
  Console.Clear();
  ExibirTituloDaOpcao("Exibindo todas as bandas registradas");

  foreach (var banda in bandasRegistradas.Keys)
  {
    Console.WriteLine($"- {banda}");
  }

  Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
  Console.ReadKey();
  Console.Clear();
  ExibirOpcoesDoMenu();
}

void ExibirTituloDaOpcao(string titulo)
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
    ExibirTituloDaOpcao("Avaliar banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Banda banda = bandasRegistradas[nomeDaBanda];
        Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        banda.AdicionarNota(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

void ExibirDetalhes()
{
  Console.Clear();
  ExibirTituloDaOpcao("Exibir detalhes da banda");
  Console.Write("Digite o nome da banda que deseja conhecer melhor: ");
  string nomeDaBanda = Console.ReadLine()!;
  if (bandasRegistradas.ContainsKey(nomeDaBanda))
  {
    Banda banda = bandasRegistradas[nomeDaBanda];
    Console.WriteLine($"\nA média da banda {nomeDaBanda} é {banda.Media}.");
    /**
    * ESPAÇO RESERVADO PARA COMPLETAR A FUNÇÃO
    */
    Console.WriteLine("Digite uma tecla para votar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();

  }
  else
  {
    Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
    Console.WriteLine("Digite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
  }
}

ExibirOpcoesDoMenu();
