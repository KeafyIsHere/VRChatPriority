using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MelonLoader;
using System.Diagnostics;

namespace VRChatPriority
{
    public class Main : MelonMod
    {
        //idk lazy
        public override void VRChat_OnUiManagerInit()
        {
            using (Process VRChatP = Process.GetCurrentProcess())
            {
                VRChatP.PriorityClass = ProcessPriorityClass.High;
            }
            MelonLogger.Log("Priority set to high.");
        }
    }
}
