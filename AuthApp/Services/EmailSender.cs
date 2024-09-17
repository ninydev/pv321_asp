using System.Net;
using System.Net.Mail;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace AuthApp.Services;

public class EmailSender : IEmailSender
{
    private readonly IConfiguration _configuration;

    public EmailSender(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public async Task SendEmailAsync(string email, string subject, string message)
    {
        var smtpSettings = _configuration.GetSection("Smtp");

        var smtpClient = new SmtpClient(smtpSettings["Host"])
        {
            Port = int.Parse(smtpSettings["Port"]),
            Credentials = new NetworkCredential(smtpSettings["UserName"], smtpSettings["Password"]),
            UseDefaultCredentials = false,
            DeliveryMethod = SmtpDeliveryMethod.Network,
            EnableSsl = bool.Parse(smtpSettings["EnableSSL"])  // Включаем SSL или TLS в зависимости от конфигурации
        };
        

// Убедимся, что используется TLS (StartTLS) при необходимости
        if (bool.Parse(smtpSettings["UseTLS"]))
        {
            smtpClient.EnableSsl = true;  // Включаем шифрование
            // smtpClient.TargetName = "STARTTLS";  // Явно указываем, что требуется StartTLS
        }

        var mailMessage = new MailMessage
        {
            From = new MailAddress(smtpSettings["UserName"]),
            Subject = subject,
            Body = message,
            IsBodyHtml = true
        };

        mailMessage.To.Add(email);

        try
        {
            smtpClient.Send(mailMessage);
            // await smtpClient.SendMailAsync(mailMessage);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        
    }
}
