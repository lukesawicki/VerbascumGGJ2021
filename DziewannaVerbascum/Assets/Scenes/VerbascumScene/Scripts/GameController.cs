using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public HerbsManager herbsManager;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("MainMenuScene", LoadSceneMode.Single);
        }

        if (herbsManager.herbsCounter >= herbsManager.MAX_HERBS)
        {
            SceneManager.LoadScene("CreditsScene", LoadSceneMode.Single);
        }
    }

}
