namespace EmailSenderLib
{
    public class Constants
    {
        public const string RecipientEmailNotFound = "Не указан почтовый ящик получателя";

        public const string ClientNotFound = "Не указан почтовый клиент";

        public const string SubjectNotFound = "Не указана тема сообщения";

        public const string BodyNotFound = "Не указано тело сообщения";

        public const string SenderName = "Administrator";

        public const string EmailNotFound = "Не указан почтовый ящик";

        public const string UserNameNotFound = "Не указано имя пользователя";

        public const string HostNotFound = "Не указан хост почтового сервера";

        public const string PortNotFound = "Не указан порт почтового сервера";

        public const string SenderEmailNotFound = "Не указан почтовый ящик отправителя";

        public const string MailMessageNotFound = "Сообщение пустое";

        public const string MailProviderNotFound = "Почтовый провайдер не найден";

        public const string NetworkCredentialsNotFound = "Учетные данные не найдены";

        public const string EmailAddressValidateError = "Указан некорректный почтовый ящик";

        public const string SmtpProtocolName = "smtp";

        public const string HostValidateError = "Указан некорректный хост почтового сервера";
    }

    public class MailPort
    {
        public const int YandexPort = 25;

        public const int UniversalPort = 587;
    }

    public class MailProvider
    {
        public const string Yandex = "smtp.yandex.ru";

        public const string Google = "smtp.gmail.com";

        public const string Mail = "smtp.mail.ru";

        public const string Outlook = "smtp.office365.com";
    }
}
