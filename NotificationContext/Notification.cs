namespace Filmes.NotificationContext
{

    //Notification - Antes era sealed
    public class Notification
    {
        public Notification() //construtor extra
        {

        }

        public Notification(string key, string message, DateTime date)
        {
            Key = key;
            Message = message;
            Date = date;
        }

        public string Key { get; private set; }
        public string Message { get; private set; }
        public DateTime Date { get; private set; }


    }

}