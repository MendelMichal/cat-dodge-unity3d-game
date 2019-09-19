using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class locked : MonoBehaviour {

	public Sprite []buttonss;
	public int zmiennaa;
	public Button button;
	// Use this for initialization
	public void zmienna(int h)
	{
		zmiennaa = h;
	}
	void Start () {
		
		if (PlayerPrefs.GetInt ("HighScore", 0) >= zmiennaa)
			button.GetComponent<Image>().sprite = buttonss[0];
		else
			button.GetComponent<Image>().sprite = buttonss[1];

	}
	
	// Update is called once per frame
	void Update () {
		if (PlayerPrefs.GetInt ("HighScore", 0) >= zmiennaa)
			button.GetComponent<Image>().sprite = buttonss[0];
		else
			button.GetComponent<Image>().sprite = buttonss[1];
		
	}
}
