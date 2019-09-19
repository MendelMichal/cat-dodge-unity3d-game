using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Sklep_przyciski : MonoBehaviour {
	public Sprite []buttonss;
	public string pp;
	public int zmienna;
	public Button button;
	// Use this for initialization
	void Start () {

		if (PlayerPrefs.GetInt (pp, 0) == 1) 
		{
			button.GetComponent<Image>().sprite = buttonss[0];
		}
	//	if (PlayerPrefs.GetInt (pp, 0) == 0 && PlayerPrefs.GetInt ("Coins",0)>=zmienna) 
	//	{
	//		button.GetComponent<Image>().sprite = buttonss[1];
	//	}
		if (PlayerPrefs.GetInt (pp, 0) == 0 && PlayerPrefs.GetInt ("Coins",0)<zmienna) 
		{
			button.GetComponent<Image>().sprite = buttonss[2];
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (PlayerPrefs.GetInt (pp, 0) == 1) 
		{
			button.GetComponent<Image>().sprite = buttonss[0];
		}
		if (PlayerPrefs.GetInt (pp, 0) == 0 && PlayerPrefs.GetInt ("Coins")>=zmienna) 
		{
			button.GetComponent<Image>().sprite = buttonss[1];
		}
		if (PlayerPrefs.GetInt (pp, 0) == 0 && PlayerPrefs.GetInt ("Coins")<zmienna) 
		{
			button.GetComponent<Image>().sprite = buttonss[2];
		}
	}
}
