using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockScript : MonoBehaviour {

    public float lifeTime;

    [HideInInspector]
    public float speed;
    [HideInInspector]
    public Vector3 direction;
	// Use this for initialization
	void Start () {
        Destroy(gameObject, lifeTime);
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += direction * Time.deltaTime * speed;
	}
}
