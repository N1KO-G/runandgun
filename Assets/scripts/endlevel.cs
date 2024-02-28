using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endlevel : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
   {
        if(collision.collider.CompareTag("Player"))
        {
            SceneManager.LoadScene(1);
        }
}
   
}
