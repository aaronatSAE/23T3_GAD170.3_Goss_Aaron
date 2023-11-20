using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// This will send the player back to the Main Menu scene.
/// </summary>
public class QuitFeature : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // If player presses ESC key, load the Main Menu scene.
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
    }
}
