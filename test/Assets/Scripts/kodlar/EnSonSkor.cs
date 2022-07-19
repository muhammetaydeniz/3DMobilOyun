using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class EnSonSkor : MonoBehaviour
{
    public Text skorun,altinin;
    public int altin;
    private int skorr,altinn;
    public Text mesafesayaci,altinSayaci;

    public TMP_Text text;
    // Start is called before the first frame update
    void Start()
    {
        //text.text = PlayerPrefs.GetInt("yuksekSkor").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        skorun.text= ""+ mesafesayaci.text;
        skorr=int.Parse(skorun.text);
        if(skorr>PlayerPrefs.GetInt("yuksekSkor"))
        {
            PlayerPrefs.SetInt("yuksekSkor",skorr);
           
        }
        //altinin.text= "" + altinSayaci.text;
        altin=int.Parse(altinSayaci.text);
        if(altin>PlayerPrefs.GetInt("yuksekAltin"))
        {
            PlayerPrefs.SetInt("yuksekAltin",altin);
           
        }

    }
}
