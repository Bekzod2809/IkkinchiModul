using dars8.Service;

namespace dars8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            INotification notification = GetNtification();
            notification.SendNotification();
        }
        public static INotification GetNtification()
        {
            //INotification Notification = new EmailService();
            //INotification Notification = new AccountService();
            INotification Notification = new TeamsService();
            return Notification;
        }
    }
}

