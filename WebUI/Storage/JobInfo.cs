namespace WebUI.Storage;

public class JobInfo
{
    public string EmployeeName { get; set; }

    public string Username { get; set; }

    public string Password { get; set; }

    public string PasswordConfirm { get; set; }

    public JobInfo(string employeeName, string username, string password, string passwordConfirm)
    {
        this.EmployeeName = employeeName;
        this.Username = username;
        this.Password = password;
        this.PasswordConfirm = passwordConfirm;
    }
}