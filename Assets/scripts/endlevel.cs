using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endlevel : MonoBehaviour
{
    public string scenename;

    private void OnCollisionEnter(Collision collision)
   {

        if(collision.collider.CompareTag("Player"))
        {
            SceneManager.LoadScene(scenename);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
}
   
}
