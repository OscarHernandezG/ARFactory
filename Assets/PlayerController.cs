using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum Player
{
    Player1,
    Player2
}

public class PlayerController : MonoBehaviour {

    public int points = 0;

    public Player type;

	// Use this for initialization
	void Start ()
    {
        points = 0;
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        Debug.Log(points.ToString());
	}
}
