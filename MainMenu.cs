using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
    SceneManager.LoadSceneAsync(1);
    }
    
    public void Info()
    {
        SceneManager.LoadSceneAsync(2);
    }
    public void Books()
    {
        SceneManager.LoadSceneAsync(7);
    }
    public void BacktoMain()
    {
        SceneManager.LoadSceneAsync(0);
    }
    public void Back()
    {
        SceneManager.LoadSceneAsync(1);
    }
    public void secondFlooor()
    {
        SceneManager.LoadSceneAsync(3);
    }
    public void thirdFlooor()
    {
        SceneManager.LoadSceneAsync(4);
    }
    public void fourthFlooor()
    {
        SceneManager.LoadSceneAsync(5);
    }
    public void fifthFlooor()
    {
        SceneManager.LoadSceneAsync(6);
    }
}