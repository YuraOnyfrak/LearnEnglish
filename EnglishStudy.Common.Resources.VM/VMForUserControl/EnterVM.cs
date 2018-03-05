using EnglishStudy.BL.Implement.Implement;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Net;
using System.Text;
using static EnglishStudy.Common.Resources.VM.Base.ViewModalBase;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EnglishStudy.Common.Resources.VM.VMForUserControl
{
    class EnterVM : ViewModelBase
    {
        protected string googleplus_client_id = "458878619548-khuatamj3qpiccnsm4q6dbulf13jumva.apps.googleusercontent.com";    // Replace this with your Client ID
        protected string googleplus_client_sceret = "4hiVJYlomswRd_PV5lyNQlfN";                                                // Replace this with your Client Secret
        protected string googleplus_redirect_url = "http://localhost:2443/Index.aspx";                                         // Replace this with your Redirect URL; Your Redirect URL from your developer.google application should match this URL.
        protected string Parameters;

       
    }
}
