using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_projeto_musical.Menus
{
    internal class MenuMostrarBandas : Menu
    {

        public override void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            base.Executar(bandasRegistradas);
            ExibirTituloDaOpcao("Exibindo todas as bandas registradas");

            foreach (var banda in bandasRegistradas.Keys)
            {
                Console.WriteLine($"- {banda}");
            }

            Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
        }
}
