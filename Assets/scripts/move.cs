using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    
    int enemiesLeft = 0;
	
	void Start () {
		 

	}
	
	// Update is called once per frame
	void Update () {
	GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
		enemiesLeft = enemies.Length;
	
		if(enemiesLeft == 0)
		{
		    
            gameObject.SetActive(false);

		}
	}
	
	
	void OnGUI()
	{
		{
			GUI.Label(new Rect (0,0,200,20),"Enemies Remaining : " + enemiesLeft);
		}
	}
	
}

    

