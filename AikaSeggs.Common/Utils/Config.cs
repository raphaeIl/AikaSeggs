using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AikaSeggs.Common.Utils
{
    public static class Config
    {
        public static string ResourceDir = Path.Join(Path.GetDirectoryName(AppContext.BaseDirectory), "Resources");
        public static string PcapDir = Path.Join(ResourceDir, "Packets");
        public static string BaseUrl = "https://prod-web-r.tc.deepone-online.com/deep-one/api";

        //public static string GameVersion = "v1_43_440";
        //public static string GameVersionNumber = "1.43.440";
        //public static int ResourceVersion = 1906;
        //public static int MasterVersion = 1497;
    }
}
