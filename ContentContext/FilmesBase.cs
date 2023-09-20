using Filmes2.ContentContext.Enums;
using Filmes2.SharedContext;

namespace Filmes2.ContentContext
{
    public class FilmesBase : Conteudo
    {
        public FilmesBase(string title, string url, EContentParental parental, string director, string actors, int year, int rate, string tag, int durationInMinutes, string descriptionMovie) : base(title, url, parental)
        {
            Director = director;
            Actors = actors;
            Year = year;
            Rate = rate;
            Tag = tag;
            DurationInMinutes = durationInMinutes;
            DescriptionMovie = descriptionMovie;
        }
        public string Director { get; set; }

        public string Actors { get; set; }

        public int Year { get; set; }

        public int Rate { get; set; } // estrelinhas - será usada depois pelo usuário

        public string Tag { get; set; }

        public int DurationInMinutes { get; set; }

        public string DescriptionMovie { get; set; }


    }
}
