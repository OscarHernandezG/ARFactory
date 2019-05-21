using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneManager : MonoBehaviour {

    public static sceneManager call;

    public PlayerController player1;
    public PlayerController player2;

	// Use this for initialization
	void Start () {
        call = this;
	}

    public void FinishGame()
    {
        PlayerPrefs.SetInt("player1", player1.points);
        PlayerPrefs.SetInt("player2", player2.points);

        if (player1.life <= 0)
        {
            PlayerPrefs.SetInt("Winner", (int)player2.type);
        }
        else if (player2.life <= 0)
        {
            PlayerPrefs.SetInt("Winner", (int)player1.type);
        }
        else
            PlayerPrefs.SetInt("Winner", (int)(player1.points > player2.points ? player1.type : player2.type));

        SceneManager.LoadScene("ScoreScene");
    }
}
