using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatingRocks : MonoBehaviour {

    public Vector2 distance;
    public List<GameObject> rocks;

    public float maxScale;
    public float speed;
    public float angle;
    float verticalTimer;
    float diagonalTimer;
	// Use this for initialization
	void Start ()
    {
        verticalTimer = 0.0f;
    }
	
	// Update is called once per frame
	void Update () {
		if(verticalTimer >= 0.5f)
        {
            NewVerticalRock();
            verticalTimer = 0.0f;
        }
        verticalTimer += Time.deltaTime;

        if (diagonalTimer >= 1.5f)
        {
           // NewDiagonalRock();
            diagonalTimer = 0.0f;
        }
        diagonalTimer += Time.deltaTime;
    }

    void NewVerticalRock()
    {
        float posX = Random.Range(transform.position.x - distance.x, transform.position.x + distance.x);

        Vector3 pos = new Vector3(posX, transform.position.z + distance.y, 0f);

        int position = Random.Range(0, rocks.Count);

        GameObject go = Instantiate(rocks[position], pos, Random.rotationUniform);
        go.GetComponent<RockScript>().direction = -rocks[position].transform.up;

        float scale = Random.Range(1.5f, maxScale);
        go.transform.localScale = new Vector3(scale, scale, scale);

        go.GetComponent<RockScript>().speed = speed * maxScale / scale;
        
    }

    void NewDiagonalRock()
    {
        float posX = Random.Range(-1.0f, 1.0f);
        if (posX > 0)
            posX = -1;
        else
            posX = 1;

        float posY = Random.Range(distance.y, distance.y + 100);

        Vector3 pos = new Vector3(posX * distance.x, 0, posY);

        int rock = Random.Range(0, rocks.Count);

        GameObject go = Instantiate(rocks[rock], pos, Random.rotationUniform);

        Vector3 direction = Quaternion.AngleAxis(angle * posX, rocks[rock].transform.up) * rocks[rock].transform.forward;
        go.GetComponent<RockScript>().direction = direction;

        float scale = Random.Range(1.5f, maxScale);
        go.transform.localScale = new Vector3(scale, scale, scale);

        go.GetComponent<RockScript>().speed = speed * maxScale / scale;

    }

}
