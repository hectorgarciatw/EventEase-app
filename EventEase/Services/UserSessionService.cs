namespace EventEase.Services
{
    public class UserSessionService
    {
        public string UserName { get; private set; } = "";
        public string Email { get; private set; } = "";
        public bool IsRegistered { get; private set; } = false;

        public void Register(string name, string email)
        {
            UserName = name;
            Email = email;
            IsRegistered = true;
        }

        public void Logout()
        {
            UserName = "";
            Email = "";
            IsRegistered = false;
        }
    }
}
