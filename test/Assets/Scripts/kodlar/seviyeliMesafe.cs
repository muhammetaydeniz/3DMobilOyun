using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class seviyeliMesafe : MonoBehaviour
{
    public GameObject gosterge;
    public int kosuMesafesi;
    public bool mesafeEkleme = false;
    public float mesafeArtmaGecikmesi = 0.35f;

    void Update() 
    {
        if(mesafeEkleme == false)
        {
            mesafeEkleme = true;
            StartCoroutine(MesafeEkleme());
        }
    }
    IEnumerator MesafeEkleme()
    {
        kosuMesafesi+=1;
        gosterge.GetComponent<Text>().text = "" + kosuMesafesi;
        yield return new WaitForSeconds(mesafeArtmaGecikmesi);
        mesafeEkleme = false;
    }
}