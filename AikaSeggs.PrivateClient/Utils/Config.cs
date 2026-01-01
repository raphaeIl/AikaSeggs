using System;
using System.IO;

namespace AikaSeggs.PrivateClient.Utils
{
    public static class Config
    {
        public static string ResourceDir = Path.Join(Path.GetDirectoryName(AppContext.BaseDirectory), "Resources");
        public static string BaseUrl = "https://prod-web-r.tc.deepone-online.com/deep-one/api";
    }
}

