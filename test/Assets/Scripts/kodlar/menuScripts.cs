using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class menuScripts : MonoBehaviour
{

   public void OynaButonu()
   {
       Ganimet.altinSayaci=0;
       SceneManager.LoadScene(1);

   }
   public void QuitButonu()
   {
       Debug.Log("Oyundan Çıktı");
       Application.Quit();
   }

   public void MenuyeGeriDon()
   {
       SceneManager.LoadScene(0);
   }
   public void ProfilButonu()
   {
       SceneManager.LoadScene(2);
   }
   
}
