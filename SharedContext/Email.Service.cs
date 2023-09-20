using System.Net;
using System.Net.Mail;

public class EmailService
{
    private readonly string _smtpServer;
    private readonly int _smtpPort;
    private readonly string _smtpUsername;
    private readonly string _smtpPassword;

    private readonly bool _UseSsl;
    private readonly string _fromAddress;

    public EmailService(string smtpServer, int smtpPort, string smtpUsername, string smtpPassword, bool useSsl, string fromAddress)
    {
        _smtpServer = smtpServer;
        _smtpPort = smtpPort;
        _smtpUsername = smtpUsername;
        _smtpPassword = smtpPassword;
        _UseSsl = useSsl;
        _fromAddress = fromAddress;
    }

    public void SendEmail(string toAddress, string subject, string body)
    {
        using (var client = new SmtpClient(_smtpServer, _smtpPort))
        {
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential(_smtpUsername, _smtpPassword);

            var message = new MailMessage(_fromAddress, toAddress, subject, body);
            message.IsBodyHtml = true;

            client.Send(message);
        }
    }
    public class EmailSettings
    {
        public string SmtpServer { get; set; }
        public int SmtpPort { get; set; }
        public string SmtpUsername { get; set; }
        public string SmtpPassword { get; set; }

        public bool UseSsl { get; set; }
        public string FromAddress { get; set; }
    }

}

