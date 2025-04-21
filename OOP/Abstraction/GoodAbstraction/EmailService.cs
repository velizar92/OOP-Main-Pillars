namespace Abstraction.GoodAbstraction
{
    /*Now the class has very GOOD abstraction. In order to send an email the client just need to call
     SendEmail method and internally this method calls the other infrastructure logic for connecting,
     authenticating and disconnecting from server. So the client of this class is not obligated to know
     the order of invocations of methods in the class.*/

    public class EmailService
    {
        public void SendEmail()
        {
            Connect();
            Authenticate();
            Console.WriteLine("Sending email.");
            Disconnect();
        }

        private void Connect()
        {
            Console.WriteLine("Connecting to email server.");
        }

        private void Authenticate()
        {
            Console.WriteLine("Authenticating to email server.");
        }

        private void Disconnect()
        {
            Console.WriteLine("Disconnecting from email server.");
        }    
    }
}
