using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Il2CppInterop.Runtime;

namespace IL2cppHack
{
    public class Manager : MonoBehaviour
    {
        private void Start() { }
        public static void SetIsAdmin(bool isAdmin)
        {
            try
            {
                IntPtr playerFlagsFieldPtr = IL2CPP.GetIl2CppField(
                    Il2CppClassPointerStore<BasePlayer>.NativeClassPtr,
                    "playerFlags"
                );

                BasePlayer localPlayer = LocalPlayer.LocalOrSpectatePlayer; // Методы получения локального игрока хранятся в классе LocalPlayer в файлике Assembly, обычно это LocalPlayer.Entity & LocalOrSpectatePlayer

                IntPtr playerPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(localPlayer);

                unsafe
                {
                    uint rawOffset = IL2CPP.il2cpp_field_get_offset(playerFlagsFieldPtr);

                    int offset = (int)rawOffset;

                    long playerAddress = (long)playerPtr;
                    long flagsAddress = playerAddress + offset;

                    int currentFlags = *(int*)flagsAddress;

                    if (isAdmin)
                    {
                        currentFlags |= (int)BasePlayer.PlayerFlags.IsAdmin;
                    }
                    else
                    {
                        currentFlags &= ~(int)BasePlayer.PlayerFlags.IsAdmin;
                    }

                    *(int*)flagsAddress = currentFlags;
                }
            }
            catch (Exception ex)
            {
                Debug.LogError($"Error in SetIsAdmin: {ex.Message}");
                throw;
            }
        }

        private void Update()
        {
            if (Input.GetKeyUp(KeyCode.N))
            {
                Debug.Log($"Simmoni Activating....");
                SetIsAdmin(true);
                Debug.Log($"Simmoni Activated");
            }
        }
    }
}
