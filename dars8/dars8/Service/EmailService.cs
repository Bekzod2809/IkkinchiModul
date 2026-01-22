namespace dars8.Service;

public class EmailService : INotification
{
    public void SendNotification()
    {
        Console.WriteLine("Hamma xodimlarga emaildan notification ketdi");
    }
}
