using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bengalas : MonoBehaviour
{
    private float waitTime = 4.0f;
    private float timer = 0.0f;
    
    public GameObject bengala;
    

    // Update is called once per frame
    void Update()
    {
         timer += Time.deltaTime;
         //va a confirmar que pasen los 4 segundos
         if(timer > waitTime)
         {
            bengala.SetActive(true);
         }
         
       
           // bengala.SetActive(true);
        
           // bengala.SetActive(false);
        

    }
}
