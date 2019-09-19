using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteor_home : MonoBehaviour {

    public GameObject Explosion;

    void Start () {
        GetComponent<Rigidbody2D>().gravityScale += Time.timeSinceLevelLoad / 20f;
    }
	
	void Update () {
        if (transform.position.y < -4f)
        {
            Destroy(gameObject);
            Instantiate(Explosion, transform.position, transform.rotation);
        }
    }
}
