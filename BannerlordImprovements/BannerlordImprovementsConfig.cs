using System.IO;
using System.Reflection;
using System.Xml;

namespace BannerlordImprovements
{
    public class BannerlordImprovementsConfig
    {
        private static string FILE_NAME = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "/bannerlordimprovements.xml";
        public XmlDocument config = new XmlDocument();

        public BannerlordImprovementsConfig()
        {
            using (XmlReader reader = XmlReader.Create(FILE_NAME, new XmlReaderSettings()
            {
                IgnoreComments = true
            }))
                this.config.Load(reader);
        }
    }
}
