using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class endgamemenuscore : MonoBehaviour {
	public Text score;
	public Text bestscore;
	// Use this for initialization
	void Start () {
		score.text = globalnezmiene.score.ToString();
		bestscore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();

	}
	
	// Update is called once per frame
	void Update () {
		score.text = globalnezmiene.score.ToString();
		bestscore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
	}
}
