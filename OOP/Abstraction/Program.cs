/*============START OF BAD ABSTRACTION EXAMPLE===========*/

var badEmailService = new Abstraction.BadAbstraction.EmailService();

badEmailService.Connect();
badEmailService.Authenticate();
badEmailService.SendEmail();
badEmailService.Disconnect();

/*NOT GOOD: The client (Program.cs class) is obliged to know in which order to call these methods
 which makes using of the Email Service class not intuitive and easy to use.*/


/*============END OF BAD ABSTRACTION EXAMPLE===========*/


//==============================================================================
//==============================================================================
//==============================================================================


/*============START OF GOOD ABSTRACTION EXAMPLE===========*/

var emailService = new Abstraction.GoodAbstraction.EmailService();

emailService.SendEmail();

/*VERY GOOD: In order to send email we just call SendEmail method and everything is fine.
 So the using of EmailService is very abstract because we do not have to know the details
 for the class itself. We are just interested in sending of email and that's it.*/


/*============END OF GOOD ABSTRACTION EXAMPLE===========*/