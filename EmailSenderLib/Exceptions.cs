using System.Diagnostics;

namespace EmailSenderLib
{
    public class Exceptions
    {
        public static ArgumentNullException RecipientEmailNotFound()
        {
            return new ArgumentNullException(Constants.RecipientEmailNotFound);
        }

        public static ArgumentNullException ClientNotFound() 
        {
            return new ArgumentNullException(Constants.ClientNotFound);
        }

        public static ArgumentNullException SubjectNotFound() 
        {
            return new ArgumentNullException(Constants.SubjectNotFound);
        }

        public static ArgumentNullException BodyNotFound() 
        {
            return new ArgumentNullException(Constants.BodyNotFound);
        }

        public static ArgumentNullException UserNameNotFound()
        {
            return new ArgumentNullException(Constants.UserNameNotFound);
        }

        public static ArgumentNullException EmailNotFound()
        {
            return new ArgumentNullException(Constants.EmailNotFound);
        }

        public static ArgumentNullException HostNotFound()
        {
            return new ArgumentNullException(Constants.HostNotFound);
        }

        public static ArgumentNullException PortNotFound()
        {
            return new ArgumentNullException(Constants.PortNotFound);
        }

        public static ArgumentException SenderAddressNotFound()
        {
            return new ArgumentException(Constants.SenderEmailNotFound);
        }

        public static ArgumentException MailMessageNotFound()
        {
            return new ArgumentException(Constants.MailMessageNotFound);
        }

        public static ArgumentException MailProviderNotFound()
        {
            return new ArgumentException(Constants.MailProviderNotFound);
        }

        public static ArgumentException NetworkCredentialsNotFound()
        {
            return new ArgumentException(Constants.NetworkCredentialsNotFound);
        }

        public static ArgumentException EmailValueValidateError()
        {
            return new ArgumentException(Constants.EmailAddressValidateError);
        }

        public static ArgumentException HostValidateError()
        {
            return new ArgumentException(Constants.HostValidateError);
        }
    }
}
