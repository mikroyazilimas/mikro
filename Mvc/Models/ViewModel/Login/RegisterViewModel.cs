using SitefinityWebApp.Mvc.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitefinityWebApp.Mvc.Models
{
    public class RegisterViewModel : BaseViewModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public string RepeatPassword { get; set; }

        public string Email { get; set; }
        public bool Subscription { get; set; }
        public bool Contract { get; set; }
        public bool ProgramParticipant { get; set; }
        public bool AygazPermission { get; set; }
        public bool ParoProgram { get; set; }
        public string CaptchaText { get; set; }
        public string CaptchaImg { get; set; }
    }
}