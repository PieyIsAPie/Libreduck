using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreduck
{
    public class Global
    {
        public CefSettings settings = new CefSettings();

        public Global() {
            //settings.UserAgent = "Mozilla/5.0 (Linux; Android; GoogleTV 15.0) AppleWebKit/535.6 (KHTML, like Gecko) Chrome/115.0.5790.69 Safari/535.6";
        }
    }
}
