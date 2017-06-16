using BrockAllen.MembershipReboot;
using BrockAllen.MembershipReboot.WebHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace zengamemanifesto.Password
{
    public class MembershipRebootConfig
    {
        public static MembershipRebootConfiguration Create() {
            var config = new MembershipRebootConfiguration();
            config.RequireAccountVerification = true;
            config.EmailIsUsername = false;

            var appInfo = new AspNetApplicationInformation(
                "Test", "Test Hack.guide tutorials", 
                "Account/Login/", 
                "Account/ConfirmEmail/", 
                "UserAccount/CancelRegistration/", 
                "Account/ConfirmPasswordReset/");
            var emailFormatter = new EmailMessageFormatter(appInfo);
            config.AddEventHandler(new EmailAccountEventsHandler(emailFormatter));
            

            return config;
        }
    }
}