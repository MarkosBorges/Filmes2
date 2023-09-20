//tipo de assinatura que pertence ao user
using Filmes2.SharedContext;

namespace Filmes2.SubscriptionContext
{
    public class Subscription : Base
    {
        public Plan Plan { get; set; }

        public DateTime? EndDate { get; set; }//verifica se é nulo e o user ta ativo. se esta no futuro ou no passado

        public bool IsInactive => EndDate <= DateTime.Now;//vai estar inativo se o EndDate for menor q o DateTime 
    }
}