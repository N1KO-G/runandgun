using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class death : MonoBehaviour
{
private void OnCollisionEnter(Collision collision)
   {
        if(collision.collider.CompareTag("Player"))
        {
            SceneManager.LoadScene(4);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;

        }
}

}
