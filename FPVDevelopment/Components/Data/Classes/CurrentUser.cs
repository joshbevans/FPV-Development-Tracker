using FPVDevelopment.Components.Data.Models;

namespace FPVDevelopment.Components.Data.Classes
{
    public class CurrentUser
    {
        public DateTime LoginTime { get; set; }
        public User? User { get; set; } = null;

        public event EventHandler CurrentUserChangedEvent;

        public void SetCurrentUser(User user)
        {
            User = user;
            LoginTime = DateTime.Now;
            CurrentUserChangedEvent?.Invoke(this, EventArgs.Empty);
        }
    }
}
