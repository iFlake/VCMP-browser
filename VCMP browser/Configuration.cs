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
        public MasterlistConfiguration mMasterlist = new MasterlistConfiguration();
        public UpdateConfiguration mUpdate = new UpdateConfiguration();
        public DownloadMirrorConfiguration mDownloadMirror = new DownloadMirrorConfiguration();
        public ViceCityDirectoryConfiguration mViceCityDirectory = new ViceCityDirectoryConfiguration();
        public NameValueCollection mInstalledVersions = new NameValueCollection();
        public ServerConfiguration mServerConfiguration = new ServerConfiguration();
    }

    public class MasterlistConfiguration
    {
        public string mURL = "http://vcmp.master.cloudwards.es:10732";
    }

    public class UpdateConfiguration
    {
        public string mURL = "http://u04.maxorator.com";
        public string mPassword = "";
        public bool mCheck = true;
    }

    public class DownloadMirrorConfiguration
    {
        public string mURL = "https://vcmp.mirror.cloudwards.es";
        public bool mCheck = true;
    }

    public class ViceCityDirectoryConfiguration
    {
        public string mPath = "";
    }

    public class ServerConfiguration
    {
        public string mNickname = "";
        public NameValueCollection mNicknameOverrides = new NameValueCollection();

        public string mPassword = "";
        public NameValueCollection mPasswordOverrides = new NameValueCollection();
    }

    public static class ConfigurationManager
    {
        public static Configuration mConfiguration = new Configuration();

        public static void Save()
        {
            Validate();

            string serial = Newtonsoft.Json.JsonConvert.SerializeObject(mConfiguration, Newtonsoft.Json.Formatting.Indented);
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
                System.IO.File.Create(Application.StartupPath + "/mVCMPConfig.json").Close();
                Save();
            }
        }
    }
}
