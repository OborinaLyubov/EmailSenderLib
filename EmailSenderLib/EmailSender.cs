using System.Net;
using System.Net.Mail;

namespace EmailSenderLib
{
    public class EmailSender
    {
        public static void SendYandex(string recipient, string client, string subject, string body)
        {
            if(recipient == null)
            {
                throw Exceptions.RecipientNotFound();
            }

            if(client == null)
            {
                throw Exceptions.ClientNotFound();
            }

            if(subject == null)
            {
                throw Exceptions.SubjectNotFound();
            }

            if(body == null)
            {
                throw Exceptions.BodyNotFound();
            }

            try
            {
                var emailSender = new MailAddress(HideData.AdminYandexEmail, Constants.SenderName);
                var emailRecipient = new MailAddress(recipient);
                var emailMessage = new MailMessage(emailSender, emailRecipient)
                {
                    Subject = subject,
                    Body = body,
                    IsBodyHtml = true
                };
                var smtp = new SmtpClient(client, MailPort.YandexPort)
                {
                    Credentials = new NetworkCredential(HideData.AdminYandexEmail, HideData.AdminYandexPassword),
                    EnableSsl = true
                };
                smtp.Send(emailMessage);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public static void SendGoogle(string recipient, string client, string subject, string body)
        {
            if (recipient == null)
            {
                throw Exceptions.RecipientNotFound();
            }

            if (client == null)
            {
                throw Exceptions.ClientNotFound();
            }

            if (subject == null)
            {
                throw Exceptions.SubjectNotFound();
            }

            if (body == null)
            {
                throw Exceptions.BodyNotFound();
            }

            try
            {
                var emailSender = new MailAddress(HideData.AdminGoogleEmail, Constants.SenderName);
                var emailRecipient = new MailAddress(recipient);
                var emailMessage = new MailMessage(emailSender, emailRecipient)
                {
                    Subject = subject,
                    Body = body,
                    IsBodyHtml = true
                };
                var smtp = new SmtpClient(client,MailPort.UniversalPort)
                {
                    Credentials = new NetworkCredential(HideData.AdminGoogleEmail, HideData.AdminGooglePassword),
                    EnableSsl = true
                };
                smtp.Send(emailMessage);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public static void SendMail(string recipient, string client, string subject, string body)
        {
            if (recipient == null)
            {
                throw Exceptions.RecipientNotFound();
            }

            if (client == null)
            {
                throw Exceptions.ClientNotFound();
            }

            if (subject == null)
            {
                throw Exceptions.SubjectNotFound();
            }

            if (body == null)
            {
                throw Exceptions.BodyNotFound();
            }

            try
            {
                var emailSender = new MailAddress(HideData.AdminMailEmail, Constants.SenderName);
                var emailRecipient = new MailAddress(recipient);
                var emailMessage = new MailMessage(emailSender, emailRecipient)
                {
                    Subject = subject,
                    Body = body,
                    IsBodyHtml = true
                };
                var smtp = new SmtpClient(client, MailPort.UniversalPort)
                {
                    Credentials = new NetworkCredential(HideData.AdminMailEmail, HideData.AdminMailPassword),
                    EnableSsl = true
                };
                smtp.Send(emailMessage);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public static void SendOutlook(string recipient, string client, string subject, string body)
        {
            if (recipient == null)
            {
                throw Exceptions.RecipientNotFound();
            }

            if (client == null)
            {
                throw Exceptions.ClientNotFound();
            }

            if (subject == null)
            {
                throw Exceptions.SubjectNotFound();
            }

            if (body == null)
            {
                throw Exceptions.BodyNotFound();
            }

            try
            {
                var emailSender = new MailAddress(HideData.AdminOutlookEmail, Constants.SenderName);
                var emailRecipient = new MailAddress(recipient);
                var emailMessage = new MailMessage(emailSender, emailRecipient)
                {
                    Subject = subject,
                    Body = body,
                    IsBodyHtml = true
                };
                var smtp = new SmtpClient(client, MailPort.UniversalPort)
                {
                    Credentials = new NetworkCredential(HideData.AdminOutlookEmail, HideData.AdminOutlookPassword)
                };
                smtp.Send(emailMessage);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
    }
}