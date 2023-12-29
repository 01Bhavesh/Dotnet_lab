namespace Notification;
public static class NotificationService{
    public static void sendEmail(string to,string content)
    {
        Console.WriteLine("email is send to "+ to);
    }
    public static void sendSMS(string to,string content)
    {
        Console.WriteLine("SMS is send to " + to);
    }
    public static void sendWhatsApp(string to, string content)
    {
        Console.WriteLine("whatsApp msg is send to " + to);
    }
}