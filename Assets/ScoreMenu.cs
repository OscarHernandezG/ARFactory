using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreMenu : MonoBehaviour {

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainScreen");
    }

    public void ReplayGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
