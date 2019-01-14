using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScenes : MonoBehaviour {

    public void continueGameLevel1()
    {
        SceneManager.LoadScene("Level 2");
    }

    public void tryAgainLevel1()
    {
        SceneManager.LoadScene("Level");
    }

    public void tryAgainLevel2()
    {
        SceneManager.LoadScene("Level 2");
    }

    public void backMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

}
