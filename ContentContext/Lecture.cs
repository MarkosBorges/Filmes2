using Filmes2.ContentContext.Enums;
using Filmes2.SharedContext;

namespace Filmes2.ContentContext
{


    public class Lecture : Base
    {
        public int Ordem { get; set; }

        public string Title { get; set; }

        public int DurationInMinutes { get; set; }
        public EContentParental Parental { get; set; }
    }
}