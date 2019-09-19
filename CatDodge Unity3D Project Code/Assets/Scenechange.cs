using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenechange : MonoBehaviour {

	// Use this for initialization
	public void change (string a) {
		SceneManager.LoadScene (a);
        Time.timeScale = 1;

    }
	

}
