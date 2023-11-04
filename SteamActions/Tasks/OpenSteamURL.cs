using JCorePanelBase.Structures;
using JCorePanelBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace SteamActions
{
    public class OpenSteamURL : JCEventBase
    {

        public string Name = "Open Steam URL";
        public OpenSteamURL(List<JCEventProperty> PropertiesList) : base(PropertiesList)
        {

        }
        public void EventBody(List<JCSteamAccountInstance> Accounts)
        {
            foreach (var account in Accounts)
            {
                Process.Start("https://steamcommunity.com/profiles/" + account.AccountInfo.MaFile.Session.SteamID.ToString());
            }
        }
    }
}
