using BrockAllen.MembershipReboot;
using BrockAllen.MembershipReboot.Ef;
using BrockAllen.MembershipReboot.WebHost;
using SimpleInjector;
using SimpleInjector.Integration.Web;
using SimpleInjector.Integration.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace zengamemanifesto.Password
{
    public class SimpleInjectorConfig
    {
        public static void Register()
        {
            // Create the container as usual. 
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();
            // Register types: 
            container.RegisterSingleton<MembershipRebootConfiguration>(MembershipRebootConfig.Create);
            container.Register<DefaultMembershipRebootDatabase>(() => new DefaultMembershipRebootDatabase());
            container.Register<UserAccountService>(() => new UserAccountService(container.GetInstance<MembershipRebootConfiguration>(), container.GetInstance<IUserAccountRepository>()));
            //Or make it InstancePerHttpRequest 
            container.Register<AuthenticationService, SamAuthenticationService>();
            var defaultAccountRepositoryRegistration = Lifestyle.Scoped.CreateRegistration<DefaultUserAccountRepository>(container);
            container.AddRegistration(typeof(IUserAccountQuery), defaultAccountRepositoryRegistration);
            container.AddRegistration(typeof(IUserAccountRepository), defaultAccountRepositoryRegistration);
            // This is an extension method from the integration package. 
            container.RegisterMvcControllers(Assembly.GetExecutingAssembly());
            // This is an extension method from the integration package as well. 
            container.RegisterMvcIntegratedFilterProvider();
            container.Verify();
            //Set dependency resolver for MVC 
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }
            
    }
}