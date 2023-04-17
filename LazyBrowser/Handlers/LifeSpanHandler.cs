using CefSharp;

namespace LazyBrowser.Handlers
{
    internal class LifeSpanHandler : ILifeSpanHandler
    {
        public bool DoClose(IWebBrowser chromiumWebBrowser, IBrowser browser)
        {
            throw new System.NotImplementedException();
        }

        public void OnAfterCreated(IWebBrowser chromiumWebBrowser, IBrowser browser)
        {
            throw new System.NotImplementedException();
        }

        public void OnBeforeClose(IWebBrowser chromiumWebBrowser, IBrowser browser)
        {
            throw new System.NotImplementedException();
        }

        public bool OnBeforePopup(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, string targetUrl, string targetFrameName, WindowOpenDisposition targetDisposition, bool userGesture, IPopupFeatures popupFeatures, IWindowInfo windowInfo, IBrowserSettings browserSettings, ref bool noJavascriptAccess, out IWebBrowser newBrowser)
        {
            throw new System.NotImplementedException();
        }
    }
}
