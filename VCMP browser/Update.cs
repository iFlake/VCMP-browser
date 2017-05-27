using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace VCMP_browser
{
    public class UpdateManager
    {
        public string mUpdater;
        public string mUpdaterPassword;

        public NameValueCollection mInstalledVersions;

        UpdateManager(string updater, string password, NameValueCollection installed_versions)
        {
            mUpdater = updater;
            mUpdaterPassword = password;

            mInstalledVersions = installed_versions;
        }

        public string CheckUpdates()
        {
            string serial = Newtonsoft.Json.JsonConvert.SerializeObject(mInstalledVersions);


            WebClient client = new WebClient();
            client.Headers[HttpRequestHeader.ContentType] = "application/json";
            string result = client.UploadString(mUpdater, "POST", serial);

            return result;
        }
    }

    public static class Updater
    {
        
    }
}
