using apijikan_csm;
using Refit;
using System.Runtime.InteropServices;

namespace apijikan_csm
{
    class Program
    {
        private static IJikanApiService jikanApiService = RestService.For<IJikanApiService>("https://api.jikan.moe/v4");
        private static List<Anime> resultPesquisa = new List<Anime>(25);

        static async Task Main(string[] args)
        {
            bool active = true;

            while (active) {
                Console.Clear();
                Console.WriteLine("Bem vindo à APIJikan Interface. \nEscolha sua opção, com base nas funcionalidades abaixo:");
                Console.WriteLine("\n1 - Procurar Animes\n2 - Melhores Animes\n");

                string option = Console.ReadLine();

                switch (option){
                    case "1":
                        await Search(resultPesquisa);
                        break;

                    case "2":
                        await GetTopAnime();
                        break;

                    default:
                        Console.WriteLine("\nO programa será encerrado. Obrigado por utilizar a APIJikan Interface!\n\n");
                        active = false;
                        break;
                }
            }
        }

        static async Task Search(List<Anime> animes)
        {

            Console.Clear();
            Console.WriteLine("==== PROCURAR ANIMES ====\nInforme a palavra-chave a ser pesquisada: ");
            string busca = Console.ReadLine();

            try
            {
                // Faça a chamada para a API Jikan
                ApiResponse response = await jikanApiService.SearchAnime(busca);
                int count = 0, countMax = 10, pag = 1;
                string proximaPag;
                string text = $"BUSCA POR: {busca}\n\n";

                Console.WriteLine("\n");

                // Processar a resposta
                foreach (Anime anime in response.Data)
                {
                    animes.Add(anime);

                    count++;
                    Console.WriteLine($"{count} - {anime.Title}");
                    text += $"{count} - {anime.Title}\n";

                    if (count == countMax)
                    {
                        Console.WriteLine($"\nExibindo {count} resultados.\n\n");
                        proximaPag = Console.ReadLine();
                        Console.WriteLine("\n");

                        if (proximaPag == "1")
                        {
                            countMax += 10;
                            Console.Clear();
                            Console.Write(text);
                            continue;
                        }
                        else
                        {
                            break;
                        }
                    }
                }

                Console.WriteLine($"\nExibindo {count} resultados.\nBusca finalizada.\n\nPressione enter para continuar...");
                Console.ReadLine();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao consultar a API Jikan: {ex}");
            }
        }

        static async Task GetTopAnime()
        {

        }
    }
}

