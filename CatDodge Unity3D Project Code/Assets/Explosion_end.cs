using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion_end : MonoBehaviour {

    public GameObject Explosion;

    void Update () {
        Destroy(Explosion, this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length);
    }
}
