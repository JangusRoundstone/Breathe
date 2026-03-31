// DisplaySetup.cs
using UnityEngine;

public class DisplaySetup : MonoBehaviour
{
    void Awake()
    {
        QualitySettings.vSyncCount = 1; // sync every v-blank
        Application.targetFrameRate = Screen.currentResolution.refreshRate;
    }
}
