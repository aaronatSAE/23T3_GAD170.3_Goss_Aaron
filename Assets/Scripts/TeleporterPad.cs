using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleporterPad : MonoBehaviour
{
    [SerializeField] private GameObject playerCharacter;
    [SerializeField] private int sceneIndexToLoad;
    [SerializeField] private KeyCode keyToPress;

    [SerializeField] private bool isPlayerCharacterNearby = false;

    [SerializeField] private GameObject textLabel;

    // We want to detect the player character
    // If they are nearby, and press E,
    // Teleport them! (that is, load the "YOU WIN!" scene)

    private void Update()
    {
        // When player enters the area, set isPlayerCharacterNearby to true
        // if isPlayerCharacterNearby is true, allow for E to be pressed/code to run

        // If the player presses E
        // AND
        // The "isPlayerCharacterNearby" boolean is true
        if (Input.GetKeyDown(keyToPress) && isPlayerCharacterNearby == true)
        {
            // Teleport them! (that is, load the "YOU WIN!" scene)
            Debug.Log("YOU PRESSED E");
            TeleportActivate();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // We should check if "other" is the player character,
        // and if so, adjust the boolean
        if (other.CompareTag("Player"))
        {
            isPlayerCharacterNearby = true;
            textLabel.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // We should check if "other" is the player character,
        // and if so, adjust the boolean
        if (other.CompareTag("Player"))
        {
            isPlayerCharacterNearby = false;
            textLabel.SetActive(false);
        }
    }

    private void TeleportActivate()
    {
        // Load scene
        SceneManager.LoadScene(sceneIndexToLoad);
    }
}
