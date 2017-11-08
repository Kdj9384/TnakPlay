using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Con : MonoBehaviour {
    public float Rotatespeed = 100f;
    public float Movespeed = 1f;
    public GameObject Bullet;
	public Transform BulletSpawn;
    public int Reload = 1;

    public int Bulletcount = 0;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
            transform.Rotate(-Vector3.forward, Rotatespeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.A))
            transform.Rotate(Vector3.forward, Rotatespeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.W))
            transform.Translate(Vector3.up * Movespeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.S))
            transform.Translate(-Vector3.up * Movespeed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.R))
        {
            Instantiate(Bullet, BulletSpawn.position, BulletSpawn.rotation);
        }
    }
}
