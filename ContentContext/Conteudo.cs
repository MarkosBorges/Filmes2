using Filmes2.ContentContext.Enums;

namespace Filmes2.SharedContext
{
    public abstract class Conteudo : Base
    {

        public Conteudo(string title, string url, EContentParental parental)
        {
            Title = title;
            Url = url;
            Parental = parental;
        }

        public string Title { get; set; }


        public string Url { get; set; }

        public EContentParental Parental { get; set; }
    }
}