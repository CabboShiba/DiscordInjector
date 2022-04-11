using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordInjector
{
    internal class ClientPath
    {
        public static string LocalPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        public static string RoamingPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        public static string DiscordClient = LocalPath + @"\Discord";
        public static string CanaryClient = LocalPath + @"\DiscordCanary";
        public static string DevelopementClient = LocalPath + @"\DiscordDevelopment";
        public static string PTBClient = LocalPath + @"\DiscordPTB";
    }
}
