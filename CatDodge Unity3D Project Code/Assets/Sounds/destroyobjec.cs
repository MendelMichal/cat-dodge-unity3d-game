﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyobjec : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Destroy(GameObject.Find("backgroundmusic"));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
