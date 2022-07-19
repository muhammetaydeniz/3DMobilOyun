using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMove : MonoBehaviour
{
    public float kosuHizi = 5;
    public float sagSolHizi = 4;
 
    private CharacterController controller;
    
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * kosuHizi, Space.World);
        
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)){
            if(this.gameObject.transform.position.x > SeviyeSiniri.leftSide)
            {
                 transform.Translate(Vector3.left* Time.deltaTime* sagSolHizi);
            }
        }
         if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)){

            if(this.gameObject.transform.position.x < SeviyeSiniri.rightSide)
            {
                transform.Translate(Vector3.left* Time.deltaTime* sagSolHizi* -1);
            }

        }
        if(Input.GetKey(KeyCode.Space)){

            if(this.gameObject.transform.position.y < 4)
            {
                 transform.Translate(Vector3.up* Time.deltaTime*22);
            }
        }
        kosuHizi+=0.0007f * Time.timeScale;
        sagSolHizi+=0.0002f*Time.timeScale;
        
    }

    private void OnCollisionEnter(Collision collision) 
    {
        if (collision.gameObject.tag=="engel")
        {
            //Debug.Log("Çarptı");
            GameOver.gameOver = true; 
        }
        
    }
    
}
