using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VCMP_browser
{
    public class Configuration
    {
        public string mMasterlist = "http://vcmp.master.cloudwards.es:10732";

        public string mUpdater = "http://u04.maxorator.com";
        public string mUpdaterPassword = "";
        public bool mCheckForUpdates = true;

        public string mDownloadMirror = "https://vcmp.mirror.cloudwards.es";
        public bool mUseDownloadMirror = true;

        public string mViceCityDirectory = "";

        public NameValueCollection mInstalledVersions;

        public string mNickname = "";
        public NameValueCollection mPassword;
    }

    public static class ConfigurationManager
    {
        public static Configuration mConfiguration = new Configuration();

        public static void Save()
        {
            Validate();

            string serial = Newtonsoft.Json.JsonConvert.SerializeObject(mConfiguration);
            System.IO.File.WriteAllText(Application.StartupPath + "/mVCMPConfig.json", serial);
        }

        public static void Load()
        {
            Validate();

            string serial = System.IO.File.ReadAllText(Application.StartupPath + "/mVCMPConfig.json");
            mConfiguration = Newtonsoft.Json.JsonConvert.DeserializeObject<Configuration>(serial);
        }

        private static void Validate()
        {
            if (System.IO.File.Exists(Application.StartupPath + "/mVCMPConfig.json") == false)
            {
                System.IO.File.Create(Application.StartupPath + "/mVCMPConfig.json");
                Save();
            }
        }
    }
}
