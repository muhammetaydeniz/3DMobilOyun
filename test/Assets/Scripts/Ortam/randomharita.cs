using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomharita : MonoBehaviour
{
    public GameObject[] bolum;
    public int zPos=100;
    public bool bolumYaratma= false;
    public int bolumNo;

 
    void Update()
    {
        if (bolumYaratma == false) 
        {
            bolumYaratma = true;
            StartCoroutine(bolumOlustur());
        }

    }
    IEnumerator bolumOlustur()
    {
        bolumNo = Random.Range(0,3);
        Instantiate(bolum[bolumNo], new Vector3(0,0,zPos), Quaternion.identity);
        zPos +=50;
        yield return new WaitForSeconds(4);
        bolumYaratma=false;
    }
}
