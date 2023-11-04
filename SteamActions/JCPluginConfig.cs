using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JCorePanelBase;

namespace SteamActions
{
    public static class JCPluginConfig
    {
        public static string PLUGIN_NAME = "SteamActions";
        public static string PLUGIN_FRENDLY_NAME = "Steam Actions";
        public static string PLUGIN_FRENDLY_VERSION = "1.0.1";
        public static string PLUGIN_AUTHOR = "Admin";
        public static int PLUGIN_VERSION = 2;
        public static string PLUGIN_DESCRIPTION = "Steam Actions - Add same simple steam action for steam accounts.";
        public static List<JCPluginProperty> PLUGIN_SETTINGS = new List<JCPluginProperty>{

            new JCPluginProperty { Name="SteamRunParameters", Value="-vgui" },

        };
        //For Exaple new Even
        /*public static void OnLoad(List<JCSteamAccountInstance> AccountsList)
        {

        }*/
    }
}
