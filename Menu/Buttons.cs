using Monk_Client.Mods;
using Photon.Pun;
using Template.Classes;
using Template.Mods;
using static Template.Settings;

namespace Template.Menu
{
    internal class Buttons
    {
        public static ButtonInfo[][] buttons = new ButtonInfo[][]
        {
            new ButtonInfo[] { // Main Mods
                new ButtonInfo { buttonText = "Settings", method =() => Main.Cats(1), isTogglable = false, toolTip = "Opens the main settings page for the menu."},
                new ButtonInfo { buttonText = "Saftey", method =() => Main.Cats(2), isTogglable = false, toolTip = ""},
                new ButtonInfo { buttonText = "Room", method =() => Main.Cats(3), isTogglable = false, toolTip = ""},
            },

            new ButtonInfo[] { 
                new ButtonInfo { buttonText = "Right Hand", enableMethod =() => SettingsMods.RightHand(), disableMethod =() => SettingsMods.LeftHand(), toolTip = "Puts the menu on your right hand."},
                new ButtonInfo { buttonText = "Notifications", enableMethod =() => SettingsMods.EnableNotifications(), disableMethod =() => SettingsMods.DisableNotifications(), enabled = !disableNotifications, toolTip = "Toggles the notifications."},
            },

            new ButtonInfo[] { // Saftey Catagory Aka Saftey Cat 
                new ButtonInfo { buttonText = "Anti Report", method =() => Safety.AntiReportDisconnect(),enabled = true, isTogglable = true, toolTip = "Disconnects you when someone tries to report you."},

            },

            new ButtonInfo[] {
                new ButtonInfo { buttonText = "Return to Main", method =() => Main.Cats(0), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                new ButtonInfo { buttonText = "DisableNetworkTriggers", method =() => Room.DisableNetworkTriggersMod(), disableMethod =() => Room.EnableNetworkTriggers(), isTogglable = true},
            },

           

            new ButtonInfo[] {
                new ButtonInfo { buttonText = "Return to Main", method =() => Main.Cats(0), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                new ButtonInfo { buttonText = "Disconnect", method =() => PhotonNetwork.Disconnect(), isTogglable = false, toolTip = "Disconnects you from the room."},
            },
        };
    }
}
