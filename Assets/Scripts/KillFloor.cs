using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillFloor : MonoBehaviour
{
    // When the player character enters this trigger area,
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // we restart the scene!
            SceneManager.LoadScene(1);
        }
    }
}
