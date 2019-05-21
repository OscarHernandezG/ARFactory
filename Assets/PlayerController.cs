using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum Player
{
    Player1,
    Player2
}

public class PlayerController : MonoBehaviour {

    public Player type;

    public Text textPoints;

    public int MeteorLayer;

    string initialText;
    [HideInInspector]
    public int points = 0;
    [HideInInspector]
    public int life = 3;

    public int maxPoints = 100;

    // Use this for initialization
	void Start ()
    {
        points = 0;
        initialText = textPoints.text;
        UpdateLabel(0);
	}

    public void UpdateLabel(int extraPoints)
    {
        points += extraPoints;
        textPoints.text = initialText + points.ToString();

        if (points >= maxPoints)
        {
            sceneManager.call.FinishGame();
        }      
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("COLLISION");
        if (collision.gameObject.layer == MeteorLayer)
        {
            life--;
            Destroy(textPoints.transform.GetChild(life).gameObject);
        }

        if(life == 0)
        {
            sceneManager.call.FinishGame();
        }       
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("TRIGGERED");
    }
}
