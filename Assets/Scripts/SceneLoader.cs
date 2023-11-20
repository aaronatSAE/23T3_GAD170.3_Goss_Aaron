using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // We want a method to OPEN A SCENE

    /// <summary>
    /// Loads a scene.
    /// </summary>
    public void LoadScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }

    /// <summary>
    /// Quits the application.
    /// </summary>
    public void Quit()
    {
        Debug.Log("Quitting game");
        Application.Quit();
    }
}
