using Filmes.NotificationContext;
using Filmes2.ContentContext.Enums;
using Filmes2.SharedContext;
using Filmes2.SubscriptionContext;

namespace Filmes2.ContentContext
{
    public class Genero : Conteudo
    {
        public Genero(string title, string url, EContentParental parental) : base(title, url, parental)
        {
            Items = new List<GenreItem>();

        }
        //public IList<Filme> Filmes { get; set; }

        public IList<GenreItem> Items { get; set; }

        /*
                public int TotalMovies => return Items.Count;
                {
                    get
                    {
                        return Items.Count;
                    }

                }
                */
        //Expression Body 
        public int TotalMovies => Items.Count;
    }

    public class GenreItem : Base
    {
        public GenreItem(int order, string genre, string description, FilmesBase filme)
        {
            if (filme == null)
            {
                AddNotification(new CustomNotification("Filme", "Filme inválido!"));
            }
            Order = order;
            Genre = genre;
            Description = description;
            FilmesBase = filme;
        }

        public int Order { get; set; }

        public FilmesBase FilmesBase { get; set; }

        public string Genre { get; set; }

        public string Description { get; set; }


    }
}