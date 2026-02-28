using HarmonyLib;
using Template;
using Template.Classes;
using Template.Menu;
using Template.Notifications;
using Template.Patches;
using System;
using Template.Classes;
using UnityEngine;
using UnityEngine.Identifiers;
using UnityEngine.InputSystem;

namespace Template.Classes
{
    [HarmonyPatch(typeof(GorillaLocomotion.GTPlayer), "LateUpdate")]
    internal class MenuInitializer
    {
        private static GameObject menuObject = null;

        static void Postfix()
        {
            if (menuObject != null && GameObject.Find(PluginInfo.Name) != null) return;

            if (menuObject != null)
            {
                Debug.LogWarning($"{PluginInfo.Name} was unexpectedly destroyed. Reinitializing...");
            }

            try
            {
                menuObject = new GameObject(PluginInfo.Name);
                Debug.Log($"Initializing {PluginInfo.Name}...");
                menuObject.AddComponent<Main>();
                menuObject.AddComponent<NotifiLib>();
                GameObject.DontDestroyOnLoad(menuObject);
                Debug.Log($"{PluginInfo.Name} successfully initialized.");
            }
            catch (Exception ex)
            {
                Debug.LogError($"Failed to initialize {PluginInfo.Name}: {ex.Message}\n{ex.StackTrace}");
            }
        }

    }

}