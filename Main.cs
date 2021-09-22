using HarmonyLib;
using System.Reflection;
using VRage.Plugins;

namespace InstantExit
{
    public class Main : IPlugin
    {
        public void Dispose()
        {
            
        }

        public void Init(object gameInstance)
        {
            Harmony harmony = new Harmony("InstantExit");
            harmony.PatchAll(Assembly.GetExecutingAssembly());
        }

        public void Update()
        {
            
        }
    }
}
