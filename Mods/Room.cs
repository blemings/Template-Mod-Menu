using BepInEx;
using GorillaNetworking;
using Photon.Pun;
using Photon.Realtime;
using Template.Notifications;
using Template.Patches;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using static Mono.Security.X509.X520;

namespace Template.Mods
{
    internal class Room
    {

        
        public static void DisableNetworkTriggersMod()
        {
            GameObject.Find("Environment Objects/TriggerZones_Prefab/JoinRoomTriggers_Prefab").SetActive(false);
        }



        public static void EnableNetworkTriggers()
        {
            GameObject.Find("Environment Objects/TriggerZones_Prefab/JoinRoomTriggers_Prefab").SetActive(true);
        }
    }
}