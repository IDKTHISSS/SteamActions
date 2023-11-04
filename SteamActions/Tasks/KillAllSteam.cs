using JCorePanelBase;
using JCorePanelBase.Structures;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamActions
{
    public class KillAllSteam : JCEventBase
    {

        public string Name = "KillAllSteams";
        public KillAllSteam(List<JCEventProperty> PropertiesList) : base(PropertiesList)
        {

        }
        public void EventBody(List<JCSteamAccountInstance> Accounts)
        {
            Process[] processes = Process.GetProcesses();

            foreach (Process process in processes)
            {
                try
                {
                    if (process.ProcessName.ToLower().Contains("steam"))
                    {
                        process.Kill();
                       
                    }
                }
                catch (Exception ex)
                {
                }
            }
        }
    }
}
