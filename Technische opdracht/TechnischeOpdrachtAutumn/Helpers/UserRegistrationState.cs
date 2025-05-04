using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using TechnischeOpdrachtAutumn.Models;

namespace TechnischeOpdrachtAutumn.Helpers
{
    public class UserRegistrationState
    {
        private readonly ProtectedSessionStorage _sessionStorage;
        private const string StorageKey = "UserRegistration";

        public UserRegistrationModel UserRegistration { get; set; } = new();
        public int CurrentStep { get; set; } = 1;
        public int MaxSteps { get; set; } = 4;

        public void Reset()
        {
            CurrentStep = 1;
            UserRegistration = new UserRegistrationModel();
        }
    }
}
