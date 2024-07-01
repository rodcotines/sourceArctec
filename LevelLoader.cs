using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f;

    // Method to load the Augmentable scene
    public void LoadAugmentable()
    {
        StartCoroutine(LoadLevel("Augmentable"));
    }

    // Method to load the MainMenu scene
    public void LoadMainMenu()
    {
        StartCoroutine(LoadLevel("MainMenu"));
    }

    // Method to load the GroundFloor scene
    public void LoadGroundFloor()
    {
        StartCoroutine(LoadLevel("Ground"));
    }

    // Method to load the SecondFloor scene
    public void LoadSecondFloor()
    {
        StartCoroutine(LoadLevel("2NDFLOOR"));
    }

    // Method to load the ThirdFloor scene
    public void LoadThirdFloor()
    {
        StartCoroutine(LoadLevel("3RDFLOOR"));
    }

    // Method to load the FourthFloor scene
    public void LoadFourthFloor()
    {
        StartCoroutine(LoadLevel("4THFLOOR"));
    }

    // Method to load the FifthFloor scene
    public void LoadFifthFloor()
    {
        StartCoroutine(LoadLevel("5THFLOOR"));
    }

    // Method to load the Scanner scene
    public void LoadScanner()
    {
        StartCoroutine(LoadLevel("SampleScene"));
    }
    public void LoadHistory()
    {
        StartCoroutine(LoadLevel("History"));
    }
    public void LoadInstructions()
    {
        StartCoroutine(LoadLevel("Instructions"));
    }
     public void LoadLibQR()
    {
        StartCoroutine(LoadLevel("LibraryQR"));
    }
    public void LoadDownloadQR()
    {
        StartCoroutine(LoadLevel("Download"));
    }

    // Coroutine to handle the transition and loading of scenes
    IEnumerator LoadLevel(string sceneName)
    {
        // Play transition animation
        transition.SetTrigger("Start");

        // Wait for transition time
        yield return new WaitForSeconds(transitionTime);

        // Load the scene
        SceneManager.LoadScene(sceneName);
    }
}
