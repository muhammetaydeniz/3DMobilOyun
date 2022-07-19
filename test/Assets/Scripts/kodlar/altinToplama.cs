using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class altinToplama : MonoBehaviour
{
    public AudioSource coinFX;

    void OnTriggerEnter(Collider other)
    {
        coinFX.Play();
        Ganimet.altinSayaci += 1;
        this.gameObject.SetActive(false);
    }
}

