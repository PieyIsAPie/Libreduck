using CefSharp;

public class JSHandler : IJsDialogHandler
{
    public bool OnBeforeUnloadDialog(IWebBrowser chromiumWebBrowser, IBrowser browser, string messageText, bool isReload, IJsDialogCallback callback)
    {
		return false;
	}

    public void OnDialogClosed(IWebBrowser chromiumWebBrowser, IBrowser browser)
    {
	}

    public bool OnJSAlert(IWebBrowser chromiumWebBrowser, string url, string message)
	{

		return false;
	}

	public bool OnJSConfirm(IWebBrowser chromiumWebBrowser, string url, string message, out bool retval)
	{
		retval = false;
		return false;
	}

    public bool OnJSDialog(IWebBrowser chromiumWebBrowser, IBrowser browser, string originUrl, CefJsDialogType dialogType, string messageText, string defaultPromptText, IJsDialogCallback callback, ref bool suppressMessage)
    {
		return false;
	}

    public bool OnJSPrompt(IWebBrowser chromiumWebBrowser, string url, string message, string defaultValue, out bool retval, out string result)
	{
		retval = false;
		result = "";
		return false;
	}

    public void OnResetDialogState(IWebBrowser chromiumWebBrowser, IBrowser browser)
    {
    }
}