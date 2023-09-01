using CefSharp;
using CefSharp.WinForms;
using System;
using LazyBrowser;

namespace LazyBrowser.Handlers
{
    public class LifeSpanHandler : ILifeSpanHandler
    {
        bool ILifeSpanHandler.OnBeforePopup(IWebBrowser browserControl,
             IBrowser browser, IFrame frame, string targetUrl,
             string targetFrameName, WindowOpenDisposition targetDisposition,
             bool userGesture, IPopupFeatures popupFeatures, IWindowInfo windowInfo,
             IBrowserSettings browserSettings, ref bool noJavascriptAccess,
             out IWebBrowser newBrowser)
        {
            //stop open popup
            Popup popup = new Popup(targetUrl);
            popup.Show();
            newBrowser = null;
            return true;
        }

        bool ILifeSpanHandler.DoClose(IWebBrowser browserControl, IBrowser browser)
        { return false; }

        void ILifeSpanHandler.OnBeforeClose(IWebBrowser browserControl, IBrowser browser) { }

        void ILifeSpanHandler.OnAfterCreated(IWebBrowser browserControl, IBrowser browser) { }
    }
}