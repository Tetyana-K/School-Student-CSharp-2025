namespace  Event_Handler_With_Args;
class NotificationService
{
    public static void Handler(object sender, NewsStreamEventArgs args)
    {
        Console.WriteLine($"All workers  were notified!");
    }
}