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

    public GameObject panel1;
    public GameObject panel2;

    private int points1;
    private int points2;
    private Player winner;

    void Start()
    {
        points1 = PlayerPrefs.GetInt("player1");
        points2 = PlayerPrefs.GetInt("player2");

        textPoints1.text = points1.ToString();
        textPoints2.text = points2.ToString();

        winner = (Player)PlayerPrefs.GetInt("Winner");
        if (winner.Equals(Player.Player1))
        {
            panel1.SetActive(true);
        }
        else
        {
            panel2.SetActive(true);
        }
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainScreen");
    }

    public void ReplayGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
