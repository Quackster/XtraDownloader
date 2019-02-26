using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace XtraDownload
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> urls = new List<string>()
            {
                "http://download.macromedia.com/pub/shockwave10.4/xtras/MacroMix.w32",
                "http://download.macromedia.com/pub/shockwave10.4/xtras/XMLParser.w32",
                "http://download.macromedia.com/pub/shockwave10.4/xtras/FlashAsset.w32",
                "http://download.macromedia.com/pub/shockwave10.4/xtras/DirectSound.w32",
                "http://download.macromedia.com/pub/shockwave10.4/xtras/SWA.w32",
                "http://download.macromedia.com/pub/shockwave10.4/xtras/FontXtra.w32",
                "http://download.macromedia.com/pub/shockwave10.4/xtras/TextXtra.w32",
                "http://download.macromedia.com/pub/shockwave10.4/xtras/FontAsset.w32",
                "http://download.macromedia.com/pub/shockwave10.4/xtras/SoundControl.w32",
                "http://download.macromedia.com/pub/shockwave10.4/xtras/TextAsset.w32"
            };

            List<string> fpUrls = new List<string>()
            {
                "http://fpdownload.macromedia.com/pub/shockwave10.4/xtras/SWA.w32",
                "http://fpdownload.macromedia.com/pub/shockwave10.4/xtras/FontXtra.w32",
                "http://fpdownload.macromedia.com/pub/shockwave10.4/xtras/DirectSound.w32",
                "http://fpdownload.macromedia.com/pub/shockwave10.4/xtras/FlashAsset.w32",
                "http://fpdownload.macromedia.com/pub/shockwave10.4/xtras/MacroMix.w32",
                "http://fpdownload.macromedia.com/pub/shockwave10.4/xtras/XMLParser.w32",
                "http://fpdownload.macromedia.com/pub/shockwave10.4/xtras/FontAsset.w32",
                "http://fpdownload.macromedia.com/pub/shockwave10.4/xtras/TextXtra.w32",
                "http://fpdownload.macromedia.com/pub/shockwave10.4/xtras/SoundControl.w32",
                "http://fpdownload.macromedia.com/pub/shockwave10.4/xtras/TextAsset.w32"
            };

            if (!Directory.Exists("normal"))
                Directory.CreateDirectory("normal");

            if (!Directory.Exists("fp"))
                Directory.CreateDirectory("fp");

            WebClient webClient = new WebClient();

            foreach (string url in urls)
                webClient.DownloadFile(url, "normal/" + Path.GetFileName(url));

            foreach (string url in fpUrls)
                webClient.DownloadFile(url, "fp/" + Path.GetFileName(url));
        }
    }
}
