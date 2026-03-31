using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireController : MonoBehaviour
{
    [Range(0f, 1f)]
    public float targetIntensity = 0f; // For testing purpose
    public Transform fireTransform;
    public AudioSource fireAudio;
    public float smoothSpeed = 2f;

    private float currentIntensity = 0f;

    // Update is called once per frame
    void Update()
    {
        currentIntensity = Mathf.Lerp(currentIntensity, targetIntensity, Time.deltaTime * smoothSpeed);

        float scale = Mathf.Lerp(1.0f, 2.5f, currentIntensity);
        fireTransform.localScale = new Vector3(scale, scale, scale);

        fireAudio.volume = Mathf.Lerp(0.1f, 1f, currentIntensity);
        fireAudio.pitch = Mathf.Lerp(0.8f, 3.0f, currentIntensity);
    }

    public void SetFireIntensity(float newValue)
    {
        targetIntensity = 1.0f - Mathf.Clamp01(newValue);
    }
}
