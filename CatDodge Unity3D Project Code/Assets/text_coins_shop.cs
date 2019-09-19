using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class text_coins_shop : MonoBehaviour {
	
	public Text text;
	// Use this for initialization
	void Start () {
		text.text = PlayerPrefs.GetInt ("Coins").ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
