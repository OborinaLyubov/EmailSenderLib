namespace EmailSenderLib
{
    public class Exceptions
    {
        public static ArgumentNullException RecipientNotFound()
        {
            return new ArgumentNullException(Constants.RecipientNotFound);
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
    }
}
