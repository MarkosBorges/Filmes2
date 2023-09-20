//Criado para testes futuros
using Filmes.NotificationContext;
using Filmes2.SharedContext;
using Flunt.Validations;
using Flunt.Extensions.Br;
using System.Diagnostics.Contracts;
using System.Net;
using System.Net.Mail;

namespace Filmes2.SubscriptionContext
{
    public class CustomNotification : Notification
    {
        public CustomNotification(string key, string message)
            : base(key, message, DateTime.Now)
        {
            Date = DateTime.Now;
        }

        public CustomNotification(string key, string message, DateTime date)
            : base(key, message, date)
        {
            Date = date;
        }

        public DateTime Date { get; }
    }
    public class Client : Base
    {

        //Habilitar a Linha: _emailService.SendEmail 
        // private readonly EmailService _emailService;

        // public Client(EmailService emailService)
        // {
        //     _emailService = emailService;
        //     Subscriptions = new List<Subscription>();
        // }


        public Client()
        {
            Subscriptions = new List<Subscription>();
        }
        // restante da classe


        public string Name { get; set; }

        public string Email { get; set; }

        public User User { get; set; }

        public IList<Subscription> Subscriptions { get; set; }

        //verifica se o cliente já tem uma assinatura        // Verifica se o cliente já tem uma assinatura
        public void CreateSubscription(Subscription subscription)
        {
            if (IsPremium)
            {
                var notification = new CustomNotification("Premium", "O cliente já tem uma assinatura ativa!", DateTime.Now);
                AddNotification(notification);
                //_emailService.SendEmail(Email, "Erro ao criar assinatura", $"O cliente {Name} já possui uma assinatura ativa.");
                return;
            }
            Subscriptions.Add(subscription);
        }

        public bool IsPremium => Subscriptions.Any(x => !x.IsInactive);
    }
}