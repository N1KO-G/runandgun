using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class footstepsounds : MonoBehaviour
{

public float steptimer;
public float timebetweensteps;

PlayerMovement playermovement;
public AudioSource AudioSource;

public AudioClip concrete;
public AudioClip grass;
public AudioClip dirt;
public AudioClip gravel;
public AudioClip wood;
public AudioClip gore;
public AudioClip water;

RaycastHit hit;
public Transform RayStart;

public float range;
public LayerMask layerMask;



public void Footstep()
{
    if(Physics.Raycast(RayStart.position, RayStart.transform.up * -1, out hit, range, layerMask))
    {
        if (hit.collider.CompareTag("concrete"))
        {
            PlayFootStepSoundL(concrete);
        }
         if (hit.collider.CompareTag("grass"))
        {
            PlayFootStepSoundL(grass);
        }
         if (hit.collider.CompareTag("dirt"))
        {
            PlayFootStepSoundL(dirt);
        }
         if (hit.collider.CompareTag("gravel"))
        {
            PlayFootStepSoundL(gravel);
        }
         if (hit.collider.CompareTag("wood"))
        {
            PlayFootStepSoundL(wood);
        }
         if (hit.collider.CompareTag("gore"))
        {
            PlayFootStepSoundL(gore);
        }
         if (hit.collider.CompareTag("water"))
        {
            PlayFootStepSoundL(water);
        }
    }
      
}

void Awake()
{
    playermovement = GetComponent<PlayerMovement>();
}


    void PlayFootStepSoundL(AudioClip audio)
    {
        AudioSource.pitch = Random.Range(0.8f, 1f);
        AudioSource.PlayOneShot(audio);
    
    }


   void FixedUpdate()
   {
        if(playermovement.x != 0 || playermovement.y != 0)
        {
            if(playermovement.grounded) steptimer -= Time.deltaTime;
        }
        if(steptimer < 0)
        {
            Footstep();
            steptimer = timebetweensteps;
        }
   }

}


 



   



