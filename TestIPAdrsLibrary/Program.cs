using Notifications;

namespace SendIPAdrsConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SendNotifications obj = new SendNotifications();
            obj.SendEmail();
        }
    }
}
