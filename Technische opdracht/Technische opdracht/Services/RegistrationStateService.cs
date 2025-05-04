using Technische_opdracht.Models;

namespace Technische_opdracht.Services
{
    public class RegistrationStateService
    {
        public Step1Model Step1 { get; set; } = new Step1Model();
        public UserRegistrationModel Registration { get; set; } = new UserRegistrationModel();
    }
}
