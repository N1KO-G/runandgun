using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthpackcode : MonoBehaviour
{

    Healthmanager healthmanager;

    public float healing;


   
   private void OnTriggerEnter(Collider other)
   {
        if(other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<Healthmanager>().Heal(healing);
            Destroy(gameObject);
        }
        

   }
}

