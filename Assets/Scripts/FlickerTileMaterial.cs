using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickerTileMaterial : MonoBehaviour
{
    public Color colorA = Color.black;

    public Color colorB = Color.white;

    public float frequency;

    private Material tileMaterial;

    private float elapsedTime;

    void Awake()
    {
        this.enabled = false; // only enable it duing ball movement at runtime
    }

    void Start()
    {
        tileMaterial = GetComponent<Renderer>().material;
    }

    void Update()
    {
        elapsedTime += Time.deltaTime;
        float t = (Mathf.Sin(2 * Mathf.PI * frequency * elapsedTime) + 1f) / 2f;
        tileMaterial.color = Color.Lerp(colorA, colorB, t);
    }

    public void SetFrequency(float target_freq)
    {
        frequency = target_freq;
    }

    public void ResetTileColor()
    {
        tileMaterial.color = colorA;
    }
}
