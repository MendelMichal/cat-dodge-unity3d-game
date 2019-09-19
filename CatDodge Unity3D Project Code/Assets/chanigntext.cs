using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class chanigntext : MonoBehaviour {

	public int zmiennaa;

	Text instruction;

	void Start () {

	    instruction = GetComponent<Text>();
		if (PlayerPrefs.GetInt ("HighScore", 0) >= zmiennaa)
	    instruction.text = "ABLE";
		else
	    instruction.text = zmiennaa.ToString ();
		
	}
}
