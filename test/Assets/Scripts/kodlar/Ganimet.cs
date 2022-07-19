using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ganimet : MonoBehaviour
{
    public static int altinSayaci; //altın sayısını değiştirebilmemiz için static olarak yazdık
    public GameObject altinSayacGosterimi;

    void Update()
    {
        altinSayacGosterimi.GetComponent<Text>().text = "" + altinSayaci;
        
    }
}
