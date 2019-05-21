using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public enum Player
{
    Player1,
    Player2
}

public class PlayerController : MonoBehaviour {

    public Player type;

    public Text textPoints;

    string initialText;
    int points = 0;
	
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
   }
}
