using System.IO;
using System.Xml.Serialization;

namespace BasicFacebookFeatures
{
    public class AppSettings
    {
        public string AppID { get; set; }
        public string[] Permissions { get; set; }
        public bool RememberUser { get; set; }
        public string LastAccessToken { get; set; }
        public WishlistManager WishlistManager { get; set; }
        public WishlistFacade WishlistFacade { get; set; }
        public WorkoutManager WorkoutManager { get; set; }
        public WorkoutFacade WorkoutFacade { get; set; }
        public AppSettings()
        {
            RememberUser = false;
            LastAccessToken = null;
            Permissions = null;
            AppID = null;
            WishlistFacade = null;
            WishlistManager = null;
            WorkoutManager = null;
            WorkoutFacade = null;
        }
        public void SaveToFile(string i_FilePath)
        {
            if (!File.Exists(i_FilePath))
            {
                File.Create(i_FilePath).Dispose();
            }
            using (Stream stream = new FileStream(i_FilePath, FileMode.Truncate))
            {
                XmlSerializer serilaizer = new XmlSerializer(this.GetType());

                serilaizer.Serialize(stream, this);
            }
        }
        public static AppSettings LoadFromFile(string i_FilePath)
        {
            AppSettings settings = new AppSettings();

            using (Stream stream = new FileStream(i_FilePath, FileMode.OpenOrCreate))
            {
                if (stream.Length > 0)
                {
                    XmlSerializer deserilaizer = new XmlSerializer(typeof(AppSettings));

                    settings = deserilaizer.Deserialize(stream) as AppSettings;
                }
            }

            return settings;
        }
    }
}