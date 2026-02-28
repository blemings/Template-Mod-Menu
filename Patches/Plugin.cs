using BepInEx;
using System.ComponentModel;

namespace Template.Patches
{
    [Description(Template.PluginInfo.Description)]
    [BepInPlugin(Template.PluginInfo.GUID, Template.PluginInfo.Name, Template.PluginInfo.Version)]
    public class HarmonyPatches : BaseUnityPlugin
    {
        private void OnEnable()
        {
            Menu.ApplyHarmonyPatches();
        }

        private void OnDisable()
        {
            Menu.RemoveHarmonyPatches();
        }
    }
}
