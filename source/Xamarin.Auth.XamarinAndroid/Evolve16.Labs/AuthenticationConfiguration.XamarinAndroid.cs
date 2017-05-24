using Android.Content;
using Android.OS;

using Xamarin.Auth._MobileServices;
using Xamarin.Auth._MobileServices.Presenters.XamarinAndroid;

namespace Xamarin.Auth._MobileServices.Presenters.XamarinAndroid
{
    public static class AuthenticationConfiguration
    {
        internal static Context Context
        {
            get;
            set;
        }

        public static void Init(Context context, Bundle bundle)
        {
            AuthenticationConfiguration.Context = context;

            OAuthLoginPresenter.PlatformLogin = (authenticator) =>
            {
                PlatformOAuthLoginPresenter oauthLogin = new PlatformOAuthLoginPresenter();
                oauthLogin.Login(authenticator);
            };
        }
    }
}