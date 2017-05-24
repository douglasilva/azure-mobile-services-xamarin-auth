using System;

namespace Xamarin.Auth._MobileServices
{
    public static class FileHelper
    {
        public static string GetLocalStoragePath()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.Personal);
        }
    }
}