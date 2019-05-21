using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class bulletShoot : MonoBehaviour {

    public GameObject Bullet_Emitter_Right;
    public GameObject Bullet_Emitter_Left;
    public GameObject Bullet;

    public float bullet_speed;

    private float timer;

    public float time;

    public AudioSource laser_sound;

    private PlayerController player;

    // Use this for initialization
    void Start() {

        laser_sound = GetComponent<AudioSource>();

        player = GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update() {

        if (timer >= time)
        {
            
            GameObject bullet_right;
            GameObject bullet_left;
            bullet_right = Instantiate(Bullet, Bullet_Emitter_Right.transform.position, Bullet_Emitter_Right.transform.rotation);
            bullet_left = Instantiate(Bullet, Bullet_Emitter_Left.transform.position, Bullet_Emitter_Left.transform.rotation);

            bullet_right.GetComponent<Bullet>().player = player;
            bullet_left.GetComponent<Bullet>().player = player;

            laser_sound.Play();

            bullet_right.transform.Rotate(Vector3.left * 90);
            bullet_left.transform.Rotate(Vector3.left * 90);

            Rigidbody bullet_rigidbody_right;
            Rigidbody bullet_rigidbody_left;

            bullet_rigidbody_right = bullet_right.GetComponent<Rigidbody>();
            bullet_rigidbody_left = bullet_left.GetComponent<Rigidbody>();

            bullet_rigidbody_right.AddForce(transform.forward * bullet_speed);
            bullet_rigidbody_left.AddForce(transform.forward * bullet_speed);

            Destroy(bullet_right, 3.0f);
            Destroy(bullet_left, 3.0f);

            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
