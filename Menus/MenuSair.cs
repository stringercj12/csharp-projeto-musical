namespace csharp_projeto_musical.Menus;

internal class MenuSair : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        Console.WriteLine("Saindo do programa...");

    }
}