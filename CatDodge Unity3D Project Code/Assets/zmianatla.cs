using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class zmianatla : MonoBehaviour {
	

	public Button but1;
	public Button but2;
	public Button but3;
	int kupno=0;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		Button zmianatla1 = but1.GetComponent<Button>();
		Button zmianatla2 = but2.GetComponent<Button>();
		Button zmianatla3 = but3.GetComponent<Button>();

		but1.onClick.AddListener(Tlo1);
		but2.onClick.AddListener(Tlo2);
		but3.onClick.AddListener(Tlo3);

	}
	void Tlo1()
	{


		globalnezmiene.tlo=0;

	}
	void Tlo2()
	{
		kupno = PlayerPrefs.GetInt ("p2",0);
		if (kupno == 1) {
			globalnezmiene.tlo = 1;
		}
		else if (kupno == 0 && PlayerPrefs.GetInt ("Coins") >= 20) {
			int coins_po_zakupie = PlayerPrefs.GetInt ("Coins") - 20;
			PlayerPrefs.SetInt ("Coins", coins_po_zakupie);

			PlayerPrefs.SetInt ("p2", 1);
		} 
		else 
		{
			globalnezmiene.tlo=0;
		}

	}
	void Tlo3()
	{
		kupno = PlayerPrefs.GetInt ("p3",0);
		if (kupno == 1) {
			globalnezmiene.tlo = 2;
		}
		else if (kupno == 0 && PlayerPrefs.GetInt ("Coins") >= 50) {
			int coins_po_zakupie = PlayerPrefs.GetInt ("Coins") - 50;
			PlayerPrefs.SetInt ("Coins", coins_po_zakupie);

			PlayerPrefs.SetInt ("p3", 1);
		} 
		else 
		{
			globalnezmiene.tlo=0;
		}

	}
}
