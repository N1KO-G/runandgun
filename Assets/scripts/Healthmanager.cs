using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Healthmanager : MonoBehaviour
{
    public Image healthBar;
    public float healthAmount = 100f;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (healthAmount <= 0)
        {
            SceneManager.LoadScene(0);

        }
    }

    public void TakeDamage2(float EnemyDamage)                              
    {
        healthAmount -= EnemyDamage;
        healthBar.fillAmount = healthAmount / 100f;
    }

    public void Heal(float healingAmount)
<<<<<<< Updated upstream
    {   
        if (healthAmount <= 100)
=======
<<<<<<< HEAD
    {
        if (healthAmount < 100)
=======
    {   
        if (healthAmount <= 100)
>>>>>>> aab25c63d73a916e776a139bd53a23f73c71ab35
>>>>>>> Stashed changes
        {
            healthAmount += healingAmount;
        healthAmount = Mathf.Clamp(healthAmount, 0, 100);

        }
       

        healthBar.fillAmount = healthAmount / 100f;
        }
        
    }

 
}
