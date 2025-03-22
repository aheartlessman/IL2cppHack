using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BepInEx;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;
using Il2CppSystem;

namespace IL2cppHack
{
    [BepInPlugin("com.SystemDrawing.simmoni", "HackManager", "1.0.0")]
    public class HackManager : BasePlugin
    {
        public override void Load()
        {
          InitializeMemory();
          UnityEngine.Object.DontDestroyOnLoad(base.AddComponent<Manager>().gameObject);
        }

        private void InitializeMemory()
        {
            Harmony harmony = new Harmony("com.SystemDrawing.simmoni");
            harmony.PatchAll();
        }
    }
}
