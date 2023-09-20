using System;
using System.Linq;
using Filmes2.ContentContext;
using Filmes2.ContentContext.Enums;
using Filmes2.SubscriptionContext;
using Microsoft.Extensions.DependencyInjection;
using static EmailService;

// dotnet add package flunt
namespace Filmes2
{
    class Program
    {
        static void Main(string[] args)
        {
            //INJECCAO DE DEPENDENCIA
            var emailSettings = new EmailSettings
            {
                SmtpServer = "smtp.gmail.com",
                SmtpPort = 587,
                SmtpUsername = "MeuEmail",
                SmtpPassword = "MeuPasswrod",
                UseSsl = true,
                FromAddress = "MeuEmail"
            };

            var serviceProvider = new ServiceCollection()
                .AddTransient<EmailService>()
                .BuildServiceProvider();

            //var emailService = serviceProvider.GetService<EmailService>();
            // FIM INJECAO

            //regra de negocios -------------------------
            Console.Clear();
            Console.WriteLine("========================================");
            Console.WriteLine("--- BEM-VINDO A SUA LOCADORA VIRTUAL ---");
            Console.WriteLine("========================================");

            // ------------ SESSAO ARTIGOS ---------------------
            /*
            var artigos = new List<Artigos>();
            artigos.Add(new Artigos("Vingadores no cinema", "blockbusters", EContentParental.Spoiler));
            artigos.Add(new Artigos("Titanic volta ao cinema", "geral", EContentParental.Spoiler));
            artigos.Add(new Artigos("Maverick ganhará algum Oscar?", "critica", EContentParental.Spoiler));

            Console.WriteLine("\nArtigos de Filmes:");
            foreach (var artigo in artigos)
            {
                Console.WriteLine($"ID:{artigo.Id}");
                Console.WriteLine($"Filme:{artigo.Title}");
                Console.WriteLine($"TAG:{artigo.Url}");
                Console.WriteLine("==================\n");
            }
            */
            //title, url, parental, director, actors, year, rate,  tag,  durationInMinutes, descriptionMovie)
            // ----------------- SESSAO FILMES -----------------------
            var filmes = new List<FilmesBase>();
            var topGun = new FilmesBase("Top Gun: Maverick", "filme-acao", EContentParental.NReco16anos, "Joe", "shamala-rayan-suze", 2022, 10, "Aventura", 120, "Esse filme é a continuação do blablabla");
            var Titanic = new FilmesBase("Titanic", "filme-drama", EContentParental.NReco16anos, "Maikon", "shamala-rayan-suze", 1997, 9, "Drama", 190, "Esse filme é a clássico blablabla");
            var Vinga = new FilmesBase("Vingadores", "filme-ficcao", EContentParental.NReco10anos, "Smith", "shamala-rayan-suze", 2014, 8, "Ficçã", 180, "Esse filme é o primeiro do heróis da Marvel blablabla");
            filmes.Add(topGun);
            filmes.Add(Titanic);
            filmes.Add(Vinga);


            // ---------------------- SESSAO GENERO ----------------------
            var generos = new List<Genero>();
            var acao = new Genero("Ação", "acao", EContentParental.Livre);
            var genreItem = new GenreItem(1, "Assista filmes de ação", "", topGun);
            var genreItem2 = new GenreItem(2, "Assista filmes de terror", "", null);
            var genreItem3 = new GenreItem(3, "Assista filmes de Ficção", "", Vinga);
            acao.Items.Add(genreItem);
            acao.Items.Add(genreItem2);
            acao.Items.Add(genreItem3);
            generos.Add(acao);


            //foreach de ordem aleatoria
            //craida uma nova instancia da class randem q vai gerar um num para cada item
            //coloquei ordemby na lista de itens aleatorios
            //a cada execucao os numeros vao ser gerados diferentes
            foreach (var genero in generos)
            {
                Console.WriteLine($"Gênero: {genero.Title}");
                Random random = new Random();
                var ordemAleatoria = genero.Items.OrderBy(x => random.Next());
                Console.WriteLine($"Recomendação {ordemAleatoria}");

                foreach (var item in ordemAleatoria)
                {
                    //Console.WriteLine($"{item.Order} - {item.Genre}");
                    //Console.WriteLine($"Recomendação do dia - {item.Genre}");
                    Console.WriteLine(item.FilmesBase?.Title);
                    Console.WriteLine(item.FilmesBase?.Parental);
                    Console.WriteLine("==============================");
                    foreach (var notification in item.Notifications)
                    {
                        Console.WriteLine("=== ATENÇÃO - HÁ UM ITEM VAZIO ===");
                        Console.WriteLine($"Chave: {notification.Key} \nMensagem: {notification.Message} \nData: {notification.Date}");
                    }
                    //Console.WriteLine("===============================");
                }
                // ? = verificando se o objeto é nula

                // ================= SESSAO SUBSCRIPTION ==================================
                var payPal = new PayPal();
                //var client = new Client(emailService);
                var client = new Client();
                client.CreateSubscription(payPal);
                //======== FIM SUBSCRIPTION =====================


            }

            //============== TESTE EMAIL ================
            //ADC: Microsoft.Extensions.DependencyInjection


            // var serviceProvider = new ServiceCollection()
            //     .AddSingleton(emailSettings)
            //     .AddTransient<EmailService>()
            //     .BuildServiceProvider();

            // var emailService = serviceProvider.GetService<EmailService>();
            // Use o emailService para enviar e-mails...
            //================ FIM EMAIL ==============



            // AREA TESTES
            /*
                        var filme = new Filme();
                        filme.Parental = ContentContext.Enums.EContentParental.Livre;
                        foreach (var item in filme.Modules)
                        {

                        }

                        var genre = new Genero();
                        genre.Items.Add(new GenreItem());
                        Console.WriteLine(genre.TotalMovies);//mostra total de item nos generos
            */
            // FIM AREA TESTES
        }
    }
}