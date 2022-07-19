using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameOver : MonoBehaviour
{
    public string skor;
    public static bool gameOver,pause,devamEt;
    public GameObject GameOverPanel, DuraklatPaneli;
    public TMP_Text text;
    void Start()
    {
        text.text = PlayerPrefs.GetInt("yuksekSkor").ToString();
        gameOver = false;
        pause = false;
        Time.timeScale = 1;

        

    }

    // Update is called once per frame
    void Update()
    {
        if(gameOver)
        {
            Time.timeScale = 0;
            //text.text = PlayerPrefs.GetInt("yuksekSkor").ToString();
            GameOverPanel.SetActive(true);

           
        }
        if(pause)
        {
            Time.timeScale=0;
            DuraklatPaneli.SetActive(true);
            pause=false;

        }
        if(devamEt)
        {   
            Time.timeScale=1;
            DuraklatPaneli.SetActive(false);
            devamEt=false;
        }
    }
     public void Pause()
    {
        GameOver.pause=true;
    }
    public void devam()
    {
        GameOver.devamEt=true;
    }
    
}
