using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class dontdestroy : MonoBehaviour {
	
	// Use this for initialization


	void Awake()
	{
		GameObject[] objs = GameObject.FindGameObjectsWithTag ("music");
		if(objs.Length > 1)
			Destroy(this.gameObject);



			DontDestroyOnLoad (this.gameObject);
		//Destroy(this.gameObject);
	}
}
