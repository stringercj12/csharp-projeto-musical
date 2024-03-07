﻿namespace csharp_projeto_musical.Menus;

internal class MenuRegistrarBanda : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Registro de bandas");

        Console.Write("Digite o nome da banda que deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;

        Banda banda = new Banda(nomeDaBanda);
        bandasRegistradas.Add(nomeDaBanda, banda);

        Console.WriteLine($"\nA banda {nomeDaBanda} foi registrada com sucesso!");

        Thread.Sleep(2000);
        Console.Clear();
    }

}
