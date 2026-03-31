using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class GameMenu : MonoBehaviour
{
    public void QuitApplication()
    {
        Application.Quit();
    }

    public void RestartApplication()
    {
        SceneManager.LoadScene("SSVEP Ball Maze");
    }
}