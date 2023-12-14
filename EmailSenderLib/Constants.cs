namespace EmailSenderLib
{
    public class Constants
    {
        public const string RecipientNotFound = "Не указан почтовый ящик получателя";

        public const string ClientNotFound = "Не указан почтовый клиент";

        public const string SubjectNotFound = "Не указана тема сообщения";

        public const string BodyNotFound = "Не указано тело сообщения";

        public const string SenderName = "Administrator";
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

        public const string Outlook = "smtp-mail.outlook.com";
    }
}
