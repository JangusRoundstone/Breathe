using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneNavigation : MonoBehaviour
{
    public void LoadSceneFireplace()
    {
        SceneManager.LoadScene("Week 2 - Fireplace"); // Use actual scene name
    }

    public void LoadSceneBeach()
    {
        SceneManager.LoadScene("Week 3 - Beach"); // Use actual scene name
    }
}
