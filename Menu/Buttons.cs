using StupidTemplate.Classes;
using StupidTemplate.Mods;
using static StupidTemplate.Settings;

namespace StupidTemplate.Menu
{
    internal class Buttons
    {
        public static ButtonInfo[][] buttons = new ButtonInfo[][]
        {
            new ButtonInfo[] { // Main Mods
                new ButtonInfo { buttonText = "Settings", method =() => Main.Cats(1), isTogglable = false, toolTip = "Opens the main settings page for the menu."},
                new ButtonInfo { buttonText = "Cat 2", method =() => Main.Cats(2), isTogglable = false, toolTip = ""},
                new ButtonInfo { buttonText = "Cat 3", method =() => Main.Cats(3), isTogglable = false, toolTip = ""},
                new ButtonInfo { buttonText = "Cat 4", method =() => Main.Cats(4), isTogglable = false, toolTip = ""},
                new ButtonInfo { buttonText = "Cat 5", method =() => Main.Cats(5), isTogglable = false, toolTip = ""},
                new ButtonInfo { buttonText = "Cat 6", method =() => Main.Cats(6), isTogglable = false, toolTip = ""},

            },

            new ButtonInfo[] { 
                new ButtonInfo { buttonText = "Right Hand", enableMethod =() => SettingsMods.RightHand(), disableMethod =() => SettingsMods.LeftHand(), toolTip = "Puts the menu on your right hand."},
                new ButtonInfo { buttonText = "Notifications", enableMethod =() => SettingsMods.EnableNotifications(), disableMethod =() => SettingsMods.DisableNotifications(), enabled = !disableNotifications, toolTip = "Toggles the notifications."},
            },

            new ButtonInfo[] { 

            },

            new ButtonInfo[] { 
            },

            new ButtonInfo[] { 
            },
            new ButtonInfo[] {
            },

            new ButtonInfo[] {
            },
        };
    }
}
