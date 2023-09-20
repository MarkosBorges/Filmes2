using Filmes2.SharedContext;

namespace Filmes2.ContentContext
{
    public class Module : Base
    {
        public Module()
        {
            Lectures = new List<Lecture>();
        }
        public int Order { get; set; }

        public string Title { get; set; }

        public IList<Lecture> Lectures { get; set; }

    }
}