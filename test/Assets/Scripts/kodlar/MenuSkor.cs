using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuSkor : MonoBehaviour
{
    // Start is called before the first frame update
    public Text skor;
    public Text altin;

    // Update is called once per frame
    void Update()
    {
        string rekor =  PlayerPrefs.GetInt("yuksekSkor").ToString();
        skor.text=rekor;
        string altinToplami=PlayerPrefs.GetInt("yuksekAltin").ToString();
        altin.text=altinToplami;

    }
}
