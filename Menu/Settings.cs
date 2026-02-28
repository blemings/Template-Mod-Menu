using Template.Classes;
using UnityEngine;
using static Template.Menu.Main;
using Template.Patches;
using Template.Utilities;

namespace Template
{
    internal class Settings
    {
        public static ExtGradient backgroundColor = new ExtGradient{ isRainbow = true  };
        public static ExtGradient[] buttonColors = new ExtGradient[]
        {
            new ExtGradient{colors = GetSolidGradient( Color.black) }, // Disabled
            new ExtGradient{ isRainbow = true }, // Enabled

        };
        public static Color[] textColors = new Color[]
        {
            Color.white, // Disabled
            Color.white // Enabled
        };

        public static Font currentFont = Font.CreateDynamicFontFromOSFont("Roboto", 5)  as Font;

        public static bool fpsCounter = true;
        public static bool pageCounter = true;
        public static bool disconnectButton = true;
        public static bool homeButton = true;
        public static bool settingsButton = true;
        public static bool rightHanded = false;
        public static bool disableNotifications = true;

        public static KeyCode keyboardButton = KeyCode.Q;

        public static Vector3 menuSize = new Vector3(0.1f, 1.3f, 1.1f); // Depth, width, height + don't change unless you know what you're doing
        public static int buttonsPerPage = 6;
    }
}
