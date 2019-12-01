using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RodriguesP4.Services
{
    public class Email
    {
        /// <summary>
        /// Method by Jason Lark from https://stackoverflow.com/questions/10444107/send-email-in-c-sharp
        /// </summary>
        /// <param name="subject">Subject of your email.</param>
        /// <param name="content">Body of your email.</param>
        /// <param name="recipients">Array of strings with email address to send email to.</param>
        /// <param name="from">String with from email address.</param>
        /// <returns></returns>
        public static bool SendGmail(string subject, string content, string[] recipients, string from)
        {
            if (recipients == null || recipients.Length == 0)
                throw new ArgumentException("recipients");

            var gmailClient = new System.Net.Mail.SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                UseDefaultCredentials = false,
                Credentials = new System.Net.NetworkCredential("cmath2000@gmail.com", "Password123!")
            };

            using (var msg = new System.Net.Mail.MailMessage(from, recipients[0], subject, content))
            {
                for (int i = 1; i < recipients.Length; i++)
                    msg.To.Add(recipients[i]);

                try
                {
                    gmailClient.Send(msg);
                    return true;
                }
                catch (Exception)
                {
                    // TODO: Handle the exception
                    return false;
                }
            }
        }
    }

}

