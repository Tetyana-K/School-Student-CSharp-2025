namespace Events;
class NotificationService
{
    public static void Handler(string message) //  static
    {
        Console.WriteLine($"All people  were notified about : '{message}'");
    }
}