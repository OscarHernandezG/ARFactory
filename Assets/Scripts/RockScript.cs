using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockScript : MonoBehaviour {

    public float lifeTime;

    [HideInInspector]
    public float speed;

    [HideInInspector]
    public Vector3 direction;

    AudioSource explosionSound;


	// Use this for initialization
	void Start () {
        Destroy(gameObject, lifeTime);
        //explosionSound = GetComponent<AudioSource>();
	}

	// Update is called once per frame
	void Update () {
        transform.position += direction * Time.deltaTime * speed;
	}

    private void OnCollisionEnter(Collision collision)
    {
        // Play audio destroy meteor
        //explosionSound.Play();

        Destroy(gameObject);
    }
}
