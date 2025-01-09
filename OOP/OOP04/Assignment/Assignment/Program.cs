using Assignment.Q1_Models;
using Assignment.Q2_Models;
using Assignment.Q3_Models;

namespace Assignment
{
    internal class Program
    {
        static void PrintShapeInfo(IShape shape)
        {
            shape.DisplayShapeInfo();
        }
        static void Main(string[] args)
        {
            // Part 01
            #region 1. What is the primary purpose of an interface in C#?
            // a) To provide a way to implement multiple inheritance
            #endregion
            #region 2.Which of the following is NOT a valid access modifier for interface members in C#?
            // c) internal
            #endregion
            #region 3.Can an interface contain fields in C#?
            // c) Only if they are static
            #endregion
            #region 4.In C#, can an interface inherit from another interface?
            // b) Yes, interfaces can inherit from multiple interfaces
            #endregion
            #region 5.Which keyword is used to implement an interface in a class in C#?
            // d) implements
            // must be the colon ":"
            #endregion
            #region 6.Can an interface contain static methods in C#?
            // a) Yes
            #endregion
            #region 7.In C#, can an interface have explicit access modifiers for its members?
            // a) Yes, for all members
            #endregion
            #region 8.What is the purpose of an explicit interface implementation in C#?
            // b) To provide a clear separation between interface and class members
            #endregion
            #region 9.In C#, can an interface have a constructor?
            // b) No, interfaces cannot have constructors
            #endregion
            #region 10.How can a C# class implement multiple interfaces?
            // c) By separating interface names with commas
            #endregion

            // Part 02 
            #region Question (01)
            //Circle circle = new Circle(3.5);
            //Rectangle rectangle = new Rectangle(4, 6);
            //PrintShapeInfo(circle);
            //PrintShapeInfo(rectangle);
            #endregion
            #region Question (02)
            //IAuthenticationService authService = new BasicAuthenticationService();
            //if(authService.AuthenticateUser("Mina","1234") && authService.AuthorizeUser("Mina"))
            //{
            //    Console.WriteLine("Success");
            //}
            //else
            //{
            //    Console.WriteLine("Failed");
            //} 
            #endregion
            #region Question (03)
            //EmailNotificationService email = new EmailNotificationService();
            //email.SendNotification(10, "This Message from Email");
            //Console.WriteLine("-------------------");
            //SmsNotificationService sms = new SmsNotificationService();
            //sms.SendNotification(15, "This Message from SMS");
            //Console.WriteLine("-------------------");
            //PushNotificationService pushNotification = new PushNotificationService();
            //pushNotification.SendNotification(20, "This Message from PushNotification"); 
            #endregion
        }
    }
}
