using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManagerScript : MonoBehaviour {

    int count;
    public Text countText;
    public Text timerText;
    float timer = 10f;
    public Text buttonText;

    bool isPlaying = false;
    public GameObject rendaSound;

	// Use this for initialization
	void Start () {
        buttonText.text = "スターーート！！！";
		
	}
	
	// Update is called once per frame
	void Update () {
        if (isPlaying == true){
            timer -= Time.deltaTime;
            timerText.text = timer.ToString("f2");
        }
        if (timer < 0){
            isPlaying = false;
            timer = 0;
            timerText.text = timer.ToString("f2");
            buttonText.text = "終わりーーーーー！！！";

            PlayerPrefs.SetInt("scoore", count);
            SceneManager.LoadScene("endScene");

        }
		
	}
    public void CountUp(){
        if (isPlaying == true){
            count++;
            countText.text = count.ToString();
            Debug.Log(count);

            GameObject rendaSoundClone = Instantiate(rendaSound) as GameObject;
            Destroy(rendaSoundClone, 3.0f);
        }else{
            isPlaying = true;
            buttonText.text = "タップ！";
            countText.text = "0";
        }
    }
}
