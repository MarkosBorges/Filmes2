using Flunt.Notifications;

namespace MeuProjeto
{
    public class CustomNotification : Notification
    {
        public CustomNotification(string key, string message)
            : base(key, message)
        {
            Date = DateTime.Now;
        }

        public CustomNotification(string key, string message, DateTime date)
            : base(key, message)
        {
            Date = date;
        }

        public DateTime Date { get; set; }
    }
}
