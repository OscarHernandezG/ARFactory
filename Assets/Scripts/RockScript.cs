using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockScript : MonoBehaviour {

    public float lifeTime;

    [HideInInspector]
    public float speed;

    [HideInInspector]
    public Vector3 direction;

    public AudioSource explosionSound;

    private bool is_alive = true;

	// Use this for initialization
	void Start () {
        Destroy(gameObject, lifeTime);
        explosionSound = GetComponent<AudioSource>();
        
	}

	// Update is called once per frame
	void Update () {
        if (is_alive)
            transform.position += direction * Time.deltaTime * speed;
	}

    private void OnCollisionEnter(Collision collision)
    {
        is_alive = false;

        // Play audio destroy meteor
        explosionSound.Play();

        gameObject.GetComponent<SphereCollider>().enabled = false;
        gameObject.GetComponent<MeshRenderer>().enabled = false;
        gameObject.GetComponent<ParticleSystem>().Play();

        Destroy(gameObject, 1.0f);
    }
}
