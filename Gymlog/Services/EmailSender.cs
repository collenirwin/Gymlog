using System;
using MimeKit;
using MimeKit.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MailKit.Security;

namespace Gymlog.Services
{
    public class EmailSender
    {
        public async void SendEmailAsync(string emailAddress,string subject, string body, int retryCount = 4)
        {
            var message = new MimeMessage();

            message.From.Add(new MailboxAddress(EmailCredentials.EMAIL));
            message.To.Add(new MailboxAddress(emailAddress));
            message.Subject = subject;

            message.Body = new TextPart(TextFormat.Html)
            {
                Text = body
            };

            for (int x = 0; x < retryCount; x++)
            {
                try
                {
                    using (var client = new SmtpClient())
                    {
                        client.LocalDomain = "outlook.com";
                        // connect
                        await client.ConnectAsync(EmailCredentials.HOST, EmailCredentials.PORT, SecureSocketOptions.Auto)
                            .ConfigureAwait(false);

                        // authenticate
                        await client.AuthenticateAsync(EmailCredentials.EMAIL, EmailCredentials.PASSWORD).ConfigureAwait(false);

                        // send
                        await client.SendAsync(message).ConfigureAwait(false);

                        // disconnect
                        await client.DisconnectAsync(true).ConfigureAwait(false);

                        // doone
                        break;
                    }
                }
                catch
                {
                    throw; // 

                    await Task.Delay(1000);
                    
                }

            }
        }
    }
}
