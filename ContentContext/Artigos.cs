using Filmes.NotificationContext;
using Filmes2.ContentContext.Enums;
using Filmes2.SharedContext;

namespace Filmes2.ContentContext
{
    public class Artigos : Conteudo
    {
        public Artigos(string title, string url, EContentParental parental) : base(title, url, parental)
        {

        }

    }
}