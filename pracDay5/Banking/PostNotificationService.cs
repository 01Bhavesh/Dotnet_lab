namespace Notification;
using System.Threading;
public static class PostNotificationService{
    public static void NotificationComplete(IAsyncResult itfAR)
    {
        Console.WriteLine("NotificationComplete() invoked on thread {0}.",Thread.CurrentThread.ManagedThreadId);
        Console.WriteLine("your Notification is complete");
    }
}