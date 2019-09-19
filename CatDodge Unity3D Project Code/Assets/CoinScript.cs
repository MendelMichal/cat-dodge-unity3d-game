using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    int coin = 0;
    void Start()
    {
        GetComponent<Rigidbody2D>().gravityScale += Time.timeSinceLevelLoad / 20f;
    }

    public void OnCollisionEnter2D(Collision2D coll)
    {

        if (coll.transform.gameObject.name == "Cat")
        {

            coin = PlayerPrefs.GetInt("Coins");
            coin = coin + 1;
            PlayerPrefs.SetInt("Coins", coin);
            globalnezmiene.colizion_count = globalnezmiene.colizion_count + 1;
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
