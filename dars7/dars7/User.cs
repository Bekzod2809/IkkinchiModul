namespace dars7;

public class User
{
    private Guid userId;

    public Guid UserId
    {
        get { return userId; }
        set { userId = value; }
    }

    private string userName;

    public string UserName
    {
        get { return userName; }
        set { userName = value; }
    }

    private string password;

    public string Password
    {
        get { return password; }
        set { password = value; }
    }
    private string lastName;

    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }

    private string firstName;

    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }

}
