using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{

    public void Start()
    {
        Cursor.lockState = CursorLockMode.None;
    }

    public void play()
    {
        Debug.Log("Play");
        SceneManager.LoadScene("VerbascumScene", LoadSceneMode.Single);
    }

    public void quit()
    {
        Debug.Log("Exit");
        Application.Quit();
    }
}
