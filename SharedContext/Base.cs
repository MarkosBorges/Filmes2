//Classe abstrata criada para ser usada como objeto base para outras classes herdarem 
//No caso, foi criada para herdar do Notifiable

using Filmes2.NotificationContext;

namespace Filmes2.SharedContext
{
    public abstract class Base : Notifiable
    {
        protected Base()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
    }

}