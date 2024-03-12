using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Healthmanager : MonoBehaviour
{
    public Image healthBar;
    public float healthAmount = 100f;

    public string scenename;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (healthAmount <= 0)
        {
            SceneManager.LoadScene(4);
             Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;

        }
    }

    public void TakeDamage2(float EnemyDamage)
    {
        healthAmount -= EnemyDamage;
        healthBar.fillAmount = healthAmount / 100f;
    }

    public void Heal(float healingAmount)
    {   
        if (healthAmount <= 100)
        {
            healthAmount += healingAmount;
        healthAmount = Mathf.Clamp(healthAmount, 0, 100);

        }
       

        healthBar.fillAmount = healthAmount / 100f;
    }

 
}
