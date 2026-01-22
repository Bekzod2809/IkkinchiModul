namespace dars7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.UserId = Guid.NewGuid();
            user.UserName = "johndoe";
            user.Password = "12345";
            user.FirstName = "John";
            user.LastName = "Doe";
            Console.WriteLine($"{user.FirstName} {user.LastName}  {user.UserName}, ID: {user.UserId}");
        }
    }
}
