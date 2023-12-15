using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace EmailSenderLib.Smtp
{
    public class EmailSender
    {
        private static NetworkCredential? NetworkCredential;
        private static MailAddress? SenderEmail;
        private static int Port = 0;

        static readonly Regex ValidEmailRegex = CreateValidEmailRegex();

        public static MailAddress GetSenderAddress(string host)
        {
            if(host == null || host == string.Empty)
            {
                throw Exceptions.ClientNotFound();
            }

            var hostPath = host.Split('.');
            if (hostPath[0] != Constants.SmtpProtocolName)
            {
                throw Exceptions.HostValidateError();
            }

            switch (host)
            {
                case MailProvider.Yandex:
                    NetworkCredential = new NetworkCredential(HideData.AdminYandexEmail, HideData.AdminYandexPassword);
                    SenderEmail = new MailAddress(HideData.AdminYandexEmail, Constants.SenderName);
                    Port = MailPort.YandexPort;
                    break;
                case MailProvider.Google:
                    NetworkCredential = new NetworkCredential(HideData.AdminGoogleEmail, HideData.AdminGooglePassword);
                    SenderEmail = new MailAddress(HideData.AdminGoogleEmail, Constants.SenderName);
                    Port = MailPort.UniversalPort;
                    break;
                case MailProvider.Mail:
                    NetworkCredential = new NetworkCredential(HideData.AdminMailEmail, HideData.AdminMailPassword);
                    SenderEmail = new MailAddress(HideData.AdminMailEmail, Constants.SenderName);
                    Port = MailPort.UniversalPort;
                    break;
                case MailProvider.Outlook:
                    NetworkCredential = new NetworkCredential(HideData.AdminOutlookEmail, HideData.AdminOutlookPassword);
                    SenderEmail = new MailAddress(HideData.AdminOutlookEmail, Constants.SenderName);
                    Port = MailPort.UniversalPort;
                    break;
                default: throw Exceptions.MailProviderNotFound();
            }

            return SenderEmail;
        }

        public static void Send(MailMessage mailMessage, string host)
        {
            if(mailMessage == null)
            {
                throw Exceptions.MailMessageNotFound();
            }

            if(host == null || host == string.Empty)
            {
                throw Exceptions.HostNotFound();
            }

            if(host != MailProvider.Mail && host != MailProvider.Outlook && host != MailProvider.Google && host != MailProvider.Yandex) 
            {
                throw Exceptions.MailProviderNotFound();
            }

            if(Port == 0 || Port >= 1000)
            {
                throw Exceptions.PortNotFound();
            }

            if(NetworkCredential == null) 
            {
                throw Exceptions.NetworkCredentialsNotFound();
            }

            var smtp = new SmtpClient(host, Port)
            {
                Credentials = NetworkCredential,
                EnableSsl = true
            };
            smtp.Send(mailMessage);
        }

        public static MailMessage AddMailMessage(MailAddress senderAddress, string recipientEmail, string subject, string body)
        {
            if (senderAddress == null)
            {
                throw Exceptions.SenderAddressNotFound();
            }

            if (recipientEmail == null || recipientEmail == string.Empty)
            {
                throw Exceptions.RecipientEmailNotFound();
            }

            if(!IsValidEmailAddress(recipientEmail))
            {
                throw Exceptions.EmailValueValidateError();
            }

            if (subject == null || subject == string.Empty)
            {
                throw Exceptions.SubjectNotFound();
            }

            if (body == null || body == string.Empty)
            {
                throw Exceptions.BodyNotFound();
            }

            var emailRecipient = new MailAddress(recipientEmail);
            var mailMessage = new MailMessage(senderAddress, emailRecipient)
            {
                Subject = subject,
                Body = body,
                IsBodyHtml = true
            };

            return mailMessage;
        }

        private static Regex CreateValidEmailRegex()
        {
            string validEmailPattern = "^\\S+@\\S+\\.\\S+$";

            return new Regex(validEmailPattern, RegexOptions.IgnoreCase);
        }

        private static bool IsValidEmailAddress(string email)
        {
            bool isValid = ValidEmailRegex.IsMatch(email);
            return isValid;
        }
    }
}