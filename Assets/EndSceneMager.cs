using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndSceneMager : MonoBehaviour {
    public Text lastScoreText;
    public Text highScoreText;
    int highScore;
    int lastScore;

	// Use this for initialization
	void Start () {
        lastScore = PlayerPrefs.GetInt("score");
        lastScoreText.text = lastScore.ToString();

        if (PlayerPrefs.HasKey("highScore") == true){
            highScore = PlayerPrefs.GetInt("highScore");
            if (highScore < lastScore){
                highScore = lastScore;
                PlayerPrefs.GetInt("highScore", highScore);
            }
        }else{
            highScore = lastScore;
            PlayerPrefs.SetInt("highScore", highScore);

        }
        highScoreText.text = highScore.ToString();

		
	}
    public void RetryButton(){
        SceneManager.LoadScene("StartScene");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
