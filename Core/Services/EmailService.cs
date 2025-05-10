using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Options;
using Mailjet.Client;
using Mailjet.Client.Resources;
using Newtonsoft.Json.Linq;
using System;
using System.Threading.Tasks;
using Core.Helpers;

namespace Core.Services
{
    public class EmailService : IEmailSender
    {
        private readonly MailJetSettings _mailJetSettings;

        public EmailService(IOptions<MailJetSettings> mailJetSettings)
        {
            _mailJetSettings = mailJetSettings.Value;
        }

        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            // Перевірка наявності API ключів
            if (string.IsNullOrEmpty(_mailJetSettings.ApiKey))
                throw new ArgumentNullException(nameof(_mailJetSettings.ApiKey), "Mailjet API key is not set.");
            if (string.IsNullOrEmpty(_mailJetSettings.SecretKey))
                throw new ArgumentNullException(nameof(_mailJetSettings.SecretKey), "Mailjet Secret key is not set.");

            // Створення клієнта Mailjet без використання властивості Version
            var client = new MailjetClient(_mailJetSettings.ApiKey, _mailJetSettings.SecretKey);

            // Формування запиту для надсилання листа
            var request = new MailjetRequest
            {
                Resource = Send.Resource,
            }
            .Property(Send.FromEmail, _mailJetSettings.SenderEmail)
            .Property(Send.FromName, _mailJetSettings.SenderName)
            .Property(Send.Subject, subject)
            .Property(Send.HtmlPart, htmlMessage)
            .Property(Send.Recipients, new JArray
            {
                new JObject { { "Email", email } }
            });

            var response = await client.PostAsync(request);

            // Перевірка результату запиту
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"Failed to send email: {response.StatusCode} {response.GetErrorMessage()}");
            }
        }
    }
}