using JCorePanelBase.Structures;
using JCorePanelBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SteamActions
{
    public class StartSteam : JCEventBase
    {

        public string Name = "Start Steam";
        public StartSteam(List<JCEventProperty> PropertiesList) : base(PropertiesList)
        {
            AddProperty(new JCEventProperty("LaunchOptions", "-language english"));
            AddProperty(new JCEventProperty("TimeBetweenLaunch", "20"));
        }
        public void EventBody(List<JCSteamAccountInstance> Accounts)
        {
            foreach (var account in Accounts)
            {
                SetStatus($"Starting {account.AccountInfo.Login}");
                _ = Steam.RunSteamWithParams(account, GetPropertie("LaunchOptions"));
                Thread.Sleep(Int32.Parse(GetPropertie("TimeBetweenLaunch")) * 1000);
            }
        }
    }
}
