using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatingRocks : MonoBehaviour {

    public Vector2 distance;
    public List<GameObject> rocks;

	// Use this for initialization
	void Start ()
    {
    }
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            NewRock();
        }
	}

    void NewRock()
    {
        float posX = Random.Range(transform.position.x - distance.x, transform.position.x + distance.x);

        Vector3 pos = new Vector3(posX, 0, distance.y);

        GameObject go = Instantiate(rocks[0], pos, Random.rotationUniform);
        go.GetComponent<RockScript>().direction = rocks[0].transform.forward;

        float scale = Random.Range(1.0f, 1.75f);
        go.transform.localScale = new Vector3(scale, scale, scale);
    }
}
