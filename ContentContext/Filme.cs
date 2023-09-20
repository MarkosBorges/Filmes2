using Filmes2.ContentContext.Enums;
using Filmes2.SharedContext;

namespace Filmes2.ContentContext
{
    // public class Filme : Conteudo
    // {

    //     public Filme(string title, string url, EContentParental parental) : base(title, url, parental)
    //     {
    //         Modules = new List<Module>();// inicializacao do modulo
    //     }


    //     public string Director { get; set; }

    //     public string Actors { get; set; }

    //     public int Year { get; set; }

    //     public float Rate { get; set; } // estrelinhas - será usada depois pelo usuário

    //     public string Tag { get; set; }

    //     public int DurationInMinutes { get; set; }

    //     public string DescriptionMovie { get; set; }

    //     public EContentParental Parental { get; set; }

    //     public IList<Module> Modules { get; set; }

    //     public override string ToString()
    //     {
    //         return @$"Título: {Title} | Ano: {Year} | Diretor: {Director}| \nElenco: {Actors} | \nNota:{Rate} 
    //         | Duração: {DurationInMinutes} | Classificação: {(EContentParental)this.Parental} | Sinopse: {DescriptionMovie}";
    //     }
    // }
    public class Filme : FilmesBase
    {

        public Filme(string title, string url, EContentParental parental, string director, string actors, int year, int rate, string tag, int durationInMinutes, string descriptionMovie) : base(title, url, parental, director, actors, year, rate, tag, durationInMinutes, descriptionMovie)
        {
            Modules = new List<Module>();// inicializacao do modulo
        }

        public IList<Module> Modules { get; set; }

        public override string ToString()
        {
            return @$"Título: {Title} | Ano: {Year} | Diretor: {Director}| \nElenco: {Actors} | \nNota:{Rate} 
            | Duração: {DurationInMinutes} | Classificação: {(EContentParental)this.Parental} | Sinopse: {DescriptionMovie}";
        }
    }

}
