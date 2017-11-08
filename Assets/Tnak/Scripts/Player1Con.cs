using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Con : MonoBehaviour {
    public float Rotatespeed = 70f;
    public float Movespeed = 4f;
    public GameObject Bullet;
    public Transform BulletSpawn;
    public float firerate = 1f;

    private float nextfire = 0f;


	// Update is called once per frame
	void Update () {
        
        if (Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(-Vector3.forward, Rotatespeed * Time.deltaTime);
        
        if (Input.GetKey(KeyCode.LeftArrow))
			transform.Rotate(Vector3.forward, Rotatespeed * Time.deltaTime);
        
        if (Input.GetKey(KeyCode.UpArrow))
            transform.Translate(Vector3.up * Movespeed * Time.deltaTime);
        
        if (Input.GetKey(KeyCode.DownArrow))
            transform.Translate(-Vector3.up * Movespeed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.K) /*&& Time.time > nextfire*/) {
            //nextfire += firerate);
			Instantiate(Bullet, BulletSpawn.position, BulletSpawn.rotation);

		}
    }
}
