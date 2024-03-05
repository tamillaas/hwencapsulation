

internal class User
{
    public User(string username, string password)
    {
        Username = username;
        Password = password;
    }
    private string _username;

    public string Username
    {
        get
        {
            return _username;
        }
        set
        {
            return;
        }
    }
    private string _password;
    public string Password
    {
        get
        {
            return _password;
        }
        set
        {

            if (value != null && value.Length > 8 && CheckDigit(value) && CheckUpper(value))
            {
                _password = value;
            }
            else
            {
                Console.WriteLine("Uygun password gonderin");
            }
        }
    }
    private bool CheckDigit(string password)
    {
        bool isVar = false;
        foreach (var item in password)
        {
            if (char.IsDigit(item))
            {
                isVar = true;
                break;
            }

        }
        return isVar;
    }
    private bool CheckUpper(string password)
    {
        bool isVar = false;
        foreach (var item in password)
        {
            if (char.IsUpper(item))
            {
                isVar = true;
                break;
            }

        }
        return isVar;
    }
}