using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zmianatlostart : MonoBehaviour {
	public Sprite []backgrounds;
	// Use this for initialization
	void Start () {
		GetComponent<SpriteRenderer> ().sprite = backgrounds [globalnezmiene.tlo];
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
