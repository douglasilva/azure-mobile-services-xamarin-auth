using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.Auth._MobileServices.XamarinForms
{
    public interface IEmbeddedWebViewConfiguration
    {
        /// <summary>
        /// iOS WebView implementation
        /// </summary>
        bool IsUsingWKWebView
        {
            get;
            set;
        }
    }
}
