using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSlowMotion : MonoBehaviour {

    public AudioSource Music;
	
	public void MusicSlowMotion () {
        Music.pitch = 0.8f;
    }
}
