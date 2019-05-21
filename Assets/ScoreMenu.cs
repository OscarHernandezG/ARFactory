using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class ScoreMenu : MonoBehaviour
{
    public TextMeshProUGUI textPoints1;
    public TextMeshProUGUI textPoints2;

    //void Start()
    //{
    //    textPoints1 = .ToString();
    //    textPoints2 = .ToString();


    //}

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainScreen");
    }

    public void ReplayGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
