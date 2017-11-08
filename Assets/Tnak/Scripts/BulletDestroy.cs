using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroy : MonoBehaviour {
	public float speed = 11f;
    public ParticleSystem explosion;


	private void OnCollisionEnter2D(Collision2D collision)
    {
        
		Destroy(gameObject);
        Instantiate(explosion, transform.position, Quaternion.identity);


	}

    public void Update()
    {
        
        Transform vel = gameObject.GetComponent<Transform>();
        vel.Translate(Vector3.up * speed * Time.deltaTime);

    }

}
