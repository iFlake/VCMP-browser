using System;
using System.Collections.Generic;
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

        public string mNickname = "";
        public Password[] mPassword;
    }

    public class Password
    {
        string mHost = "";
        string mPassword = "";
    }

    public static class ConfigurationManager
    {
        public static Configuration mConfiguration;

        public static void Save()
        {
            string serial = Newtonsoft.Json.JsonConvert.SerializeObject(mConfiguration);
            System.IO.File.WriteAllText(Application.StartupPath + "/mVCMPConfig.json", serial);
        }

        public static void Load()
        {

        }
    }
}
