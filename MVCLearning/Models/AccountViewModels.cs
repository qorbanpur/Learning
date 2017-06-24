using System;
using System.Collections.Generic;

namespace MVCLearning.Models
{
    // Models returned by AccountController actions.

    public class ExternalLoginViewModel
    {
        public string Name { get; set; }

        public string Url { get; set; }

        public string State { get; set; }
    }

    public class ManageInfoViewModel
    {
        public string LocalLoginProvider { get; set; }

        public string Email { get; set; }

        public List<UserLoginInfoViewModel> Logins { get; set; }

        public IEnumerable<ExternalLoginViewModel> ExternalLoginProviders { get; set; }

        public ManageInfoViewModel()
        {
            var x = new List<UserLoginInfoViewModel>();
            x.Add(new UserLoginInfoViewModel("LoginProvider1", "ProviderKey1"));
            x.Add(new UserLoginInfoViewModel("LoginProvider1", "ProviderKey1"));

            Logins = x;
        }
    }

    public class UserInfoViewModel
    {
        public string Email { get; set; }

        public bool HasRegistered { get; set; }

        public string LoginProvider { get; set; }
    }

    public class UserLoginInfoViewModel
    {
        public string LoginProvider { get; set; }

        public string ProviderKey { get; set; }

        public UserLoginInfoViewModel(string loginProvider, string providerKey)
        {
            LoginProvider = loginProvider;
            ProviderKey = providerKey;
        }
        public UserLoginInfoViewModel() : this("newLoginProvider", "newProviderKey")
        {            
        }
    }
}
