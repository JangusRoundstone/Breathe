using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindController : MonoBehaviour
{
    [Range(0f, 1f)]
    public float targetIntensity = 0f; // For testing purpose
    public WindZone windzone;
    public AudioSource windAudio;
    public float smoothSpeed = 2f;
    private float currentIntensity = 0f;

    // Update is called once per frame
    void Update()
    {
        currentIntensity = Mathf.Lerp(currentIntensity, targetIntensity, Time.deltaTime * smoothSpeed);

        windzone.windMain = Mathf.Lerp(1f, 3f, currentIntensity);
        windzone.windTurbulence = Mathf.Lerp(1f, 3f, currentIntensity);
        windzone.windPulseMagnitude = Mathf.Lerp(0.5f, 3f, currentIntensity);
        // windzone.windPulseFrequency = Mathf.Lerp(0.01f, 0.1f, currentIntensity);

        windAudio.volume = Mathf.Lerp(0.1f, 1f, currentIntensity);
        windAudio.pitch = Mathf.Lerp(0.8f, 3.0f, currentIntensity);
    }

    public void SetWindIntensity(float newValue)
    {
        targetIntensity = 1.0f - Mathf.Clamp01(newValue);
    }
}
