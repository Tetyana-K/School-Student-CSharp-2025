namespace Event_Handler;
class NotificationService
{
    public static void Handler(object sender, EventArgs args)
    {
        Console.WriteLine($"All workers  were notified!");
    }
}