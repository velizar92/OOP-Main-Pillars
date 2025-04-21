namespace Abstraction.BadAbstraction
{
    /*The problem with this class is that it does not have good abstraction.
     In order to send email you have to call always the other methods first
     for connecting to server, authentication and disconnecting from server.
     This makes using of this class very hard and error prune. The client should know
     in which order to call all these methods in order use properly the class and to send
     an email. This is NOT good abstraction!*/

    public class EmailService
    {
        public void Connect()
        {
            Console.WriteLine("Connecting to email server.");
        }

        public void Authenticate()
        {
            Console.WriteLine("Authenticating to email server.");
        }

        public void Disconnect()
        {
            Console.WriteLine("Disconnecting from email server.");
        }

        public void SendEmail()
        {
            Console.WriteLine("Sending email.");
        }   
    }
}
