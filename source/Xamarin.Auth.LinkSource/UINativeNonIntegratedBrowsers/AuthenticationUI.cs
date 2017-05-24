using System;

namespace Xamarin.Auth._MobileServices
{
    public class AuthenticationUI
    {
        public static AuthenticationUIType AuthenticationUIType 
        { 
            get; 
            set; 
        } = AuthenticationUIType.EmbeddedBrowser;
    }
}
