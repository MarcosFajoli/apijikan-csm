using Refit;
using System.Text.RegularExpressions;

namespace apijikan_csm
{
    class Program
    {
        private static IJikanApiService jikanApiService = RestService.For<IJikanApiService>("https://api.jikan.moe/v4");
        private static List<Anime> resultPesquisa;

        static async Task Main(string[] args)
        {
            bool active = true;

            while (active) {
                resultPesquisa = new List<Anime>(25);
                Console.Clear();
                Console.WriteLine("Bem vindo à APIJikan Interface. \nEscolha sua opção, com base nas funcionalidades abaixo:");
                Console.WriteLine("\n1 - Procurar Animes\n2 - Melhores Animes\n0 - Encerrar aplicação\n");

                string option = Console.ReadLine();

                switch (option){
                    case "1":
                        await Search(resultPesquisa);
                        break;

                    case "2":
                        await GetTopAnime(resultPesquisa);
                        break;

                    default:
                        Console.WriteLine("\nO programa será encerrado. Obrigado por utilizar a APIJikan Interface!\n\n");
                        active = false;
                        break;
                }
            }
        }

        static async Task Search(List<Anime> animesReturn)
        {

            Console.Clear();
            Console.WriteLine("==== PROCURAR ANIMES ====\nInforme a palavra-chave a ser pesquisada:\n");
            string busca = Console.ReadLine();

            ApiResponse response = await jikanApiService.SearchAnime(busca);

            try
            {
                ShowAnimes(response.Data, animesReturn, "search", busca);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao consultar a API Jikan: {ex.Message}");
                Console.ReadLine();
            }
        }

        static async Task GetTopAnime(List<Anime> animesReturn)
        {
            ApiResponse response = await jikanApiService.GetTopAnime();

            try
            {
                ShowAnimes(response.Data, animesReturn, "top25", null);
            } catch (Exception ex) 
            {
                Console.WriteLine($"Erro ao consultar a API Jikan: {ex.Message}");
                Console.ReadLine();
            }
        }

        static void ShowAnimes(List<Anime> data, List<Anime> animesReturn, string function, string? busca)
        {
            int count = 0;
            string option;

            if (function == "search"){
                Console.WriteLine($"BUSCA POR: {busca}\n");
            } else if (function == "top25"){
                Console.Clear();
                Console.WriteLine("TOP 25 ANIMES MYANIMELIST\n");
            }

            foreach (Anime anime in data)
            {
                count++;
                animesReturn.Add(anime);
                Console.WriteLine($"{count} - {anime.Title}");

            }

            Console.WriteLine($"\nExibindo {count} resultados.\n\nEscolha a opção desejada:");
            Console.WriteLine("\n(1o) Digite o número do anime para verificar suas informações.\n(2o) Digite qualquer outra coisa para sair da busca. \n");
            option = Console.ReadLine();
            Console.WriteLine("\n");

            bool containsStr = Regex.IsMatch(option, "[a-zA-Z]");

            if (!containsStr)
            {
                int.TryParse(option, out int number);
                Console.Clear();
                Console.Write(ShowAnimeInformation(animesReturn[(int)number - 1]));
                Console.WriteLine("\n\nPressione qualquer tecla para continuar...");
                Console.ReadLine();
            }
        }

        static string ShowAnimeInformation(Anime anime)
        {
            string titulo = anime.Title, classificacao = anime.Rating, link = anime.Url, sinopse = anime.Synopsis;
            int? episodios = anime.Episodes, ranking = anime.Rank;
            double? score = anime.Score;

            return $@"Exibindo informações de {titulo}
                    
Nome - {titulo}
Episódios - {episodios}
Score - {score}
Ranking Geral - {ranking}
Classificação - {classificacao}

Sinopse
=====================================================================================+
{sinopse}
=====================================================================================+

Link MyAnimeList - {link}";

        }
    }
}

