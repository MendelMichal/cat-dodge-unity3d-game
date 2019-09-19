using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shieldscript : MonoBehaviour
{

    public GameObject Shield;
    Vector3 tempPos;

    void Start()
    {
        GetComponent<Rigidbody2D>().gravityScale += Time.timeSinceLevelLoad / 20f;
    }

    public void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.transform.gameObject.name == "Cat")
        {
            tempPos = transform.position;
            tempPos.y -= 1.5f;
            transform.position = tempPos;
            if (coll.transform.childCount == 0)
            {
                GameObject shield = Instantiate(Shield, coll.transform.position, coll.transform.rotation);
                shield.transform.parent = coll.transform;
            }

            globalnezmiene.colizion_count = 2;
            Destroy(gameObject);

        }
    }

    void Update()
    {
        if (transform.position.y < -1f)
        {
            Destroy(gameObject);
        }
    }
}
