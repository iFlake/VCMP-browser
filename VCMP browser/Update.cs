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

        public object mInstalledVersions;

        public UpdateManager(string updater, string password, object installed_versions)
        {
            mUpdater = updater;
            mUpdaterPassword = password;

            mInstalledVersions = installed_versions;
        }

        public string[] CheckUpdates()
        {
            UpdateRequest request = new UpdateRequest();
            request.password = mUpdaterPassword;
            request.versions = mInstalledVersions;

            string serial = "------------------------fccbef9bbb9a1ec3\nContent-Disposition: form-data; name=\"json\"\n\n" + Newtonsoft.Json.JsonConvert.SerializeObject(request) + "\n\n------------------------fccbef9bbb9a1ec3--" ;

            WebClient client = new WebClient();
            client.Headers[HttpRequestHeader.ContentType] = "multipart/form-data; boundary=------------------------fccbef9bbb9a1ec3";
            string result = client.UploadString(mUpdater + "/check", "POST", serial);
            System.IO.File.WriteAllText(System.Windows.Forms.Application.StartupPath + "/mVCMPConfig.json", serial);
            System.Windows.Forms.MessageBox.Show(serial);
            System.Windows.Forms.MessageBox.Show(result);
            return result.Split('|');
        }
    }

    public class UpdateRequest
    {
        public string password;
        public dynamic versions;
    }

    public static class Updater
    {
        
    }
}
