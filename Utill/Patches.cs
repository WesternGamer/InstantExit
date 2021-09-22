using HarmonyLib;
using Sandbox;
using System.Diagnostics;

namespace InstantExit.Utill
{
    [HarmonyPatch(typeof(MySandboxGame), "ExitThreadSafe")]
    public class Patch_ExitThreadSafe
    {
        public static bool Prefix()
        {
            Process.GetCurrentProcess().Kill();
            return false;
        }
    }
}
