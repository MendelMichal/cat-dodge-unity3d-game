using UnityEngine;
using System.Collections;

public class meteor_6 : MonoBehaviour {

    public UIManager uimanager;

    public GameObject Explosion;
    public GameObject ExplosionPlayer;
    Vector3 tempPos;

    void Start ()
	{
        uimanager = FindObjectOfType(typeof(UIManager)) as UIManager;
        GetComponent<Rigidbody2D>().gravityScale += Time.timeSinceLevelLoad / 20f;
    }

    void OnCollisionEnter2D (Collision2D coll)
    {
        if (coll.transform.gameObject.name == "Cat" && globalnezmiene.colizion_count == 0)
        {
            tempPos = transform.position;
            tempPos.y -= 1f;
            transform.position = tempPos;
            Destroy(gameObject);
            Destroy(coll.gameObject);
            
            Instantiate(ExplosionPlayer, transform.position, transform.rotation);
        }

        if (coll.transform.gameObject.name == "Cat" && globalnezmiene.colizion_count == 1)
        {
            tempPos = transform.position;
            tempPos.y -= 1f;
            transform.position = tempPos;
            Destroy(gameObject);
            Destroy(coll.transform.Find("spr_shield(Clone)").gameObject);

            Instantiate(ExplosionPlayer, transform.position, transform.rotation);
        }

    }

        void Update () {
		if (transform.position.y < 0f)
		{
			Destroy(gameObject);
            Instantiate(Explosion, transform.position, transform.rotation);

            uimanager.ScoreUpdate();
        }
    }

}
