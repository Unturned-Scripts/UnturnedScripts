using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

namespace SDG.Unturned
{
    // Will Shutdown the Server when Enabled
    // If the Server has disabled Update Shutdowns you have to set isScheduledShutdownEnabled to true
    [AddComponentMenu("Unturned Scripts/Builtin Auto Shutdown")]
    internal class BuiltinAutoShutdown : MonoBehaviour
    {
        public bool isScheduledShutdownEnabled;

        public DateTime scheduledShutdownTime;
    }
}
