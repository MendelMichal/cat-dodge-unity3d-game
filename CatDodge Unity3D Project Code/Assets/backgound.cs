using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class backgound : MonoBehaviour {

	public Sprite []backgrounds;
	int zmiennaa;
    int kupno = 0;
	string pp;

    //Camera cam = Camera.main;
    // Use this for initialization
    void Start () {
        //	GetComponent<SpriteRenderer>().sprite = backgrounds[1];
        //transform.localScale = new Vector3(Screen.width,Screen.height,1);
       
	}

	public void zmienna(int h)
	{
		zmiennaa = h;
	}
	public void kupno_dotyczny(string p)
	{
		pp = p;
	}
	public void set (int a) {
		kupno = PlayerPrefs.GetInt (pp,0);
		if (kupno == 1) {
			GetComponent<SpriteRenderer> ().sprite = backgrounds [a];
		}
		else if (kupno == 0 && PlayerPrefs.GetInt ("Coins") >= zmiennaa) 
		{
			int coins_po_zakupie = PlayerPrefs.GetInt ("Coins") - zmiennaa;
			PlayerPrefs.SetInt ("Coins",coins_po_zakupie);
			PlayerPrefs.SetInt (pp,1);
		}
   
    }




}