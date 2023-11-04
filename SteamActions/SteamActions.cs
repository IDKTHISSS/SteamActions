using JCorePanelBase;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SteamActions
{
    public class SteamActions : JCAccountActionBase
    {
        public void LoadActions(JCSteamAccount CurrectAccount)
        {
            if (CurrectAccount == null) return; 
            AddAction(new JCAction("StartSteam", "Start Steam", StartSteamClient, "Steam|Client"));

            if (CurrectAccount.MaFile == null) return;

            AddAction(new JCAction("OpenSteamURL", "Open Steam Profile", OpenSteamURL, "Steam|URL"));
            AddAction(new JCAction("OpenSteamInventoryURL", "Open Steam Inventory", OpenSteamInventoryURL, "Steam|URL"));
            AddAction(new JCAction("CopySteamGuardCode", "Copy SteamGuard Code", CopySteamGuardCode, "Steam|SteamGuard"));
        }
        private async Task StartSteamClient(JCSteamAccountInstance Account)
        {
            Account.SetInWork(true);
            Account.SetWorkStatus("Starting Steam");
            await Steam.RunSteamWithParams(Account, GlobalMenager.GetProperty("SteamRunParameters"));
            Account.SetInWork(false);
        }
        private async Task OpenSteamURL(JCSteamAccountInstance Account)
        {
            Process.Start("https://steamcommunity.com/profiles/" + Account.AccountInfo.MaFile.Session.SteamID.ToString());
            
        }
        private async Task OpenSteamInventoryURL(JCSteamAccountInstance Account)
        {
            Process.Start("https://steamcommunity.com/profiles/" + Account.AccountInfo.MaFile.Session.SteamID.ToString() + "/inventory/");
        }
        private async Task CopySteamGuardCode(JCSteamAccountInstance Account)
        {
            Utils.SetTextToClipboard(await Account.AccountInfo.MaFile.GenerateSteamGuardCodeAsync());
        }
    }
}
