using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
// I attached this script directly to the Button.
// normally I would press the + and add a function but I couldn't find the + and was forced to add an event listner instead.
public class RestartButton : MonoBehaviour
{
    public Button restartButton; // Reference to the button

    void Start()
    {
        // Ensure the button is assigned in the Inspector
        if (restartButton != null)
        {
            restartButton.onClick.AddListener(RestartGame);
        }
    }

    public void RestartGame()
    {
        // Reload the current scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}