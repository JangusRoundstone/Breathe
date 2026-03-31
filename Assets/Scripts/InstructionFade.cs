using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InstructionFade : MonoBehaviour
{
    public TextMeshProUGUI instructionText;
    public float delayBeforeFade = 2.0f;
    public float fadeDuration = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FadeOutRoutine());
    }

    IEnumerator FadeOutRoutine()
    {
        yield return new WaitForSeconds(delayBeforeFade);
        
        Color originalColor = instructionText.color;
        float timer = 0f;

        while(timer < fadeDuration)
        {
            float alpha = Mathf.Lerp(1.0f, 0f, timer / fadeDuration);
            instructionText.color = new Color(originalColor.r, originalColor.g, originalColor.b, alpha);
            timer += Time.deltaTime;
            yield return null;
        }

        instructionText.color = new Color(originalColor.r, originalColor.g, originalColor.b, 0f);
    }
}
