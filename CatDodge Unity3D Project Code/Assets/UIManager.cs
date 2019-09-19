using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    public Text Score;
    public Text BestScore;
    public Text Coins;

    int ScoreNumber = 0;

    void Start()
    {
        Score.text = ScoreNumber.ToString();
        BestScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
        Coins.text = PlayerPrefs.GetInt("Coins", 0).ToString();
		globalnezmiene.score = ScoreNumber;
    }
    void Update()
    {
        Coins.text = PlayerPrefs.GetInt("Coins", 0).ToString();
    }
	public void ScoreUpdate ()
    {
        ScoreNumber = ScoreNumber + 10;
		PlayerPrefs.SetInt("Score", ScoreNumber);
        Score.text = ScoreNumber.ToString();
		globalnezmiene.score = ScoreNumber;
        if(ScoreNumber >  PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", ScoreNumber);
            BestScore.text = ScoreNumber.ToString();
           
        }
    }

}
