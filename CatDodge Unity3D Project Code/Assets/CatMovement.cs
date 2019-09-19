using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class CatMovement : MonoBehaviour {

    public Animator anim;
    public float speed = 10f;
    public float mapWidth = 5f;

    public GameObject DeadPrefab;

    public AudioSlowMotion audioslowmotion;

    private Rigidbody2D rb;

    void Start () {

        audioslowmotion = FindObjectOfType(typeof(AudioSlowMotion)) as AudioSlowMotion;
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
	}
    
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (globalnezmiene.colizion_count == 0)
        {
            audioslowmotion.MusicSlowMotion();
            Instantiate(DeadPrefab, transform.position, transform.rotation);
            FindObjectOfType<GameManager>().EndGame();
        }
        else
        {
            globalnezmiene.colizion_count = globalnezmiene.colizion_count - 1;
            Destroy(coll.gameObject);
        }
    }

    void FixedUpdate () {

        if (CrossPlatformInputManager.GetAxis("Horizontal") < -0.1f)
        {
            transform.localScale = new Vector3(-0.4810887f, 0.4810887f, 0.4810887f);
        }

        if (CrossPlatformInputManager.GetAxis("Horizontal") > 0.1f)
        {
            transform.localScale = new Vector3(0.4810887f, 0.4810887f, 0.4810887f);
        }
        if (CrossPlatformInputManager.GetAxis("Horizontal") != 0)
        {
            anim.SetInteger("State", 1);
        }
        else
        {
            anim.SetInteger("State", 0);
        }


            float x = CrossPlatformInputManager.GetAxis("Horizontal") * Time.fixedDeltaTime * speed;
   
            Vector2 newPosition = rb.position + Vector2.right * x;
       
            newPosition.x = Mathf.Clamp(newPosition.x, -mapWidth, mapWidth);

            rb.MovePosition(newPosition);

        
    }
}
